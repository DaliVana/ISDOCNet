namespace ISDOCNet
{
    using System.Collections.Generic;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TaxTotal
    {

        #region Private fields
        private List<TaxSubTotal> _taxSubTotal;

        private decimal _taxAmountCurr;

        private decimal _taxAmount;
        #endregion

        public TaxTotal()
        {
            this._taxSubTotal = new List<TaxSubTotal>();
        }

        public List<TaxSubTotal> TaxSubTotal
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
    }
}
