namespace ISDOCNet
{
    using System.Collections.Generic;
    using System.Linq;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TaxTotal
    {

        #region Private fields
        private TaxSubTotal _taxSubTotal;

        private decimal? _taxAmountCurr;

        private decimal? _taxAmount;
        #endregion

        public TaxTotal()
        {
            //this._taxSubTotal = new List<TaxSubTotal>();
        }

        public bool ShouldSerializeTaxSubTotal()
        {
            return _taxSubTotal != null;
        }

        public TaxSubTotal TaxSubTotal
        {
            get
            {
                return this._taxSubTotal;
            }
            set
            {
                this._taxSubTotal = value;
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
    }
}
