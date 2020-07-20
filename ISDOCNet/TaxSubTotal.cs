namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TaxSubTotal
    {

        #region Private fields
        private decimal? _taxableAmountCurr;

        private decimal? _taxableAmount;

        private decimal? _taxAmountCurr;

        private decimal? _taxAmount;

        private decimal? _taxInclusiveAmountCurr;

        private decimal? _taxInclusiveAmount;

        private decimal? _alreadyClaimedTaxableAmountCurr;

        private decimal? _alreadyClaimedTaxableAmount;

        private decimal? _alreadyClaimedTaxAmountCurr;

        private decimal? _alreadyClaimedTaxAmount;

        private decimal? _alreadyClaimedTaxInclusiveAmountCurr;

        private decimal? _alreadyClaimedTaxInclusiveAmount;

        private decimal? _differenceTaxableAmountCurr;

        private decimal? _differenceTaxableAmount;

        private decimal? _differenceTaxAmountCurr;

        private decimal? _differenceTaxAmount;

        private decimal? _differenceTaxInclusiveAmountCurr;

        private decimal? _differenceTaxInclusiveAmount;

        private TaxCategory _taxCategory;
        #endregion

        public TaxSubTotal()
        {
            //this._taxCategory = new TaxCategory();
        }

        public bool ShouldSerializeTaxableAmountCurr()
        {
            return _taxableAmountCurr != null;
        }

        public decimal? TaxableAmountCurr
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

        public bool ShouldSerializeTaxableAmount()
        {
            return _taxableAmount != null;
        }

        public decimal? TaxableAmount
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

        public bool ShouldSerializeTaxAmountCurr()
        {
            return _taxAmountCurr != null;
        }

        public decimal? TaxAmountCurr
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

        public bool ShouldSerializeTaxAmount()
        {
            return _taxAmount != null;
        }

        public decimal? TaxAmount
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

        public bool ShouldSerializeTaxInclusiveAmountCurr()
        {
            return _taxInclusiveAmountCurr != null;
        }

        public decimal? TaxInclusiveAmountCurr
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

        public bool ShouldSerializeTaxInclusiveAmount()
        {
            return _taxInclusiveAmount != null;
        }

        public decimal? TaxInclusiveAmount
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

        public bool ShouldSerializeAlreadyClaimedTaxableAmountCurr()
        {
            return _alreadyClaimedTaxableAmountCurr != null;
        }

        public decimal? AlreadyClaimedTaxableAmountCurr
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

        public bool ShouldSerializeAlreadyClaimedTaxableAmount()
        {
            return _alreadyClaimedTaxableAmount != null;
        }

        public decimal? AlreadyClaimedTaxableAmount
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
        public bool ShouldSerializeAlreadyClaimedTaxAmountCurr()
        {
            return _alreadyClaimedTaxAmountCurr != null;
        }

        public decimal? AlreadyClaimedTaxAmountCurr
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

        public bool ShouldSerializeAlreadyClaimedTaxAmount()
        {
            return _alreadyClaimedTaxAmount != null;
        }

        public decimal? AlreadyClaimedTaxAmount
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

        public bool ShouldSerializeAlreadyClaimedTaxInclusiveAmountCurr()
        {
            return _alreadyClaimedTaxInclusiveAmountCurr != null;
        }

        public decimal? AlreadyClaimedTaxInclusiveAmountCurr
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

        public bool ShouldSerializeAlreadyClaimedTaxInclusiveAmount()
        {
            return _alreadyClaimedTaxInclusiveAmount != null;
        }

        public decimal? AlreadyClaimedTaxInclusiveAmount
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

        public bool ShouldSerializeDifferenceTaxableAmountCurr()
        {
            return _differenceTaxableAmountCurr != null;
        }

        public decimal? DifferenceTaxableAmountCurr
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

        public bool ShouldSerializeDifferenceTaxableAmount()
        {
            return _differenceTaxableAmount != null; ;
        }

        public decimal? DifferenceTaxableAmount
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

        public bool ShouldSerializeDifferenceTaxAmountCurr()
        {
            return _differenceTaxAmountCurr != null;
        }

        public decimal? DifferenceTaxAmountCurr
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

        public bool ShouldSerializeDifferenceTaxAmount()
        {
            return _differenceTaxAmount != null;
        }

        public decimal? DifferenceTaxAmount
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

        public bool ShouldSerializeDifferenceTaxInclusiveAmountCurr()
        {
            return _differenceTaxInclusiveAmountCurr != null;
        }

        public decimal? DifferenceTaxInclusiveAmountCurr
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

        public bool ShouldSerializeDifferenceTaxInclusiveAmount()
        {
            return _differenceTaxInclusiveAmount != null;
        }

        public decimal? DifferenceTaxInclusiveAmount
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

        public bool ShouldSerializeTaxCategory()
        {
            return _taxCategory != null;
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
