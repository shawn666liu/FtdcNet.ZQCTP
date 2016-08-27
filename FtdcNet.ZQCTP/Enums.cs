/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2016/8/26 21:37:00
/////////////////////////////////////////////////////////////////////////

using System;

namespace ZQCTP
{
    /// <summary>
    /// THOST_TE_RESUME_TYPE, 公共流重传方式
    /// </summary>
    public enum EnumTeResumeType : byte
    {
        THOST_TERT_RESTART = 0,
        THOST_TERT_RESUME,
        THOST_TERT_QUICK
    };

    /// <summary>
    /// TFtdcOrderUnitType是一个申报单位类型
    /// </summary>
    public enum EnumOrderUnitType : byte
    {
        /// <summary>
        /// 手
        /// </summary>
        Shou = (byte)'0',

        /// <summary>
        /// 股
        /// </summary>
        Gu = (byte)'1',

        /// <summary>
        /// 份
        /// </summary>
        Fen = (byte)'2',

        /// <summary>
        /// 张
        /// </summary>
        Zhang = (byte)'3'
    };

    /// <summary>
    /// TFtdcStatusType是一个有效状态类型
    /// </summary>
    public enum EnumStatusType : byte
    {
        /// <summary>
        /// 初始
        /// </summary>
        Initial = (byte)'0',

        /// <summary>
        /// 启用
        /// </summary>
        Starting = (byte)'1',

        /// <summary>
        /// 禁用
        /// </summary>
        Forbidden = (byte)'2'
    };

    /// <summary>
    /// TFtdcTradingStatusType是一个交易状态类型
    /// </summary>
    public enum EnumTradingStatusType : byte
    {
        /// <summary>
        /// 收市
        /// </summary>
        Closing = (byte)'0',

        /// <summary>
        /// 开盘集合竞价
        /// </summary>
        OpenAggregateAuction = (byte)'1',

        /// <summary>
        /// 连续竞价
        /// </summary>
        ContinuousAuction = (byte)'2',

        /// <summary>
        /// 收盘集合竞价
        /// </summary>
        CloseAggregateAuction = (byte)'3',

        /// <summary>
        /// 非交易
        /// </summary>
        NoneTrade = (byte)'4'
    };

    /// <summary>
    /// TFtdcRatioBaseType是一个持股比例基准类型
    /// </summary>
    public enum EnumRatioBaseType : byte
    {
        /// <summary>
        /// 总股本
        /// </summary>
        Total = (byte)'0',

        /// <summary>
        /// 流通股本
        /// </summary>
        Circulation = (byte)'1'
    };

    /// <summary>
    /// TFtdcInvestorTypeType是一个投资者类型类型
    /// </summary>
    public enum EnumInvestorTypeType : byte
    {
        /// <summary>
        /// 自然人
        /// </summary>
        Person = (byte)'0',

        /// <summary>
        /// 法人
        /// </summary>
        Company = (byte)'1',

        /// <summary>
        /// 投资基金
        /// </summary>
        Fund = (byte)'2',

        /// <summary>
        /// 特殊法人
        /// </summary>
        SpecialOrgan = (byte)'3',

        /// <summary>
        /// 资管户
        /// </summary>
        Asset = (byte)'4'
    };

    /// <summary>
    /// TFtdcIdCardTypeType是一个证件类型类型
    /// </summary>
    public enum EnumIdCardTypeType : byte
    {
        /// <summary>
        /// 组织机构代码
        /// </summary>
        EID = (byte)'0',

        /// <summary>
        /// 中国公民身份证
        /// </summary>
        IDCard = (byte)'1',

        /// <summary>
        /// 军官证
        /// </summary>
        OfficerIDCard = (byte)'2',

        /// <summary>
        /// 警官证
        /// </summary>
        PoliceIDCard = (byte)'3',

        /// <summary>
        /// 士兵证
        /// </summary>
        SoldierIDCard = (byte)'4',

        /// <summary>
        /// 户口簿
        /// </summary>
        HouseholdRegister = (byte)'5',

        /// <summary>
        /// 护照
        /// </summary>
        Passport = (byte)'6',

        /// <summary>
        /// 台胞证
        /// </summary>
        TaiwanCompatriotIDCard = (byte)'7',

        /// <summary>
        /// 回乡证
        /// </summary>
        HomeComingCard = (byte)'8',

        /// <summary>
        /// 营业执照号
        /// </summary>
        LicenseNo = (byte)'9',

        /// <summary>
        /// 税务登记号/当地纳税ID
        /// </summary>
        TaxNo = (byte)'A',

        /// <summary>
        /// 港澳居民来往内地通行证
        /// </summary>
        HMMainlandTravelPermit = (byte)'B',

        /// <summary>
        /// 台湾居民来往大陆通行证
        /// </summary>
        TwMainlandTravelPermit = (byte)'C',

        /// <summary>
        /// 驾照
        /// </summary>
        DrivingLicense = (byte)'D',

        /// <summary>
        /// 当地社保ID
        /// </summary>
        SocialID = (byte)'F',

        /// <summary>
        /// 当地身份证
        /// </summary>
        LocalID = (byte)'G',

        /// <summary>
        /// 商业登记证
        /// </summary>
        BusinessRegistration = (byte)'H',

        /// <summary>
        /// 港澳永久性居民身份证
        /// </summary>
        HKMCIDCard = (byte)'I',

        /// <summary>
        /// 人行开户许可证
        /// </summary>
        AccountsPermits = (byte)'J',

        /// <summary>
        /// 其他证件
        /// </summary>
        OtherCard = (byte)'x'
    };

    /// <summary>
    /// TFtdcGenderType是一个性别类型
    /// </summary>
    public enum EnumGenderType : byte
    {
        /// <summary>
        /// 男
        /// </summary>
        Man = (byte)'1',

        /// <summary>
        /// 女
        /// </summary>
        Woman = (byte)'2'
    };

    /// <summary>
    /// TFtdcAccountTypeType是一个资金账户类型类型
    /// </summary>
    public enum EnumAccountTypeType : byte
    {
        /// <summary>
        /// 普通
        /// </summary>
        Normal = (byte)'1',

        /// <summary>
        /// 信用
        /// </summary>
        Credit = (byte)'2',

        /// <summary>
        /// 衍生品
        /// </summary>
        Derivatives = (byte)'3'
    };

    /// <summary>
    /// TFtdcSubscribingSharesLimitFlagType是一个新股申购上限控制标志类型
    /// </summary>
    public enum EnumSubscribingSharesLimitFlagType : byte
    {
        /// <summary>
        /// 按全部控制
        /// </summary>
        All = (byte)'0',

        /// <summary>
        /// 按网上申购上限控制
        /// </summary>
        OnlineLimit = (byte)'1',

        /// <summary>
        /// 按可申购额度控制
        /// </summary>
        PersonalLimit = (byte)'2'
    };

    /// <summary>
    /// TFtdcPositionTradingFlagType是一个持仓交易标志类型
    /// </summary>
    public enum EnumPositionTradingFlagType : byte
    {
        /// <summary>
        /// 不可以
        /// </summary>
        Forbidden = (byte)'0',

        /// <summary>
        /// 可以
        /// </summary>
        Permit = (byte)'1',

        /// <summary>
        /// 不适用
        /// </summary>
        NA = (byte)'x'
    };

