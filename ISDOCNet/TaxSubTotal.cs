namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TaxSubTotal
    {

        #region Private fields
        private decimal _taxableAmountCurr;

        private decimal _taxableAmount;

        private decimal _taxAmountCurr;

        private decimal _taxAmount;

        private decimal _taxInclusiveAmountCurr;

        private decimal _taxInclusiveAmount;

        private decimal _alreadyClaimedTaxableAmountCurr;

        private decimal _alreadyClaimedTaxableAmount;

        private decimal _alreadyClaimedTaxAmountCurr;

        private decimal _alreadyClaimedTaxAmount;

        private decimal _alreadyClaimedTaxInclusiveAmountCurr;

        private decimal _alreadyClaimedTaxInclusiveAmount;

        private decimal _differenceTaxableAmountCurr;

        private decimal _differenceTaxableAmount;

        private decimal _differenceTaxAmountCurr;

        private decimal _differenceTaxAmount;

        private decimal _differenceTaxInclusiveAmountCurr;

        private decimal _differenceTaxInclusiveAmount;

        private TaxCategory _taxCategory;
        #endregion

        public TaxSubTotal()
        {
            this._taxCategory = new TaxCategory();
        }

        public decimal TaxableAmountCurr
        {
            get
            {
                return this._taxableAmountCurr;
            }
            set
            {
                this._taxableAmountCurr = value;
            }
        }

        public decimal TaxableAmount
        {
            get
            {
                return this._taxableAmount;
            }
            set
            {
                this._taxableAmount = value;
            }
        }

        public decimal TaxAmountCurr
        {
            get
            {
                return this._taxAmountCurr;
            }
            set
            {
                this._taxAmountCurr = value;
            }
        }

        public decimal TaxAmount
        {
            get
            {
                return this._taxAmount;
            }
            set
            {
                this._taxAmount = value;
            }
        }

        public decimal TaxInclusiveAmountCurr
        {
            get
            {
                return this._taxInclusiveAmountCurr;
            }
            set
            {
                this._taxInclusiveAmountCurr = value;
            }
        }

        public decimal TaxInclusiveAmount
        {
            get
            {
                return this._taxInclusiveAmount;
            }
            set
            {
                this._taxInclusiveAmount = value;
            }
        }

        public decimal AlreadyClaimedTaxableAmountCurr
        {
            get
            {
                return this._alreadyClaimedTaxableAmountCurr;
            }
            set
            {
                this._alreadyClaimedTaxableAmountCurr = value;
            }
        }

        public decimal AlreadyClaimedTaxableAmount
        {
            get
            {
                return this._alreadyClaimedTaxableAmount;
            }
            set
            {
                this._alreadyClaimedTaxableAmount = value;
            }
        }

        public decimal AlreadyClaimedTaxAmountCurr
        {
            get
            {
                return this._alreadyClaimedTaxAmountCurr;
            }
            set
            {
                this._alreadyClaimedTaxAmountCurr = value;
            }
        }

        public decimal AlreadyClaimedTaxAmount
        {
            get
            {
                return this._alreadyClaimedTaxAmount;
            }
            set
            {
                this._alreadyClaimedTaxAmount = value;
            }
        }

        public decimal AlreadyClaimedTaxInclusiveAmountCurr
        {
            get
            {
                return this._alreadyClaimedTaxInclusiveAmountCurr;
            }
            set
            {
                this._alreadyClaimedTaxInclusiveAmountCurr = value;
            }
        }

        public decimal AlreadyClaimedTaxInclusiveAmount
        {
            get
            {
                return this._alreadyClaimedTaxInclusiveAmount;
            }
            set
            {
                this._alreadyClaimedTaxInclusiveAmount = value;
            }
        }

        public decimal DifferenceTaxableAmountCurr
        {
            get
            {
                return this._differenceTaxableAmountCurr;
            }
            set
            {
                this._differenceTaxableAmountCurr = value;
            }
        }

        public decimal DifferenceTaxableAmount
        {
            get
            {
                return this._differenceTaxableAmount;
            }
            set
            {
                this._differenceTaxableAmount = value;
            }
        }

        public decimal DifferenceTaxAmountCurr
        {
            get
            {
                return this._differenceTaxAmountCurr;
            }
            set
            {
                this._differenceTaxAmountCurr = value;
            }
        }

        public decimal DifferenceTaxAmount
        {
            get
            {
                return this._differenceTaxAmount;
            }
            set
            {
                this._differenceTaxAmount = value;
            }
        }

        public decimal DifferenceTaxInclusiveAmountCurr
        {
            get
            {
                return this._differenceTaxInclusiveAmountCurr;
            }
            set
            {
                this._differenceTaxInclusiveAmountCurr = value;
            }
        }

        public decimal DifferenceTaxInclusiveAmount
        {
            get
            {
                return this._differenceTaxInclusiveAmount;
            }
            set
            {
                this._differenceTaxInclusiveAmount = value;
            }
        }

        public TaxCategory TaxCategory
        {
            get
            {
                return this._taxCategory;
            }
            set
            {
                this._taxCategory = value;
            }
        }
    }
}
