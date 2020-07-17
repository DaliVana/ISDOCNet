namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class NonTaxedDeposit
    {

        #region Private fields
        private string _id;

        private string _variableSymbol;

        private decimal _depositAmountCurr;

        private decimal _depositAmount;
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

        public string VariableSymbol
        {
            get
            {
                return this._variableSymbol;
            }
            set
            {
                this._variableSymbol = value;
            }
        }

        public decimal DepositAmountCurr
        {
            get
            {
                return this._depositAmountCurr;
            }
            set
            {
                this._depositAmountCurr = value;
            }
        }

        public decimal DepositAmount
        {
            get
            {
                return this._depositAmount;
            }
            set
            {
                this._depositAmount = value;
            }
        }
    }
}
