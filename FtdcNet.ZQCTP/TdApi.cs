/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2016/8/26 21:37:00
/////////////////////////////////////////////////////////////////////////



using System;
using System.Runtime.InteropServices;


namespace ZQCTP
{
    /// <summary>
    /// 交易接口
    /// </summary>
    public class FtdcTdAdapter : IDisposable
    {
        /// <summary>
        /// Native Object Pointer
        /// </summary>
        public IntPtr Handle { get; private set; }

        /// <summary>
        /// 处理所有的OnErrRtn****回调事件
        /// </summary>
        public event OnErrRtnEventHandler OnErrRtnEvent;

        /// <summary>
        /// 处理所有的OnFront****回调事件
        /// </summary>
        public event OnFrontEventHandler OnFrontEvent;

        /// <summary>
        /// 处理所有的OnRsp****回调事件
        /// </summary>
        public event OnRspEventHandler OnRspEvent;

        /// <summary>
        /// 处理所有的OnRtn****回调事件
        /// </summary>
        public event OnRtnEventHandler OnRtnEvent;

        /// <summary>
        ///创建TraderApi
        ///@param pszFlowPath 存贮订阅信息文件的目录，默认为当前目录
        ///@return 创建出的UserApi
        /// </summary>
        public FtdcTdAdapter(string pszFlowPath, bool bIsUsingUdp)
        {
            Handle = Interop.TdCreateApi(pszFlowPath, bIsUsingUdp);
            if (Handle == IntPtr.Zero)
                throw new Exception("TdCreateApi Failed!");
            this.CbOnErrRtnDelegate = this.CbOnErrRtnFunc;
            this.CbOnFrontDelegate = this.CbOnFrontFunc;
            this.CbOnRspDelegate = this.CbOnRspFunc;
            this.CbOnRtnDelegate = this.CbOnRtnFunc;
            Interop.TdRegisterCallback(Handle, this.CbOnErrRtnDelegate, this.CbOnFrontDelegate, this.CbOnRspDelegate, this.CbOnRtnDelegate, IntPtr.Zero);
        }


        /// <summary>
        ///获取API版本号
        ///@return 版本号
        /// </summary>
        public static string GetApiVersion()
        {
            return Marshal.PtrToStringAnsi(Interop.TdGetApiVersion());
        }

        /// <summary>
        ///删除接口对象本身
        ///@remark 不再使用本接口对象时,调用该函数删除接口对象
        /// </summary>
        public void Release()
        {
            if (Handle != IntPtr.Zero)
            {
                Interop.TdDestroyApi(Handle);
                Handle = IntPtr.Zero;
            }
        }

        /// <summary>
        ///初始化
        ///@remark 初始化运行环境,只有调用后,接口才开始工作
        /// </summary>
        public void Init()
        {
            Interop.TdInit(Handle);
        }

        /// <summary>
        ///注册前置机网络地址
        ///@param pszFrontAddress：前置机网络地址。
        ///@remark 网络地址的格式为：“protocol://ipaddress:port”，如：”tcp://127.0.0.1:17001”。
        ///@remark “tcp”代表传输协议，“127.0.0.1”代表服务器地址。”17001”代表服务器端口号。
        /// </summary>
        public void RegisterFront(string pszFrontAddress)
        {
            Interop.TdRegisterFront(Handle, pszFrontAddress);
        }

        /// <summary>
        ///订阅私有流。
        ///@param nResumeType 私有流重传方式
        ///        THOST_TERT_RESTART:从本交易日开始重传
        ///        THOST_TERT_RESUME:从上次收到的续传
        ///        THOST_TERT_QUICK:只传送登录后私有流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到私有流的数据。
        /// </summary>
        public void SubscribePrivateTopic(EnumTeResumeType nResumeType)
        {
            Interop.TdSubscribePrivateTopic(Handle, (int)nResumeType);
        }

