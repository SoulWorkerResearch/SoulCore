using ICSharpCode.SharpZipLib.Zip;
using SoulWorkerResearch.SoulCore.IO.Res.Entries;

namespace SoulWorkerResearch.SoulCore.IO.Res;

public sealed class TableReader : ArchiveReader
{
    public IAsyncEnumerable<AchievementBeginEntry> ReadAchievementBeginTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AchievementBeginEntry>(ct);

    public IAsyncEnumerable<CashshopChargeEntry> ReadCashshopChargeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CashshopChargeEntry>(ct);

    public IAsyncEnumerable<CheckAccessRewardEntry> ReadCheckAccessRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CheckAccessRewardEntry>(ct);

    public IAsyncEnumerable<CostumeSocketEntry> ReadCostumeSocketTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CostumeSocketEntry>(ct);

    public IAsyncEnumerable<CustomizeViewCostumeEntry> ReadCustomizeViewCostumeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomizeViewCostumeEntry>(ct);

    public IAsyncEnumerable<DispatchTypeEntry> ReadDispatchTypeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DispatchTypeEntry>(ct);

    public IAsyncEnumerable<FactionEntry> ReadFactionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<FactionEntry>(ct);

    public IAsyncEnumerable<InfiniteTowerMonsterEntry> ReadInfiniteTowerMonsterTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<InfiniteTowerMonsterEntry>(ct);

    public IAsyncEnumerable<ItemTitleGroupEntry> ReadItemTitleGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemTitleGroupEntry>(ct);

    public IAsyncEnumerable<ItemTitleValueEntry> ReadItemTitleValueTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemTitleValueEntry>(ct);

    public IAsyncEnumerable<ModeBiSectorInfoEntry> ReadModeBiSectorInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeBiSectorInfoEntry>(ct);

    public IAsyncEnumerable<ModeBiSkillEditEntry> ReadModeBiSkillEditTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeBiSkillEditEntry>(ct);

    public IAsyncEnumerable<PcRewardSystemEntry> ReadPcRewardSystemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PcRewardSystemEntry>(ct);

    public IAsyncEnumerable<PcRewardSystemMonthEntry> ReadPcRewardSystemMonthTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PcRewardSystemMonthEntry>(ct);

    public IAsyncEnumerable<RandomChangeEntry> ReadRandomChangeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RandomChangeEntry>(ct);

    public IAsyncEnumerable<RandomGetEntry> ReadRandomGetTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RandomGetEntry>(ct);

    public IAsyncEnumerable<SoulGuageEntry> ReadSoulGuageTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SoulGuageEntry>(ct);

    public IAsyncEnumerable<SoulMetryEntry> ReadSoulMetryTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SoulMetryEntry>(ct);

    public IAsyncEnumerable<TitleStringEntry> ReadTitleStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TitleStringEntry>(ct);

    public IAsyncEnumerable<TooltipStringEntry> ReadTooltipStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TooltipStringEntry>(ct);

    public IAsyncEnumerable<AchievementEmblemEntry> ReadAchievementEmblemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AchievementEmblemEntry>(ct);

    public IAsyncEnumerable<CashshopTabEntry> ReadCashshopTabTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CashshopTabEntry>(ct);

    public IAsyncEnumerable<CheckAttendanceInfoEntry> ReadCheckAttendanceInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CheckAttendanceInfoEntry>(ct);

    public IAsyncEnumerable<CustomizeHairEntry> ReadCustomizeHairTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomizeHairEntry>(ct);

    public IAsyncEnumerable<DistrictEntry> ReadDistrictTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DistrictEntry>(ct);

    public IAsyncEnumerable<EventConditionEntry> ReadEventConditionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<EventConditionEntry>(ct);

    public IAsyncEnumerable<HelpEntry> ReadHelpTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<HelpEntry>(ct);

    public IAsyncEnumerable<ItemCountboxGroupEntry> ReadItemCountboxGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemCountboxGroupEntry>(ct);

    public IAsyncEnumerable<LeagueMarkEntry> ReadLeagueMarkTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LeagueMarkEntry>(ct);

    public IAsyncEnumerable<LeagueRaidEntry> ReadLeagueRaidTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LeagueRaidEntry>(ct);

    public IAsyncEnumerable<ModeCardmatchFactionEntry> ReadModeCardmatchFactionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeCardmatchFactionEntry>(ct);

    public IAsyncEnumerable<ModeCardmatchRuleEntry> ReadModeCardmatchRuleTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeCardmatchRuleEntry>(ct);

    public IAsyncEnumerable<PetCommonEntry> ReadPetCommonTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetCommonEntry>(ct);

    public IAsyncEnumerable<PetDispatchEntry> ReadPetDispatchTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetDispatchEntry>(ct);

    public IAsyncEnumerable<ReinforceEntry> ReadReinforceTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ReinforceEntry>(ct);

    public IAsyncEnumerable<ReinforceExchangeEntry> ReadReinforceExchangeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ReinforceExchangeEntry>(ct);

    public IAsyncEnumerable<SpeechPcFEntry> ReadSpeechPcFTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcFEntry>(ct);

