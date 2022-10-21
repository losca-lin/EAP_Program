using System;
using System.Collections.Generic;

namespace Getech.EAP.Entity
{
    public class FLSWebMessageCheckinfo
    {
        private string _lineName = string.Empty;
        private string _machineName = string.Empty;
        private string _portName = string.Empty;
        private string _carrierName = string.Empty;
        private string _timeKey = string.Empty;
        private bool _isFinish;
        private bool _isSend;
        public string MachineName
        {
            get { return _machineName; }
            set { _machineName = value; }
        }
        public string CarrierName
        {
            get { return _carrierName; }
            set { _carrierName = value; }
        }
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }
        public string TrxKey
        {
            get { return _timeKey; }
            set { _timeKey = value; }
        }
        public bool IsSend
        {
            get { return _isSend; }
            set { _isSend = value; }
        }
        public bool IsFinish
        {
            get { return _isFinish; }
            set { _isFinish = value; }
        }
        
        private DateTime _createTime = DateTime.Now;   

        public List<FLSWebMessageCheckinfo> FLSCommandCheckinfolist { get; set; }
       
        public string lineName
        {
            get { return _lineName; }
            set { _lineName = value; }
        }

        public DateTime CreateTime
        {
            get { return _createTime; }
            set { _createTime = value; }
        }

        public FLSWebMessageCheckinfo(string machineid, string portname, string carriername, string trxid, bool send = false, bool finish = false)
        {
            _machineName = machineid;
            _portName = portname;
            _carrierName = carriername;
            _timeKey = trxid;
            _isSend = send;
            _isFinish = finish;
        }
    }
    public class FLSWebMessageReceive
    {
        private string _trxID;

        private bool _isFinish = false;

        private bool _isSend = false;

        public bool IsSend
        {
            get { return _isSend; }
            set { _isSend = value; }
        }

        public bool IsFinish
        {
            get { return _isFinish; }
            set { _isFinish = value; }
        }

        public string TrxID
        {
            get { return _trxID; }
            set { _trxID = value; }
        }
        public FLSWebMessageReceive(string trxId,string machinname,string portname,string linename)
        {
            _trxID = trxId;
            _trxID = machinname;
            _trxID = portname;
            _trxID = linename;
        }
    }
}