        /// <summary>
        ///订阅公共流。
        ///@param nResumeType 公共流重传方式
        ///        THOST_TERT_RESTART:从本交易日开始重传
        ///        THOST_TERT_RESUME:从上次收到的续传
        ///        THOST_TERT_QUICK:只传送登录后公共流的内容
        ///@remark 该方法要在Init方法前调用。若不调用则不会收到公共流的数据。
        /// </summary>
        public void SubscribePublicTopic(EnumTeResumeType nResumeType)
        {
            Interop.TdSubscribePublicTopic(Handle, (int)nResumeType);
        }

        /// <summary>
        ///客户端认证请求
        /// </summary>
        public int ReqAuthenticate(ThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID)
        {
            return Interop.TdReqAuthenticate(Handle, pReqAuthenticateField, nRequestID);
        }

        /// <summary>
        ///用户登录请求
        /// </summary>
        public int ReqUserLogin(ThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
            return Interop.TdReqUserLogin(Handle, pReqUserLoginField, nRequestID);
        }

        /// <summary>
        ///登出请求
        /// </summary>
        public int ReqUserLogout(ThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
            return Interop.TdReqUserLogout(Handle, pUserLogout, nRequestID);
        }

        /// <summary>
        ///用户口令更新请求
        /// </summary>
        public int ReqUserPasswordUpdate(ThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID)
        {
            return Interop.TdReqUserPasswordUpdate(Handle, pUserPasswordUpdate, nRequestID);
        }

        /// <summary>
        ///报单录入请求
        /// </summary>
        public int ReqOrderInsert(ThostFtdcInputOrderField pInputOrder, int nRequestID)
        {
            return Interop.TdReqOrderInsert(Handle, pInputOrder, nRequestID);
        }

        /// <summary>
        ///报单操作录入请求
        /// </summary>
        public int ReqOrderAction(ThostFtdcInputOrderActionField pInputOrderAction, int nRequestID)
        {
            return Interop.TdReqOrderAction(Handle, pInputOrderAction, nRequestID);
        }

        /// <summary>
        ///请求查询交易所
        /// </summary>
        public int ReqQryExchange(ThostFtdcQryExchangeField pQryExchange, int nRequestID)
        {
            return Interop.TdReqQryExchange(Handle, pQryExchange, nRequestID);
        }

        /// <summary>
        ///请求查询行情
        /// </summary>
        public int ReqQryDepthMarketData(ThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID)
        {
            return Interop.TdReqQryDepthMarketData(Handle, pQryDepthMarketData, nRequestID);
        }

        /// <summary>
        ///请求查询证券
        /// </summary>
        public int ReqQrySecurity(ThostFtdcQrySecurityField pQrySecurity, int nRequestID)
        {
            return Interop.TdReqQrySecurity(Handle, pQrySecurity, nRequestID);
        }

        /// <summary>
        ///请求查询ETF清单
        /// </summary>
        public int ReqQryETFFile(ThostFtdcQryETFFileField pQryETFFile, int nRequestID)
        {
            return Interop.TdReqQryETFFile(Handle, pQryETFFile, nRequestID);
        }

        /// <summary>
        ///请求查询ETF成分证券
        /// </summary>
        public int ReqQryETFBasket(ThostFtdcQryETFBasketField pQryETFBasket, int nRequestID)
        {
            return Interop.TdReqQryETFBasket(Handle, pQryETFBasket, nRequestID);
        }

        /// <summary>
        ///请求查询新股信息
        /// </summary>
        public int ReqQrySubscribingShares(ThostFtdcQrySubscribingSharesField pQrySubscribingShares, int nRequestID)
        {
            return Interop.TdReqQrySubscribingShares(Handle, pQrySubscribingShares, nRequestID);
        }

        /// <summary>
        ///请求查询质押申报代码
        /// </summary>
        public int ReqQryPledgeOrderInfo(ThostFtdcQryPledgeOrderInfoField pQryPledgeOrderInfo, int nRequestID)
        {
            return Interop.TdReqQryPledgeOrderInfo(Handle, pQryPledgeOrderInfo, nRequestID);
        }

        /// <summary>
        ///请求市场
        /// </summary>
        public int ReqQryMarket(ThostFtdcQryMarketField pQryMarket, int nRequestID)
        {
            return Interop.TdReqQryMarket(Handle, pQryMarket, nRequestID);
        }