    public IAsyncEnumerable<SpeechPcGEntry> ReadSpeechPcGTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcGEntry>(ct);

    public IAsyncEnumerable<UiImgEntry> ReadUiImgTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<UiImgEntry>(ct);

    public IAsyncEnumerable<UiPopupEntry> ReadUiPopupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<UiPopupEntry>(ct);

    public IAsyncEnumerable<AchievementScriptEntry> ReadAchievementScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AchievementScriptEntry>(ct);

    public IAsyncEnumerable<BoosterEntry> ReadBoosterTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BoosterEntry>(ct);

    public IAsyncEnumerable<ClassbattleRoleEntry> ReadClassbattleRoleTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ClassbattleRoleEntry>(ct);

    public IAsyncEnumerable<DefAttackEntry> ReadDefAttackTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DefAttackEntry>(ct);

    public IAsyncEnumerable<DyeEntry> ReadDyeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DyeEntry>(ct);

    public IAsyncEnumerable<GrowthExpTransferInfoEntry> ReadGrowthExpTransferInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GrowthExpTransferInfoEntry>(ct);

    public IAsyncEnumerable<InteractionItemEntry> ReadInteractionItemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<InteractionItemEntry>(ct);

    public IAsyncEnumerable<LeagueInfoEntry> ReadLeagueInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LeagueInfoEntry>(ct);

    public IAsyncEnumerable<LoadingStringEntry> ReadLoadingStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LoadingStringEntry>(ct);

    public IAsyncEnumerable<MakeEntry> ReadMakeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MakeEntry>(ct);

    public IAsyncEnumerable<ModeOperationEntry> ReadModeOperationTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeOperationEntry>(ct);

    public IAsyncEnumerable<ModeResourcesEntry> ReadModeResourcesTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeResourcesEntry>(ct);

    public IAsyncEnumerable<PetGroupInfoEntry> ReadPetGroupInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetGroupInfoEntry>(ct);

    public IAsyncEnumerable<PetInfoLinkEntry> ReadPetInfoLinkTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetInfoLinkEntry>(ct);

    public IAsyncEnumerable<RankRewardTotalpointEntry> ReadRankRewardTotalpointTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RankRewardTotalpointEntry>(ct);

    public IAsyncEnumerable<RankTierEntry> ReadRankTierTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RankTierEntry>(ct);

    public IAsyncEnumerable<SpeechEntry> ReadSpeechTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechEntry>(ct);

    public IAsyncEnumerable<SpeechPcAEntry> ReadSpeechPcATableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcAEntry>(ct);

    public IAsyncEnumerable<UiStringEntry> ReadUiStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<UiStringEntry>(ct);

    public IAsyncEnumerable<UnityEventEntry> ReadUnityEventTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<UnityEventEntry>(ct);

    public IAsyncEnumerable<ActMainEntry> ReadActMainTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ActMainEntry>(ct);

    public IAsyncEnumerable<BuffEntry> ReadBuffTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BuffEntry>(ct);

    public IAsyncEnumerable<CharacterPartsEntry> ReadCharacterPartsTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CharacterPartsEntry>(ct);

    public IAsyncEnumerable<ControlkeyinfoEntry> ReadControlkeyinfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ControlkeyinfoEntry>(ct);

    public IAsyncEnumerable<CustomizeViewSoundEntry> ReadCustomizeViewSoundTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomizeViewSoundEntry>(ct);

    public IAsyncEnumerable<DropLimitMazeEntry> ReadDropLimitMazeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DropLimitMazeEntry>(ct);

    public IAsyncEnumerable<GrowthItemExpEntry> ReadGrowthItemExpTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GrowthItemExpEntry>(ct);

    public IAsyncEnumerable<InvenSlotExtendEntry> ReadInvenSlotExtendTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<InvenSlotExtendEntry>(ct);

    public IAsyncEnumerable<LeagueAttendanceEntry> ReadLeagueAttendanceTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LeagueAttendanceEntry>(ct);

    public IAsyncEnumerable<LeagueBoosterEntry> ReadLeagueBoosterTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LeagueBoosterEntry>(ct);

    public IAsyncEnumerable<ModeBiUpgradeEntry> ReadModeBiUpgradeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeBiUpgradeEntry>(ct);

    public IAsyncEnumerable<ModeCardmatchCardEntry> ReadModeCardmatchCardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeCardmatchCardEntry>(ct);

    public IAsyncEnumerable<RandomGetGroupEntry> ReadRandomGetGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RandomGetGroupEntry>(ct);

    public IAsyncEnumerable<RandomOptionEntry> ReadRandomOptionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RandomOptionEntry>(ct);

    public IAsyncEnumerable<SpecialOptionChangeEntry> ReadSpecialOptionChangeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpecialOptionChangeEntry>(ct);

    public IAsyncEnumerable<SpecialmazeOpenEntry> ReadSpecialmazeOpenTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpecialmazeOpenEntry>(ct);

    public IAsyncEnumerable<ActMazeGroupEntry> ReadActMazeGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ActMazeGroupEntry>(ct);

