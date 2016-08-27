/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2016/8/26 21:37:00
/////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ZQCTP
{
    [System.Security.SuppressUnmanagedCodeSecurity]
    static unsafe class Interop
    {
        static Interop()
        {
            string assemblyDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dir = Path.Combine(assemblyDirectory, Environment.Is64BitProcess ? "x64" : "x86");
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                // Can't work, since LD_LIBRARY_PATH will not reload 
                Environment.SetEnvironmentVariable("LD_LIBRARY_PATH", dir + ":" + Environment.GetEnvironmentVariable("LD_LIBRARY_PATH"));
            else
                Environment.SetEnvironmentVariable("PATH", dir + ";" + Environment.GetEnvironmentVariable("PATH"));
        }

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnErrRtnEvent(IntPtr pObject, EnumOnErrRtnType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnFrontEvent(IntPtr pObject, EnumOnFrontType type, int nReason);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnRspEvent(IntPtr pObject, EnumOnRspType type, IntPtr pParam, ThostFtdcRspInfoField pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.I1)] bool bIsLast);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void CbOnRtnEvent(IntPtr pObject, EnumOnRtnType type, IntPtr pParam);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterCallback(IntPtr pApi, CbOnFrontEvent c1, CbOnRspEvent c2, CbOnRtnEvent c3, IntPtr pObject);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterCallback(IntPtr pApi, CbOnErrRtnEvent c1, CbOnFrontEvent c2, CbOnRspEvent c3, CbOnRtnEvent c4, IntPtr pObject);


        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MdCreateApi(string pszFlowPath, bool bIsUsingUdp);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr MdGetApiVersion();

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdDestroyApi(IntPtr pApi);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdInit(IntPtr pApi);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void MdRegisterFront(IntPtr pApi, string pszFrontAddress);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdSubscribeMarketData(IntPtr pApi, string[] ppInstrumentID, int nCount, string pExchageID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdUnSubscribeMarketData(IntPtr pApi, string[] ppInstrumentID, int nCount, string pExchageID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqUserLogin(IntPtr pApi, ThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int MdReqUserLogout(IntPtr pApi, ThostFtdcUserLogoutField pUserLogout, int nRequestID);



        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TdCreateApi(string pszFlowPath, bool bIsUsingUdp);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TdGetApiVersion();

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdDestroyApi(IntPtr pApi);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdInit(IntPtr pApi);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdRegisterFront(IntPtr pApi, string pszFrontAddress);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSubscribePrivateTopic(IntPtr pApi, int nResumeType);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void TdSubscribePublicTopic(IntPtr pApi, int nResumeType);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqAuthenticate(IntPtr pApi, ThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLogin(IntPtr pApi, ThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserLogout(IntPtr pApi, ThostFtdcUserLogoutField pUserLogout, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqUserPasswordUpdate(IntPtr pApi, ThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqOrderInsert(IntPtr pApi, ThostFtdcInputOrderField pInputOrder, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqOrderAction(IntPtr pApi, ThostFtdcInputOrderActionField pInputOrderAction, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExchange(IntPtr pApi, ThostFtdcQryExchangeField pQryExchange, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryDepthMarketData(IntPtr pApi, ThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySecurity(IntPtr pApi, ThostFtdcQrySecurityField pQrySecurity, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryETFFile(IntPtr pApi, ThostFtdcQryETFFileField pQryETFFile, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryETFBasket(IntPtr pApi, ThostFtdcQryETFBasketField pQryETFBasket, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySubscribingShares(IntPtr pApi, ThostFtdcQrySubscribingSharesField pQrySubscribingShares, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryPledgeOrderInfo(IntPtr pApi, ThostFtdcQryPledgeOrderInfoField pQryPledgeOrderInfo, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryMarket(IntPtr pApi, ThostFtdcQryMarketField pQryMarket, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySecurityProduct(IntPtr pApi, ThostFtdcQrySecurityProductField pQrySecurityProduct, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySecurityClass(IntPtr pApi, ThostFtdcQrySecurityClassField pQrySecurityClass, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryOrder(IntPtr pApi, ThostFtdcQryOrderField pQryOrder, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTrade(IntPtr pApi, ThostFtdcQryTradeField pQryTrade, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTradingAccount(IntPtr pApi, ThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorSecurityPosition(IntPtr pApi, ThostFtdcQryInvestorSecurityPositionField pQryInvestorSecurityPosition, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorPledgePosition(IntPtr pApi, ThostFtdcQryInvestorPledgePositionField pQryInvestorPledgePosition, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorPledgeInfo(IntPtr pApi, ThostFtdcQryInvestorPledgeInfoField pQryInvestorPledgeInfo, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryOrderFundDetail(IntPtr pApi, ThostFtdcQryOrderFundDetailField pQryOrderFundDetail, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestor(IntPtr pApi, ThostFtdcQryInvestorField pQryInvestor, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTradingCode(IntPtr pApi, ThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestUnit(IntPtr pApi, ThostFtdcQryInvestUnitField pQryInvestUnit, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestUnitAndTradingAcct(IntPtr pApi, ThostFtdcQryInvestUnitAndTradingAcctField pQryInvestUnitAndTradingAcct, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestUnitAndUser(IntPtr pApi, ThostFtdcQryInvestUnitAndUserField pQryInvestUnitAndUser, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryBrokerage(IntPtr pApi, ThostFtdcQryBrokerageField pQryBrokerage, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySubscribingSharesQuota(IntPtr pApi, ThostFtdcQrySubscribingSharesQuotaField pQrySubscribingSharesQuota, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryRepoRatio(IntPtr pApi, ThostFtdcQryRepoRatioField pQryRepoRatio, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryRepurchaseMaxTimes(IntPtr pApi, ThostFtdcQryRepurchaseMaxTimesField pQryRepurchaseMaxTimes, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTransferFund(IntPtr pApi, ThostFtdcQryTransferFundField pQryTransferFund, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryTransferPosition(IntPtr pApi, ThostFtdcQryTransferPositionField pQryTransferPosition, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqExecOrderInsert(IntPtr pApi, ThostFtdcInputExecOrderField pInputExecOrder, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqExecOrderAction(IntPtr pApi, ThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqLockInsert(IntPtr pApi, ThostFtdcInputLockField pInputLock, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqSecurityTransfer(IntPtr pApi, ThostFtdcInputSecurityTransferField pInputSecurityTransfer, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInstrument(IntPtr pApi, ThostFtdcQryInstrumentField pQryInstrument, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryLock(IntPtr pApi, ThostFtdcQryLockField pQryLock, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExecOrder(IntPtr pApi, ThostFtdcQryExecOrderField pQryExecOrder, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryLockPosition(IntPtr pApi, ThostFtdcQryLockPositionField pQryLockPosition, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryMarginRate(IntPtr pApi, ThostFtdcQryMarginRateField pQryMarginRate, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryLimitAmount(IntPtr pApi, ThostFtdcQryLimitAmountField pQryLimitAmount, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryLimitPosition(IntPtr pApi, ThostFtdcQryLimitPositionField pQryLimitPosition, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryExerciseAssignment(IntPtr pApi, ThostFtdcQryExerciseAssignmentField pQryExerciseAssignment, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryInvestorPosition(IntPtr pApi, ThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQrySecurityTransfer(IntPtr pApi, ThostFtdcQrySecurityTransferField pQrySecurityTransfer, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryLOFInfo(IntPtr pApi, ThostFtdcQryLOFInfoField pQryLOFInfo, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryLOFSubInfo(IntPtr pApi, ThostFtdcQryLOFSubInfoField pQryLOFSubInfo, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqCashRepayInsert(IntPtr pApi, ThostFtdcInputCashRepayField pInputCashRepay, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCashRepay(IntPtr pApi, ThostFtdcQryCashRepayField pQryCashRepay, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCreditInfo(IntPtr pApi, ThostFtdcQryCreditInfoField pQryCreditInfo, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCreditSecurityPosition(IntPtr pApi, ThostFtdcQryCreditSecurityPositionField pQryCreditSecurityPosition, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCreditContract(IntPtr pApi, ThostFtdcQryCreditContractField pQryCreditContract, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCreditRepayment(IntPtr pApi, ThostFtdcQryCreditRepaymentField pQryCreditRepayment, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCreditUnderlying(IntPtr pApi, ThostFtdcQryCreditUnderlyingField pQryCreditUnderlying, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCreditCollateral(IntPtr pApi, ThostFtdcQryCreditCollateralField pQryCreditCollateral, int nRequestID);

        [DllImport("ftdc2c_zqctp", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int TdReqQryCreditFundPosition(IntPtr pApi, ThostFtdcQryCreditFundPositionField pQryCreditFundPosition, int nRequestID);


    }
}