        /// <summary>
        ///请求查询证券品种
        /// </summary>
        public int ReqQrySecurityProduct(ThostFtdcQrySecurityProductField pQrySecurityProduct, int nRequestID)
        {
            return Interop.TdReqQrySecurityProduct(Handle, pQrySecurityProduct, nRequestID);
        }

        /// <summary>
        ///请求查询证券类别
        /// </summary>
        public int ReqQrySecurityClass(ThostFtdcQrySecurityClassField pQrySecurityClass, int nRequestID)
        {
            return Interop.TdReqQrySecurityClass(Handle, pQrySecurityClass, nRequestID);
        }

        /// <summary>
        ///请求查询报单
        /// </summary>
        public int ReqQryOrder(ThostFtdcQryOrderField pQryOrder, int nRequestID)
        {
            return Interop.TdReqQryOrder(Handle, pQryOrder, nRequestID);
        }

        /// <summary>
        ///请求查询成交
        /// </summary>
        public int ReqQryTrade(ThostFtdcQryTradeField pQryTrade, int nRequestID)
        {
            return Interop.TdReqQryTrade(Handle, pQryTrade, nRequestID);
        }

        /// <summary>
        ///请求查询资金账户
        /// </summary>
        public int ReqQryTradingAccount(ThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID)
        {
            return Interop.TdReqQryTradingAccount(Handle, pQryTradingAccount, nRequestID);
        }

        /// <summary>
        ///请求查询投资者证券持仓
        /// </summary>
        public int ReqQryInvestorSecurityPosition(ThostFtdcQryInvestorSecurityPositionField pQryInvestorSecurityPosition, int nRequestID)
        {
            return Interop.TdReqQryInvestorSecurityPosition(Handle, pQryInvestorSecurityPosition, nRequestID);
        }

        /// <summary>
        ///请求查询投资者质押持仓
        /// </summary>
        public int ReqQryInvestorPledgePosition(ThostFtdcQryInvestorPledgePositionField pQryInvestorPledgePosition, int nRequestID)
        {
            return Interop.TdReqQryInvestorPledgePosition(Handle, pQryInvestorPledgePosition, nRequestID);
        }

        /// <summary>
        ///请求查询投资者质押回购
        /// </summary>
        public int ReqQryInvestorPledgeInfo(ThostFtdcQryInvestorPledgeInfoField pQryInvestorPledgeInfo, int nRequestID)
        {
            return Interop.TdReqQryInvestorPledgeInfo(Handle, pQryInvestorPledgeInfo, nRequestID);
        }

        /// <summary>
        ///请求查询报单资金明细
        /// </summary>
        public int ReqQryOrderFundDetail(ThostFtdcQryOrderFundDetailField pQryOrderFundDetail, int nRequestID)
        {
            return Interop.TdReqQryOrderFundDetail(Handle, pQryOrderFundDetail, nRequestID);
        }

        /// <summary>
        ///请求查询投资者
        /// </summary>
        public int ReqQryInvestor(ThostFtdcQryInvestorField pQryInvestor, int nRequestID)
        {
            return Interop.TdReqQryInvestor(Handle, pQryInvestor, nRequestID);
        }

        /// <summary>
        ///请求查询交易账户
        /// </summary>
        public int ReqQryTradingCode(ThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID)
        {
            return Interop.TdReqQryTradingCode(Handle, pQryTradingCode, nRequestID);
        }

        /// <summary>
        ///请求查询投资单元
        /// </summary>
        public int ReqQryInvestUnit(ThostFtdcQryInvestUnitField pQryInvestUnit, int nRequestID)
        {
            return Interop.TdReqQryInvestUnit(Handle, pQryInvestUnit, nRequestID);
        }

        /// <summary>
        ///请求查询投资单元与交易资金账户关系
        /// </summary>
        public int ReqQryInvestUnitAndTradingAcct(ThostFtdcQryInvestUnitAndTradingAcctField pQryInvestUnitAndTradingAcct, int nRequestID)
        {
            return Interop.TdReqQryInvestUnitAndTradingAcct(Handle, pQryInvestUnitAndTradingAcct, nRequestID);
        }