    public IAsyncEnumerable<CashshopEntry> ReadCashshopTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CashshopEntry>(ct);

    public IAsyncEnumerable<CheckAttendanceRewardEntry> ReadCheckAttendanceRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CheckAttendanceRewardEntry>(ct);

    public IAsyncEnumerable<CreateoptionEntry> ReadCreateoptionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CreateoptionEntry>(ct);

    public IAsyncEnumerable<DyeInfoEntry> ReadDyeInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DyeInfoEntry>(ct);

    public IAsyncEnumerable<ItemModelEntry> ReadItemModelTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemModelEntry>(ct);

    public IAsyncEnumerable<LeagueSkillEntry> ReadLeagueSkillTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LeagueSkillEntry>(ct);

    public IAsyncEnumerable<MazeSelectEntry> ReadMazeSelectTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazeSelectEntry>(ct);

    public IAsyncEnumerable<MyroomFurnitureEntry> ReadMyroomFurnitureTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MyroomFurnitureEntry>(ct);

    public IAsyncEnumerable<MyroomGreedEntry> ReadMyroomGreedTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MyroomGreedEntry>(ct);

    public IAsyncEnumerable<PlusSystemEntry> ReadPlusSystemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PlusSystemEntry>(ct);

    public IAsyncEnumerable<PollenEntry> ReadPollenTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PollenEntry>(ct);

    public IAsyncEnumerable<RspEventEntry> ReadRspEventTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RspEventEntry>(ct);

    public IAsyncEnumerable<SeasonMainEntry> ReadSeasonMainTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SeasonMainEntry>(ct);

    public IAsyncEnumerable<SpeechTagEntry> ReadSpeechTagTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechTagEntry>(ct);

    public IAsyncEnumerable<SpeechbubbleEntry> ReadSpeechbubbleTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechbubbleEntry>(ct);

    public IAsyncEnumerable<AdvancinghelixEntry> ReadAdvancinghelixTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AdvancinghelixEntry>(ct);

    public IAsyncEnumerable<CashbillingInfoEntry> ReadCashbillingInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CashbillingInfoEntry>(ct);

    public IAsyncEnumerable<ChattingfilterEntry> ReadChattingfilterTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ChattingfilterEntry>(ct);

    public IAsyncEnumerable<CultivationEntry> ReadCultivationTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CultivationEntry>(ct);

    public IAsyncEnumerable<DeckBonusEntry> ReadDeckBonusTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DeckBonusEntry>(ct);

    public IAsyncEnumerable<DsPointEntry> ReadDsPointTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DsPointEntry>(ct);

    public IAsyncEnumerable<GestureSlotExtendEntry> ReadGestureSlotExtendTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GestureSlotExtendEntry>(ct);

    public IAsyncEnumerable<HitvfxEntry> ReadHitvfxTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<HitvfxEntry>(ct);

    public IAsyncEnumerable<ItemSimilargroupEntry> ReadItemSimilargroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemSimilargroupEntry>(ct);

    public IAsyncEnumerable<ItemSubmodelEntry> ReadItemSubmodelTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemSubmodelEntry>(ct);

    public IAsyncEnumerable<MazerewardLevelEntry> ReadMazerewardLevelTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazerewardLevelEntry>(ct);

    public IAsyncEnumerable<MazerewardNormalEntry> ReadMazerewardNormalTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazerewardNormalEntry>(ct);

    public IAsyncEnumerable<NpcScriptEntry> ReadNpcScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<NpcScriptEntry>(ct);

    public IAsyncEnumerable<OperationInfoEntry> ReadOperationInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<OperationInfoEntry>(ct);

    public IAsyncEnumerable<PvpLimitEntry> ReadPvpLimitTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PvpLimitEntry>(ct);

    public IAsyncEnumerable<PvpReviseEntry> ReadPvpReviseTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PvpReviseEntry>(ct);

    public IAsyncEnumerable<SfxGroundmaterialEntry> ReadSfxGroundmaterialTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SfxGroundmaterialEntry>(ct);

    public IAsyncEnumerable<ShopEntry> ReadShopTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ShopEntry>(ct);

    public IAsyncEnumerable<SpeechPcJEntry> ReadSpeechPcJTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcJEntry>(ct);

    public IAsyncEnumerable<SpeechStringEntry> ReadSpeechStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechStringEntry>(ct);

    public IAsyncEnumerable<WeekDayEntry> ReadWeekDayTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WeekDayEntry>(ct);

    public IAsyncEnumerable<WeekGroupEntry> ReadWeekGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WeekGroupEntry>(ct);

    public IAsyncEnumerable<AkashicCombinationEntry> ReadAkashicCombinationTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AkashicCombinationEntry>(ct);

    public IAsyncEnumerable<BankSlotExtendEntry> ReadBankSlotExtendTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BankSlotExtendEntry>(ct);

    public IAsyncEnumerable<ChapterGroupEntry> ReadChapterGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ChapterGroupEntry>(ct);

    public IAsyncEnumerable<ColorEntry> ReadColorTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ColorEntry>(ct);