    /// <summary>
    /// TFtdcDirectionType是一个报单类别类型
    /// </summary>
    public enum EnumDirectionType : byte
    {
        /// <summary>
        /// 买入
        /// </summary>
        Buy = (byte)'0',

        /// <summary>
        /// 卖出
        /// </summary>
        Sell = (byte)'1',

        /// <summary>
        /// ETF申购
        /// </summary>
        ETFPur = (byte)'2',

        /// <summary>
        /// ETF赎回
        /// </summary>
        ETFRed = (byte)'3',

        /// <summary>
        /// 新股申购
        /// </summary>
        SubscribingShares = (byte)'4',

        /// <summary>
        /// 正回购
        /// </summary>
        Repurchase = (byte)'5',

        /// <summary>
        /// 逆回购
        /// </summary>
        ReverseRepur = (byte)'6',

        /// <summary>
        /// 开放式基金申购
        /// </summary>
        OeFundPur = (byte)'8',

        /// <summary>
        /// 开放式基金赎回
        /// </summary>
        OeFundRed = (byte)'9',

        /// <summary>
        /// 担保品划入
        /// </summary>
        CollateralIn = (byte)'a',

        /// <summary>
        /// 担保品划出
        /// </summary>
        CollateralOut = (byte)'b',

        /// <summary>
        /// 质押入库
        /// </summary>
        PledgeIn = (byte)'d',

        /// <summary>
        /// 质押出库
        /// </summary>
        PledgeOut = (byte)'e',

        /// <summary>
        /// 配股配债
        /// </summary>
        Rationed = (byte)'f',

        /// <summary>
        /// 开放式基金拆分
        /// </summary>
        Split = (byte)'g',

        /// <summary>
        /// 开放式基金合并
        /// </summary>
        Merge = (byte)'h',

        /// <summary>
        /// 融资买入
        /// </summary>
        MarginBuy = (byte)'i',

        /// <summary>
        /// 融券卖出
        /// </summary>
        ShortSell = (byte)'j',

        /// <summary>
        /// 卖券还款
        /// </summary>
        SellRepayment = (byte)'k',

        /// <summary>
        /// 买券还券
        /// </summary>
        BuyRepayment = (byte)'l',

        /// <summary>
        /// 还券划转
        /// </summary>
        SecurityRepay = (byte)'m',

        /// <summary>
        /// 余券划转
        /// </summary>
        RemainTransfer = (byte)'n'
    };

    /// <summary>
    /// TFtdcBrokerageTypeType是一个佣金类型类型
    /// </summary>
    public enum EnumBrokerageTypeType : byte
    {
        /// <summary>
        /// 毛佣金
        /// </summary>
        Gross = (byte)'0',

        /// <summary>
        /// 净佣金
        /// </summary>
        Net = (byte)'1'
    };

    /// <summary>
    /// TFtdcUserTypeType是一个用户类型类型
    /// </summary>
    public enum EnumUserTypeType : byte
    {
        /// <summary>
        /// 经纪公司用户
        /// </summary>
        Broker = (byte)'0',

        /// <summary>
        /// 系统维护用户
        /// </summary>
        SystemAdmin = (byte)'1',

        /// <summary>
        /// 投资者用户
        /// </summary>
        Investor = (byte)'2',

        /// <summary>
        /// 外部系统用户
        /// </summary>
        OtherSystem = (byte)'3'
    };

    /// <summary>
    /// TFtdcContingentConditionType是一个触发条件类型
    /// </summary>
    public enum EnumContingentConditionType : byte
    {
        /// <summary>
        /// 立即
        /// </summary>
        Immediately = (byte)'1',

        /// <summary>
        /// 止损
        /// </summary>
        Touch = (byte)'2',

        /// <summary>
        /// 止赢
        /// </summary>
        TouchProfit = (byte)'3',

        /// <summary>
        /// 预埋单
        /// </summary>
        ParkedOrder = (byte)'4',

        /// <summary>
        /// 最新价大于条件价
        /// </summary>
        LastPriceGreaterThanStopPrice = (byte)'5',

        /// <summary>
        /// 最新价大于等于条件价
        /// </summary>
        LastPriceGreaterEqualStopPrice = (byte)'6',

        /// <summary>
        /// 最新价小于条件价
        /// </summary>
        LastPriceLesserThanStopPrice = (byte)'7',

        /// <summary>
        /// 最新价小于等于条件价
        /// </summary>
        LastPriceLesserEqualStopPrice = (byte)'8',

        /// <summary>
        /// 卖一价大于条件价
        /// </summary>
        AskPriceGreaterThanStopPrice = (byte)'9',

        /// <summary>
        /// 卖一价大于等于条件价
        /// </summary>
        AskPriceGreaterEqualStopPrice = (byte)'A',

        /// <summary>
        /// 卖一价小于条件价
        /// </summary>
        AskPriceLesserThanStopPrice = (byte)'B',

        /// <summary>
        /// 卖一价小于等于条件价
        /// </summary>
        AskPriceLesserEqualStopPrice = (byte)'C',

        /// <summary>
        /// 买一价大于条件价
        /// </summary>
        BidPriceGreaterThanStopPrice = (byte)'D',

        /// <summary>
        /// 买一价大于等于条件价
        /// </summary>
        BidPriceGreaterEqualStopPrice = (byte)'E',

        /// <summary>
        /// 买一价小于条件价
        /// </summary>
        BidPriceLesserThanStopPrice = (byte)'F',

        /// <summary>
        /// 买一价小于等于条件价
        /// </summary>
        BidPriceLesserEqualStopPrice = (byte)'H'
    };

    /// <summary>
    /// TFtdcETFCurrenceReplaceStatusType是一个ETF现金替代标志类型
    /// </summary>
    public enum EnumETFCurrenceReplaceStatusType : byte
    {
        /// <summary>
        /// 禁止现金替代
        /// </summary>
        Forbidden = (byte)'0',

        /// <summary>
        /// 可以现金替代
        /// </summary>
        Allow = (byte)'1',

        /// <summary>
        /// 必须现金替代
        /// </summary>
        Force = (byte)'2',

        /// <summary>
        /// 跨市退补现金替代
        /// </summary>
        CBAllow = (byte)'3',

        /// <summary>
        /// 跨市必须现金替代
        /// </summary>
        CBForce = (byte)'4'
    };

    /// <summary>
    /// TFtdcAudStatusType是一个复核状态类型
    /// </summary>
    public enum EnumAudStatusType : byte
    {
        /// <summary>
        /// 初始
        /// </summary>
        Init = (byte)'0',

        /// <summary>
        /// 忽略
        /// </summary>
        Ignore = (byte)'1',

        /// <summary>
        /// 通过
        /// </summary>
        Confirm = (byte)'2',

        /// <summary>
        /// 驳回
        /// </summary>
        Reject = (byte)'3'
    };

    /// <summary>
    /// TFtdcBrokerExchangeStatusType是一个交易所状态类型
    /// </summary>
    public enum EnumBrokerExchangeStatusType : byte
    {
        /// <summary>
        /// 交易数据准备
        /// </summary>
        Preparing = (byte)'0',

        /// <summary>
        /// 开始交易
        /// </summary>
        Starting = (byte)'1',

        /// <summary>
        /// 结束交易
        /// </summary>
        Finished = (byte)'2'
    };

