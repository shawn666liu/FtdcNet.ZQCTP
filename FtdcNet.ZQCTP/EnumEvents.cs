/////////////////////////////////////////////////////////////////////////
//// 上期技术 Ftdc C++ => .Net Framework Adapter
//// Author : shawn666.liu@hotmail.com   
//// 本文件生成于 2016/8/26 21:37:00
/////////////////////////////////////////////////////////////////////////

using System;

namespace ZQCTP
{

    // 注意，注意：所有索引值必须与c语言enums.h中的值一一对应，否则回调将会错乱

    /// <summary>
    /// 所有的OnErrRtnXXXX回调事件
    /// </summary>
    public enum EnumOnErrRtnType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///报单录入错误回报, ThostFtdcInputOrderField
        /// </summary>
        OnErrRtnOrderInsert,
        /// <summary>
        ///撤单操作错误回报, ThostFtdcOrderActionField
        /// </summary>
        OnErrRtnOrderAction,
        /// <summary>
        ///行权录入错误通知, ThostFtdcInputExecOrderField
        /// </summary>
        OnErrRtnExecOrderInsert,
        /// <summary>
        ///行权操作录入错误通知, ThostFtdcExecOrderActionField
        /// </summary>
        OnErrRtnExecOrderAction,
        /// <summary>
        ///锁定录入错误通知, ThostFtdcInputLockField
        /// </summary>
        OnErrRtnLockInsert,
        /// <summary>
        ///现券转移错误通知, ThostFtdcInputSecurityTransferField
        /// </summary>
        OnErrRtnSecurityTransfer,
        /// <summary>
        ///直接还款录入错误通知, ThostFtdcInputCashRepayField
        /// </summary>
        OnErrRtnCashRepayInsert,
    };

    /// <summary>
    /// 所有的OnFrontXXXX回调事件
    /// </summary>
    public enum EnumOnFrontType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
        /// </summary>
        OnFrontConnected,
        /// <summary>
        ///当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
        ///@param nReason 错误原因
        ///        0x1001 网络读失败
        ///        0x1002 网络写失败
        ///        0x2001 接收心跳超时
        ///        0x2002 发送心跳失败
        ///        0x2003 收到错误报文, int
        /// </summary>
        OnFrontDisconnected,
    };

    /// <summary>
    /// 所有的OnRspXXXX回调事件
    /// </summary>
    public enum EnumOnRspType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///错误应答, ThostFtdcRspInfoField
        /// </summary>
        OnRspError,
        /// <summary>
        ///登录请求响应, ThostFtdcRspUserLoginField
        /// </summary>
        OnRspUserLogin,
        /// <summary>
        ///登出请求响应, ThostFtdcUserLogoutField
        /// </summary>
        OnRspUserLogout,
        /// <summary>
        ///订阅行情应答, ThostFtdcSpecificInstrumentField
        /// </summary>
        OnRspSubMarketData,
        /// <summary>
        ///取消订阅行情应答, ThostFtdcSpecificInstrumentField
        /// </summary>
        OnRspUnSubMarketData,
        /// <summary>
        ///客户端认证响应, ThostFtdcRspAuthenticateField
        /// </summary>
        OnRspAuthenticate,
        /// <summary>
        ///用户口令更新响应, ThostFtdcUserPasswordUpdateField
        /// </summary>
        OnRspUserPasswordUpdate,
        /// <summary>
        ///报单录入请求响应, ThostFtdcInputOrderField
        /// </summary>
        OnRspOrderInsert,
        /// <summary>
        ///报单操作录入请求响应, ThostFtdcInputOrderActionField
        /// </summary>
        OnRspOrderAction,
        /// <summary>
        ///请求查询交易所响应, ThostFtdcExchangeField
        /// </summary>
        OnRspQryExchange,
        /// <summary>
        ///请求查询行情响应, ThostFtdcDepthMarketDataField
        /// </summary>
        OnRspQryDepthMarketData,
        /// <summary>
        ///请求查询证券响应, ThostFtdcSecurityField
        /// </summary>
        OnRspQrySecurity,
        /// <summary>
        ///请求查询ETF清单响应, ThostFtdcETFFileField
        /// </summary>
        OnRspQryETFFile,
        /// <summary>
        ///请求查询ETF成分证券响应, ThostFtdcETFBasketField
        /// </summary>
        OnRspQryETFBasket,
        /// <summary>
        ///请求查询新股信息响应, ThostFtdcSubscribingSharesField
        /// </summary>
        OnRspQrySubscribingShares,
        /// <summary>
        ///请求查询质押申报代码, ThostFtdcPledgeOrderInfoField
        /// </summary>
        OnRspQryPledgeOrderInfo,
        /// <summary>
        ///请求查询市场响应, ThostFtdcMarketField
        /// </summary>
        OnRspQryMarket,
        /// <summary>
        ///请求查询证券品种响应, ThostFtdcSecurityProductField
        /// </summary>
        OnRspQrySecurityProduct,
        /// <summary>
        ///请求查询证券类别响应, ThostFtdcSecurityClassField
        /// </summary>
        OnRspQrySecurityClass,
        /// <summary>
        ///请求查询报单响应, ThostFtdcOrderField
        /// </summary>
        OnRspQryOrder,
        /// <summary>
        ///请求查询成交响应, ThostFtdcTradeField
        /// </summary>
        OnRspQryTrade,
        /// <summary>
        ///请求查询资金账户响应, ThostFtdcTradingAccountField
        /// </summary>
        OnRspQryTradingAccount,
        /// <summary>
        ///请求查询投资者证券持仓响应, ThostFtdcInvestorSecurityPositionField
        /// </summary>
        OnRspQryInvestorSecurityPosition,
        /// <summary>
        ///请求查询投资者质押持仓响应, ThostFtdcInvestorPledgePositionField
        /// </summary>
        OnRspQryInvestorPledgePosition,
        /// <summary>
        ///请求查询投资者质押回购响应, ThostFtdcInvestorPledgeInfoField
        /// </summary>
        OnRspQryInvestorPledgeInfo,
        /// <summary>
        ///请求查询报单资金明细响应, ThostFtdcOrderFundDetailField
        /// </summary>
        OnRspQryOrderFundDetail,
        /// <summary>
        ///请求查询投资者响应, ThostFtdcInvestorField
        /// </summary>
        OnRspQryInvestor,
        /// <summary>
        ///请求查询交易账户响应, ThostFtdcTradingCodeField
        /// </summary>
        OnRspQryTradingCode,
        /// <summary>
        ///请求查询投资单元响应, ThostFtdcInvestUnitField
        /// </summary>
        OnRspQryInvestUnit,
        /// <summary>
        ///请求查询投资单元与交易资金账户关系响应, ThostFtdcInvestUnitAndTradingAcctField
        /// </summary>
        OnRspQryInvestUnitAndTradingAcct,
        /// <summary>
        ///请求查询投资单元与交易用户响应, ThostFtdcInvestUnitAndUserField
        /// </summary>
        OnRspQryInvestUnitAndUser,
        /// <summary>
        ///请求查询投资者佣金响应, ThostFtdcBrokerageField
        /// </summary>
        OnRspQryBrokerage,
        /// <summary>
        ///请求查询新股申购额度响应, ThostFtdcSubscribingSharesQuotaField
        /// </summary>
        OnRspQrySubscribingSharesQuota,
        /// <summary>
        ///请求查询标准券使用率响应, ThostFtdcRepoRatioField
        /// </summary>
        OnRspQryRepoRatio,
        /// <summary>
        ///请求查询回购放大倍数响应, ThostFtdcRepurchaseMaxTimesField
        /// </summary>
        OnRspQryRepurchaseMaxTimes,
        /// <summary>
        ///请求查询资金转移响应, ThostFtdcTransferFundField
        /// </summary>
        OnRspQryTransferFund,
        /// <summary>
        ///请求查询仓位转移响应, ThostFtdcTransferPositionField
        /// </summary>
        OnRspQryTransferPosition,
        /// <summary>
        ///行权录入响应, ThostFtdcInputExecOrderField
        /// </summary>
        OnRspExecOrderInsert,
        /// <summary>
        ///行权操作录入响应, ThostFtdcInputExecOrderActionField
        /// </summary>
        OnRspExecOrderAction,
        /// <summary>
        ///锁定录入响应, ThostFtdcInputLockField
        /// </summary>
        OnRspLockInsert,
        /// <summary>
        ///现券转移响应, ThostFtdcInputSecurityTransferField
        /// </summary>
        OnRspSecurityTransfer,
        /// <summary>
        ///个股期权合约查询响应, ThostFtdcInstrumentField
        /// </summary>
        OnRspQryInstrument,
        /// <summary>
        ///锁定查询响应, ThostFtdcLockField
        /// </summary>
        OnRspQryLock,
        /// <summary>
        ///执行宣告查询响应, ThostFtdcExecOrderField
        /// </summary>
        OnRspQryExecOrder,
        /// <summary>
        ///锁定持仓查询响应, ThostFtdcLockPositionField
        /// </summary>
        OnRspQryLockPosition,
        /// <summary>
        ///投资者保证金率查询响应, ThostFtdcMarginRateField
        /// </summary>
        OnRspQryMarginRate,
        /// <summary>
        ///投资者买入额度查询响应, ThostFtdcLimitAmountField
        /// </summary>
        OnRspQryLimitAmount,
        /// <summary>
        ///投资者持仓限制查询响应, ThostFtdcLimitPositionField
        /// </summary>
        OnRspQryLimitPosition,
        /// <summary>
        ///行权指派查询响应, ThostFtdcExerciseAssignmentField
        /// </summary>
        OnRspQryExerciseAssignment,
        /// <summary>
        ///投资者合约持仓查询响应, ThostFtdcInvestorPositionField
        /// </summary>
        OnRspQryInvestorPosition,
        /// <summary>
        ///现券转移查询响应, ThostFtdcSecurityTransferField
        /// </summary>
        OnRspQrySecurityTransfer,
        /// <summary>
        ///上市开放式基金信息查询响应, ThostFtdcLOFInfoField
        /// </summary>
        OnRspQryLOFInfo,
        /// <summary>
        ///上市开放式基金子基金信息查询响应, ThostFtdcLOFSubInfoField
        /// </summary>
        OnRspQryLOFSubInfo,
        /// <summary>
        ///直接还款录入响应, ThostFtdcInputCashRepayField
        /// </summary>
        OnRspCashRepayInsert,
        /// <summary>
        ///查询融资融券直接还款信息响应, ThostFtdcCashRepayField
        /// </summary>
        OnRspQryCashRepay,
        /// <summary>
        ///查询投资者融资融券信息响应, ThostFtdcCreditInfoField
        /// </summary>
        OnRspQryCreditInfo,
        /// <summary>
        ///查询投资者融资融券可用证券头寸响应, ThostFtdcCreditSecurityPositionField
        /// </summary>
        OnRspQryCreditSecurityPosition,
        /// <summary>
        ///请求查询投资者信用合约响应, ThostFtdcCreditContractField
        /// </summary>
        OnRspQryCreditContract,
        /// <summary>
        ///请求查询投资者融资融券偿还明细响应, ThostFtdcCreditRepaymentField
        /// </summary>
        OnRspQryCreditRepayment,
        /// <summary>
        ///请求查询投资者融资融券标的证券信息响应, ThostFtdcCreditUnderlyingField
        /// </summary>
        OnRspQryCreditUnderlying,
        /// <summary>
        ///请求查询投资者融资融券担保证券信息响应, ThostFtdcCreditCollateralField
        /// </summary>
        OnRspQryCreditCollateral,
        /// <summary>
        ///请求查询投资者融资融券可用资金头寸响应, ThostFtdcCreditFundPositionField
        /// </summary>
        OnRspQryCreditFundPosition,
    };

    /// <summary>
    /// 所有的OnRtnXXXX回调事件
    /// </summary>
    public enum EnumOnRtnType
    {
        /// <summary>
        /// 未使用,保留
        /// </summary>
        None,
        /// <summary>
        ///深度行情通知, ThostFtdcDepthMarketDataField
        /// </summary>
        OnRtnDepthMarketData,
        /// <summary>
        ///报单通知, ThostFtdcOrderField
        /// </summary>
        OnRtnOrder,
        /// <summary>
        ///成交通知, ThostFtdcTradeField
        /// </summary>
        OnRtnTrade,
        /// <summary>
        ///交易通知, ThostFtdcTradingNoticeInfoField
        /// </summary>
        OnRtnTradingNotice,
        /// <summary>
        ///资金转移回报, ThostFtdcTransferFundField
        /// </summary>
        OnRtnTransferFund,
        /// <summary>
        ///仓位转移回报, ThostFtdcTransferPositionField
        /// </summary>
        OnRtnTransferPosition,
        /// <summary>
        ///行权通知, ThostFtdcExecOrderField
        /// </summary>
        OnRtnExecOrder,
        /// <summary>
        ///锁定通知, ThostFtdcLockField
        /// </summary>
        OnRtnLock,
        /// <summary>
        ///现券转移通知, ThostFtdcSecurityTransferField
        /// </summary>
        OnRtnSecurityTransfer,
        /// <summary>
        ///直接还款回报, ThostFtdcCashRepayField
        /// </summary>
        OnRtnCashRepay,
    };

}; // end of namespace