    public IAsyncEnumerable<CustomizeInfoEntry> ReadCustomizeInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomizeInfoEntry>(ct);

    public IAsyncEnumerable<DiceRewardEntry> ReadDiceRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DiceRewardEntry>(ct);

    public IAsyncEnumerable<EqualizerSummonEntry> ReadEqualizerSummonTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<EqualizerSummonEntry>(ct);

    public IAsyncEnumerable<GrowthTransferGroupEntry> ReadGrowthTransferGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GrowthTransferGroupEntry>(ct);

    public IAsyncEnumerable<ItemEvolutionEntry> ReadItemEvolutionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemEvolutionEntry>(ct);

    public IAsyncEnumerable<ItemExtractionEntry> ReadItemExtractionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemExtractionEntry>(ct);

    public IAsyncEnumerable<MazerewardDifficultyEntry> ReadMazerewardDifficultyTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazerewardDifficultyEntry>(ct);

    public IAsyncEnumerable<MazerewardGolddirectEntry> ReadMazerewardGolddirectTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazerewardGolddirectEntry>(ct);

    public IAsyncEnumerable<NavigationWarpmapEntry> ReadNavigationWarpmapTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<NavigationWarpmapEntry>(ct);

    public IAsyncEnumerable<NoticeEntry> ReadNoticeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<NoticeEntry>(ct);

    public IAsyncEnumerable<QuestChapterEntry> ReadQuestChapterTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<QuestChapterEntry>(ct);

    public IAsyncEnumerable<QuestConditionEntry> ReadQuestConditionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<QuestConditionEntry>(ct);

    public IAsyncEnumerable<SkillActionEntry> ReadSkillActionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SkillActionEntry>(ct);

    public IAsyncEnumerable<SkillDivideEntry> ReadSkillDivideTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SkillDivideEntry>(ct);

    public IAsyncEnumerable<TitleInfoEntry> ReadTitleInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TitleInfoEntry>(ct);

    public IAsyncEnumerable<TitleRewardEntry> ReadTitleRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TitleRewardEntry>(ct);

    public IAsyncEnumerable<AkashicDisassembleEntry> ReadAkashicDisassembleTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AkashicDisassembleEntry>(ct);

    public IAsyncEnumerable<BoosterScriptEntry> ReadBoosterScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BoosterScriptEntry>(ct);

    public IAsyncEnumerable<ClassFormEntry> ReadClassFormTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ClassFormEntry>(ct);

    public IAsyncEnumerable<CustomerGradeEntry> ReadCustomerGradeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomerGradeEntry>(ct);

    public IAsyncEnumerable<DiceEpisodeEntry> ReadDiceEpisodeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DiceEpisodeEntry>(ct);

    public IAsyncEnumerable<EchelonEntry> ReadEchelonTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<EchelonEntry>(ct);

    public IAsyncEnumerable<GrowthItemExpItemEntry> ReadGrowthItemExpItemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GrowthItemExpItemEntry>(ct);

    public IAsyncEnumerable<InteractionObjectEntry> ReadInteractionObjectTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<InteractionObjectEntry>(ct);

    public IAsyncEnumerable<JumpingCharacterEntry> ReadJumpingCharacterTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<JumpingCharacterEntry>(ct);

    public IAsyncEnumerable<JumpingInfoEntry> ReadJumpingInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<JumpingInfoEntry>(ct);

    public IAsyncEnumerable<MessagenotifyerEntry> ReadMessagenotifyerTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MessagenotifyerEntry>(ct);

    public IAsyncEnumerable<MileageEntry> ReadMileageTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MileageEntry>(ct);

    public IAsyncEnumerable<PassInfoEntry> ReadPassInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PassInfoEntry>(ct);

    public IAsyncEnumerable<PassRewardEntry> ReadPassRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PassRewardEntry>(ct);

    public IAsyncEnumerable<QuestSeasonEntry> ReadQuestSeasonTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<QuestSeasonEntry>(ct);

    public IAsyncEnumerable<QuickChangeEntry> ReadQuickChangeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<QuickChangeEntry>(ct);

    public IAsyncEnumerable<SkillOptionEntry> ReadSkillOptionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SkillOptionEntry>(ct);

    public IAsyncEnumerable<SkillScriptEntry> ReadSkillScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SkillScriptEntry>(ct);

    public IAsyncEnumerable<SubweaponEntry> ReadSubweaponTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SubweaponEntry>(ct);

    public IAsyncEnumerable<SystemmailEntry> ReadSystemmailTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SystemmailEntry>(ct);

    public IAsyncEnumerable<WorkerguideMainEntry> ReadWorkerguideMainTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WorkerguideMainEntry>(ct);

    public IAsyncEnumerable<WorldEventEntry> ReadWorldEventTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WorldEventEntry>(ct);

    public IAsyncEnumerable<AkashicMakeEntry> ReadAkashicMakeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AkashicMakeEntry>(ct);

    public IAsyncEnumerable<ChallengeoptionEntry> ReadChallengeoptionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ChallengeoptionEntry>(ct);

    public IAsyncEnumerable<ChangeTabEntry> ReadChangeTabTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ChangeTabEntry>(ct);

