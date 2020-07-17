namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TaxedDeposit
    {

        #region Private fields
        private string _id;

        private string _variableSymbol;

        private decimal _taxableDepositAmountCurr;

        private decimal _taxableDepositAmount;

        private decimal _taxInclusiveDepositAmountCurr;

        private decimal _taxInclusiveDepositAmount;

        private ClassifiedTaxCategory _classifiedTaxCategory;
        #endregion

        public TaxedDeposit()
        {
            this._classifiedTaxCategory = new ClassifiedTaxCategory();
        }

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

        public decimal TaxableDepositAmountCurr
        {
            get
            {
                return this._taxableDepositAmountCurr;
            }
            set
            {
                this._taxableDepositAmountCurr = value;
            }
        }

        public decimal TaxableDepositAmount
        {
            get
            {
                return this._taxableDepositAmount;
            }
            set
            {
                this._taxableDepositAmount = value;
            }
        }

        public decimal TaxInclusiveDepositAmountCurr
        {
            get
            {
                return this._taxInclusiveDepositAmountCurr;
            }
            set
            {
                this._taxInclusiveDepositAmountCurr = value;
            }
        }

        public decimal TaxInclusiveDepositAmount
        {
            get
            {
                return this._taxInclusiveDepositAmount;
            }
            set
            {
                this._taxInclusiveDepositAmount = value;
            }
        }

        public ClassifiedTaxCategory ClassifiedTaxCategory
        {
            get
            {
                return this._classifiedTaxCategory;
            }
            set
            {
                this._classifiedTaxCategory = value;
            }
        }
    }
}
