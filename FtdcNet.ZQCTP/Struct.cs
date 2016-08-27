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
    /// Convert Native Ftdc struct ptr to Managed object
    /// </summary>
    public static class Conv
    {
        /// <summary>
        /// Marshal IntPtr to Struct/Class 
        /// </summary>
        public static T P2S<T>(IntPtr ptr) where T : class
        {
            return Marshal.PtrToStructure(ptr, typeof(T)) as T;
        }
    }

    /// <summary>
    /// 响应信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspInfoField
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorID;

        /// <summary>
        /// 错误消息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;

    };

    /// <summary>
    /// 信息分发
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDisseminationField
    {
        /// <summary>
        /// 序列系列号
        /// </summary>
        public ushort SequenceSeries;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

    };

    /// <summary>
    /// 用户登录请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqUserLoginField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 动态密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;

        /// <summary>
        /// 终端IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;

        /// <summary>
        /// 接口语言
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string Lang;

    };

    /// <summary>
    /// 用户登录应答
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspUserLoginField
    {
        /// <summary>
        /// 登录成功时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 最大报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;

    };

    /// <summary>
    /// 用户登出请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserLogoutField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 强制交易员退出
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcForceUserLogoutField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 全部登出
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLogoutAllField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 系统名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;

    };

    /// <summary>
    /// 重置用户密码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserPasswordUpdateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 旧密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;

        /// <summary>
        /// 新密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;

    };

    /// <summary>
    /// 激活用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcActivateUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 客户端认证请求
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcReqAuthenticateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 认证码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string AuthCode;

    };

    /// <summary>
    /// 客户端认证响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRspAuthenticateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

    };

    /// <summary>
    /// 客户端认证信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcAuthenticationInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 认证信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string AuthInfo;

        /// <summary>
        /// 是否为认证结果
        /// </summary>
        public int IsResult;

    };

    /// <summary>
    /// 报单录入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 报单价格条件
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_0;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_1;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_2;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_3;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_4;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_0;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_1;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_2;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_3;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_4;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 触发条件
        /// </summary>
        public EnumContingentConditionType ContingentCondition;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;

        /// <summary>
        /// 互换单标志
        /// </summary>
        public int IsSwapOrder;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 头寸类型
        /// </summary>
        public EnumCreditPositionTypeType CreditPositionType;

    };

    /// <summary>
    /// 输入报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 转托管录入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputCustodyTransferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 申报数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 转入交易单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InPbuID;

        /// <summary>
        /// 转托管类型
        /// </summary>
        public EnumCustodyTransferTypeType CustodyTransferType;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 校验用户密码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcVerifyUserPasswordField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

    };

    /// <summary>
    /// 转托管报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputCustodyTransferActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 资金转移
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputTransferFundField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

        /// <summary>
        /// 转移方向
        /// </summary>
        public EnumTransferDirectionType TransferDirection;

        /// <summary>
        /// 转账金额
        /// </summary>
        public double Amount;

    };

    /// <summary>
    /// 冲正资金转移
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputRepealFundField
    {
        /// <summary>
        /// 被冲正CTP转账流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CTPRepealFundSerial;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

    };

    /// <summary>
    /// 仓位转移
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputTransferPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

        /// <summary>
        /// 转移方向
        /// </summary>
        public EnumTransferDirectionType TransferDirection;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 转移持仓类型
        /// </summary>
        public EnumTransferPositionTypeType TransferPositionType;

    };

    /// <summary>
    /// 冲正仓位转移
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputRepealPositionField
    {
        /// <summary>
        /// 被冲正CTP转仓流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CTPRepealPositionSerial;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 行情订阅
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSpecificInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 报单价格条件
        /// </summary>
        public EnumOrderPriceTypeType OrderPriceType;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_0;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_1;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_2;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_3;

        /// <summary>
        /// 组合开平标志
        /// </summary>
        public EnumOffsetFlagType CombOffsetFlag_4;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_0;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_1;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_2;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_3;

        /// <summary>
        /// 组合投机套保标志
        /// </summary>
        public EnumHedgeFlagType CombHedgeFlag_4;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 有效期类型
        /// </summary>
        public EnumTimeConditionType TimeCondition;

        /// <summary>
        /// GTD日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;

        /// <summary>
        /// 成交量类型
        /// </summary>
        public EnumVolumeConditionType VolumeCondition;

        /// <summary>
        /// 最小成交量
        /// </summary>
        public int MinVolume;

        /// <summary>
        /// 触发条件
        /// </summary>
        public EnumContingentConditionType ContingentCondition;

        /// <summary>
        /// 止损价
        /// </summary>
        public double StopPrice;

        /// <summary>
        /// 强平原因
        /// </summary>
        public EnumForceCloseReasonType ForceCloseReason;

        /// <summary>
        /// 自动挂起标志
        /// </summary>
        public int IsAutoSuspend;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 报单来源
        /// </summary>
        public EnumOrderSourceType OrderSource;

        /// <summary>
        /// 报单状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

        /// <summary>
        /// 报单类型
        /// </summary>
        public EnumOrderTypeType OrderType;

        /// <summary>
        /// 今成交数量
        /// </summary>
        public int VolumeTraded;

        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 激活时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;

        /// <summary>
        /// 挂起时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 最后修改交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 用户强评标志
        /// </summary>
        public int UserForceClose;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;

        /// <summary>
        /// 相关报单
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;

        /// <summary>
        /// 互换单标志
        /// </summary>
        public int IsSwapOrder;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

        /// <summary>
        /// 头寸类型
        /// </summary>
        public EnumCreditPositionTypeType CreditPositionType;

    };

    /// <summary>
    /// 成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易角色
        /// </summary>
        public EnumTradingRoleType TradingRole;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double Price;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 成交时期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;

        /// <summary>
        /// 成交时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;

        /// <summary>
        /// 成交类型
        /// </summary>
        public EnumTradeTypeType TradeType;

        /// <summary>
        /// 成交价来源
        /// </summary>
        public EnumPriceSourceType PriceSource;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;

        /// <summary>
        /// 成交来源
        /// </summary>
        public EnumTradeSourceType TradeSource;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

    };

    /// <summary>
    /// 报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 价格
        /// </summary>
        public double LimitPrice;

        /// <summary>
        /// 数量变化
        /// </summary>
        public int VolumeChange;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易所信息变更
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeName;

        /// <summary>
        /// 交易所属性
        /// </summary>
        public EnumExchangePropertyType ExchangeProperty;

        /// <summary>
        /// 当前交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

    };

    /// <summary>
    /// 转托管报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCustodyTransferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 转入交易单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InPbuID;

        /// <summary>
        /// 转托管类型
        /// </summary>
        public EnumCustodyTransferTypeType CustodyTransferType;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 报单来源
        /// </summary>
        public EnumOrderSourceType OrderSource;

        /// <summary>
        /// 报单状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

        /// <summary>
        /// 报单日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 委托时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 最后修改交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司报单编号
        /// </summary>
        public int BrokerOrderSeq;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 转托管操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCustodyTransferActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 报单操作引用
        /// </summary>
        public int OrderActionRef;

        /// <summary>
        /// 报单引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 交易通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingNoticeInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 发送时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;

        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;

        /// <summary>
        /// 序列系列号
        /// </summary>
        public ushort SequenceSeries;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

    };

    /// <summary>
    /// 资金转移回报
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferFundField
    {
        /// <summary>
        /// CTP转账流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CTPFundSerial;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 转移方向
        /// </summary>
        public EnumTransferDirectionType TransferDirection;

        /// <summary>
        /// 出入金金额
        /// </summary>
        public double Amount;

        /// <summary>
        /// 转移状态
        /// </summary>
        public EnumTransferStatusType TransferStatus;

        /// <summary>
        /// 操作人员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string OperatorID;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateTime;

    };

    /// <summary>
    /// 仓位转移回报
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTransferPositionField
    {
        /// <summary>
        /// CTP仓位转移流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CTPPositionSerial;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 证券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 转移方向
        /// </summary>
        public EnumTransferDirectionType TransferDirection;

        /// <summary>
        /// 转移持仓类型
        /// </summary>
        public EnumTransferPositionTypeType TransferPositionType;

        /// <summary>
        /// 昨日持仓数量
        /// </summary>
        public int HistoryVolume;

        /// <summary>
        /// 今日买卖持仓数量
        /// </summary>
        public int TodayBSVolume;

        /// <summary>
        /// 今日申赎持仓数量
        /// </summary>
        public int TodayPRVolume;

        /// <summary>
        /// 转移状态
        /// </summary>
        public EnumTransferStatusType TransferStatus;

        /// <summary>
        /// 操作人员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string OperatorID;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateTime;

    };

    /// <summary>
    /// 深度行情通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDepthMarketDataField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;

        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;

        /// <summary>
        /// 昨持仓量
        /// </summary>
        public double PreOpenInterest;

        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;

        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;

        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public Int64 Volume;

        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;

        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;

        /// <summary>
        /// 今收盘
        /// </summary>
        public double ClosePrice;

        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

        /// <summary>
        /// 昨虚实度
        /// </summary>
        public double PreDelta;

        /// <summary>
        /// 今虚实度
        /// </summary>
        public double CurrDelta;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;

        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;

        /// <summary>
        /// 申买量一
        /// </summary>
        public Int64 BidVolume1;

        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;

        /// <summary>
        /// 申卖量一
        /// </summary>
        public Int64 AskVolume1;

        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;

        /// <summary>
        /// 申买量二
        /// </summary>
        public Int64 BidVolume2;

        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;

        /// <summary>
        /// 申卖量二
        /// </summary>
        public Int64 AskVolume2;

        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;

        /// <summary>
        /// 申买量三
        /// </summary>
        public Int64 BidVolume3;

        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;

        /// <summary>
        /// 申卖量三
        /// </summary>
        public Int64 AskVolume3;

        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;

        /// <summary>
        /// 申买量四
        /// </summary>
        public Int64 BidVolume4;

        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;

        /// <summary>
        /// 申卖量四
        /// </summary>
        public Int64 AskVolume4;

        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;

        /// <summary>
        /// 申买量五
        /// </summary>
        public Int64 BidVolume5;

        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;

        /// <summary>
        /// 申卖量五
        /// </summary>
        public Int64 AskVolume5;

        /// <summary>
        /// 当日均价
        /// </summary>
        public double AveragePrice;

        /// <summary>
        /// 业务日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;

        /// <summary>
        /// 合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;

        /// <summary>
        /// 成交笔数
        /// </summary>
        public Int64 TradingCount;

        /// <summary>
        /// 市盈率1
        /// </summary>
        public double PERatio1;

        /// <summary>
        /// 市盈率2
        /// </summary>
        public double PERatio2;

        /// <summary>
        /// 价格升跌1
        /// </summary>
        public double PriceUpDown1;

        /// <summary>
        /// 价格升跌2
        /// </summary>
        public double PriceUpDown2;

    };

    /// <summary>
    /// 行情交易所代码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 行情基础属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBaseField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 昨收盘
        /// </summary>
        public double PreClosePrice;

        /// <summary>
        /// 合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;

    };

    /// <summary>
    /// 行情静态属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataStaticField
    {
        /// <summary>
        /// 今开盘
        /// </summary>
        public double OpenPrice;

        /// <summary>
        /// 最高价
        /// </summary>
        public double HighestPrice;

        /// <summary>
        /// 最低价
        /// </summary>
        public double LowestPrice;

        /// <summary>
        /// 涨停板价
        /// </summary>
        public double UpperLimitPrice;

        /// <summary>
        /// 跌停板价
        /// </summary>
        public double LowerLimitPrice;

    };

    /// <summary>
    /// 行情最新成交属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataLastMatchField
    {
        /// <summary>
        /// 最新价
        /// </summary>
        public double LastPrice;

        /// <summary>
        /// 数量
        /// </summary>
        public Int64 Volume;

        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;

        /// <summary>
        /// 成交笔数
        /// </summary>
        public Int64 TradingCount;

        /// <summary>
        /// 市盈率1
        /// </summary>
        public double PERatio1;

        /// <summary>
        /// 市盈率2
        /// </summary>
        public double PERatio2;

        /// <summary>
        /// 价格升跌1
        /// </summary>
        public double PriceUpDown1;

        /// <summary>
        /// 价格升跌2
        /// </summary>
        public double PriceUpDown2;

        /// <summary>
        /// 持仓量
        /// </summary>
        public double OpenInterest;

    };

    /// <summary>
    /// 行情最优价属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBestPriceField
    {
        /// <summary>
        /// 申买价一
        /// </summary>
        public double BidPrice1;

        /// <summary>
        /// 申买量一
        /// </summary>
        public Int64 BidVolume1;

        /// <summary>
        /// 申卖价一
        /// </summary>
        public double AskPrice1;

        /// <summary>
        /// 申卖量一
        /// </summary>
        public Int64 AskVolume1;

    };

    /// <summary>
    /// 行情申买二、三属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBid23Field
    {
        /// <summary>
        /// 申买价二
        /// </summary>
        public double BidPrice2;

        /// <summary>
        /// 申买量二
        /// </summary>
        public Int64 BidVolume2;

        /// <summary>
        /// 申买价三
        /// </summary>
        public double BidPrice3;

        /// <summary>
        /// 申买量三
        /// </summary>
        public Int64 BidVolume3;

    };

    /// <summary>
    /// 行情申卖二、三属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataAsk23Field
    {
        /// <summary>
        /// 申卖价二
        /// </summary>
        public double AskPrice2;

        /// <summary>
        /// 申卖量二
        /// </summary>
        public Int64 AskVolume2;

        /// <summary>
        /// 申卖价三
        /// </summary>
        public double AskPrice3;

        /// <summary>
        /// 申卖量三
        /// </summary>
        public Int64 AskVolume3;

    };

    /// <summary>
    /// 行情申买四、五属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataBid45Field
    {
        /// <summary>
        /// 申买价四
        /// </summary>
        public double BidPrice4;

        /// <summary>
        /// 申买量四
        /// </summary>
        public Int64 BidVolume4;

        /// <summary>
        /// 申买价五
        /// </summary>
        public double BidPrice5;

        /// <summary>
        /// 申买量五
        /// </summary>
        public Int64 BidVolume5;

    };

    /// <summary>
    /// 行情申卖四、五属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataAsk45Field
    {
        /// <summary>
        /// 申卖价四
        /// </summary>
        public double AskPrice4;

        /// <summary>
        /// 申卖量四
        /// </summary>
        public Int64 AskVolume4;

        /// <summary>
        /// 申卖价五
        /// </summary>
        public double AskPrice5;

        /// <summary>
        /// 申卖量五
        /// </summary>
        public Int64 AskVolume5;

    };

    /// <summary>
    /// 行情更新时间属性
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketDataUpdateTimeField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;

        /// <summary>
        /// 最后修改毫秒
        /// </summary>
        public int UpdateMillisec;

    };

    /// <summary>
    /// 查询交易所
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExchangeField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询行情
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryDepthMarketDataField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询证券
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySecurityField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

    };

    /// <summary>
    /// 证券
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSecurityField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 市场代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MarketID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 证券类别代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string SecurityClassID;

        /// <summary>
        /// 申报单位
        /// </summary>
        public EnumOrderUnitType OrderUnit;

        /// <summary>
        /// 买入交易单位
        /// </summary>
        public int BuyTradingUnit;

        /// <summary>
        /// 卖出交易单位
        /// </summary>
        public int SellTradingUnit;

        /// <summary>
        /// 市价单买最大下单量
        /// </summary>
        public int MaxMarketOrderBuyVolume;

        /// <summary>
        /// 市价单买最小下单量
        /// </summary>
        public int MinMarketOrderBuyVolume;

        /// <summary>
        /// 限价单买最大下单量
        /// </summary>
        public int MaxLimitOrderBuyVolume;

        /// <summary>
        /// 限价单买最小下单量
        /// </summary>
        public int MinLimitOrderBuyVolume;

        /// <summary>
        /// 市价单卖最大下单量
        /// </summary>
        public int MaxMarketOrderSellVolume;

        /// <summary>
        /// 市价单卖最小下单量
        /// </summary>
        public int MinMarketOrderSellVolume;

        /// <summary>
        /// 限价单卖最大下单量
        /// </summary>
        public int MaxLimitOrderSellVolume;

        /// <summary>
        /// 限价单卖最小下单量
        /// </summary>
        public int MinLimitOrderSellVolume;

        /// <summary>
        /// 数量乘数
        /// </summary>
        public int VolumeMultiple;

        /// <summary>
        /// 最小变动价位
        /// </summary>
        public double PriceTick;

        /// <summary>
        /// 上市日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 持仓类型
        /// </summary>
        public EnumPositionTypeType PositionType;

        /// <summary>
        /// 面值
        /// </summary>
        public double SecurityValue;

        /// <summary>
        /// 证券状态
        /// </summary>
        public int SecurityStatusFlag;

        /// <summary>
        /// 债券应计利息
        /// </summary>
        public double BondInterest;

        /// <summary>
        /// 折算率
        /// </summary>
        public double ConversionRate;

    };

    /// <summary>
    /// 查询ETF清单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryETFFileField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// ETF合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ETFInstrumentID;

        /// <summary>
        /// ETF申赎代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ETFCreRedInstrumentID;

    };

    /// <summary>
    /// ETF清单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcETFFileField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// ETF交易代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ETFInstrumentID;

        /// <summary>
        /// ETF申赎代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ETFCreRedInstrumentID;

        /// <summary>
        /// 最小申购赎回单位份数
        /// </summary>
        public int CreationRedemptionUnit;

        /// <summary>
        /// 最大现金替代比例
        /// </summary>
        public double Maxcashratio;

        /// <summary>
        /// 是否允许申购
        /// </summary>
        public int CreationStatus;

        /// <summary>
        /// 是否允许赎回
        /// </summary>
        public int RedemptionStatus;

        /// <summary>
        /// 预估现金差额
        /// </summary>
        public double EstimateCashComponent;

        /// <summary>
        /// 前一交易日现金差额
        /// </summary>
        public double CashComponent;

        /// <summary>
        /// 前一交易日基金单位净值
        /// </summary>
        public double NAV;

        /// <summary>
        /// 前一交易日申赎基准单位净值
        /// </summary>
        public double NAVperCU;

        /// <summary>
        /// 当日申购赎回基准单位的红利金额
        /// </summary>
        public double DividendPerCU;

    };

    /// <summary>
    /// 查询ETF成分证券
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryETFBasketField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// ETF合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ETFInstrumentID;

        /// <summary>
        /// 成分合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// ETF成分证券
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcETFBasketField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// ETF交易代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ETFInstrumentID;

        /// <summary>
        /// ETF成份证券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 证券简称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;

        /// <summary>
        /// 证券数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 替代标志
        /// </summary>
        public EnumETFCurrenceReplaceStatusType ETFCurrenceReplaceStatus;

        /// <summary>
        /// 溢价比例
        /// </summary>
        public double Premium;

        /// <summary>
        /// 申购替代金额
        /// </summary>
        public double CreationReplaceAmount;

        /// <summary>
        /// 赎回替代金额
        /// </summary>
        public double RedemptionReplaceAmount;

        /// <summary>
        /// 挂牌市场
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string Market;

    };

    /// <summary>
    /// 查询新股
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySubscribingSharesField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 申购代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 新股
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSubscribingSharesField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 申购代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 市场代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MarketID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 证券类别代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string SecurityClassID;

        /// <summary>
        /// 网上申购上限
        /// </summary>
        public int OnlineLimit;

        /// <summary>
        /// 发行价格
        /// </summary>
        public double Price;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 查询质押申报代码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryPledgeOrderInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 质押申报代码
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcPledgeOrderInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 质押申报代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string PledgeOrderID;

        /// <summary>
        /// 标准券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string StandardBondID;

    };

    /// <summary>
    /// 查询市场
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryMarketField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 市场代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MarketID;

    };

    /// <summary>
    /// 市场
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarketField
    {
        /// <summary>
        /// 市场代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MarketID;

        /// <summary>
        /// 市场名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string MarketName;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询证券品种
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySecurityProductField
    {
        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 证券品种
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSecurityProductField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 产品名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ProductName;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

    };

    /// <summary>
    /// 查询证券类别
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySecurityClassField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 证券类别代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string SecurityClassID;

    };

    /// <summary>
    /// 证券类别
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSecurityClassField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 证券类别代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string SecurityClassID;

        /// <summary>
        /// 证券类别名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string SecurityClassName;

    };

    /// <summary>
    /// 查询用户权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryUserFunctionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 用户权限
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserFunctionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 功能代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string FunctionID;

        /// <summary>
        /// 功能名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string FunctionName;

    };

    /// <summary>
    /// 查询报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询报单操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 查询成交
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 成交编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询资金账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradingAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 资金账户所属投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 资金账户类型
        /// </summary>
        public EnumAccountTypeType AccountType;

    };

    /// <summary>
    /// 资金账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingAccountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 可用资金
        /// </summary>
        public double Available;

        /// <summary>
        /// 可取资金
        /// </summary>
        public double WithdrawQuota;

        /// <summary>
        /// 币种代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;

        /// <summary>
        /// 入金金额
        /// </summary>
        public double Deposit;

        /// <summary>
        /// 出金金额
        /// </summary>
        public double Withdraw;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;

        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;

        /// <summary>
        /// 当前保证金总额
        /// </summary>
        public double CurrMargin;

        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;

        /// <summary>
        /// 资金账户类型
        /// </summary>
        public EnumAccountTypeType AccountType;

    };

    /// <summary>
    /// 查询投资者证券持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorSecurityPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者证券持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorSecurityPositionField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 持仓多空方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 昨日持仓
        /// </summary>
        public double HistoryPosition;

        /// <summary>
        /// 昨日持仓冻结
        /// </summary>
        public double HistoryFrozen;

        /// <summary>
        /// 今日买卖持仓
        /// </summary>
        public double TodayBSPosition;

        /// <summary>
        /// 今日买卖持仓冻结
        /// </summary>
        public double TodayBSFrozen;

        /// <summary>
        /// 今日申赎持仓
        /// </summary>
        public double TodayPRPosition;

        /// <summary>
        /// 今日申赎持仓冻结
        /// </summary>
        public double TodayPRFrozen;

        /// <summary>
        /// 持仓成本
        /// </summary>
        public double PositionCost;

        /// <summary>
        /// 今日拆分合并持仓
        /// </summary>
        public double TodaySMPosition;

        /// <summary>
        /// 今日拆分合并持仓冻结
        /// </summary>
        public double TodaySMFrozen;

        /// <summary>
        /// 融资买入数量
        /// </summary>
        public double MarginBuyVolume;

        /// <summary>
        /// 融券卖出数量
        /// </summary>
        public double ShortSellVolume;

    };

    /// <summary>
    /// 查询投资者质押持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorPledgePositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者质押持仓
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorPledgePositionField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 入库证券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 质押申报代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string PledgeOrderID;

        /// <summary>
        /// 标准券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string StandardBondID;

        /// <summary>
        /// 昨日入库持仓
        /// </summary>
        public double HisPledgePos;

        /// <summary>
        /// 昨日入库持仓冻结
        /// </summary>
        public double HisPledgePosFrozen;

        /// <summary>
        /// 今日入库持仓
        /// </summary>
        public double TodayPledgePos;

        /// <summary>
        /// 今日入库持仓冻结
        /// </summary>
        public double TodayPledgePosFrozen;

    };

    /// <summary>
    /// 查询投资者质押回购
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorPledgeInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 标准券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string StandardBondID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者质押回购
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorPledgeInfoField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 标准券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string StandardBondID;

        /// <summary>
        /// 融资数量
        /// </summary>
        public double PurchaseVol;

        /// <summary>
        /// 融资金额
        /// </summary>
        public double PurchaseAmt;

        /// <summary>
        /// 融券数量
        /// </summary>
        public double ReversePurVol;

        /// <summary>
        /// 融券金额
        /// </summary>
        public double ReversePurAmt;

        /// <summary>
        /// 未成交融资数量
        /// </summary>
        public double NoTradePurchaseVol;

        /// <summary>
        /// 未成交融资金额
        /// </summary>
        public double NoTradePurchaseAmt;

        /// <summary>
        /// 未成交融券数量
        /// </summary>
        public double NoTradeReversePurVol;

        /// <summary>
        /// 未成交融券金额
        /// </summary>
        public double NoTradeReversePurAmt;

    };

    /// <summary>
    /// 查询报单资金明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryOrderFundDetailField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 报单资金明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcOrderFundDetailField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 初始冻结金额
        /// </summary>
        public double TotalFrozen;

        /// <summary>
        /// 总费用
        /// </summary>
        public double TotalFee;

        /// <summary>
        /// 成交金额
        /// </summary>
        public double Turnover;

    };

    /// <summary>
    /// 查询投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 投资者
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorField
    {
        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string InvestorName;

        /// <summary>
        /// 证件类型
        /// </summary>
        public EnumIdCardTypeType IdentifiedCardType;

        /// <summary>
        /// 证件号码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 联系电话
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;

        /// <summary>
        /// 通讯地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;

        /// <summary>
        /// 开户日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 手机
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;

        /// <summary>
        /// 佣金模板代码
        /// </summary>
        public int BrokerageTemplateNo;

        /// <summary>
        /// 个股期权佣金模板代码
        /// </summary>
        public int SecurityOptionTemplateNo;

        /// <summary>
        /// 保证金模板代码
        /// </summary>
        public int MarginTemplateNo;

        /// <summary>
        /// 融资融券佣金模板代码
        /// </summary>
        public int CreditTemplateNo;

    };

    /// <summary>
    /// 查询交易账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTradingCodeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易编码类型
        /// </summary>
        public EnumClientIDTypeType ClientIDType;

    };

    /// <summary>
    /// 交易账户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingCodeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 交易编码类型
        /// </summary>
        public EnumClientIDTypeType ClientIDType;

        /// <summary>
        /// 市场代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MarketID;

        /// <summary>
        /// 交易所营业部编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BranchID;

    };

    /// <summary>
    /// 查询投资单元
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestUnitField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 投资单元
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestUnitField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 投资单元名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string InvestUnitName;

    };

    /// <summary>
    /// 查询投资单元与交易资金账户关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestUnitAndTradingAcctField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

    };

    /// <summary>
    /// 投资单元与交易资金账户关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestUnitAndTradingAcctField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

    };

    /// <summary>
    /// 查询投资者用户与投资单元关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestUnitAndUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者用户与投资单元关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestUnitAndUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询投资者佣金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerageField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 佣金模板代码
        /// </summary>
        public int BrokerageTemplateNo;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 投资者佣金
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerageField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 佣金模板代码
        /// </summary>
        public int BrokerageTemplateNo;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 证券类别代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string SecurityClassID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 业务类别
        /// </summary>
        public EnumBizClassType BizClass;

        /// <summary>
        /// 佣金类型
        /// </summary>
        public EnumBrokerageTypeType BrokerageType;

        /// <summary>
        /// 佣金按金额收取比例
        /// </summary>
        public double RatioByAmt;

        /// <summary>
        /// 佣金按面值收取比例
        /// </summary>
        public double RatioByPar;

        /// <summary>
        /// 佣金按笔收取金额
        /// </summary>
        public double FeePerOrder;

        /// <summary>
        /// 佣金最低收取金额
        /// </summary>
        public double FeeMin;

        /// <summary>
        /// 佣金最高收取金额
        /// </summary>
        public double FeeMax;

        /// <summary>
        /// 佣金按数量收取金额
        /// </summary>
        public double FeeByVolume;

    };

    /// <summary>
    /// 查询新股申购额度
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySubscribingSharesQuotaField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

    };

    /// <summary>
    /// 新股申购额度
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSubscribingSharesQuotaField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 可申购额度
        /// </summary>
        public int MaxVolume;

    };

    /// <summary>
    /// 查询标准券使用率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryRepoRatioField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 标准券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string StandardBondID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 标准券使用率
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRepoRatioField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 标准券代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string StandardBondID;

        /// <summary>
        /// 标准券使用率
        /// </summary>
        public double StandardUseRatio;

    };

    /// <summary>
    /// 查询回购放大倍数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryRepurchaseMaxTimesField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 回购放大倍数
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcRepurchaseMaxTimesField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 回购放大倍数
        /// </summary>
        public double RepurchaseMaxTimes;

    };

    /// <summary>
    /// 查询资金转移
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTransferFundField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 资金账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// CTP转账流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CTPFundSerial;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

    };

    /// <summary>
    /// 查询仓位转移
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTransferPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// CTP仓位转移流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CTPPositionSerial;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

    };

    /// <summary>
    /// 查询经纪公司用户与投资者关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerUserAndInvestorField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 经纪公司用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 经纪公司用户与投资者关系
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerUserAndInvestorField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 查询经纪公司
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBrokerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 经纪公司
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBrokerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 经纪公司简称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BrokerAbbr;

        /// <summary>
        /// 经纪公司名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string BrokerName;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

    };

    /// <summary>
    /// 查询部门
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryDepartmentField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 经纪公司部门代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string DepartmentID;

    };

    /// <summary>
    /// 部门
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDepartmentField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 经纪公司部门代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string DepartmentID;

        /// <summary>
        /// 经纪公司部门名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string DepartmentName;

    };

    /// <summary>
    /// 查询基础交易费用
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryBasicTradingFeeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 基础交易费用
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcBasicTradingFeeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 证券类别代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string SecurityClassID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 业务类别
        /// </summary>
        public EnumBizClassType BizClass;

        /// <summary>
        /// 印花税按金额收取比例
        /// </summary>
        public double StampTaxRatioByAmt;

        /// <summary>
        /// 印花税按面值收取比例
        /// </summary>
        public double StampTaxRatioByPar;

        /// <summary>
        /// 印花税按笔收取金额
        /// </summary>
        public double StampTaxFeePerOrder;

        /// <summary>
        /// 印花税最低收取金额
        /// </summary>
        public double StampTaxFeeMin;

        /// <summary>
        /// 印花税最高收取金额
        /// </summary>
        public double StampTaxFeeMax;

        /// <summary>
        /// 过户费按金额收取比例
        /// </summary>
        public double TransferRatioByAmt;

        /// <summary>
        /// 过户费按面值收取比例
        /// </summary>
        public double TransferRatioByPar;

        /// <summary>
        /// 过户费按笔收取金额
        /// </summary>
        public double TransferFeePerOrder;

        /// <summary>
        /// 过户费最低收取金额
        /// </summary>
        public double TransferFeeMin;

        /// <summary>
        /// 过户费最高收取金额
        /// </summary>
        public double TransferFeeMax;

        /// <summary>
        /// 经手费按金额收取比例
        /// </summary>
        public double HandlingRatioByAmt;

        /// <summary>
        /// 经手费按面值收取比例
        /// </summary>
        public double HandlingRatioByPar;

        /// <summary>
        /// 经手费按笔收取金额
        /// </summary>
        public double HandlingFeePerOrder;

        /// <summary>
        /// 经手费最低收取金额
        /// </summary>
        public double HandlingFeeMin;

        /// <summary>
        /// 经手费最高收取金额
        /// </summary>
        public double HandlingFeeMax;

        /// <summary>
        /// 证管费按金额收取比例
        /// </summary>
        public double RegulateRatioByAmt;

        /// <summary>
        /// 证管费按面值收取比例
        /// </summary>
        public double RegulateRatioByPar;

        /// <summary>
        /// 证管费按笔收取金额
        /// </summary>
        public double RegulateFeePerOrder;

        /// <summary>
        /// 证管费最低收取金额
        /// </summary>
        public double RegulateFeeMin;

        /// <summary>
        /// 证管费最高收取金额
        /// </summary>
        public double RegulateFeeMax;

        /// <summary>
        /// 过户费按数量收取金额
        /// </summary>
        public double TransferFeeByVolume;

        /// <summary>
        /// 经手费按数量收取金额
        /// </summary>
        public double HandlingFeeByVolume;

        /// <summary>
        /// 结算费按金额收取比例
        /// </summary>
        public double SettlementRatioByAmt;

        /// <summary>
        /// 结算费按面值收取比例
        /// </summary>
        public double SettlementRatioByPar;

        /// <summary>
        /// 结算费按笔收取金额
        /// </summary>
        public double SettlementFeePerOrder;

        /// <summary>
        /// 结算费按数量收取金额
        /// </summary>
        public double SettlementFeeByVolume;

        /// <summary>
        /// 结算费最低收取金额
        /// </summary>
        public double SettlementFeeMin;

        /// <summary>
        /// 结算费最高收取金额
        /// </summary>
        public double SettlementFeeMax;

        /// <summary>
        /// 系统标识
        /// </summary>
        public EnumSystemFlagType SystemFlag;

    };

    /// <summary>
    /// 查询用户会话
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryUserSessionField
    {
        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

    };

    /// <summary>
    /// 用户会话
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserSessionField
    {
        /// <summary>
        /// 登录前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 登录会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 登录日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;

        /// <summary>
        /// 登录时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;

        /// <summary>
        /// 登录IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 接口端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;

        /// <summary>
        /// 协议信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;

        /// <summary>
        /// 登录Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 查询用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户类型
        /// </summary>
        public EnumUserTypeType UserType;

    };

    /// <summary>
    /// 用户
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUserField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 用户名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 用户类型
        /// </summary>
        public EnumUserTypeType UserType;

        /// <summary>
        /// 是否活跃
        /// </summary>
        public int IsActive;

        /// <summary>
        /// 登录限制
        /// </summary>
        public int LoginLimit;

        /// <summary>
        /// 每秒最大报单数
        /// </summary>
        public int PerSecondOrders;

    };

    /// <summary>
    /// 查询交易所交易员报盘机信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTraderOfferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易报盘编号
        /// </summary>
        public int TraderOfferID;

    };

    /// <summary>
    /// 交易所交易员报盘机信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTraderOfferField
    {
        /// <summary>
        /// 交易报盘编号
        /// </summary>
        public int TraderOfferID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 连接类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ConnectType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 通用字段1
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString1;

        /// <summary>
        /// 通用字段2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString2;

        /// <summary>
        /// 通用字段3
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString3;

        /// <summary>
        /// 报文序号1
        /// </summary>
        public int SequenceNo1;

        /// <summary>
        /// 报文序号2
        /// </summary>
        public int SequenceNo2;

        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

        /// <summary>
        /// 运行ID
        /// </summary>
        public ushort RunID;

        /// <summary>
        /// 平台类型
        /// </summary>
        public EnumPlatformTypeType PlatformType;

        /// <summary>
        /// 前置ID
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话ID
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 连接状态
        /// </summary>
        public EnumConnectStatusType ConnectStatus;

        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;

        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;

        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;

        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;

    };

    /// <summary>
    /// 更新交易所交易员报盘机信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUpdTraderOfferField
    {
        /// <summary>
        /// 交易报盘编号
        /// </summary>
        public int TraderOfferID;

        /// <summary>
        /// 连接类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ConnectType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 通用字段1
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString1;

        /// <summary>
        /// 通用字段2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString2;

        /// <summary>
        /// 通用字段3
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString3;

        /// <summary>
        /// 报文序号1
        /// </summary>
        public int SequenceNo1;

        /// <summary>
        /// 报文序号2
        /// </summary>
        public int SequenceNo2;

    };

    /// <summary>
    /// 查询交易员信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryTraderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 交易报盘编号
        /// </summary>
        public int TraderOfferID;

    };

    /// <summary>
    /// 交易员信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTraderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 平台类型
        /// </summary>
        public EnumPlatformTypeType PlatformType;

        /// <summary>
        /// 交易报盘编号
        /// </summary>
        public int TraderOfferID;

    };

    /// <summary>
    /// 查询行情服务器信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryMdServerField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 行情服务器编号
        /// </summary>
        public int MdServerID;

    };

    /// <summary>
    /// 行情服务器信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMdServerField
    {
        /// <summary>
        /// 行情服务器编号
        /// </summary>
        public int MdServerID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 连接类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ConnectType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 通用字段1
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString1;

        /// <summary>
        /// 通用字段2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString2;

        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

        /// <summary>
        /// 运行ID
        /// </summary>
        public ushort RunID;

        /// <summary>
        /// 前置ID
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话ID
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 连接状态
        /// </summary>
        public EnumConnectStatusType ConnectStatus;

        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;

        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;

        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;

        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;

    };

    /// <summary>
    /// 更新行情服务器信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUpdMdServerField
    {
        /// <summary>
        /// 行情服务器编号
        /// </summary>
        public int MdServerID;

        /// <summary>
        /// 连接类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ConnectType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 通用字段1
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString1;

        /// <summary>
        /// 通用字段2
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string CommString2;

    };

    /// <summary>
    /// 查询Dbmt信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryDbmtField
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

    };

    /// <summary>
    /// Dbmt信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDbmtField
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

        /// <summary>
        /// 连接类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ConnectType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 当前最大Dbmt编号
        /// </summary>
        public int CurrDbmtNo;

        /// <summary>
        /// 运行ID
        /// </summary>
        public ushort RunID;

        /// <summary>
        /// 前置ID
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话ID
        /// </summary>
        public int SessionID;

        /// <summary>
        /// Dbmt连接状态
        /// </summary>
        public EnumConnectStatusType DbmtConnectStatus;

        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;

        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;

        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;

        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;

    };

    /// <summary>
    /// 更新Dbmt信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUpdDbmtField
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

        /// <summary>
        /// 连接类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ConnectType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 当前最大Dbmt编号
        /// </summary>
        public int CurrDbmtNo;

    };

    /// <summary>
    /// 查询Dbwriter信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryDbwriterField
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

    };

    /// <summary>
    /// Dbwriter信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcDbwriterField
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

        /// <summary>
        /// 连接类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ConnectType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 运行ID
        /// </summary>
        public ushort RunID;

        /// <summary>
        /// 前置ID
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话ID
        /// </summary>
        public int SessionID;

        /// <summary>
        /// Dbwriter连接状态
        /// </summary>
        public EnumConnectStatusType DbwriterConnectStatus;

        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;

        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;

        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;

        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;

    };

    /// <summary>
    /// 更新Dbwriter信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUpdDbwriterField
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

        /// <summary>
        /// 连接类型
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ConnectType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

    };

    /// <summary>
    /// 更新证券报盘信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUpdSecurityOfferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 连接系统
        /// </summary>
        public EnumConnectSystemType ConnectSystem;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 密码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;

        /// <summary>
        /// 认证码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string AuthCode;

    };

    /// <summary>
    /// 更新投资者融资融券限制
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcUpdCreditTradingLimitField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 是否可融资买入
        /// </summary>
        public int IsMarginBuy;

        /// <summary>
        /// 是否可融券卖出
        /// </summary>
        public int IsShortSell;

        /// <summary>
        /// 是否可担保品买入
        /// </summary>
        public int IsBuy;

    };

    /// <summary>
    /// 查询转托管报单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCustodyTransferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询转托管操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCustodyTransferActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 行权输入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputExecOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 行权引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 行权数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumExecOrderActionTypeType ActionType;

        /// <summary>
        /// 保留寸头申请的持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 期权行权后是否保留期货头寸的标记
        /// </summary>
        public EnumReservePositionFlagType ReservePositionFlag;

        /// <summary>
        /// 期权行权后生成的头寸是否自动平仓
        /// </summary>
        public EnumCloseFlagType CloseFlag;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 行权
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExecOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 行权引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 行权数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 开平标志
        /// </summary>
        public EnumOffsetFlagType OffsetFlag;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumExecOrderActionTypeType ActionType;

        /// <summary>
        /// 保留寸头申请的持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 期权行权后是否保留期货头寸的标记
        /// </summary>
        public EnumReservePositionFlagType ReservePositionFlag;

        /// <summary>
        /// 期权行权后生成的头寸是否自动平仓
        /// </summary>
        public EnumCloseFlagType CloseFlag;

        /// <summary>
        /// 本地行权编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 系统行权编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 申报日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 申报时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 执行结果
        /// </summary>
        public EnumExecResultType ExecResult;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司行权编号
        /// </summary>
        public int BrokerExecOrderSeq;

        /// <summary>
        /// 交易所营业部编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 行权操作输入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputExecOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 行权操作引用
        /// </summary>
        public int ExecOrderActionRef;

        /// <summary>
        /// 行权引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 系统行权编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 锁定输入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputLockField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 锁定引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string LockRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 锁定数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 锁定类型
        /// </summary>
        public EnumLockTypeType LockType;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 锁定
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLockField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 锁定引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string LockRef;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 锁定数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 锁定类型
        /// </summary>
        public EnumLockTypeType LockType;

        /// <summary>
        /// 本地锁定编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string LockLocalID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 报单提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 报单提示序号
        /// </summary>
        public int NotifySequence;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 系统锁定编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string LockSysID;

        /// <summary>
        /// 申报日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 申报时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 报盘状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

        /// <summary>
        /// 结算会员编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;

        /// <summary>
        /// 序号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 经纪公司锁定编号
        /// </summary>
        public int BrokerLockSeq;

        /// <summary>
        /// 交易所营业部编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BranchID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 锁定操作输入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputLockActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 锁定操作引用
        /// </summary>
        public int LockActionRef;

        /// <summary>
        /// 锁定引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string LockRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 系统行权编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string LockSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 行权操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExecOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 行权操作引用
        /// </summary>
        public int ExecOrderActionRef;

        /// <summary>
        /// 行权引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 系统行权编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地行权编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;

        /// <summary>
        /// 本地操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 执行类型
        /// </summary>
        public EnumExecOrderActionTypeType ActionType;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 交易所营业部编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BranchID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 锁定操作
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLockActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 锁定操作引用
        /// </summary>
        public int LockActionRef;

        /// <summary>
        /// 锁定引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string LockRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 系统锁定编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string LockSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 安装编号
        /// </summary>
        public int InstallID;

        /// <summary>
        /// 本地锁定编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string LockLocalID;

        /// <summary>
        /// 本地操作编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 会员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 业务单元
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumOrderActionStatusType OrderActionStatus;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 现券转移输入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputSecurityTransferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 现券系统投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string SecurityInvestorID;

        /// <summary>
        /// 现券系统投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string SecurityInvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

        /// <summary>
        /// 现券转移方向
        /// </summary>
        public EnumSecurityTransferDirectionType SecurityTransferDirection;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 转移持仓类型
        /// </summary>
        public EnumTransferPositionTypeType TransferPositionType;

    };

    /// <summary>
    /// 现券转移
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSecurityTransferField
    {
        /// <summary>
        /// 现券转移流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string SecurityTransferSerial;

        /// <summary>
        /// 申请流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string ApplySerial;

        /// <summary>
        /// 证券系统仓位转移流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string SecurityPositionSerial;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 现券系统投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string SecurityInvestorID;

        /// <summary>
        /// 现券系统投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string SecurityInvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 转移方向
        /// </summary>
        public EnumSecurityTransferDirectionType SecurityTransferDirection;

        /// <summary>
        /// 转移持仓类型
        /// </summary>
        public EnumTransferPositionTypeType TransferPositionType;

        /// <summary>
        /// 昨日仓位转移数量
        /// </summary>
        public int HistoryVolume;

        /// <summary>
        /// 今日买卖仓位转移数量
        /// </summary>
        public int TodayBSVolume;

        /// <summary>
        /// 今日申赎仓位转移数量
        /// </summary>
        public int TodayPRVolume;

        /// <summary>
        /// 转移状态
        /// </summary>
        public EnumSecurityTransferStatusType SecurityTransferStatus;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// 操作人员
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string OperatorID;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateTime;

    };

    /// <summary>
    /// 组合策略输入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputCombOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 成分1合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID1;

        /// <summary>
        /// 成分2合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID2;

        /// <summary>
        /// 成分3合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID3;

        /// <summary>
        /// 成分4合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID4;

        /// <summary>
        /// 组合策略引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombOrderRef;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 组合指令方向类型
        /// </summary>
        public EnumCombDirectionType CombDirection;

        /// <summary>
        /// 组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CombTradeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金帐号代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 组合策略
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCombOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 成分1合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID1;

        /// <summary>
        /// 成分1持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection1;

        /// <summary>
        /// 成分2合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID2;

        /// <summary>
        /// 成分2持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection2;

        /// <summary>
        /// 成分3合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID3;

        /// <summary>
        /// 成分3持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection3;

        /// <summary>
        /// 成分4合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID4;

        /// <summary>
        /// 成分4持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection4;

        /// <summary>
        /// 组合策略引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombOrderRef;

        /// <summary>
        /// 数量
        /// </summary>
        public int VolumeTotalOriginal;

        /// <summary>
        /// 成交数量
        /// </summary>
        public int VolumeTraded;

        /// <summary>
        /// 剩余数量
        /// </summary>
        public int VolumeTotal;

        /// <summary>
        /// 组合指令方向类型
        /// </summary>
        public EnumCombDirectionType CombDirection;

        /// <summary>
        /// 组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CombTradeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金帐号代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 组合策略本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombOrderLocalID;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 组合策略报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CombOrderSysID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 保证金差额
        /// </summary>
        public double MarginComponent;

        /// <summary>
        /// 保证金
        /// </summary>
        public double Margin;

        /// <summary>
        /// 报单状态
        /// </summary>
        public EnumOrderStatusType OrderStatus;

        /// <summary>
        /// 报单提交状态
        /// </summary>
        public EnumOrderSubmitStatusType OrderSubmitStatus;

        /// <summary>
        /// 营业部编码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BranchID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 操作用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;

        /// <summary>
        /// 申报日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 申报时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 撤销时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 组合策略撤单输入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputCombOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 组合策略操作引用
        /// </summary>
        public int CombOrderActionRef;

        /// <summary>
        /// 组合策略引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombOrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 组合策略报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CombOrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 组合策略撤单
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCombOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 组合策略操作引用
        /// </summary>
        public int CombOrderActionRef;

        /// <summary>
        /// 组合策略引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombOrderRef;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 组合策略报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CombOrderSysID;

        /// <summary>
        /// 操作标志
        /// </summary>
        public EnumActionFlagType ActionFlag;

        /// <summary>
        /// 操作日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;

        /// <summary>
        /// 操作时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;

        /// <summary>
        /// 交易所交易员代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;

        /// <summary>
        /// 组合策略本地报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombOrderLocalID;

        /// <summary>
        /// 操作本地编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 报单操作状态
        /// </summary>
        public EnumCancelOrderStatusType OrderActionStatus;

        /// <summary>
        /// 状态信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;

        /// <summary>
        /// IP地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;

        /// <summary>
        /// Mac地址
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;

    };

    /// <summary>
    /// 个股期权合约查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约在交易所的代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

    };

    /// <summary>
    /// 个股期权合约查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInstrumentField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;

        /// <summary>
        /// 合约交易代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;

        /// <summary>
        /// 产品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;

        /// <summary>
        /// 产品类型
        /// </summary>
        public EnumProductClassType ProductClass;

        /// <summary>
        /// 交割年份
        /// </summary>
        public int DeliveryYear;

        /// <summary>
        /// 交割月份
        /// </summary>
        public int DeliveryMonth;

        /// <summary>
        /// 市价单买最大下单量
        /// </summary>
        public int MaxMarketOrderBuyVolume;

        /// <summary>
        /// 市价单买最小下单量
        /// </summary>
        public int MinMarketOrderBuyVolume;

        /// <summary>
        /// 限价单买最大下单量
        /// </summary>
        public int MaxLimitOrderBuyVolume;

        /// <summary>
        /// 限价单买最小下单量
        /// </summary>
        public int MinLimitOrderBuyVolume;

        /// <summary>
        /// 市价单卖最大下单量
        /// </summary>
        public int MaxMarketOrderSellVolume;

        /// <summary>
        /// 市价单卖最小下单量
        /// </summary>
        public int MinMarketOrderSellVolume;

        /// <summary>
        /// 限价单卖最大下单量
        /// </summary>
        public int MaxLimitOrderSellVolume;

        /// <summary>
        /// 限价单卖最小下单量
        /// </summary>
        public int MinLimitOrderSellVolume;

        /// <summary>
        /// 合约乘数
        /// </summary>
        public int VolumeMultiple;

        /// <summary>
        /// 最小变动价位
        /// </summary>
        public double PriceTick;

        /// <summary>
        /// 创建日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;

        /// <summary>
        /// 上市日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 到期日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;

        /// <summary>
        /// 开始交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDelivDate;

        /// <summary>
        /// 结束交割日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EndDelivDate;

        /// <summary>
        /// 合约生命周期状态
        /// </summary>
        public EnumInstLifePhaseType InstLifePhase;

        /// <summary>
        /// 当前是否交易
        /// </summary>
        public int IsTrading;

        /// <summary>
        /// 持仓类型
        /// </summary>
        public EnumPositionTypeType PositionType;

        /// <summary>
        /// 持仓日期类型
        /// </summary>
        public EnumPositionDateType PositionDateType;

        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatio;

        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatio;

        /// <summary>
        /// 是否使用大额单边保证金算法
        /// </summary>
        public EnumMaxMarginSideAlgorithmType MaxMarginSideAlgorithm;

        /// <summary>
        /// 基础商品代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string UnderlyingInstrID;

        /// <summary>
        /// 执行价
        /// </summary>
        public double StrikePrice;

        /// <summary>
        /// 期权类型
        /// </summary>
        public EnumOptionsTypeType OptionsType;

        /// <summary>
        /// 合约基础商品乘数
        /// </summary>
        public int UnderlyingMultiple;

        /// <summary>
        /// 组合类型
        /// </summary>
        public EnumCombinationTypeType CombinationType;

        /// <summary>
        /// 买入交易单位
        /// </summary>
        public int BuyTradingUnit;

        /// <summary>
        /// 卖出交易单位
        /// </summary>
        public int SellTradingUnit;

    };

    /// <summary>
    /// 锁定查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLockField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 锁定编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string LockSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 锁定撤单查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLockActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 执行宣告查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExecOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 执行宣告编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 执行宣告操作查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExecOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 锁定持仓查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLockPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 锁定持仓查询相应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLockPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 冻结数量
        /// </summary>
        public int FrozenVolume;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者保证金率查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryMarginRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 保证金模板代码
        /// </summary>
        public int MarginTemplateNo;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 投资者保证金率查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcMarginRateField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 保证金模板代码
        /// </summary>
        public int MarginTemplateNo;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 多头保证金率
        /// </summary>
        public double LongMarginRatioByMoney;

        /// <summary>
        /// 多头保证金费
        /// </summary>
        public double LongMarginRatioByVolume;

        /// <summary>
        /// 空头保证金率
        /// </summary>
        public double ShortMarginRatioByMoney;

        /// <summary>
        /// 空头保证金费
        /// </summary>
        public double ShortMarginRatioByVolume;

    };

    /// <summary>
    /// 投资者买入额度查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLimitAmountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 投资者买入额度查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLimitAmountField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 多头金额限额
        /// </summary>
        public double LongAmount;

        /// <summary>
        /// 多头金额冻结
        /// </summary>
        public double LongAmountFrozen;

    };

    /// <summary>
    /// 投资者持仓限制查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLimitPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 投资者持仓限制查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLimitPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 总数量限制
        /// </summary>
        public int TotalVolume;

        /// <summary>
        /// 多头数量限制
        /// </summary>
        public int LongVolume;

        /// <summary>
        /// 当日开仓数量限制
        /// </summary>
        public int OpenVolume;

        /// <summary>
        /// 总数量冻结
        /// </summary>
        public int TotalVolumeFrozen;

        /// <summary>
        /// 多头数量冻结
        /// </summary>
        public int LongVolumeFrozen;

        /// <summary>
        /// 当日开仓数量冻结
        /// </summary>
        public int OpenVolumeFrozen;

    };

    /// <summary>
    /// 行权指派查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryExerciseAssignmentField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 行权指派查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcExerciseAssignmentField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易账户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 行权指派数量
        /// </summary>
        public int AssignmentVolume;

    };

    /// <summary>
    /// 证券报盘查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySecurityOfferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

    };

    /// <summary>
    /// 证券报盘查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcSecurityOfferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 连接系统
        /// </summary>
        public EnumConnectSystemType ConnectSystem;

        /// <summary>
        /// 连接字符串
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
        public string ConnectString;

        /// <summary>
        /// 用户名
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;

        /// <summary>
        /// 应用名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AppName;

        /// <summary>
        /// 运行ID
        /// </summary>
        public ushort RunID;

        /// <summary>
        /// 前置ID
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话ID
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 证券报盘连接状态
        /// </summary>
        public EnumConnectStatusType SoConnectStatus;

        /// <summary>
        /// 发出连接请求的日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;

        /// <summary>
        /// 发出连接请求的时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;

        /// <summary>
        /// 完成连接日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;

        /// <summary>
        /// 完成连接时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;

    };

    /// <summary>
    /// 投资者合约持仓查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者合约持仓查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorPositionField
    {
        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 持仓多空方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 持仓日期类型
        /// </summary>
        public EnumPositionDateType PositionDate;

        /// <summary>
        /// 昨日持仓
        /// </summary>
        public int YdPosition;

        /// <summary>
        /// 今日持仓
        /// </summary>
        public int Position;

        /// <summary>
        /// 多头冻结
        /// </summary>
        public int LongFrozen;

        /// <summary>
        /// 空头冻结
        /// </summary>
        public int ShortFrozen;

        /// <summary>
        /// 多头冻结金额
        /// </summary>
        public double LongFrozenAmount;

        /// <summary>
        /// 空头冻结金额
        /// </summary>
        public double ShortFrozenAmount;

        /// <summary>
        /// 开仓量
        /// </summary>
        public int OpenVolume;

        /// <summary>
        /// 平仓量
        /// </summary>
        public int CloseVolume;

        /// <summary>
        /// 开仓金额
        /// </summary>
        public double OpenAmount;

        /// <summary>
        /// 平仓金额
        /// </summary>
        public double CloseAmount;

        /// <summary>
        /// 持仓成本
        /// </summary>
        public double PositionCost;

        /// <summary>
        /// 上次占用的保证金
        /// </summary>
        public double PreMargin;

        /// <summary>
        /// 占用的保证金
        /// </summary>
        public double UseMargin;

        /// <summary>
        /// 冻结的保证金
        /// </summary>
        public double FrozenMargin;

        /// <summary>
        /// 冻结的资金
        /// </summary>
        public double FrozenCash;

        /// <summary>
        /// 冻结的手续费
        /// </summary>
        public double FrozenCommission;

        /// <summary>
        /// 资金差额
        /// </summary>
        public double CashIn;

        /// <summary>
        /// 手续费
        /// </summary>
        public double Commission;

        /// <summary>
        /// 平仓盈亏
        /// </summary>
        public double CloseProfit;

        /// <summary>
        /// 持仓盈亏
        /// </summary>
        public double PositionProfit;

        /// <summary>
        /// 上次结算价
        /// </summary>
        public double PreSettlementPrice;

        /// <summary>
        /// 本次结算价
        /// </summary>
        public double SettlementPrice;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 开仓成本
        /// </summary>
        public double OpenCost;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchangeMargin;

        /// <summary>
        /// 组合成交形成的持仓
        /// </summary>
        public int CombPosition;

        /// <summary>
        /// 组合多头冻结
        /// </summary>
        public int CombLongFrozen;

        /// <summary>
        /// 组合空头冻结
        /// </summary>
        public int CombShortFrozen;

        /// <summary>
        /// 逐日盯市平仓盈亏
        /// </summary>
        public double CloseProfitByDate;

        /// <summary>
        /// 逐笔对冲平仓盈亏
        /// </summary>
        public double CloseProfitByTrade;

        /// <summary>
        /// 今日持仓
        /// </summary>
        public int TodayPosition;

        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;

        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;

        /// <summary>
        /// 执行冻结
        /// </summary>
        public int StrikeFrozen;

        /// <summary>
        /// 执行冻结金额
        /// </summary>
        public double StrikeFrozenAmount;

        /// <summary>
        /// 放弃执行冻结
        /// </summary>
        public int AbandonFrozen;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 现券转移查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQrySecurityTransferField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 现券转移流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string SecurityTransferSerial;

    };

    /// <summary>
    /// 组合合约信息查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCombinationField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

    };

    /// <summary>
    /// 组合合约信息查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCombinationField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 组合合约名称
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string CombInstrumentName;

        /// <summary>
        /// 成分合约数
        /// </summary>
        public int NoLeges;

        /// <summary>
        /// 标的是否相同
        /// </summary>
        public EnumDataCompFlagType SameUnderlyingFlag;

        /// <summary>
        /// 到期日是否相同
        /// </summary>
        public EnumDataCompFlagType SameExpireDateFlag;

        /// <summary>
        /// 合约单位是否相同
        /// </summary>
        public EnumDataCompFlagType SameUnderlyingMultipleFlag;

        /// <summary>
        /// 组合策略自动解除天数
        /// </summary>
        public int AutoSplitDay;

        /// <summary>
        /// 组合类型
        /// </summary>
        public EnumCombinationTypeType CombinationType;

        /// <summary>
        /// 组合保证金算法
        /// </summary>
        public EnumCombMarginAlgoType CombMarginAlgo;

    };

    /// <summary>
    /// 组合合约分腿信息查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCombinationLegField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;

    };

    /// <summary>
    /// 组合合约分腿信息查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCombinationLegField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;

        /// <summary>
        /// 单腿合约类型
        /// </summary>
        public EnumOptionsTypeType LegOptionsType;

        /// <summary>
        /// 单腿持仓方向
        /// </summary>
        public EnumPosiDirectionType LegPosiDirection;

        /// <summary>
        /// 单腿行权价顺序号
        /// </summary>
        public int LegExecPriceSeq;

        /// <summary>
        /// 单腿到期日顺序号
        /// </summary>
        public int LegExpireDateSeq;

        /// <summary>
        /// 单腿乘数
        /// </summary>
        public int LegMultiple;

    };

    /// <summary>
    /// 组合策略报单查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCombOrderField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 组合策略报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CombOrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 组合策略报单操作查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCombOrderActionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

    };

    /// <summary>
    /// 投资者组合持仓明细查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryInvestorPositionCombineDetailField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CombTradeID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 投资者组合持仓明细查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInvestorPositionCombineDetailField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 开仓日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 结算编号
        /// </summary>
        public int SettlementID;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 组合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CombTradeID;

        /// <summary>
        /// 撮合编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 投机套保标志
        /// </summary>
        public EnumHedgeFlagType HedgeFlag;

        /// <summary>
        /// 买卖方向
        /// </summary>
        public EnumDirectionType Direction;

        /// <summary>
        /// 持仓量
        /// </summary>
        public int TotalAmt;

        /// <summary>
        /// 投资者保证金
        /// </summary>
        public double Margin;

        /// <summary>
        /// 交易所保证金
        /// </summary>
        public double ExchMargin;

        /// <summary>
        /// 保证金率
        /// </summary>
        public double MarginRateByMoney;

        /// <summary>
        /// 保证金率(按手数)
        /// </summary>
        public double MarginRateByVolume;

        /// <summary>
        /// 单腿编号
        /// </summary>
        public int LegID;

        /// <summary>
        /// 单腿乘数
        /// </summary>
        public int LegMultiple;

        /// <summary>
        /// 组合合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;

        /// <summary>
        /// 成交组号
        /// </summary>
        public int TradeGroupID;

        /// <summary>
        /// 持仓方向
        /// </summary>
        public EnumPosiDirectionType PosiDirection;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 上市开放式基金信息查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLOFInfoField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 基金代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string FundID;

    };

    /// <summary>
    /// 上市开放式基金信息查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLOFInfoField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 基金代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string FundID;

        /// <summary>
        /// 基金类型
        /// </summary>
        public EnumFundTypeType FundTypeID;

        /// <summary>
        /// 拆分合并交易单位
        /// </summary>
        public int SMTradingUnit;

        /// <summary>
        /// 母基金转换系数
        /// </summary>
        public int MasterRatio;

        /// <summary>
        /// 拆分申报最小数量
        /// </summary>
        public int SplitVolMin;

        /// <summary>
        /// 合并申报最小数量
        /// </summary>
        public int MergeVolMin;

        /// <summary>
        /// 是否允许申购
        /// </summary>
        public int IsSupportPur;

        /// <summary>
        /// 是否允许赎回
        /// </summary>
        public int IsSupportRed;

        /// <summary>
        /// 是否允许拆分
        /// </summary>
        public int IsSupportSplit;

        /// <summary>
        /// 是否允许合并
        /// </summary>
        public int IsSupportMerge;

    };

    /// <summary>
    /// 上市开放式基金子基金信息查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryLOFSubInfoField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 母基金代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MasterFundID;

        /// <summary>
        /// 子基金代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string SubFundID;

    };

    /// <summary>
    /// 上市开放式基金子基金信息查询响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcLOFSubInfoField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 母基金代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MasterFundID;

        /// <summary>
        /// 子基金代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string SubFundID;

        /// <summary>
        /// 子份额转换系数
        /// </summary>
        public int SubRatio;

    };

    /// <summary>
    /// 融资融券直接还款录入
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcInputCashRepayField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 直接还款引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CROrderRef;

        /// <summary>
        /// 资金帐号代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 申报还款金额
        /// </summary>
        public double Amount;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

    };

    /// <summary>
    /// 融资融券直接还款
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCashRepayField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 直接还款引用
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CROrderRef;

        /// <summary>
        /// 资金帐号代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

        /// <summary>
        /// 申报还款金额
        /// </summary>
        public double Amount;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 请求编号
        /// </summary>
        public int RequestID;

        /// <summary>
        /// 实际还款金额
        /// </summary>
        public double RepaidAmount;

        /// <summary>
        /// 用户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;

        /// <summary>
        /// 直接还款报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CROrderSysID;

        /// <summary>
        /// 前置编号
        /// </summary>
        public int FrontID;

        /// <summary>
        /// 会话编号
        /// </summary>
        public int SessionID;

        /// <summary>
        /// 申报日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;

        /// <summary>
        /// 申报时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;

        /// <summary>
        /// 用户端产品信息
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;

    };

    /// <summary>
    /// 直接还款查询
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCashRepayField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 直接还款报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CROrderSysID;

        /// <summary>
        /// 开始时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;

        /// <summary>
        /// 结束时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

    };

    /// <summary>
    /// 查询投资者融资融券信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCreditInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 查询投资者融资融券信息响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCreditInfoField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 授信总额度
        /// </summary>
        public double CreditAmount;

        /// <summary>
        /// 融资额度上限
        /// </summary>
        public double MarginBuyLimitAmount;

        /// <summary>
        /// 融资买入金额
        /// </summary>
        public double MarginBuyAmount;

        /// <summary>
        /// 融资买入未成交金额
        /// </summary>
        public double NoTradeMarginBuyAmount;

        /// <summary>
        /// 融资冻结保证金
        /// </summary>
        public double MarginBuyFrozenMargin;

        /// <summary>
        /// 融资买入利息
        /// </summary>
        public double MarginBuyInterest;

        /// <summary>
        /// 融券额度上限
        /// </summary>
        public double ShortSellLimitAmount;

        /// <summary>
        /// 融券卖出金额
        /// </summary>
        public double ShortSellAmount;

        /// <summary>
        /// 融券卖出未成交金额
        /// </summary>
        public double NoTradeShortSellAmount;

        /// <summary>
        /// 融券冻结保证金
        /// </summary>
        public double ShortSellFrozenMargin;

        /// <summary>
        /// 融券卖出利息
        /// </summary>
        public double ShortSellInterest;

    };

    /// <summary>
    /// 查询投资者融资融券可用证券头寸
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCreditSecurityPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 头寸类型
        /// </summary>
        public EnumCreditPositionTypeType CreditPositionType;

    };

    /// <summary>
    /// 查询投资者融资融券可用证券头寸响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCreditSecurityPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 头寸编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string PositionGroupID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 头寸类型
        /// </summary>
        public EnumCreditPositionTypeType CreditPositionType;

        /// <summary>
        /// 可用数量
        /// </summary>
        public int Volume;

    };

    /// <summary>
    /// 请求查询投资者信用合约
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCreditContractField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

    };

    /// <summary>
    /// 请求查询投资者信用合约响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCreditContractField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 信用合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CreditContractID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 开仓日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;

        /// <summary>
        /// 到期日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;

        /// <summary>
        /// 信用合约类型
        /// </summary>
        public EnumCreditContractTypeType CreditContractType;

        /// <summary>
        /// 成交均价
        /// </summary>
        public double AveragePrice;

        /// <summary>
        /// 数量
        /// </summary>
        public double Volume;

        /// <summary>
        /// 金额
        /// </summary>
        public double Amount;

        /// <summary>
        /// 未偿还数量
        /// </summary>
        public double LeavesVolume;

        /// <summary>
        /// 未偿还金额
        /// </summary>
        public double LeavesAmount;

        /// <summary>
        /// 未结利息
        /// </summary>
        public double LeavesInterest;

        /// <summary>
        /// 未结交易费用
        /// </summary>
        public double LeavesFee;

        /// <summary>
        /// 信用合约状态
        /// </summary>
        public EnumCreditContractStatusType CreditContractStatus;

        /// <summary>
        /// 头寸类型
        /// </summary>
        public EnumCreditPositionTypeType CreditPositionType;

    };

    /// <summary>
    /// 请求查询投资者融资融券偿还明细
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCreditRepaymentField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 信用合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CreditContractID;

    };

    /// <summary>
    /// 请求查询投资者融资融券偿还明细响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCreditRepaymentField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 信用合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CreditContractID;

        /// <summary>
        /// 偿还流水号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string RepaymentID;

        /// <summary>
        /// 报单编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;

        /// <summary>
        /// 偿还金额
        /// </summary>
        public double RepaidAmount;

        /// <summary>
        /// 偿还数量
        /// </summary>
        public double RepaidVolume;

        /// <summary>
        /// 偿还交易费用
        /// </summary>
        public double RepaidFee;

        /// <summary>
        /// 偿还利息
        /// </summary>
        public double RepaidInterest;

    };

    /// <summary>
    /// 请求查询投资者融资融券标的证券信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCreditUnderlyingField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 请求查询投资者融资融券标的证券信息响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCreditUnderlyingField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 可否融资
        /// </summary>
        public int IsMarginBuy;

        /// <summary>
        /// 可否融券
        /// </summary>
        public int IsShortSell;

        /// <summary>
        /// 融资保证金率
        /// </summary>
        public double MarginBuyRate;

        /// <summary>
        /// 融券保证金率
        /// </summary>
        public double ShortSellRate;

    };

    /// <summary>
    /// 请求查询投资者融资融券担保证券信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCreditCollateralField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 请求查询投资者融资融券担保证券信息响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCreditCollateralField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 是否担保品
        /// </summary>
        public int IsCollateral;

        /// <summary>
        /// 担保品折算率
        /// </summary>
        public double CollateralConversionRate;

    };

    /// <summary>
    /// 请求查询投资者融资融券可用资金头寸
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCreditFundPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 头寸类型
        /// </summary>
        public EnumCreditPositionTypeType CreditPositionType;

    };

    /// <summary>
    /// 请求查询投资者融资融券可用资金头寸响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCreditFundPositionField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 头寸编号
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string PositionGroupID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 头寸类型
        /// </summary>
        public EnumCreditPositionTypeType CreditPositionType;

        /// <summary>
        /// 可用资金
        /// </summary>
        public double Amount;

    };

    /// <summary>
    /// 请求查询经纪公司余券信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcQryCreditRemainField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

    };

    /// <summary>
    /// 请求查询经纪公司余券信息响应
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcCreditRemainField
    {
        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 客户代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;

        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 合约代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;

        /// <summary>
        /// 需返还数量
        /// </summary>
        public int Volume;

        /// <summary>
        /// 已返还数量
        /// </summary>
        public int ReturnedVolume;

    };

    /// <summary>
    /// 交易通知
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingNoticeField
    {
        /// <summary>
        /// 经纪公司代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;

        /// <summary>
        /// 投资者代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;

        /// <summary>
        /// 发送日期
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendDate;

        /// <summary>
        /// 发送时间
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;

        /// <summary>
        /// 消息正文
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;

        /// <summary>
        /// 序列系列号
        /// </summary>
        public ushort SequenceSeries;

        /// <summary>
        /// 序列号
        /// </summary>
        public int SequenceNo;

        /// <summary>
        /// 投资单元代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;

        /// <summary>
        /// 资金账户
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;

    };

    /// <summary>
    /// 交易日
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ThostFtdcTradingDayField
    {
        /// <summary>
        /// 交易所代码
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;

        /// <summary>
        /// 交易日
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;

    };

}; // end of namespace