    public IAsyncEnumerable<ClassselectInfoEntry> ReadClassselectInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ClassselectInfoEntry>(ct);

    public IAsyncEnumerable<CustomizeEyesEntry> ReadCustomizeEyesTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomizeEyesEntry>(ct);

    public IAsyncEnumerable<DiceEventEntry> ReadDiceEventTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DiceEventEntry>(ct);

    public IAsyncEnumerable<EmoticonEntry> ReadEmoticonTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<EmoticonEntry>(ct);

    public IAsyncEnumerable<GrowthItemInfoEntry> ReadGrowthItemInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GrowthItemInfoEntry>(ct);

    public IAsyncEnumerable<ItemEntry> ReadItemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemEntry>(ct);

    public IAsyncEnumerable<ItemClassifyEntry> ReadItemClassifyTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemClassifyEntry>(ct);

    public IAsyncEnumerable<MasteryEntry> ReadMasteryTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MasteryEntry>(ct);

    public IAsyncEnumerable<MasteryScriptEntry> ReadMasteryScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MasteryScriptEntry>(ct);

    public IAsyncEnumerable<MonsterScriptEntry> ReadMonsterScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MonsterScriptEntry>(ct);

    public IAsyncEnumerable<MonsterWeaponEntry> ReadMonsterWeaponTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MonsterWeaponEntry>(ct);

    public IAsyncEnumerable<PetVoiceEntry> ReadPetVoiceTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetVoiceEntry>(ct);

    public IAsyncEnumerable<PhotoItemEntry> ReadPhotoItemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PhotoItemEntry>(ct);

    public IAsyncEnumerable<ReinforceOptionEntry> ReadReinforceOptionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ReinforceOptionEntry>(ct);

    public IAsyncEnumerable<RepackagecostumeEntry> ReadRepackagecostumeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RepackagecostumeEntry>(ct);

    public IAsyncEnumerable<SpeechPcDEntry> ReadSpeechPcDTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcDEntry>(ct);

    public IAsyncEnumerable<SpeechPcEEntry> ReadSpeechPcETableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcEEntry>(ct);

    public IAsyncEnumerable<WorkerguideContentsEntry> ReadWorkerguideContentsTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WorkerguideContentsEntry>(ct);

    public IAsyncEnumerable<WorkerguideEquipmentEntry> ReadWorkerguideEquipmentTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WorkerguideEquipmentEntry>(ct);

    public IAsyncEnumerable<AkashicMysticEntry> ReadAkashicMysticTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AkashicMysticEntry>(ct);

    public IAsyncEnumerable<BuffScriptEntry> ReadBuffScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BuffScriptEntry>(ct);

    public IAsyncEnumerable<CharacterInfoEntry> ReadCharacterInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CharacterInfoEntry>(ct);

    public IAsyncEnumerable<CostumeExtractionEntry> ReadCostumeExtractionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CostumeExtractionEntry>(ct);

    public IAsyncEnumerable<DailymazePortalEntry> ReadDailymazePortalTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DailymazePortalEntry>(ct);

    public IAsyncEnumerable<DropSymbolEntry> ReadDropSymbolTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DropSymbolEntry>(ct);

    public IAsyncEnumerable<GestureEntry> ReadGestureTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GestureEntry>(ct);

    public IAsyncEnumerable<InfiniteTowerEntry> ReadInfiniteTowerTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<InfiniteTowerEntry>(ct);

    public IAsyncEnumerable<ItemTitleEntry> ReadItemTitleTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemTitleEntry>(ct);

    public IAsyncEnumerable<ItemTitleChangeEntry> ReadItemTitleChangeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemTitleChangeEntry>(ct);

    public IAsyncEnumerable<MazerewardSoulvaperEntry> ReadMazerewardSoulvaperTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazerewardSoulvaperEntry>(ct);

    public IAsyncEnumerable<MazerewardTimeEntry> ReadMazerewardTimeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazerewardTimeEntry>(ct);

    public IAsyncEnumerable<PcAkashicEntry> ReadPcAkashicTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PcAkashicEntry>(ct);

    public IAsyncEnumerable<PcCostumeEntry> ReadPcCostumeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PcCostumeEntry>(ct);

    public IAsyncEnumerable<QuestRewardEntry> ReadQuestRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<QuestRewardEntry>(ct);

    public IAsyncEnumerable<QuestScriptEntry> ReadQuestScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<QuestScriptEntry>(ct);

    public IAsyncEnumerable<SocialMotionEntry> ReadSocialMotionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SocialMotionEntry>(ct);

    public IAsyncEnumerable<SocketEntry> ReadSocketTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SocketEntry>(ct);

    public IAsyncEnumerable<TalkStringEntry> ReadTalkStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TalkStringEntry>(ct);

    public IAsyncEnumerable<TimeEntry> ReadTimeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TimeEntry>(ct);

    public IAsyncEnumerable<WorldEventRewardEntry> ReadWorldEventRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WorldEventRewardEntry>(ct);

    public IAsyncEnumerable<AkashicPartsEntry> ReadAkashicPartsTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AkashicPartsEntry>(ct);