        /// <summary>
        ///请求查询投资单元与交易用户关系
        /// </summary>
        public int ReqQryInvestUnitAndUser(ThostFtdcQryInvestUnitAndUserField pQryInvestUnitAndUser, int nRequestID)
        {
            return Interop.TdReqQryInvestUnitAndUser(Handle, pQryInvestUnitAndUser, nRequestID);
        }

        /// <summary>
        ///请求查询投资者佣金
        /// </summary>
        public int ReqQryBrokerage(ThostFtdcQryBrokerageField pQryBrokerage, int nRequestID)
        {
            return Interop.TdReqQryBrokerage(Handle, pQryBrokerage, nRequestID);
        }

        /// <summary>
        ///请求查询新股申购额度
        /// </summary>
        public int ReqQrySubscribingSharesQuota(ThostFtdcQrySubscribingSharesQuotaField pQrySubscribingSharesQuota, int nRequestID)
        {
            return Interop.TdReqQrySubscribingSharesQuota(Handle, pQrySubscribingSharesQuota, nRequestID);
        }

        /// <summary>
        ///请求查询标准券使用率
        /// </summary>
        public int ReqQryRepoRatio(ThostFtdcQryRepoRatioField pQryRepoRatio, int nRequestID)
        {
            return Interop.TdReqQryRepoRatio(Handle, pQryRepoRatio, nRequestID);
        }

        /// <summary>
        ///请求查询回购放大倍数
        /// </summary>
        public int ReqQryRepurchaseMaxTimes(ThostFtdcQryRepurchaseMaxTimesField pQryRepurchaseMaxTimes, int nRequestID)
        {
            return Interop.TdReqQryRepurchaseMaxTimes(Handle, pQryRepurchaseMaxTimes, nRequestID);
        }

        /// <summary>
        ///请求查询资金转移
        /// </summary>
        public int ReqQryTransferFund(ThostFtdcQryTransferFundField pQryTransferFund, int nRequestID)
        {
            return Interop.TdReqQryTransferFund(Handle, pQryTransferFund, nRequestID);
        }

        /// <summary>
        ///请求查询仓位转移
        /// </summary>
        public int ReqQryTransferPosition(ThostFtdcQryTransferPositionField pQryTransferPosition, int nRequestID)
        {
            return Interop.TdReqQryTransferPosition(Handle, pQryTransferPosition, nRequestID);
        }

        /// <summary>
        ///请求行权录入
        /// </summary>
        public int ReqExecOrderInsert(ThostFtdcInputExecOrderField pInputExecOrder, int nRequestID)
        {
            return Interop.TdReqExecOrderInsert(Handle, pInputExecOrder, nRequestID);
        }

        /// <summary>
        ///请求行权操作录入
        /// </summary>
        public int ReqExecOrderAction(ThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID)
        {
            return Interop.TdReqExecOrderAction(Handle, pInputExecOrderAction, nRequestID);
        }

        /// <summary>
        ///请求锁定录入
        /// </summary>
        public int ReqLockInsert(ThostFtdcInputLockField pInputLock, int nRequestID)
        {
            return Interop.TdReqLockInsert(Handle, pInputLock, nRequestID);
        }

        /// <summary>
        ///请求现券转移录入
        /// </summary>
        public int ReqSecurityTransfer(ThostFtdcInputSecurityTransferField pInputSecurityTransfer, int nRequestID)
        {
            return Interop.TdReqSecurityTransfer(Handle, pInputSecurityTransfer, nRequestID);
        }

        /// <summary>
        ///个股期权合约查询
        /// </summary>
        public int ReqQryInstrument(ThostFtdcQryInstrumentField pQryInstrument, int nRequestID)
        {
            return Interop.TdReqQryInstrument(Handle, pQryInstrument, nRequestID);
        }

