namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class LegalMonetaryTotal
    {

        #region Private fields
        private decimal? _taxExclusiveAmount;

        private decimal? _taxExclusiveAmountCurr;

        private decimal? _taxInclusiveAmount;

        private decimal? _taxInclusiveAmountCurr;

        private decimal? _alreadyClaimedTaxExclusiveAmount;

        private decimal? _alreadyClaimedTaxExclusiveAmountCurr;

        private decimal? _alreadyClaimedTaxInclusiveAmount;

        private decimal? _alreadyClaimedTaxInclusiveAmountCurr;

        private decimal? _differenceTaxExclusiveAmount;

        private decimal? _differenceTaxExclusiveAmountCurr;

        private decimal? _differenceTaxInclusiveAmount;

        private decimal? _differenceTaxInclusiveAmountCurr;

        private decimal? _payableRoundingAmount;

        private decimal? _payableRoundingAmountCurr;

        private decimal? _paidDepositsAmount;

        private decimal? _paidDepositsAmountCurr;

        private decimal? _payableAmount;

        private decimal? _payableAmountCurr;
        #endregion

        public bool ShouldSerializeTaxExclusiveAmount()
        {
            return _taxExclusiveAmount != null;
        }

        public decimal? TaxExclusiveAmount
        {
            get
            {
                return this._taxExclusiveAmount;
            }
            set
            {
                this._taxExclusiveAmount = value;
            }
        }

        public bool ShouldSerializeTaxExclusiveAmountCurr()
        {
            return _taxExclusiveAmountCurr != null;
        }

        public decimal? TaxExclusiveAmountCurr
        {
            get
            {
                return this._taxExclusiveAmountCurr;
            }
            set
            {
                this._taxExclusiveAmountCurr = value;
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

        public bool ShouldSerializeAlreadyClaimedTaxExclusiveAmount()
        {
            return _alreadyClaimedTaxExclusiveAmount != null;
        }

        public decimal? AlreadyClaimedTaxExclusiveAmount
        {
            get
            {
                return this._alreadyClaimedTaxExclusiveAmount;
            }
            set
            {
                this._alreadyClaimedTaxExclusiveAmount = value;
            }
        }

        public bool ShouldSerializeAlreadyClaimedTaxExclusiveAmountCurr()
        {
            return _alreadyClaimedTaxExclusiveAmountCurr != null;
        }

        public decimal? AlreadyClaimedTaxExclusiveAmountCurr
        {
            get
            {
                return this._alreadyClaimedTaxExclusiveAmountCurr;
            }
            set
            {
                this._alreadyClaimedTaxExclusiveAmountCurr = value;
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

        public bool ShouldSerializeDifferenceTaxExclusiveAmount()
        {
            return _differenceTaxExclusiveAmount != null;
        }

        public decimal? DifferenceTaxExclusiveAmount
        {
            get
            {
                return this._differenceTaxExclusiveAmount;
            }
            set
            {
                this._differenceTaxExclusiveAmount = value;
            }
        }

        public bool ShouldSerializeDifferenceTaxExclusiveAmountCurr()
        {
            return _differenceTaxExclusiveAmountCurr != null;
        }

        public decimal? DifferenceTaxExclusiveAmountCurr
        {
            get
            {
                return this._differenceTaxExclusiveAmountCurr;
            }
            set
            {
                this._differenceTaxExclusiveAmountCurr = value;
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

        public bool ShouldSerializePayableRoundingAmount()
        {
            return _payableRoundingAmount != null;
        }

        public decimal? PayableRoundingAmount
        {
            get
            {
                return this._payableRoundingAmount;
            }
            set
            {
                this._payableRoundingAmount = value;
            }
        }

        public bool ShouldSerializePayableRoundingAmountCurr()
        {
            return _payableRoundingAmountCurr != null;
        }

        public decimal? PayableRoundingAmountCurr
        {
            get
            {
                return this._payableRoundingAmountCurr;
            }
            set
            {
                this._payableRoundingAmountCurr = value;
            }
        }

        public bool ShouldSerializePaidDepositsAmount()
        {
            return _paidDepositsAmount != null;
        }

        public decimal? PaidDepositsAmount
        {
            get
            {
                return this._paidDepositsAmount;
            }
            set
            {
                this._paidDepositsAmount = value;
            }
        }

        public bool ShouldSerializePaidDepositsAmountCurr()
        {
            return _paidDepositsAmountCurr != null;
        }

        public decimal? PaidDepositsAmountCurr
        {
            get
            {
                return this._paidDepositsAmountCurr;
            }
            set
            {
                this._paidDepositsAmountCurr = value;
            }
        }

        public bool ShouldSerializePayableAmount()
        {
            return _payableAmount != null;
        }

        public decimal? PayableAmount
        {
            get
            {
                return this._payableAmount;
            }
            set
            {
                this._payableAmount = value;
            }
        }

        public bool ShouldSerializePayableAmountCurr()
        {
            return _payableAmountCurr != null;
        }

        public decimal? PayableAmountCurr
        {
            get
            {
                return this._payableAmountCurr;
            }
            set
            {
                this._payableAmountCurr = value;
            }
        }
    }
}