    public IAsyncEnumerable<BroachdataEntry> ReadBroachdataTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BroachdataEntry>(ct);

    public IAsyncEnumerable<ChangeMobIdEntry> ReadChangeMobIdTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ChangeMobIdEntry>(ct);

    public IAsyncEnumerable<ComboBuffEntry> ReadComboBuffTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ComboBuffEntry>(ct);

    public IAsyncEnumerable<DailyMissionEntry> ReadDailyMissionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DailyMissionEntry>(ct);

    public IAsyncEnumerable<EmotioneffectEntry> ReadEmotioneffectTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<EmotioneffectEntry>(ct);

    public IAsyncEnumerable<GrowthItemSpecialInfoEntry> ReadGrowthItemSpecialInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GrowthItemSpecialInfoEntry>(ct);

    public IAsyncEnumerable<ItemCountboxEntry> ReadItemCountboxTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemCountboxEntry>(ct);

    public IAsyncEnumerable<LeagueskillScriptEntry> ReadLeagueskillScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LeagueskillScriptEntry>(ct);

    public IAsyncEnumerable<LevelupPointEntry> ReadLevelupPointTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LevelupPointEntry>(ct);

    public IAsyncEnumerable<ModeDistrict6Entry> ReadModeDistrict6TableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeDistrict6Entry>(ct);

    public IAsyncEnumerable<ModeDistrict6DateEntry> ReadModeDistrict6DateTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ModeDistrict6DateEntry>(ct);

    public IAsyncEnumerable<PetExpEntry> ReadPetExpTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetExpEntry>(ct);

    public IAsyncEnumerable<PetGainInfoEntry> ReadPetGainInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetGainInfoEntry>(ct);

    public IAsyncEnumerable<RankInfoEntry> ReadRankInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RankInfoEntry>(ct);

    public IAsyncEnumerable<RankRewardEntry> ReadRankRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RankRewardEntry>(ct);

    public IAsyncEnumerable<SoulMetryStringEntry> ReadSoulMetryStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SoulMetryStringEntry>(ct);

    public IAsyncEnumerable<SoulstoneLevelupEntry> ReadSoulstoneLevelupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SoulstoneLevelupEntry>(ct);

    public IAsyncEnumerable<TransportInfoEntry> ReadTransportInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TransportInfoEntry>(ct);

    public IAsyncEnumerable<TransportNpcPosEntry> ReadTransportNpcPosTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TransportNpcPosEntry>(ct);

    public IAsyncEnumerable<AkashicRecordsEntry> ReadAkashicRecordsTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AkashicRecordsEntry>(ct);

    public IAsyncEnumerable<BattleArenaInfoEntry> ReadBattleArenaInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BattleArenaInfoEntry>(ct);

    public IAsyncEnumerable<CinematicReplayEntry> ReadCinematicReplayTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CinematicReplayEntry>(ct);

    public IAsyncEnumerable<CustomerBenefitEntry> ReadCustomerBenefitTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomerBenefitEntry>(ct);

    public IAsyncEnumerable<DefensiveWeaponEntry> ReadDefensiveWeaponTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DefensiveWeaponEntry>(ct);

    public IAsyncEnumerable<GachaEntry> ReadGachaTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GachaEntry>(ct);

    public IAsyncEnumerable<HelperEntry> ReadHelperTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<HelperEntry>(ct);

    public IAsyncEnumerable<ItemPackageEntry> ReadItemPackageTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemPackageEntry>(ct);

    public IAsyncEnumerable<LoadingEntry> ReadLoadingTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LoadingEntry>(ct);

    public IAsyncEnumerable<LoadingImgEntry> ReadLoadingImgTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<LoadingImgEntry>(ct);

    public IAsyncEnumerable<MonsterEntry> ReadMonsterTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MonsterEntry>(ct);

    public IAsyncEnumerable<MonsterBrokenPartsEntry> ReadMonsterBrokenPartsTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MonsterBrokenPartsEntry>(ct);

    public IAsyncEnumerable<RankCategoryGroupEntry> ReadRankCategoryGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RankCategoryGroupEntry>(ct);

    public IAsyncEnumerable<RankChangeEntry> ReadRankChangeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RankChangeEntry>(ct);

    public IAsyncEnumerable<SpeechPcHEntry> ReadSpeechPcHTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcHEntry>(ct);

    public IAsyncEnumerable<SpeechPcIEntry> ReadSpeechPcITableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcIEntry>(ct);

    public IAsyncEnumerable<VoiceringEntry> ReadVoiceringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<VoiceringEntry>(ct);

    public IAsyncEnumerable<WarlordGuiEntry> ReadWarlordGuiTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WarlordGuiEntry>(ct);

    public IAsyncEnumerable<AkashicSlotExtendEntry> ReadAkashicSlotExtendTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AkashicSlotExtendEntry>(ct);

    public IAsyncEnumerable<AuraEntry> ReadAuraTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AuraEntry>(ct);

    public IAsyncEnumerable<CheckAttendanceStreakEntry> ReadCheckAttendanceStreakTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CheckAttendanceStreakEntry>(ct);