        /// <summary>
        ///锁定查询
        /// </summary>
        public int ReqQryLock(ThostFtdcQryLockField pQryLock, int nRequestID)
        {
            return Interop.TdReqQryLock(Handle, pQryLock, nRequestID);
        }

        /// <summary>
        ///执行宣告查询
        /// </summary>
        public int ReqQryExecOrder(ThostFtdcQryExecOrderField pQryExecOrder, int nRequestID)
        {
            return Interop.TdReqQryExecOrder(Handle, pQryExecOrder, nRequestID);
        }

        /// <summary>
        ///锁定持仓查询
        /// </summary>
        public int ReqQryLockPosition(ThostFtdcQryLockPositionField pQryLockPosition, int nRequestID)
        {
            return Interop.TdReqQryLockPosition(Handle, pQryLockPosition, nRequestID);
        }

        /// <summary>
        ///投资者保证金率查询
        /// </summary>
        public int ReqQryMarginRate(ThostFtdcQryMarginRateField pQryMarginRate, int nRequestID)
        {
            return Interop.TdReqQryMarginRate(Handle, pQryMarginRate, nRequestID);
        }

        /// <summary>
        ///投资者买入额度查询
        /// </summary>
        public int ReqQryLimitAmount(ThostFtdcQryLimitAmountField pQryLimitAmount, int nRequestID)
        {
            return Interop.TdReqQryLimitAmount(Handle, pQryLimitAmount, nRequestID);
        }

        /// <summary>
        ///投资者持仓限制查询
        /// </summary>
        public int ReqQryLimitPosition(ThostFtdcQryLimitPositionField pQryLimitPosition, int nRequestID)
        {
            return Interop.TdReqQryLimitPosition(Handle, pQryLimitPosition, nRequestID);
        }

        /// <summary>
        ///行权指派查询
        /// </summary>
        public int ReqQryExerciseAssignment(ThostFtdcQryExerciseAssignmentField pQryExerciseAssignment, int nRequestID)
        {
            return Interop.TdReqQryExerciseAssignment(Handle, pQryExerciseAssignment, nRequestID);
        }

        /// <summary>
        ///投资者合约持仓查询
        /// </summary>
        public int ReqQryInvestorPosition(ThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID)
        {
            return Interop.TdReqQryInvestorPosition(Handle, pQryInvestorPosition, nRequestID);
        }

        /// <summary>
        ///现券转移查询
        /// </summary>
        public int ReqQrySecurityTransfer(ThostFtdcQrySecurityTransferField pQrySecurityTransfer, int nRequestID)
        {
            return Interop.TdReqQrySecurityTransfer(Handle, pQrySecurityTransfer, nRequestID);
        }

        /// <summary>
        ///上市开放式基金信息查询
        /// </summary>
        public int ReqQryLOFInfo(ThostFtdcQryLOFInfoField pQryLOFInfo, int nRequestID)
        {
            return Interop.TdReqQryLOFInfo(Handle, pQryLOFInfo, nRequestID);
        }

        /// <summary>
        ///上市开放式基金子基金信息查询
        /// </summary>
        public int ReqQryLOFSubInfo(ThostFtdcQryLOFSubInfoField pQryLOFSubInfo, int nRequestID)
        {
            return Interop.TdReqQryLOFSubInfo(Handle, pQryLOFSubInfo, nRequestID);
        }

        /// <summary>
        ///请求直接还款录入
        /// </summary>
        public int ReqCashRepayInsert(ThostFtdcInputCashRepayField pInputCashRepay, int nRequestID)
        {
            return Interop.TdReqCashRepayInsert(Handle, pInputCashRepay, nRequestID);
        }

        /// <summary>
        ///查询融资融券直接还款信息
        /// </summary>
        public int ReqQryCashRepay(ThostFtdcQryCashRepayField pQryCashRepay, int nRequestID)
        {
            return Interop.TdReqQryCashRepay(Handle, pQryCashRepay, nRequestID);
        }

