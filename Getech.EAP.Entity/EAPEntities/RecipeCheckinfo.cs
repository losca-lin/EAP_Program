using System;
using System.Collections.Generic;

namespace Getech.EAP.Entity
{
    public enum eRecipeCheckResult
    {
        OK,
        NG,
        CIMOFF,
        TIMEOUT,
        ZERO,
        NOCHECK,
    }

    public enum eRecipeCheckCommandType
    {
        BCS,
        MES,
        OPI,
    }

    public enum eRecipeCheckCommandState
    {
        WaitForEQ,
        WaitForMES,
        Finish,
    }

    public enum eModifyFlag
    {
        Create = 1,
        Modify = 2,
        Delete = 3
    }
    public class RecipeCheckInfo
    {
        private string _machineno = string.Empty;
        private string _machineid = string.Empty;
        private string _portid = string.Empty;
        private string _carriername = string.Empty;

        public string MachineID
        {
            get { return _machineid; }
            set { _machineid = value; }
        }
        private bool _isFinish;
        private bool _isSend;
        private string _recipeID;
        private string _recipeNo;
        private DateTime _createTime = DateTime.Now;
        private string _mode;//Auto Manual;
        private string _portNo;
        private string _trxId;
        private string _lineRecipeName;
        private string _eventcomment;
        private string _recipeVersiom;
        public string LineRecipeName
        {
            get { return _lineRecipeName; }
            set { _lineRecipeName = value; }
        }

        private eRecipeCheckResult _result = eRecipeCheckResult.NG;

        public List<RecipeparameterInfo> recipeparameterinfolist { get; set; }
        public string lineName { get; set; }
        public string MachineNo
        {
            get { return _machineno; }
            set { _machineno = value; }
        }
        public bool IsSend
        {
            get { return _isSend; }
            set { _isSend = value; }
        }

        public string Carriername
        {
            get { return _carriername; }
            set { _carriername = value; }
        }

        public bool IsFinish
        {
            get { return _isFinish; }
            set { _isFinish = value; }
        }

        public string EventComment
        {
            get { return _eventcomment; }
            set { _eventcomment = value; }
        }

        public string RecipeID
        {
            get { return _recipeID; }
            set { _recipeID = value; }
        }

        public string Portid
        {
            get { return _portid; }
            set { _portid = value; }
        }

        public string RecipeNo
        {
            get { return _recipeNo; }
            set { _recipeNo = value; }
        }

        public DateTime CreateTime
        {
            get { return _createTime; }
            set { _createTime = value; }
        }

        public string Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }
        public string PortNo
        {
            get { return _portNo; }
            set { _portNo = value; }
        }
        public string TrxId
        {
            get { return _trxId; }
            set { _trxId = value; }
        }
        public string RecipeVersion
        {
            get { return _recipeVersiom; }
            set { _recipeVersiom = value; }
        }

        public eRecipeCheckResult Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public RecipeCheckInfo(string machineid, string portNo, string recipeID, string recipename, bool send = false, bool finish = false)
        {
            _machineid = machineid;
            _recipeID = recipeID;
            _isSend = send;
            _isFinish = finish;
            _portNo = portNo;
            _lineRecipeName = recipename;
        }
    }

    public class RecipeCheckCommand
    {
        private string _trxID;
        private eRecipeCheckCommandType _commandType;

        private eRecipeCheckResult _result = eRecipeCheckResult.NG;

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

        public eRecipeCheckResult Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public string TrxID
        {
            get { return _trxID; }
            set { _trxID = value; }
        }
        public eRecipeCheckCommandType CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }
        public RecipeCheckCommand(string trxId, eRecipeCheckCommandType commandType)
        {
            _trxID = trxId;
            _commandType = commandType;
        }
        public override string ToString()
        {
            return string.Format("TrxID={0},Command Type={1}.", _trxID, _commandType.ToString());
        }
    }
}