    public IAsyncEnumerable<CreditRaiseEntry> ReadCreditRaiseTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CreditRaiseEntry>(ct);

    public IAsyncEnumerable<CutsceneStringEntry> ReadCutsceneStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CutsceneStringEntry>(ct);

    public IAsyncEnumerable<DistrictTransportEntry> ReadDistrictTransportTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DistrictTransportEntry>(ct);

    public IAsyncEnumerable<FragmentExchangeEntry> ReadFragmentExchangeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<FragmentExchangeEntry>(ct);

    public IAsyncEnumerable<HelpPopupEntry> ReadHelpPopupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<HelpPopupEntry>(ct);

    public IAsyncEnumerable<ItemInformationEntry> ReadItemInformationTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemInformationEntry>(ct);

    public IAsyncEnumerable<ItemLimitEntry> ReadItemLimitTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemLimitEntry>(ct);

    public IAsyncEnumerable<MazeOpencontrolEntry> ReadMazeOpencontrolTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazeOpencontrolEntry>(ct);

    public IAsyncEnumerable<MazePortalEntry> ReadMazePortalTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazePortalEntry>(ct);

    public IAsyncEnumerable<NpcEntry> ReadNpcTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<NpcEntry>(ct);

    public IAsyncEnumerable<NpcPartsEntry> ReadNpcPartsTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<NpcPartsEntry>(ct);

    public IAsyncEnumerable<PvpReviseNiEntry> ReadPvpReviseNiTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PvpReviseNiEntry>(ct);

    public IAsyncEnumerable<PvpRoleEntry> ReadPvpRoleTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PvpRoleEntry>(ct);

    public IAsyncEnumerable<ShopStringEntry> ReadShopStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ShopStringEntry>(ct);

    public IAsyncEnumerable<SkillEntry> ReadSkillTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SkillEntry>(ct);

    public IAsyncEnumerable<TransferEntry> ReadTransferTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TransferEntry>(ct);

    public IAsyncEnumerable<TransferGroupEntry> ReadTransferGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TransferGroupEntry>(ct);

    public IAsyncEnumerable<AppearanceEntry> ReadAppearanceTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AppearanceEntry>(ct);

    public IAsyncEnumerable<BroachSetEntry> ReadBroachSetTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BroachSetEntry>(ct);

    public IAsyncEnumerable<ChattingcommandEntry> ReadChattingcommandTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ChattingcommandEntry>(ct);

    public IAsyncEnumerable<CostumeClosetEntry> ReadCostumeClosetTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CostumeClosetEntry>(ct);

    public IAsyncEnumerable<CustomizeViewAniEntry> ReadCustomizeViewAniTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomizeViewAniEntry>(ct);

    public IAsyncEnumerable<DispatchEntry> ReadDispatchTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DispatchEntry>(ct);

    public IAsyncEnumerable<FragmentExtractionEntry> ReadFragmentExtractionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<FragmentExtractionEntry>(ct);

    public IAsyncEnumerable<HelperRewardEntry> ReadHelperRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<HelperRewardEntry>(ct);

    public IAsyncEnumerable<ItemRandomboxEntry> ReadItemRandomboxTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemRandomboxEntry>(ct);

    public IAsyncEnumerable<ItemRepairEntry> ReadItemRepairTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemRepairEntry>(ct);

    public IAsyncEnumerable<MonsterPartsEntry> ReadMonsterPartsTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MonsterPartsEntry>(ct);

    public IAsyncEnumerable<MonsterRimlightEntry> ReadMonsterRimlightTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MonsterRimlightEntry>(ct);

    public IAsyncEnumerable<PetItemCombinationEntry> ReadPetItemCombinationTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetItemCombinationEntry>(ct);

    public IAsyncEnumerable<PetStoryEntry> ReadPetStoryTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PetStoryEntry>(ct);

    public IAsyncEnumerable<ResvfxEntry> ReadResvfxTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ResvfxEntry>(ct);

    public IAsyncEnumerable<RoomrankRewardEntry> ReadRoomrankRewardTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<RoomrankRewardEntry>(ct);

    public IAsyncEnumerable<SpeechPcBEntry> ReadSpeechPcBTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcBEntry>(ct);

    public IAsyncEnumerable<SpeechPcCEntry> ReadSpeechPcCTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SpeechPcCEntry>(ct);

    public IAsyncEnumerable<VfxBattlematerialEntry> ReadVfxBattlematerialTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<VfxBattlematerialEntry>(ct);

    public IAsyncEnumerable<VfxGroundmaterialEntry> ReadVfxGroundmaterialTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<VfxGroundmaterialEntry>(ct);

    public IAsyncEnumerable<ApplychallengeEntry> ReadApplychallengeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ApplychallengeEntry>(ct);

    public IAsyncEnumerable<BroachSetBookEntry> ReadBroachSetBookTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BroachSetBookEntry>(ct);

    public IAsyncEnumerable<CinemaStringEntry> ReadCinemaStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CinemaStringEntry>(ct);