        /// <summary>
        ///查询投资者融资融券信息
        /// </summary>
        public int ReqQryCreditInfo(ThostFtdcQryCreditInfoField pQryCreditInfo, int nRequestID)
        {
            return Interop.TdReqQryCreditInfo(Handle, pQryCreditInfo, nRequestID);
        }

        /// <summary>
        ///查询投资者融资融券可用证券头寸
        /// </summary>
        public int ReqQryCreditSecurityPosition(ThostFtdcQryCreditSecurityPositionField pQryCreditSecurityPosition, int nRequestID)
        {
            return Interop.TdReqQryCreditSecurityPosition(Handle, pQryCreditSecurityPosition, nRequestID);
        }

        /// <summary>
        ///请求查询投资者信用合约
        /// </summary>
        public int ReqQryCreditContract(ThostFtdcQryCreditContractField pQryCreditContract, int nRequestID)
        {
            return Interop.TdReqQryCreditContract(Handle, pQryCreditContract, nRequestID);
        }

        /// <summary>
        ///请求查询投资者融资融券偿还明细
        /// </summary>
        public int ReqQryCreditRepayment(ThostFtdcQryCreditRepaymentField pQryCreditRepayment, int nRequestID)
        {
            return Interop.TdReqQryCreditRepayment(Handle, pQryCreditRepayment, nRequestID);
        }

        /// <summary>
        ///请求查询投资者融资融券标的证券信息
        /// </summary>
        public int ReqQryCreditUnderlying(ThostFtdcQryCreditUnderlyingField pQryCreditUnderlying, int nRequestID)
        {
            return Interop.TdReqQryCreditUnderlying(Handle, pQryCreditUnderlying, nRequestID);
        }

        /// <summary>
        ///请求查询投资者融资融券担保证券信息
        /// </summary>
        public int ReqQryCreditCollateral(ThostFtdcQryCreditCollateralField pQryCreditCollateral, int nRequestID)
        {
            return Interop.TdReqQryCreditCollateral(Handle, pQryCreditCollateral, nRequestID);
        }

        /// <summary>
        ///请求查询投资者融资融券可用资金头寸
        /// </summary>
        public int ReqQryCreditFundPosition(ThostFtdcQryCreditFundPositionField pQryCreditFundPosition, int nRequestID)
        {
            return Interop.TdReqQryCreditFundPosition(Handle, pQryCreditFundPosition, nRequestID);
        }

        /// <summary>
        /// 处理所有的OnErrRtn****回调事件
        /// </summary>
        protected void CbOnErrRtnFunc(IntPtr pObject, EnumOnErrRtnType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo)
        {
            if (OnErrRtnEvent != null)
                OnErrRtnEvent(this, new OnErrRtnEventArgs(type, pParam, pRspInfo));
        }
        private Interop.CbOnErrRtnEvent CbOnErrRtnDelegate;


        /// <summary>
        /// 处理所有的OnFront****回调事件
        /// </summary>
        protected void CbOnFrontFunc(IntPtr pObject, EnumOnFrontType type, int nReason)
        {
            if (OnFrontEvent != null)
                OnFrontEvent(this, new OnFrontEventArgs(type, nReason));
        }
        private Interop.CbOnFrontEvent CbOnFrontDelegate;


        /// <summary>
        /// 处理所有的OnRsp****回调事件
        /// </summary>
        protected void CbOnRspFunc(IntPtr pObject, EnumOnRspType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.I1)] bool bIsLast)
        {
            if (OnRspEvent != null)
                OnRspEvent(this, new OnRspEventArgs(type, pParam, pRspInfo, nRequestID, bIsLast));
        }
        private Interop.CbOnRspEvent CbOnRspDelegate;


        /// <summary>
        /// 处理所有的OnRtn****回调事件
        /// </summary>
        protected void CbOnRtnFunc(IntPtr pObject, EnumOnRtnType type, IntPtr pParam)
        {
            if (OnRtnEvent != null)
                OnRtnEvent(this, new OnRtnEventArgs(type, pParam));
        }
        private Interop.CbOnRtnEvent CbOnRtnDelegate;



        public void Dispose()
        {
            this.Release();
        }

    }; // end of class

}; // end of namespace