    /// <summary>
    /// TFtdcOperateSourceType是一个操作来源类型
    /// </summary>
    public enum EnumOperateSourceType : byte
    {
        /// <summary>
        /// 实时上场指令
        /// </summary>
        DBCommand = (byte)'0',

        /// <summary>
        /// 钱券同步
        /// </summary>
        SyncAPI = (byte)'1'
    };

    /// <summary>
    /// TFtdcOfferConnStatusType是一个报盘连接状态类型
    /// </summary>
    public enum EnumOfferConnStatusType : byte
    {
        /// <summary>
        /// 未连接
        /// </summary>
        NA = (byte)'0',

        /// <summary>
        /// 已连接
        /// </summary>
        Connected = (byte)'1'
    };

    /// <summary>
    /// TFtdcOrderPriceTypeType是一个报单价格条件类型
    /// </summary>
    public enum EnumOrderPriceTypeType : byte
    {
        /// <summary>
        /// 任意价
        /// </summary>
        AnyPrice = (byte)'1',

        /// <summary>
        /// 限价
        /// </summary>
        LimitPrice = (byte)'2',

        /// <summary>
        /// 最优价
        /// </summary>
        BestPrice = (byte)'3',

        /// <summary>
        /// 最新价
        /// </summary>
        LastPrice = (byte)'4',

        /// <summary>
        /// 最新价浮动上浮1个ticks
        /// </summary>
        LastPricePlusOneTicks = (byte)'5',

        /// <summary>
        /// 最新价浮动上浮2个ticks
        /// </summary>
        LastPricePlusTwoTicks = (byte)'6',

        /// <summary>
        /// 最新价浮动上浮3个ticks
        /// </summary>
        LastPricePlusThreeTicks = (byte)'7',

        /// <summary>
        /// 卖一价
        /// </summary>
        AskPrice1 = (byte)'8',

        /// <summary>
        /// 卖一价浮动上浮1个ticks
        /// </summary>
        AskPrice1PlusOneTicks = (byte)'9',

        /// <summary>
        /// 卖一价浮动上浮2个ticks
        /// </summary>
        AskPrice1PlusTwoTicks = (byte)'A',

        /// <summary>
        /// 卖一价浮动上浮3个ticks
        /// </summary>
        AskPrice1PlusThreeTicks = (byte)'B',

        /// <summary>
        /// 买一价
        /// </summary>
        BidPrice1 = (byte)'C',

        /// <summary>
        /// 买一价浮动上浮1个ticks
        /// </summary>
        BidPrice1PlusOneTicks = (byte)'D',

        /// <summary>
        /// 买一价浮动上浮2个ticks
        /// </summary>
        BidPrice1PlusTwoTicks = (byte)'E',

        /// <summary>
        /// 买一价浮动上浮3个ticks
        /// </summary>
        BidPrice1PlusThreeTicks = (byte)'F',

        /// <summary>
        /// 五档价
        /// </summary>
        FiveLevelPrice = (byte)'G',

        /// <summary>
        /// 本方最优
        /// </summary>
        HomeBestPrice = (byte)'a'
    };

    /// <summary>
    /// TFtdcTimeConditionType是一个有效期类型类型
    /// </summary>
    public enum EnumTimeConditionType : byte
    {
        /// <summary>
        /// 立即完成，否则撤销
        /// </summary>
        IOC = (byte)'1',

        /// <summary>
        /// 本节有效
        /// </summary>
        GFS = (byte)'2',

        /// <summary>
        /// 当日有效
        /// </summary>
        GFD = (byte)'3',

        /// <summary>
        /// 指定日期前有效
        /// </summary>
        GTD = (byte)'4',

        /// <summary>
        /// 撤销前有效
        /// </summary>
        GTC = (byte)'5',

        /// <summary>
        /// 集合竞价有效
        /// </summary>
        GFA = (byte)'6'
    };

    /// <summary>
    /// TFtdcVolumeConditionType是一个成交量类型类型
    /// </summary>
    public enum EnumVolumeConditionType : byte
    {
        /// <summary>
        /// 任何数量
        /// </summary>
        AV = (byte)'1',

        /// <summary>
        /// 最小数量
        /// </summary>
        MV = (byte)'2',

        /// <summary>
        /// 全部数量
        /// </summary>
        CV = (byte)'3'
    };

    /// <summary>
    /// TFtdcForceCloseReasonType是一个强平原因类型
    /// </summary>
    public enum EnumForceCloseReasonType : byte
    {
        /// <summary>
        /// 非强平
        /// </summary>
        NotForceClose = (byte)'0',

        /// <summary>
        /// 资金不足
        /// </summary>
        LackDeposit = (byte)'1',

        /// <summary>
        /// 客户超仓
        /// </summary>
        ClientOverPositionLimit = (byte)'2',

        /// <summary>
        /// 会员超仓
        /// </summary>
        MemberOverPositionLimit = (byte)'3',

        /// <summary>
        /// 持仓非整数倍
        /// </summary>
        NotMultiple = (byte)'4',

        /// <summary>
        /// 违规
        /// </summary>
        Violation = (byte)'5',

        /// <summary>
        /// 其它
        /// </summary>
        Other = (byte)'6'
    };

    /// <summary>
    /// TFtdcOrderSysStatusType是一个报单状态类型
    /// </summary>
    public enum EnumOrderSysStatusType : byte
    {
        /// <summary>
        /// 初始
        /// </summary>
        Initial = (byte)'0',

        /// <summary>
        /// 交易所已经接受
        /// </summary>
        Accepted = (byte)'1',

        /// <summary>
        /// 部分成交
        /// </summary>
        PartTraded = (byte)'2',

        /// <summary>
        /// 全部成交
        /// </summary>
        AllTraded = (byte)'3',

        /// <summary>
        /// 全部撤单
        /// </summary>
        AllCanceled = (byte)'4',

        /// <summary>
        /// 部分成交并撤单
        /// </summary>
        PartTradedCanceled = (byte)'5',

        /// <summary>
        /// 交易所已经拒绝
        /// </summary>
        Refused = (byte)'6',

        /// <summary>
        /// 报盘失败
        /// </summary>
        OfferFailed = (byte)'7'
    };

    /// <summary>
    /// TFtdcCancelOrderStatusType是一个撤单状态类型
    /// </summary>
    public enum EnumCancelOrderStatusType : byte
    {
        /// <summary>
        /// 撤单已提交
        /// </summary>
        Submitted = (byte)'a',

        /// <summary>
        /// 撤单已成功
        /// </summary>
        Canceled = (byte)'b',

        /// <summary>
        /// 撤单被拒绝
        /// </summary>
        Refused = (byte)'c',

        /// <summary>
        /// 报盘失败
        /// </summary>
        OfferFailed = (byte)'0'
    };

    /// <summary>
    /// TFtdcCancelOrderTypeType是一个撤单类型类型
    /// </summary>
    public enum EnumCancelOrderTypeType : byte
    {
        /// <summary>
        /// 普通撤单
        /// </summary>
        Nomal = (byte)'0',

        /// <summary>
        /// 强制撤单
        /// </summary>
        Force = (byte)'1'
    };

    /// <summary>
    /// TFtdcFundTransStatusType是一个出入金状态类型
    /// </summary>
    public enum EnumFundTransStatusType : byte
    {
        /// <summary>
        /// 申请
        /// </summary>
        Apply = (byte)'0',

        /// <summary>
        /// 确认
        /// </summary>
        Confirm = (byte)'1',