    public IAsyncEnumerable<CreateClothEntry> ReadCreateClothTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CreateClothEntry>(ct);

    public IAsyncEnumerable<CustomizeViewWeaponEntry> ReadCustomizeViewWeaponTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomizeViewWeaponEntry>(ct);

    public IAsyncEnumerable<DivergenceEntry> ReadDivergenceTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DivergenceEntry>(ct);

    public IAsyncEnumerable<FxBattlematerialLinkEntry> ReadFxBattlematerialLinkTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<FxBattlematerialLinkEntry>(ct);

    public IAsyncEnumerable<HiddenEventEntry> ReadHiddenEventTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<HiddenEventEntry>(ct);

    public IAsyncEnumerable<ItemScriptEntry> ReadItemScriptTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemScriptEntry>(ct);

    public IAsyncEnumerable<ItemSetitemEntry> ReadItemSetitemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemSetitemEntry>(ct);

    public IAsyncEnumerable<MazerewardPartyvalueEntry> ReadMazerewardPartyvalueTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazerewardPartyvalueEntry>(ct);

    public IAsyncEnumerable<MazerewardRankEntry> ReadMazerewardRankTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazerewardRankEntry>(ct);

    public IAsyncEnumerable<OptionStringEntry> ReadOptionStringTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<OptionStringEntry>(ct);

    public IAsyncEnumerable<PartyreviseEntry> ReadPartyreviseTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PartyreviseEntry>(ct);

    public IAsyncEnumerable<QuestEpisodeEntry> ReadQuestEpisodeTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<QuestEpisodeEntry>(ct);

    public IAsyncEnumerable<QuestReplayEntry> ReadQuestReplayTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<QuestReplayEntry>(ct);

    public IAsyncEnumerable<SkillSlotExtendEntry> ReadSkillSlotExtendTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SkillSlotExtendEntry>(ct);

    public IAsyncEnumerable<SocialItemEntry> ReadSocialItemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SocialItemEntry>(ct);

    public IAsyncEnumerable<TalkEntry> ReadTalkTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TalkEntry>(ct);

    public IAsyncEnumerable<TalkListEntry> ReadTalkListTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<TalkListEntry>(ct);

    public IAsyncEnumerable<AchievementEntry> ReadAchievementTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<AchievementEntry>(ct);

    public IAsyncEnumerable<BroachSimulatorEntry> ReadBroachSimulatorTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<BroachSimulatorEntry>(ct);

    public IAsyncEnumerable<CharacterBackgroundEntry> ReadCharacterBackgroundTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CharacterBackgroundEntry>(ct);

    public IAsyncEnumerable<CommonEntry> ReadCommonTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CommonEntry>(ct);

    public IAsyncEnumerable<CustomizeSkinEntry> ReadCustomizeSkinTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<CustomizeSkinEntry>(ct);

    public IAsyncEnumerable<DisassembleEntry> ReadDisassembleTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<DisassembleEntry>(ct);

    public IAsyncEnumerable<EqualizerInfoEntry> ReadEqualizerInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<EqualizerInfoEntry>(ct);

    public IAsyncEnumerable<GrowthItemOptionEntry> ReadGrowthItemOptionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<GrowthItemOptionEntry>(ct);

    public IAsyncEnumerable<ItemClassrewardLinkEntry> ReadItemClassrewardLinkTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemClassrewardLinkEntry>(ct);

    public IAsyncEnumerable<ItemCostumesetEntry> ReadItemCostumesetTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<ItemCostumesetEntry>(ct);

    public IAsyncEnumerable<MazeInfoEntry> ReadMazeInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazeInfoEntry>(ct);

    public IAsyncEnumerable<MazeOpenGroupEntry> ReadMazeOpenGroupTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MazeOpenGroupEntry>(ct);

    public IAsyncEnumerable<MyroomInfoEntry> ReadMyroomInfoTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<MyroomInfoEntry>(ct);

    public IAsyncEnumerable<NamefilterEntry> ReadNamefilterTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<NamefilterEntry>(ct);

    public IAsyncEnumerable<PresetEntry> ReadPresetTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PresetEntry>(ct);

    public IAsyncEnumerable<PvpLevelupPointEntry> ReadPvpLevelupPointTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<PvpLevelupPointEntry>(ct);

    public IAsyncEnumerable<SelectItemEntry> ReadSelectItemTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SelectItemEntry>(ct);

    public IAsyncEnumerable<SfxBattlematerialEntry> ReadSfxBattlematerialTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<SfxBattlematerialEntry>(ct);

    public IAsyncEnumerable<StatisticsEntry> ReadStatisticsTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<StatisticsEntry>(ct);

    public IAsyncEnumerable<StatusEntry> ReadStatusTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<StatusEntry>(ct);

    public IAsyncEnumerable<WeekMissionEntry> ReadWeekMissionTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WeekMissionEntry>(ct);

    public IAsyncEnumerable<WinPoseEntry> ReadWinPoseTableAsync(CancellationToken ct = default) =>
        ReadEntriesAsync<WinPoseEntry>(ct);

    public TableReader(ZipFile zip) : base(zip) { }
 }
