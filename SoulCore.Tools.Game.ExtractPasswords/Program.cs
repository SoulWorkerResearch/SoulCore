using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoulCore.Tools.Game.ExtractPasswords
{
    internal static class Program
    {
        private sealed record Pair
        {
            internal readonly string Name;
            internal readonly string Password;

            public override string ToString() => $"{Name}:{Password}";

            public Pair(string name, string password)
            {
                Name = name[0..^4];
                Password = password;
            }
        }

        private static int GetOffset(Match match) => match.Index + match.Length;

        private static async Task<IEnumerable<Pair>> GetPairs(string path)
        {
            string str = await File.ReadAllTextAsync(path).ConfigureAwait(false);

            Regex regex = new(@"data..\.v\0\0\0\0");
            Match current = regex.Match(str);
            List<Match> matches = new();
            while (current.Success)
            {
                matches.Add(current);
                current = current.NextMatch();
            }

            List<Pair> passwords = new();
            for (int q = 0, offset = GetOffset(matches.Last()); q < matches.Count; ++q)
            {
                string value = string.Empty;
                for (; str[offset] != '\0'; ++offset)
                {
                    value += str[offset];
                }

                passwords.Add(new(matches[q].Value, value));

                for (; str[offset] == '\0'; ++offset) ;
            }

            return passwords;
        }

        internal static async Task Main(string[] args)
        {
            await using FileStream file = File.Open("dumpedPasswords.txt", FileMode.Create);
            await using BinaryWriter bw = new(file);

            IEnumerable<Pair> pairs = await GetPairs(args[0]).ConfigureAwait(false);

            foreach (Pair pair in pairs)
            {
                bw.Write(pair.ToString());
                bw.Write('\n');
                Console.WriteLine(pair);
            }
        }
    }
}