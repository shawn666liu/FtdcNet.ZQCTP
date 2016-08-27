using ZQCTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        FtdcMdAdapter DataApi;
        FtdcTdAdapter TraderApi;

        int iRequestID = 0;

        string TD_FRONT_ADDR = "tcp://101.95.178.226:22701";
        string MD_FRONT_ADDR = "tcp://101.95.178.226:22721";
        string BrokerID = "0001";
        string AuthCode = "xyzq";
        string UserProductInfo = "xyzq";

        public Form1()
        {
            InitializeComponent();

            this.Disposed += Form1_Disposed;
        }

        void Form1_Disposed(object sender, EventArgs e)
        {
            if (DataApi != null)
                DataApi.Dispose();
            if (TraderApi != null)
                TraderApi.Dispose();
        }

        void DataApi_OnRtnEvent(object sender, OnRtnEventArgs e)
        {
            //Console.WriteLine("DataApi_OnRtnEvent " + e.EventType.ToString());

            var fld = Conv.P2S<ThostFtdcDepthMarketDataField>(e.Param);

            Console.WriteLine("{0}.{1:D3} {2} {3}", fld.UpdateTime, fld.UpdateMillisec, fld.InstrumentID, fld.LastPrice);
        }

        void DataApi_OnRspEvent(object sender, OnRspEventArgs e)
        {
            Console.WriteLine("DataApi_OnRspEvent " + e.EventType.ToString());
            bool err = IsError(e.RspInfo, e.EventType.ToString());

            switch (e.EventType)
            {
                case EnumOnRspType.OnRspUserLogin:
                    if (!err)
                        Console.WriteLine("登录成功");
                    break;
                case EnumOnRspType.OnRspSubMarketData:
                    {
                        var f = Conv.P2S<ThostFtdcSpecificInstrumentField>(e.Param);
                        Console.WriteLine("订阅成功:" + f.InstrumentID);
                    }
                    break;
                case EnumOnRspType.OnRspUnSubMarketData:
                    {
                        var f = Conv.P2S<ThostFtdcSpecificInstrumentField>(e.Param);
                        Console.WriteLine("退订成功:" + f.InstrumentID);
                    }
                    break;
            }
        }

        void DataApi_OnFrontEvent(object sender, OnFrontEventArgs e)
        {
            Console.WriteLine("=====> " + e.EventType);

            switch (e.EventType)
            {
                case EnumOnFrontType.OnFrontConnected:
                    {
                        MdReqUserLogin();
                    }
                    break;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataApi == null)
            {
                if (CheckInput() == false)
                    return;

                DataApi = new FtdcMdAdapter("", false);
                DataApi.OnFrontEvent += DataApi_OnFrontEvent;
                DataApi.OnRspEvent += DataApi_OnRspEvent;
                DataApi.OnRtnEvent += DataApi_OnRtnEvent;

                DataApi.RegisterFront(MD_FRONT_ADDR);
                DataApi.Init();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> inst = new List<string>();
            inst.Add("600000");
            inst.Add("600004");
            inst.Add("600005");
            inst.Add("600018");
            if (DataApi != null)
                DataApi.SubscribeMarketData(inst.ToArray(), "SSE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataApi != null)
            {
                DataApi.Dispose();
                DataApi = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DataApi != null)
            {
                DataApi.UnSubscribeMarketData(new string[] { "600000", "600005" }, "SSE");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TraderApi == null)
            {
                if (CheckInput() == false)
                    return;

                TraderApi = new FtdcTdAdapter("", false);
                TraderApi.OnFrontEvent += TraderApi_OnFrontEvent;
                TraderApi.OnRspEvent += TraderApi_OnRspEvent;
                TraderApi.OnRtnEvent += TraderApi_OnRtnEvent;
                TraderApi.OnErrRtnEvent += TraderApi_OnErrRtnEvent;
                TraderApi.SubscribePublicTopic(EnumTeResumeType.THOST_TERT_QUICK);
                TraderApi.SubscribePrivateTopic(EnumTeResumeType.THOST_TERT_QUICK);
                TraderApi.RegisterFront(TD_FRONT_ADDR);
                TraderApi.Init();
            }
        }

        bool IsError(ThostFtdcRspInfoField rspinfo, string source)
        {
            if (rspinfo != null && rspinfo.ErrorID != 0)
            {
                Console.WriteLine(rspinfo.ErrorMsg + ", 来源 " + source);
                return true;
            }
            return false;
        }

        void TraderApi_OnErrRtnEvent(object sender, OnErrRtnEventArgs e)
        {
            Console.WriteLine("=====> " + e.EventType);
        }

        void TraderApi_OnRtnEvent(object sender, OnRtnEventArgs e)
        {
            Console.WriteLine("=====> " + e.EventType);
        }

        void TraderApi_OnRspEvent(object sender, OnRspEventArgs e)
        {
            Console.WriteLine("=====> " + e.EventType);

            bool err = IsError(e.RspInfo, e.EventType.ToString());

            switch (e.EventType)
            {
                case EnumOnRspType.OnRspAuthenticate:
                    {
                        TdReqUserLogin();
                    }
                    break;
                case EnumOnRspType.OnRspUserLogin:
                    if (!err)
                    {
                        Console.WriteLine("登录成功");
                        var fld = Conv.P2S<ThostFtdcRspUserLoginField>(e.Param);
                        Console.WriteLine("FrontID {0}, SessionID {1} ", fld.FrontID, fld.SessionID);
                    }
                    break;
                case EnumOnRspType.OnRspQryInstrument:
                    if (e.Param != IntPtr.Zero)
                    {
                        var fld = Conv.P2S<ThostFtdcInstrumentField>(e.Param);
                        Console.WriteLine("=====> {0}, {1},  isLast {2}", e.EventType, fld.InstrumentID, e.IsLast);
                    }
                    break;
            }
        }

        void TraderApi_OnFrontEvent(object sender, OnFrontEventArgs e)
        {
            Console.WriteLine("=====> " + e.EventType);

            switch (e.EventType)
            {
                case EnumOnFrontType.OnFrontConnected:
                    {
                        ReqAuthenticate();
                    }
                    break;
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            if (TraderApi != null)
            {
                TraderApi.Dispose();
                TraderApi = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TraderApi != null)
            {
                var req = new ThostFtdcQryInstrumentField();
                req.InstrumentID = "600018";
                req.ExchangeID = "SSE";
                TraderApi.ReqQryInstrument(req, ++this.iRequestID);
            }
        }

        private void ReqAuthenticate()
        {
            var req = new ThostFtdcReqAuthenticateField();
            req.BrokerID = BrokerID;
            req.UserID = this.textBox1.Text;
            req.AuthCode = AuthCode;
            req.UserProductInfo = UserProductInfo;
            int iResult = TraderApi.ReqAuthenticate(req, ++iRequestID);
        }

        private void TdReqUserLogin()
        {
            var req = new ThostFtdcReqUserLoginField();
            req.BrokerID = BrokerID;
            req.UserID = this.textBox1.Text;
            req.Password = this.textBox2.Text;
            TraderApi.ReqUserLogin(req, ++iRequestID);
        }

        private void MdReqUserLogin()
        {
            var req = new ThostFtdcReqUserLoginField();
            req.BrokerID = BrokerID;
            req.UserID = this.textBox1.Text;
            req.Password = this.textBox2.Text;
            DataApi.ReqUserLogin(req, ++iRequestID);
        }

        private bool CheckInput()
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("请输入用户名和密码");
                return false;
            }
            return true;
        }
    }
}
