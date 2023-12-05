﻿using System.Numerics;
using System.Xml.Linq;
using SoulWorkerResearch.SoulCore.IO.Batch.Extensions;
using SoulWorkerResearch.SoulCore.IO.Batch.Types;

namespace SoulWorkerResearch.SoulCore.IO.Batch.Entities;

public sealed record PortalBox : BasicEntity
{
    public PortalBox(XElement x) : base(x)
    {
        ShowGui = x.GetBool("m_bShowGUI");
        Gui = x.GetUInt32("m_iGUI");
        JumpType = x.GetEnum<JumpType>("m_eJumpType");
        JumpMap = x.GetUInt32("m_iJumpMap");
        Jump = x.GetUInt32("m_iJump");
        PortalState = x.GetEnum<PortalState>("m_eEffectType");
        DisableEffect = x.GetString("m_szDisableEffect");
        EnableEffect = x.GetString("m_szEnableEffect");
        UiString = x.GetUInt32("m_iUIString");
        NextSector = x.GetUInt32("m_iNextSectorID");
        CallScript = x.GetBool("m_bCallScript");
        OpenEpisode = x.GetUInt32("m_uiOpenEpisode");
        CompleteEpisode = x.GetUInt32("m_uiCompleteEpisode");
        StringOffset = new Vector3(x.GetSingle("m_fStringOffsetX"), x.GetSingle("m_fStringOffsetY"),
            x.GetSingle("m_fStringOffsetZ"));
        ClearSectors = Enumerable.Range(1, 5).Select(id => x.GetUInt32($"m_iClearSectorID{id}")).ToArray();
        ClearSectorChances = Enumerable.Range(1, 5).Select(id => x.GetSingle($"m_fClearSectorChance{id}")).ToArray();

        try
        {
            MaxUserCount = x.GetUInt32("m_iMaxUserCount");
        }
        catch
        {
            MaxUserCount = 0;
        }

        try
        {
            MaxTimeCount = x.GetUInt32("m_iMaxTimeCount");
        }
        catch
        {
            MaxTimeCount = 0;
        }
    }

    /// <summary>
    ///     Visible of GUI(True or False)
    /// </summary>
    public bool ShowGui { get; }

    /// <summary>
    ///     tb_Maze_Entry_Gui
    /// </summary>
    public uint Gui { get; }

    /// <summary>
    ///     moving type
    /// </summary>
    public JumpType JumpType { get; }

    /// <summary>
    ///     Jump map ID
    /// </summary>
    public uint JumpMap { get; }

    /// <summary>
    ///     m_ID of VStartEventBox be moved
    /// </summary>
    public uint Jump { get; }

    /// <summary>
    ///     An initial activation state of the portal(Enable of Disable)
    /// </summary>
    public PortalState PortalState { get; }

    /// <summary>
    ///     Output of the non-active state VFX resource path
    /// </summary>
    public string DisableEffect { get; }

    /// <summary>
    ///     Output of the active state VFX resource path
    /// </summary>
    public string EnableEffect { get; }

    /// <summary>
    ///     UI String
    /// </summary>
    public uint UiString { get; }

    /// <summary>
    ///     ID of next sector
    /// </summary>
    public uint NextSector { get; }

    /// <summary>
    ///     Will you call the script?
    /// </summary>
    public bool CallScript { get; }

    /// <summary>
    ///     Hold or break the episode activation
    /// </summary>
    public uint OpenEpisode { get; }

    /// <summary>
    ///     Deactivated upon completion of the episode
    /// </summary>
    public uint CompleteEpisode { get; }

    /// <summary>
    ///     UI String Offset
    /// </summary>
    public Vector3 StringOffset { get; }

    /// <summary>
    ///     ClearSector Id
    /// </summary>
    public IReadOnlyList<uint> ClearSectors { get; }

    /// <summary>
    ///     ClearSector Chance
    /// </summary>
    public IReadOnlyList<float> ClearSectorChances { get; }

    /// <summary>
    ///     MaxUserCount
    /// </summary>
    public uint MaxUserCount { get; }

    /// <summary>
    ///     MaxTimeCount
    /// </summary>
    public uint MaxTimeCount { get; }
}
