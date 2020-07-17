namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class AlternateBankAccount
    {

        #region Private fields
        private string _id;

        private string _bankCode;

        private string _name;

        private string _iBAN;

        private string _bIC;
        #endregion

        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string BankCode
        {
            get
            {
                return this._bankCode;
            }
            set
            {
                this._bankCode = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string IBAN
        {
            get
            {
                return this._iBAN;
            }
            set
            {
                this._iBAN = value;
            }
        }

        public string BIC
        {
            get
            {
                return this._bIC;
            }
            set
            {
                this._bIC = value;
            }
        }
    }
}