        /// <summary>
        /// 驳回
        /// </summary>
        Reject = (byte)'2'
    };

    /// <summary>
    /// TFtdcCustodyTransferTypeType是一个转托管类型类型
    /// </summary>
    public enum EnumCustodyTransferTypeType : byte
    {
        /// <summary>
        /// 经纪公司内部转托管
        /// </summary>
        Inner = (byte)'0',

        /// <summary>
        /// 经纪公司间转托管
        /// </summary>
        Outer = (byte)'1'
    };

    /// <summary>
    /// TFtdcTransferDirectionType是一个转移方向类型
    /// </summary>
    public enum EnumTransferDirectionType : byte
    {
        /// <summary>
        /// 转入CTP
        /// </summary>
        In = (byte)'0',

        /// <summary>
        /// 转出CTP
        /// </summary>
        Out = (byte)'1'
    };

    /// <summary>
    /// TFtdcActionTypeType是一个操作类型类型
    /// </summary>
    public enum EnumActionTypeType : byte
    {
        /// <summary>
        /// 转移
        /// </summary>
        Transfer = (byte)'0',

        /// <summary>
        /// 撤销
        /// </summary>
        Cancel = (byte)'1'
    };

    /// <summary>
    /// TFtdcTransferStatusType是一个转移状态类型
    /// </summary>
    public enum EnumTransferStatusType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 冲正
        /// </summary>
        Repeal = (byte)'1'
    };

    /// <summary>
    /// TFtdcTransferPositionTypeType是一个转移持仓类型类型
    /// </summary>
    public enum EnumTransferPositionTypeType : byte
    {
        /// <summary>
        /// 任意仓
        /// </summary>
        ALL = (byte)'0',

        /// <summary>
        /// 昨仓
        /// </summary>
        History = (byte)'1',

        /// <summary>
        /// 今买卖仓
        /// </summary>
        TodayBS = (byte)'2',

        /// <summary>
        /// 今申赎仓
        /// </summary>
        TodayPR = (byte)'3'
    };

    /// <summary>
    /// TFtdcAppTypeType是一个应用程序类型类型
    /// </summary>
    public enum EnumAppTypeType : byte
    {
        /// <summary>
        /// Dbmt
        /// </summary>
        Dbmt = (byte)'1',

        /// <summary>
        /// DbWriter
        /// </summary>
        DbWriter = (byte)'2',

        /// <summary>
        /// MdServer
        /// </summary>
        MdServer = (byte)'3',

        /// <summary>
        /// TraderOffer
        /// </summary>
        TraderOffer = (byte)'4',

        /// <summary>
        /// TInit
        /// </summary>
        TInit = (byte)'5',

        /// <summary>
        /// SecurityOffer
        /// </summary>
        SecurityOffer = (byte)'6'
    };

    /// <summary>
    /// TFtdcAppConnectStatusType是一个应用组件连接状态类型
    /// </summary>
    public enum EnumAppConnectStatusType : byte
    {
        /// <summary>
        /// 没有任何连接
        /// </summary>
        NotConnected = (byte)'1',

        /// <summary>
        /// 已经登陆交易核心
        /// </summary>
        Logged = (byte)'2',

        /// <summary>
        /// 已经连接外部系统
        /// </summary>
        SysConnected = (byte)'3',

        /// <summary>
        /// 正在登陆交易所
        /// </summary>
        ExgLogin = (byte)'4',

        /// <summary>
        /// 已登录交易所
        /// </summary>
        ExgLogged = (byte)'5'
    };

    /// <summary>
    /// TFtdcConnectStatusType是一个连接状态类型
    /// </summary>
    public enum EnumConnectStatusType : byte
    {
        /// <summary>
        /// 没有任何连接
        /// </summary>
        NotConnected = (byte)'1',

        /// <summary>
        /// 正在分配应用组件
        /// </summary>
        Dispatching = (byte)'2',

        /// <summary>
        /// 已经连接
        /// </summary>
        Connected = (byte)'3'
    };

    /// <summary>
    /// TFtdcExchSequenceTypeType是一个交易所回报序号类型类型
    /// </summary>
    public enum EnumExchSequenceTypeType : byte
    {
        /// <summary>
        /// 回报序号1
        /// </summary>
        Sequence1 = (byte)'1',

        /// <summary>
        /// 回报序号2
        /// </summary>
        Sequence2 = (byte)'2',

        /// <summary>
        /// 没有回报序号
        /// </summary>
        None = (byte)'3'
    };

    /// <summary>
    /// TFtdcGradeType是一个日志级别类型
    /// </summary>
    public enum EnumGradeType : byte
    {
        /// <summary>
        /// 错误
        /// </summary>
        ERROR = (byte)'1',

        /// <summary>
        /// 警告
        /// </summary>
        WARNING = (byte)'2',

        /// <summary>
        /// 正常
        /// </summary>
        NORMAL = (byte)'3'
    };

    /// <summary>
    /// TFtdcDBOperationType是一个记录操作类型类型
    /// </summary>
    public enum EnumDBOperationType : byte
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknown = (byte)'0',

        /// <summary>
        /// 插入
        /// </summary>
        Insert = (byte)'1',

        /// <summary>
        /// 更新
        /// </summary>
        Update = (byte)'2',

        /// <summary>
        /// 删除
        /// </summary>
        Delete = (byte)'3',

        /// <summary>
        /// 提交
        /// </summary>
        Commit = (byte)'4',

        /// <summary>
        /// 初始化
        /// </summary>
        Init = (byte)'5',

        /// <summary>
        /// 快照
        /// </summary>
        Snapshot = (byte)'6'
    };

    /// <summary>
    /// TFtdcOrderStatusType是一个报单状态类型
    /// </summary>
    public enum EnumOrderStatusType : byte
    {
        /// <summary>
        /// 全部成交
        /// </summary>
        AllTraded = (byte)'0',

        /// <summary>
        /// 部分成交还在队列中
        /// </summary>
        PartTradedQueueing = (byte)'1',

        /// <summary>
        /// 部分成交不在队列中
        /// </summary>
        PartTradedNotQueueing = (byte)'2',

        /// <summary>
        /// 未成交还在队列中
        /// </summary>
        NoTradeQueueing = (byte)'3',

        /// <summary>
        /// 未成交不在队列中
        /// </summary>
        NoTradeNotQueueing = (byte)'4',

        /// <summary>
        /// 撤单
        /// </summary>
        Canceled = (byte)'5',

        /// <summary>
        /// 未知
        /// </summary>
        Unknown = (byte)'a',

        /// <summary>
        /// 尚未触发
        /// </summary>
        NotTouched = (byte)'b',

        /// <summary>
        /// 已触发
        /// </summary>
        Touched = (byte)'c'
    };

    /// <summary>
    /// TFtdcOrderSubmitStatusType是一个报单提交状态类型
    /// </summary>
    public enum EnumOrderSubmitStatusType : byte
    {
        /// <summary>
        /// 已经提交
        /// </summary>
        InsertSubmitted = (byte)'0',

        /// <summary>
        /// 撤单已经提交
        /// </summary>
        CancelSubmitted = (byte)'1',

        /// <summary>
        /// 修改已经提交
        /// </summary>
        ModifySubmitted = (byte)'2',

        /// <summary>
        /// 已经接受
        /// </summary>
        Accepted = (byte)'3',

        /// <summary>
        /// 报单已经被拒绝
        /// </summary>
        InsertRejected = (byte)'4',

        /// <summary>
        /// 撤单已经被拒绝
        /// </summary>
        CancelRejected = (byte)'5',

        /// <summary>
        /// 改单已经被拒绝
        /// </summary>
        ModifyRejected = (byte)'6'
    };

    /// <summary>
    /// TFtdcOrderSourceType是一个报单来源类型
    /// </summary>
    public enum EnumOrderSourceType : byte
    {
        /// <summary>
        /// 来自参与者
        /// </summary>
        Participant = (byte)'0',

        /// <summary>
        /// 来自管理员
        /// </summary>
        Administrator = (byte)'1'
    };

    /// <summary>
    /// TFtdcOrderTypeType是一个报单类型类型
    /// </summary>
    public enum EnumOrderTypeType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 报价衍生
        /// </summary>
        DeriveFromQuote = (byte)'1',

        /// <summary>
        /// 组合衍生
        /// </summary>
        DeriveFromCombination = (byte)'2',

        /// <summary>
        /// 组合报单
        /// </summary>
        Combination = (byte)'3',

        /// <summary>
        /// 条件单
        /// </summary>
        ConditionalOrder = (byte)'4',

        /// <summary>
        /// 互换单
        /// </summary>
        Swap = (byte)'5'
    };

    /// <summary>
    /// TFtdcTradingRoleType是一个交易角色类型
    /// </summary>
    public enum EnumTradingRoleType : byte
    {
        /// <summary>
        /// 代理
        /// </summary>
        Broker = (byte)'1',

        /// <summary>
        /// 自营
        /// </summary>
        Host = (byte)'2',

        /// <summary>
        /// 做市商
        /// </summary>
        Maker = (byte)'3'
    };

    /// <summary>
    /// TFtdcOffsetFlagType是一个开平标志类型
    /// </summary>
    public enum EnumOffsetFlagType : byte
    {
        /// <summary>
        /// 开仓
        /// </summary>
        Open = (byte)'0',

        /// <summary>
        /// 平仓
        /// </summary>
        Close = (byte)'1',

        /// <summary>
        /// 强平
        /// </summary>
        ForceClose = (byte)'2',

        /// <summary>
        /// 平今
        /// </summary>
        CloseToday = (byte)'3',

        /// <summary>
        /// 平昨
        /// </summary>
        CloseYesterday = (byte)'4',

        /// <summary>
        /// 强减
        /// </summary>
        ForceOff = (byte)'5',

        /// <summary>
        /// 本地强平
        /// </summary>
        LocalForceClose = (byte)'6'
    };

    /// <summary>
    /// TFtdcHedgeFlagType是一个投机套保标志类型
    /// </summary>
    public enum EnumHedgeFlagType : byte
    {
        /// <summary>
        /// 投机
        /// </summary>
        Speculation = (byte)'1',

        /// <summary>
        /// 套利
        /// </summary>
        Arbitrage = (byte)'2',

        /// <summary>
        /// 套保
        /// </summary>
        Hedge = (byte)'3',

        /// <summary>
        /// 备兑
        /// </summary>
        Covered = (byte)'4'
    };

    /// <summary>
    /// TFtdcCoveredFlagType是一个备兑标志类型
    /// </summary>
    public enum EnumCoveredFlagType : byte
    {
        /// <summary>
        /// 不限
        /// </summary>
        UnLimit = (byte)'0',

        /// <summary>
        /// 备兑
        /// </summary>
        Covered = (byte)'1',

        /// <summary>
        /// 非备兑
        /// </summary>
        NotCovered = (byte)'2'
    };

    /// <summary>
    /// TFtdcTradeTypeType是一个成交类型类型
    /// </summary>
    public enum EnumTradeTypeType : byte
    {
        /// <summary>
        /// 普通成交
        /// </summary>
        Common = (byte)'0',

        /// <summary>
        /// 期权执行
        /// </summary>
        OptionsExecution = (byte)'1',

        /// <summary>
        /// OTC成交
        /// </summary>
        OTC = (byte)'2',

        /// <summary>
        /// 期转现衍生成交
        /// </summary>
        EFPDerived = (byte)'3',

        /// <summary>
        /// 组合衍生成交
        /// </summary>
        CombinationDerived = (byte)'4',

        /// <summary>
        /// ETF申购
        /// </summary>
        EFTPurchase = (byte)'5',

        /// <summary>
        /// ETF赎回
        /// </summary>
        EFTRedem = (byte)'6'
    };

    /// <summary>
    /// TFtdcPriceSourceType是一个成交价来源类型
    /// </summary>
    public enum EnumPriceSourceType : byte
    {
        /// <summary>
        /// 前成交价
        /// </summary>
        LastPrice = (byte)'0',

        /// <summary>
        /// 买委托价
        /// </summary>
        Buy = (byte)'1',

        /// <summary>
        /// 卖委托价
        /// </summary>
        Sell = (byte)'2'
    };

    /// <summary>
    /// TFtdcTradeSourceType是一个成交来源类型
    /// </summary>
    public enum EnumTradeSourceType : byte
    {
        /// <summary>
        /// 来自交易所普通回报
        /// </summary>
        NORMAL = (byte)'0',

        /// <summary>
        /// 来自查询
        /// </summary>
        QUERY = (byte)'1'
    };

    /// <summary>
    /// TFtdcActionFlagType是一个操作标志类型
    /// </summary>
    public enum EnumActionFlagType : byte
    {
        /// <summary>
        /// 删除
        /// </summary>
        Delete = (byte)'0',

        /// <summary>
        /// 修改
        /// </summary>
        Modify = (byte)'3'
    };

    /// <summary>
    /// TFtdcOrderActionStatusType是一个报单操作状态类型
    /// </summary>
    public enum EnumOrderActionStatusType : byte
    {
        /// <summary>
        /// 已经提交
        /// </summary>
        Submitted = (byte)'a',

        /// <summary>
        /// 已经接受
        /// </summary>
        Accepted = (byte)'b',

        /// <summary>
        /// 已经被拒绝
        /// </summary>
        Rejected = (byte)'c'
    };

    /// <summary>
    /// TFtdcExchangePropertyType是一个交易所属性类型
    /// </summary>
    public enum EnumExchangePropertyType : byte
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 根据成交生成报单
        /// </summary>
        GenOrderByTrade = (byte)'1'
    };

    /// <summary>
    /// TFtdcClientIDTypeType是一个交易编码类型类型
    /// </summary>
    public enum EnumClientIDTypeType : byte
    {
        /// <summary>
        /// 投机
        /// </summary>
        Speculation = (byte)'1',

        /// <summary>
        /// 套利
        /// </summary>
        Arbitrage = (byte)'2',

        /// <summary>
        /// 套保
        /// </summary>
        Hedge = (byte)'3',

        /// <summary>
        /// 普通
        /// </summary>
        Normal = (byte)'a',

        /// <summary>
        /// 信用
        /// </summary>
        Credit = (byte)'b',

        /// <summary>
        /// 衍生品
        /// </summary>
        Derivatives = (byte)'c'
    };

    /// <summary>
    /// TFtdcDbmtStatusType是一个Dbmt记录操作状态类型
    /// </summary>
    public enum EnumDbmtStatusType : byte
    {
        /// <summary>
        /// 初始
        /// </summary>
        Init = (byte)'0',

        /// <summary>
        /// 处理成功
        /// </summary>
        Success = (byte)'1',

        /// <summary>
        /// 处理失败
        /// </summary>
        Failed = (byte)'2'
    };

    /// <summary>
    /// TFtdcClearingStatusType是一个日结处理状态类型
    /// </summary>
    public enum EnumClearingStatusType : byte
    {
        /// <summary>
        /// 正在执行
        /// </summary>
        RUNNING = (byte)'1',

        /// <summary>
        /// 提交
        /// </summary>
        COMMITTED = (byte)'2',

        /// <summary>
        /// 回滚
        /// </summary>
        ROLLBACK = (byte)'3',

        /// <summary>
        /// 人工干预
        /// </summary>
        MANUAL = (byte)'4'
    };

    /// <summary>
    /// TFtdcBizClassType是一个业务类别类型
    /// </summary>
    public enum EnumBizClassType : byte
    {
        /// <summary>
        /// 买入
        /// </summary>
        Buy = (byte)'0',

        /// <summary>
        /// 卖出
        /// </summary>
        Sell = (byte)'1',

        /// <summary>
        /// ETF申购
        /// </summary>
        ETFPur = (byte)'2',

        /// <summary>
        /// ETF赎回
        /// </summary>
        ETFRed = (byte)'3',

        /// <summary>
        /// 正回购
        /// </summary>
        Repurchase = (byte)'5',

        /// <summary>
        /// 逆回购
        /// </summary>
        ReverseRepur = (byte)'6',

        /// <summary>
        /// 买入开仓
        /// </summary>
        BuyOpen = (byte)'A',

        /// <summary>
        /// 买入平仓
        /// </summary>
        BuyClose = (byte)'B',

        /// <summary>
        /// 卖出开仓
        /// </summary>
        SellOpen = (byte)'C',

        /// <summary>
        /// 卖出平仓
        /// </summary>
        SellClose = (byte)'D',

        /// <summary>
        /// 备兑开仓
        /// </summary>
        CoveredOpen = (byte)'E',

        /// <summary>
        /// 备兑平仓
        /// </summary>
        CoveredClose = (byte)'F',

        /// <summary>
        /// 行权
        /// </summary>
        ExecOrder = (byte)'G',

        /// <summary>
        /// 自动行权
        /// </summary>
        AutoExecOrder = (byte)'H'
    };

    /// <summary>
    /// TFtdcSecurityProductClassType是一个品种类型类型
    /// </summary>
    public enum EnumSecurityProductClassType : byte
    {
        /// <summary>
        /// 证券
        /// </summary>
        Security = (byte)'1',

        /// <summary>
        /// 个股期权
        /// </summary>
        SecurityOption = (byte)'2'
    };

    /// <summary>
    /// TFtdcMarginAdjustWayType是一个保证金调整方式类型
    /// </summary>
    public enum EnumMarginAdjustWayType : byte
    {
        /// <summary>
        /// 线性
        /// </summary>
        Linear = (byte)'1',

        /// <summary>
        /// 非线性
        /// </summary>
        NonLinear = (byte)'2'
    };

    /// <summary>
    /// TFtdcSecurityTransferStatusType是一个转移状态类型
    /// </summary>
    public enum EnumSecurityTransferStatusType : byte
    {
        /// <summary>
        /// 初始
        /// </summary>
        Initial = (byte)'1',

        /// <summary>
        /// 转移成功
        /// </summary>
        Success = (byte)'2',

        /// <summary>
        /// 转移失败
        /// </summary>
        Failed = (byte)'3',

        /// <summary>
        /// 报盘失败
        /// </summary>
        OfferFailed = (byte)'4'
    };

    /// <summary>
    /// TFtdcLockTypeType是一个锁定类型类型
    /// </summary>
    public enum EnumLockTypeType : byte
    {
        /// <summary>
        /// 锁定
        /// </summary>
        Lock = (byte)'1',

        /// <summary>
        /// 解锁
        /// </summary>
        Unlock = (byte)'2'
    };

    /// <summary>
    /// TFtdcStrikeModeType是一个执行方式类型
    /// </summary>
    public enum EnumStrikeModeType : byte
    {
        /// <summary>
        /// 欧式
        /// </summary>
        Continental = (byte)'0',

        /// <summary>
        /// 美式
        /// </summary>
        American = (byte)'1',

        /// <summary>
        /// 百慕大
        /// </summary>
        Bermuda = (byte)'2'
    };

    /// <summary>
    /// TFtdcOptionsTypeType是一个期权类型类型
    /// </summary>
    public enum EnumOptionsTypeType : byte
    {
        /// <summary>
        /// 看涨
        /// </summary>
        CallOptions = (byte)'1',

        /// <summary>
        /// 看跌
        /// </summary>
        PutOptions = (byte)'2'
    };

    /// <summary>
    /// TFtdcSystemFlagType是一个系统标识类型
    /// </summary>
    public enum EnumSystemFlagType : byte
    {
        /// <summary>
        /// 现券
        /// </summary>
        Security = (byte)'1',

        /// <summary>
        /// 个股期权
        /// </summary>
        SecurityOption = (byte)'2',

        /// <summary>
        /// 融资融券
        /// </summary>
        Credit = (byte)'3'
    };

    /// <summary>
    /// TFtdcSecurityTransferDirectionType是一个转移方向类型
    /// </summary>
    public enum EnumSecurityTransferDirectionType : byte
    {
        /// <summary>
        /// 转入现券系统
        /// </summary>
        In = (byte)'0',

        /// <summary>
        /// 转出现券系统
        /// </summary>
        Out = (byte)'1'
    };

    /// <summary>
    /// TFtdcExecOrderActionTypeType是一个行权执行类型类型
    /// </summary>
    public enum EnumExecOrderActionTypeType : byte
    {
        /// <summary>
        /// 执行
        /// </summary>
        Execute = (byte)'1',

        /// <summary>
        /// 放弃
        /// </summary>
        Drop = (byte)'2'
    };

    /// <summary>
    /// TFtdcReservePositionFlagType是一个期权行权后是否保留期货头寸的标记类型
    /// </summary>
    public enum EnumReservePositionFlagType : byte
    {
        /// <summary>
        /// 保留
        /// </summary>
        Reserved = (byte)'0',

        /// <summary>
        /// 不保留
        /// </summary>
        Unreserved = (byte)'1'
    };

    /// <summary>
    /// TFtdcCloseFlagType是一个期权行权后生成的头寸是否自动平仓类型
    /// </summary>
    public enum EnumCloseFlagType : byte
    {
        /// <summary>
        /// 自动平仓
        /// </summary>
        CloseAuto = (byte)'0',

        /// <summary>
        /// 免于自动平仓
        /// </summary>
        NotCloseAuto = (byte)'1'
    };

    /// <summary>
    /// TFtdcExecResultType是一个执行结果类型
    /// </summary>
    public enum EnumExecResultType : byte
    {
        /// <summary>
        /// 没有执行
        /// </summary>
        NotExecuted = (byte)'n',

        /// <summary>
        /// 已经取消
        /// </summary>
        Canceled = (byte)'c',

        /// <summary>
        /// 执行成功
        /// </summary>
        Success = (byte)'0',

        /// <summary>
        /// 期权持仓不够
        /// </summary>
        NotEnoughPosition = (byte)'1',

        /// <summary>
        /// 资金不够
        /// </summary>
        NotEnoughMoney = (byte)'2',

        /// <summary>
        /// 会员不存在
        /// </summary>
        ParticipantNotExisted = (byte)'3',

        /// <summary>
        /// 客户不存在
        /// </summary>
        ClientNotExisted = (byte)'4',

        /// <summary>
        /// 合约不存在
        /// </summary>
        InstrumentNotExisted = (byte)'6',

        /// <summary>
        /// 没有执行权限
        /// </summary>
        NoPrevilige = (byte)'7',

        /// <summary>
        /// 不合理的数量
        /// </summary>
        InvalidVolume = (byte)'8',

        /// <summary>
        /// 没有足够的历史成交
        /// </summary>
        NotEnoughTrade = (byte)'9',

        /// <summary>
        /// 未知
        /// </summary>
        Unknown = (byte)'a'
    };

    /// <summary>
    /// TFtdcPositionDateType是一个持仓日期类型
    /// </summary>
    public enum EnumPositionDateType : byte
    {
        /// <summary>
        /// 今日持仓
        /// </summary>
        Today = (byte)'1',

        /// <summary>
        /// 历史持仓
        /// </summary>
        History = (byte)'2'
    };

    /// <summary>
    /// TFtdcConnectSystemType是一个连接系统类型
    /// </summary>
    public enum EnumConnectSystemType : byte
    {
        /// <summary>
        /// CTP证券
        /// </summary>
        CTPSecurity = (byte)'1'
    };

    /// <summary>
    /// TFtdcCombDirectionType是一个组合指令方向类型类型
    /// </summary>
    public enum EnumCombDirectionType : byte
    {
        /// <summary>
        /// 申请组合
        /// </summary>
        Comb = (byte)'0',

        /// <summary>
        /// 申请拆分
        /// </summary>
        UnComb = (byte)'1'
    };

    /// <summary>
    /// TFtdcCombinationTypeType是一个组合类型类型
    /// </summary>
    public enum EnumCombinationTypeType : byte
    {
        /// <summary>
        /// 期货组合
        /// </summary>
        Future = (byte)'0',

        /// <summary>
        /// 垂直价差BUL
        /// </summary>
        BUL = (byte)'1',

        /// <summary>
        /// 垂直价差BER
        /// </summary>
        BER = (byte)'2',

        /// <summary>
        /// 跨式组合
        /// </summary>
        STD = (byte)'3',

        /// <summary>
        /// 宽跨式组合
        /// </summary>
        STG = (byte)'4',

        /// <summary>
        /// 备兑组合
        /// </summary>
        PRT = (byte)'5',

        /// <summary>
        /// 时间价差组合
        /// </summary>
        CLD = (byte)'6'
    };

    /// <summary>
    /// TFtdcDataCompFlagType是一个数据是否相同类型
    /// </summary>
    public enum EnumDataCompFlagType : byte
    {
        /// <summary>
        /// 不相同
        /// </summary>
        Different = (byte)'0',

        /// <summary>
        /// 相同
        /// </summary>
        Same = (byte)'1',

        /// <summary>
        /// 不限
        /// </summary>
        UnLimit = (byte)'2'
    };

    /// <summary>
    /// TFtdcCombMarginAlgoType是一个组合保证金算法类型
    /// </summary>
    public enum EnumCombMarginAlgoType : byte
    {
        /// <summary>
        /// 无
        /// </summary>
        None = (byte)'0',

        /// <summary>
        /// 行权价之差
        /// </summary>
        ExecPrice = (byte)'1',

        /// <summary>
        /// 按最高单腿保证金计算
        /// </summary>
        MaxLegMargin = (byte)'2'
    };

    /// <summary>
    /// TFtdcFundTypeType是一个基金类型类型
    /// </summary>
    public enum EnumFundTypeType : byte
    {
        /// <summary>
        /// 普通LOF
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 财务分级基金母份额
        /// </summary>
        Financial = (byte)'1',

        /// <summary>
        /// 多空分级基金母份额
        /// </summary>
        LongShort = (byte)'2'
    };

    /// <summary>
    /// TFtdcPlatformTypeType是一个平台类型类型
    /// </summary>
    public enum EnumPlatformTypeType : byte
    {
        /// <summary>
        /// 现货集中竞价交易平台
        /// </summary>
        Spot = (byte)'0',

        /// <summary>
        /// 衍生品集中竞价交易平台
        /// </summary>
        Derive = (byte)'1',

        /// <summary>
        /// 非交易处理平台
        /// </summary>
        NoTrading = (byte)'2',

        /// <summary>
        /// 综合协议交易平台
        /// </summary>
        Negotiable = (byte)'3'
    };

    /// <summary>
    /// TFtdcValidityTypeType是一个有效期类型类型
    /// </summary>
    public enum EnumValidityTypeType : byte
    {
        /// <summary>
        /// 日
        /// </summary>
        Day = (byte)'D',

        /// <summary>
        /// 月
        /// </summary>
        Month = (byte)'M'
    };

    /// <summary>
    /// TFtdcCreditPositionTypeType是一个头寸类型类型
    /// </summary>
    public enum EnumCreditPositionTypeType : byte
    {
        /// <summary>
        /// 普通
        /// </summary>
        Normal = (byte)'0',

        /// <summary>
        /// 专项
        /// </summary>
        Special = (byte)'1'
    };

    /// <summary>
    /// TFtdcCreditContractTypeType是一个信用合约类型类型
    /// </summary>
    public enum EnumCreditContractTypeType : byte
    {
        /// <summary>
        /// 融资
        /// </summary>
        MarginBuy = (byte)'0',

        /// <summary>
        /// 融券
        /// </summary>
        ShortSell = (byte)'1'
    };

    /// <summary>
    /// TFtdcCreditContractStatusType是一个信用合约状态类型
    /// </summary>
    public enum EnumCreditContractStatusType : byte
    {
        /// <summary>
        /// 未了结
        /// </summary>
        Effective = (byte)'0',

        /// <summary>
        /// 已了结
        /// </summary>
        Finished = (byte)'1'
    };

    /// <summary>
    /// TFtdcProductClassType是一个产品类型类型
    /// </summary>
    public enum EnumProductClassType : byte
    {
        /// <summary>
        /// 期货
        /// </summary>
        Futures = (byte)'1',

        /// <summary>
        /// 期货期权
        /// </summary>
        Options = (byte)'2',

        /// <summary>
        /// 组合
        /// </summary>
        Combination = (byte)'3',

        /// <summary>
        /// 即期
        /// </summary>
        Spot = (byte)'4',

        /// <summary>
        /// 期转现
        /// </summary>
        EFP = (byte)'5',

        /// <summary>
        /// 现货期权
        /// </summary>
        SpotOption = (byte)'6'
    };

    /// <summary>
    /// TFtdcInstLifePhaseType是一个合约生命周期状态类型
    /// </summary>
    public enum EnumInstLifePhaseType : byte
    {
        /// <summary>
        /// 未上市
        /// </summary>
        NotStart = (byte)'0',

        /// <summary>
        /// 上市
        /// </summary>
        Started = (byte)'1',

        /// <summary>
        /// 停牌
        /// </summary>
        Pause = (byte)'2',

        /// <summary>
        /// 到期
        /// </summary>
        Expired = (byte)'3'
    };

    /// <summary>
    /// TFtdcMaxMarginSideAlgorithmType是一个大额单边保证金算法类型
    /// </summary>
    public enum EnumMaxMarginSideAlgorithmType : byte
    {
        /// <summary>
        /// 不使用大额单边保证金算法
        /// </summary>
        NO = (byte)'0',

        /// <summary>
        /// 使用大额单边保证金算法
        /// </summary>
        YES = (byte)'1'
    };

    /// <summary>
    /// TFtdcExchangeLifePhaseType是一个交易所生命周期状态类型
    /// </summary>
    public enum EnumExchangeLifePhaseType : byte
    {
        /// <summary>
        /// 活跃
        /// </summary>
        Active = (byte)'1',

        /// <summary>
        /// 不活跃
        /// </summary>
        NonActie = (byte)'2',

        /// <summary>
        /// 注销
        /// </summary>
        Canceled = (byte)'3'
    };

    /// <summary>
    /// TFtdcInstrumentStatusType是一个合约交易状态类型
    /// </summary>
    public enum EnumInstrumentStatusType : byte
    {
        /// <summary>
        /// 开盘前
        /// </summary>
        BeforeTrading = (byte)'0',

        /// <summary>
        /// 非交易
        /// </summary>
        NoTrading = (byte)'1',

        /// <summary>
        /// 连续交易
        /// </summary>
        Continous = (byte)'2',

        /// <summary>
        /// 集合竞价报单
        /// </summary>
        AuctionOrdering = (byte)'3',

        /// <summary>
        /// 集合竞价价格平衡
        /// </summary>
        AuctionBalance = (byte)'4',

        /// <summary>
        /// 集合竞价撮合
        /// </summary>
        AuctionMatch = (byte)'5',

        /// <summary>
        /// 收盘
        /// </summary>
        Closed = (byte)'6'
    };

    /// <summary>
    /// TFtdcMarketDataDepthType是一个市场行情深度类型
    /// </summary>
    public enum EnumMarketDataDepthType : byte
    {
        /// <summary>
        /// 0档行情
        /// </summary>
        Level0 = (byte)'0',

        /// <summary>
        /// 1档行情
        /// </summary>
        Level1 = (byte)'1',

        /// <summary>
        /// 2档行情
        /// </summary>
        Level2 = (byte)'2',

        /// <summary>
        /// 3档行情
        /// </summary>
        Level3 = (byte)'3',

        /// <summary>
        /// 4档行情
        /// </summary>
        Level4 = (byte)'4',

        /// <summary>
        /// 5档行情
        /// </summary>
        Level5 = (byte)'5'
    };

    /// <summary>
    /// TFtdcMarketDataModeType是一个行情模式类型
    /// </summary>
    public enum EnumMarketDataModeType : byte
    {
        /// <summary>
        /// 双边行情
        /// </summary>
        Double = (byte)'0',

        /// <summary>
        /// 单边行情
        /// </summary>
        Single = (byte)'1'
    };

    /// <summary>
    /// TFtdcMarketDataPubStatusType是一个行情发布状态类型
    /// </summary>
    public enum EnumMarketDataPubStatusType : byte
    {
        /// <summary>
        /// 不发送行情
        /// </summary>
        NotPublish = (byte)'0',

        /// <summary>
        /// 发送行情
        /// </summary>
        Publish = (byte)'1'
    };

    /// <summary>
    /// TFtdcAuditResultType是一个复核结果类型
    /// </summary>
    public enum EnumAuditResultType : byte
    {
        /// <summary>
        /// 未复核
        /// </summary>
        NotAudit = (byte)'0',

        /// <summary>
        /// 已复核
        /// </summary>
        Audited = (byte)'1',

        /// <summary>
        /// 忽略
        /// </summary>
        Ignore = (byte)'2'
    };

    /// <summary>
    /// TFtdcCommandStatusType是一个TBCommand命令状态类型
    /// </summary>
    public enum EnumCommandStatusType : byte
    {
        /// <summary>
        /// 新指令
        /// </summary>
        New = (byte)'0',

        /// <summary>
        /// 已提交
        /// </summary>
        Submitted = (byte)'1',

        /// <summary>
        /// 忽略
        /// </summary>
        Ignored = (byte)'2'
    };

    /// <summary>
    /// TFtdcFundDirectionType是一个出入金方向类型
    /// </summary>
    public enum EnumFundDirectionType : byte
    {
        /// <summary>
        /// 入金
        /// </summary>
        Deposit = (byte)'0',

        /// <summary>
        /// 出金
        /// </summary>
        Withdraw = (byte)'1'
    };

    /// <summary>
    /// TFtdcIsActiveType是一个是否活跃类型
    /// </summary>
    public enum EnumIsActiveType : byte
    {
        /// <summary>
        /// 活跃
        /// </summary>
        Active = (byte)'1',

        /// <summary>
        /// 不活跃
        /// </summary>
        NonActie = (byte)'0'
    };

    /// <summary>
    /// TFtdcNLogLevelType是一个日志级别类型
    /// </summary>
    public enum EnumNLogLevelType : byte
    {
        /// <summary>
        /// 调试信息
        /// </summary>
        Debug = (byte)'1',

        /// <summary>
        /// 提示信息
        /// </summary>
        Info = (byte)'2',

        /// <summary>
        /// 警告信息
        /// </summary>
        Warn = (byte)'3',

        /// <summary>
        /// 错误信息
        /// </summary>
        Error = (byte)'4'
    };

    /// <summary>
    /// TFtdcPosiDirectionType是一个持仓多空方向类型
    /// </summary>
    public enum EnumPosiDirectionType : byte
    {
        /// <summary>
        /// 净
        /// </summary>
        Net = (byte)'1',

        /// <summary>
        /// 多头
        /// </summary>
        Long = (byte)'2',

        /// <summary>
        /// 空头
        /// </summary>
        Short = (byte)'3'
    };

    /// <summary>
    /// TFtdcLoginTypeType是一个登录类型类型
    /// </summary>
    public enum EnumLoginTypeType : byte
    {
        /// <summary>
        /// 登入
        /// </summary>
        Login = (byte)'I',

        /// <summary>
        /// 登出
        /// </summary>
        Logout = (byte)'O'
    };

    /// <summary>
    /// TFtdcSessionTypeType是一个会话类型类型
    /// </summary>
    public enum EnumSessionTypeType : byte
    {
        /// <summary>
        /// 交易
        /// </summary>
        Trade = (byte)'T',

        /// <summary>
        /// 行情
        /// </summary>
        Md = (byte)'M'
    };

    /// <summary>
    /// TFtdcPositionTypeType是一个持仓类型类型
    /// </summary>
    public enum EnumPositionTypeType : byte
    {
        /// <summary>
        /// 净持仓
        /// </summary>
        Net = (byte)'1',

        /// <summary>
        /// 综合持仓
        /// </summary>
        Gross = (byte)'2'
    };

    /// <summary>
    /// TFtdcOperateTypeType是一个业务操作类型类型
    /// </summary>
    public enum EnumOperateTypeType : byte
    {
        /// <summary>
        /// 空操作
        /// </summary>
        None = (byte)'0',

        /// <summary>
        /// 新增
        /// </summary>
        Add = (byte)'1',

        /// <summary>
        /// 修改
        /// </summary>
        Update = (byte)'2',

        /// <summary>
        /// 删除
        /// </summary>
        Delete = (byte)'3'
    };

}; // end of namespace
