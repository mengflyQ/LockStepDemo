--encoding=utf-8

--message id
MsgID = {
    HandshakeRequestID	= 0x0001,
    HandshakeResponseID = 0x0002,

    ReportServerLoadID = 0x0050,

    HeartbeatID = 0x0060,
    ReloadLuaFileID = 0x0070,
    OnNewDayComeID = 0x0071,

    --DB操作
    AccountQueryID = 0x0100,
    AccountQueryRespID = 0x0101,
    PlayerQueryID = 0x0102,
    PlayerQueryRespID = 0x0103,
    NameQueryID = 0x0104,
    NameQueryRespID = 0x0105,
    MailQueryID = 0x0106,
    MailQueryRespID = 0x0107,

    -- Log操作
    LoginAndlogoutLogID = 0x0150,
    OnlineUserCountLogID = 0x0151,
    CreateCharacterLogID = 0x0152,
    GoodsProduceAndConsumeLogID = 0x0153,
    JoinActivityLogID = 0x0154,
    RechargeAndExpenseLogID = 0x0155,
    MatchRecordLogID = 0x0156,

    --Login
    VerifyVersionID = 0x0200,
    VerifyVersionRespID = 0x0201,
    VerifyCDKeyID = 0x0202,
    VerifyCDKeyRespID = 0x0203,

    EnterPlatID = 0x0210,
    EnterPlatRespID = 0x0211,
    CheckSessionID = 0x0212,
    CheckSessionRespID = 0x0213,
    CreateTeamID = 0x0214,
    CreateTeamRespID = 0x0215,
    ChooseRoleID = 0x0216,
    ChooseRoleRespID = 0x0217,
    CreateCaptainID = 0x0218,
    BuyCaptainID = 0x0219,
    BuyCaptainRespID = 0x021A,
    SwitchCaptainID = 0x021B,
    SwitchCaptainRespID = 0x021C,
    StartTrainingID = 0x021D,
    StartTrainingRespID  = 0x021E,
    NotifyTrainingInfoID = 0x021F,
    TrainingUpConfirmID = 0x0220,
    TrainingUpConfirmRespID = 0x0221,
    OpenTrainingID = 0x0222,
    OpenTrainingRespID = 0x0223,

    CreateStepInID			= 0x0230,
    CreateStepInRespID		= 0x0231,

    LogoutID = 0x0300,
    LogoutRespID = 0x0301,

    --玩家数据
    SetPlayerDataID = 0x0400,
    ChangePlayerDataID = 0x0401,
    UpdatePlayerDataID = 0x0402,
    UpdateGoodsID = 0x0403,

        --免费体力
    GetFreeHpReqID = 0x0410,
    GetFreeHpRespID = 0x0411,

    --------------抽奖
    BuyLotteryReqID			= 0x0440,
    BuyLotteryRespID		= 0x0441,

    --购买基础数值
    PlayerVipOperationID = 0x0450,
    PlayerVipOperationRespID = 0x0451,
    --PlayerBuyDiamondID = 0x0452,
    PlayerVipLevelUpRespID = 0x0453,
    --PlayerBuyGoldID = 0x0454,
    --PlayerBuyGoldRespID = 0x0455,

    --物品
    SellGoodsID = 0x0460,
    SellGoodsRespID = 0x0461,
    UseGoodsID = 0x0462,
    UseGoodsRespID = 0x0463,
    CompositeGoodsID = 0x0464,
    CompositeGoodsRespID = 0x0465,
    DecomposeGoodsID = 0x0466,
    DecomposeGoodsRespID = 0x0467,

    --技能
    SkillOperationID = 0x0470,
    SkillOperationRespID = 0x0471,

    --纹身
    TattooOperationID = 0x0480,
    TattooOperationRespID = 0x0481,
    TattooUpgradeID = 0x0482,
    TattooUpgradeRespID = 0x0483,

    --时装
    FashionOperationID   = 0x0490,
    FashionOperationRespID = 0x0491,
    FashionResetAttrReqID	= 0x0492,
    FashionResetAttrRespID	= 0x0493,

    --装备
    EquipOperationID = 0x0495,
    EquipOperationRespID = 0x0496,

    --生涯模式
    StartSectionMatchID = 0x0500,
    StartSectionMatchRespID = 0x0501,
    EndSectionMatchID = 0x0502,
    EndSectionMatchRespID = 0x0503,
    SweepSectionID = 0x0504,
    SweepSectionRespID = 0x0505,
    GetChapterStarAwardID = 0x0506,
    GetChapterStarAwardRespID = 0x0507,
    ResetSectionChallengeTimesID = 0x0508,
    ResetSectionChallengeTimesRespID = 0x0509,
    AddNewChapterID = 0x050A,
    PlayAnimationReqID = 0x050B;

    ImproveQualityReqID = 0x0600,
    ImproveQualityRespID = 0x0601,
    InviteRoleReqID = 0x0602,
    InviteRoleRespID = 0x0603,
    AddRolePiecesID = 0x0604,
    AddRolePiecesRespID = 0x0605,
    EnhanceLevelReqID				= 0x0606,
    EnhanceLevelRespID				= 0x0607,
    EnhanceExerciseReqID			= 0x0608,
    EnhanceExerciseRespID			= 0x0609,
    ResetRoleReqID					= 0x0610;
    ResetRoleRespID					= 0x0611;

    --商店
    OpenStoreID = 0x0700,
    OpenStoreRespID = 0x0701,
    RefreshStoreGoodsID = 0x0702,
    RefreshStoreGoodsRespID = 0x0703,
    BuyStoreGoodsID = 0x0704,
    BuyStoreGoodsRespID = 0x0705,

    --变更阵容
    ChangeFightRoleID = 0x0800,
    ChangeFightRoleRespID = 0x0801,
    UpdateFightRoleID = 0x0802,

    --------------新人签到
    NewComerSignReqID				= 0x0810;
    NewComerSignRespID				= 0x0811;
    --------------聊天
    ChatReqID						= 0x0813;
    ChatBroadcastID					= 0x0814;
    ChatRespID						= 0x0815;
    QueryPlayerInfoReqID			= 0x0816;
    QueryPlayerInfoRespID			= 0x0817;
    ChatLatestInfoReqID				= 0x0818;
    ChatLatestInfoRespID			= 0x0819;

    --------------新人活动
    NewComerTrialNotifyID			= 0x0830;
    GetNewComerTrialAwardsReqID		= 0x0831;
    GetNewComerTrialAwardsRespID	= 0x0832;

    --荣誉争霸赛
    EnterRaceReqID = 0x0900,
    EnterRaceRespID = 0x0901,
    EndRaceReqID = 0x0902,
    EndRaceRespID = 0x0903,
    ExitRaceReqID = 0x0904,
    ExitRaceRespID = 0x0905,
    BuyRaceTimesReqID = 0x0906,
    BuyRaceTimesRespID = 0x0907,
    AsynEnterRoomReqID = 0x0908,
    AsynEnterRoomRespID = 0x0909,
    AsynExitRoomReqID = 0x090A,
    AsynExitRoomRespID = 0x090B,

    --排行榜
    RankListReqID = 0x0910,
    RankListRespID = 0x0911,
    FetchRankListReqID = 0x0920,
    FetchRankListRespID = 0x0921,
    UpdateRankListReqID = 0x0922,
    UpdateRankListRespID = 0x0923,
    UpdateRankListID = 0x0924,

    --巡回赛
    TourResetReqID = 0x0930,
    TourResetRespID = 0x0931,
    TourStartReqID = 0x0932,
    TourStartRespID = 0x0933,
    TourCompleteReqID = 0x0934,
    TourCompleteRespID = 0x0935,
    TourExitReqID = 0x0936,
    TourExitRespID = 0x0937,
    ResetTourNpcID					= 0x0938,
    UpdateTourInfoReqID				= 0x0939;
    UpdateTourInfoRespID				= 0x093A;
    TourBuyChallengeTimesReqID			= 0x093B;
    TourBuyChallengeTimesRespID			= 0x093C;

    --
    NotifyPlayerDataID = 0x0940,

    --排位赛
    FlushRivalReqID = 0x0950,
    FlushRivalRespID = 0x0951,
    SetDefendReqID = 0x0952,
    SetDefendRespID	= 0x0953,
    ResetBattleCDReqID = 0x0954,
    ResetBattleCDRespID	= 0x0955,
    GetBattleNewsID	= 0x0956,
    GetBattleNewsRespID	= 0x0957,
    QualifyingBuyTimesReqID			= 0x0958;
    QualifyingBuyTimesRespID		= 0x0959;
    QualifyingRankingNotifyID		= 0x095A;
    RefreshQualifyingNewInfoID		= 0x095C;

    -- 新排位赛
    RefreshQualifyingNewerInfoID          = 0x0970;
    NotifyQualifyingNewerLeagueResetID    = 0x0971;
    GetQualifyingNewerGradesAwardsReqID   = 0x0972;
    GetQualifyingNewerGradesAwardsRespID  = 0x0973;
    GetQualifyingNewerLeagueAwardsReqID   = 0x0974;
    GetQualifyingNewerLeagueAwardsRespID  = 0x0975;


    --天梯赛
    RefreshLadderInfoID				= 0x0960,
    NotifyLadderLeagueResetID       = 0x0961,
    GetLadderLeagueAwardsReqID      = 0x0962,
    GetLadderLeagueAwardsRespID     = 0x0963,

    --新巡回赛
    GetTourNewGradesAwardsReqID     = 0x0980;
    GetTourNewGradesAwardsRespID    = 0x0981;

    --任务
    TaskInfoReqID = 0x1000,
    TaskInfoRespID = 0x1001,
    GetTaskAwardReqID = 0x1002,
    GetTaskAwardRespID = 0x1003,
    UnclaimedTaskNumNotifyID = 0x1004,
    SignReqID = 0x1005,
    SignRespID = 0x1006,
    GetSignAwardReqID = 0x1007,
    GetSignAwardRespID = 0x1008,
    NotifyTaskFinishID = 0x1009,

    --操作练习
    BeginPracticeID = 0x1150,
    BeginPracticeRespID = 0x1151,
    EndPracticeID = 0x1152,
    EndPracticeRespID = 0x1153,
    ExitPracticeID = 0x1154,
    ExitPracticeRespID = 0x1155,

    --邮件
    OpenMailSysID = 0x1200,
    MailInfoNotifyID = 0x01201,
    NewMailNotifyID = 0x01202,
    ReadMailID = 0x01203,
    ReadMailRespID = 0x01204,
    GetAttachmentID = 0x01205,
    GetAttachmentRespID = 0x01206,
    GetBulkAttachmentID = 0x01207,  --批量领取附件
    GetBulkAttachmentRespID = 0x01208,


    -- 斗牛比赛.
    GetBullFightNpcReqID			= 0x01210,
    GetBullFightNpcRespID			= 0x01211,
    BuyBullFightTimesReqID			= 0x01212,
    BuyBullFightTimesRespID			= 0x01213,

    -- 投篮比赛.
    ShootOpenReqID					= 0x01220;
    ShootOpenRespID					= 0x01221;
    ShootBuyTimesReqID				= 0x01222;
    ShootBuyTimesRespID				= 0x01223;
    ShootOpenCardReqID				= 0x01224;
    ShootOpendCardRespID			= 0x01225;

    --指引
    BeginGuideReqID = 0x1300,
    BeginGuideRespID = 0x1301,
    EndGuideReqID = 0x1302,
    EndGuideRespID = 0x1303,

    --活跃度
    GetActivityAwardsReqID			= 0x1310;
    GetActivityAwardsRespID			= 0x1311;
    UpdateActivityInfoID			= 0x1312;

    --同步PVP
    EnterRoomReqID					= 0x2300;
    EnterRoomRespID					= 0x2301;
    JoinRoomReqID					= 0x2302;
    JoinRoomRespID					= 0x2303;
    ExitRoomReqID					= 0x2306;
    ExitRoomRespID					= 0x2307;
    RoomActionReqID					= 0x2308;
    RoomActionRespID					= 0x2309;
    NotifyRoomUserID					= 0x230A;
    NotifyRoomUserExitID					= 0x230B;
    PVPReadyReqID					= 0x230C;
    PVPReadyRespID					= 0x230D;
    GameBeginReqID					= 0x230E;
    CreateRoomReqID					= 0x230E;
    CreateRoomRespID				= 0x230F;


    StartMatchReqID					= 0x2310;
    StartMatchRespID					= 0x2311;
    CancelMatchReqID					= 0x2312;
    CancelMatchRespID					= 0x2313;
    CreateGameReqID					= 0x2314;
    CreateGameRespID					= 0x2315;
    StartGameReqID					= 0x2316;
    StartGameRespID					= 0x2317;
    EnterGameReqID					= 0x2318;
    EnterGameRespID					= 0x2319;
    ExitGameReqID					= 0x231A;
    ExitGameRespID					= 0x231B;
    RequirePlayerDataID					= 0x231C;
    RequirePlayerDataRespID					= 0x231D;
    NotifyGameStartID					= 0x231E;
    NotifyGameStartRespID				= 0x231F;

    NotifyMatchInfoID					= 0x2320;
    SelectFightRoleID					= 0x2321;
    NotifySelectFightRoleID				= 0x2322;
    MatchOverID							= 0x2323;
    ExitSelectRoleUIID                  = 0x2324;

    RoomInfoReqID                   = 0x2330;
    NotifyUserReturnID              = 0x2331;


    EnterGameSrvID					= 0x2400;
    EnterGameSrvRespID					= 0x2401;
    FirstWinInfoID					= 0x2420;

    --比赛中,
    --BeginMoveID = 0x2500,
    StandID = 0x2500,
    MoveID = 0x2501,
    GameMsgID = 0x2502,

    SkillID = 0x2505,
    PickBallID = 0x250A,
    --BallStateID	= 0x250B,
    AttackID = 0x250F,
    PrepareToShootID = 0x2510,
    --ShootID = 0x2511,
    --LayupID = 0x2512,
    DownID = 0x2512,
    FallDownID = 0x2513,
    BlockID = 0x2514,
    StealID = 0x2515,
    StolenID = 0x2516,
    CrossOverID = 0x2517,
    ReboundID = 0x2518,
    BodyThrowCatchID = 0x2519,

    --GM指令,
    GMCommondExcuID = 0x3000,

    ServerDiscontinueInfoID = 0x8000,


    --好友系统
    FriendOperationReqID			= 0x0840;
    FriendOperationRespID			= 0x0841;
    QueryFriendInfoReqID			= 0x0842;
    QueryFriendInfoRespID			= 0x0843;
    NotifyFriendInfoID				= 0x0844;
    UpdatePlayerInfoID				= 0x0845;
    NotifyOffLineInfoToPlayerID		= 0x0846;
    SearchFriendID					= 0x0847;
    SearchFriendRespID				= 0x0848;    
    UpdateFriendInfoID              = 0x0849;


    -- 徽章系统
    BadgeUnlockSlotReqID			= 0x1350,
    BadgeUnlockSlotRespID			= 0x1351,
    BadgeBookChangeNameReqID		= 0x1352,
    BadgeBookChangeNameRespID		= 0x1353,
    BadgeAddBookReqID				= 0x1354,
    BadgeAddBookRespID				= 0x1355,
    BadgeEquipReqID					= 0x1356,
    BadgeEquipRespID				= 0x1357,
    BadgeUnequipReqID				= 0x1358,
    BadgeUnequipRespID				= 0x1359,
    BadgeDecomposeReqID				= 0x135A,
    BadgeDecomposeRespID			= 0x135B,
    BadgeComposeReqID				= 0x135C,
    BadgeComposeRespID				= 0x135D,
    BadgeSlotInfoUpdateID			= 0x135E,
    BadgeBookUseReqID				= 0x135F;
    BadgeDecomposeByGroupReqID      = 0x1360;
    BadgeDecomposeByGroupRespID     = 0x1361;
    BadgeChangeReqID                = 0x1362;
    BadgeChangeRespID               = 0x1363;

    --聊天功能--
    ChatRoomLatestQueryReqID        = 0x9017;
    ChatRoomQueryLatestRespID       = 0x9018;
    ChatRoomDeliverID               = 0x9019;
    ChatRoomBroadcastID             = 0x9020;
    NotifyMatchChatRoomID           = 0x9021;

    --成长引导
    GetLevelAwardReqID              = 0x9030;
    GetLevelAwardRespID             = 0x9031;
    LevelAwardStateReqID            = 0x9032;
    LevelAwardStateRespID           = 0x9033;

    -- 辅助开关
    FunctionSwitchListID            = 0x9034;
}