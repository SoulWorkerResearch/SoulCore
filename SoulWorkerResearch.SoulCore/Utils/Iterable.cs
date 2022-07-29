namespace SoulWorkerResearch.SoulCore.Utils;

public static class Iterable
{
    public static IEnumerable<Tuple<T1, T2, T3>> Iterate<T1, T2, T3>(IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third)
    {
        using var e1 = first.GetEnumerator();
        using var e2 = second.GetEnumerator();
        using var e3 = third.GetEnumerator();

        while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext())
            yield return Tuple.Create(e1.Current, e2.Current, e3.Current);
    }

    public static IEnumerable<Tuple<T1, T2, T3, T4>> Iterate<T1, T2, T3, T4>(IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third, IEnumerable<T4> fourth)
    {
        using var e1 = first.GetEnumerator();
        using var e2 = second.GetEnumerator();
        using var e3 = third.GetEnumerator();
        using var e4 = fourth.GetEnumerator();

        while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext())
            yield return Tuple.Create(e1.Current, e2.Current, e3.Current, e4.Current);
    }

    public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> Zip<T1, T2, T3, T4, T5>(IEnumerable<T1> first, IEnumerable<T2> second, IEnumerable<T3> third, IEnumerable<T4> fourth, IEnumerable<T5> five)
    {
        using var e1 = first.GetEnumerator();
        using var e2 = second.GetEnumerator();
        using var e3 = third.GetEnumerator();
        using var e4 = fourth.GetEnumerator();
        using var e5 = five.GetEnumerator();

        while (e1.MoveNext() && e2.MoveNext() && e3.MoveNext() && e4.MoveNext() && e5.MoveNext())
            yield return Tuple.Create(e1.Current, e2.Current, e3.Current, e4.Current, e5.Current);
    }
}
