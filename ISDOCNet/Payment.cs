namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Payment
    {

        #region Private fields
        private decimal _paidAmount;

        private PaymentMeansCode _paymentMeansCode;

        private Details _details;

        private bool _partialPayment;
        #endregion

        public Payment()
        {
            this._details = new Details();
        }

        public decimal PaidAmount
        {
            get
            {
                return this._paidAmount;
            }
            set
            {
                this._paidAmount = value;
            }
        }

        public PaymentMeansCode PaymentMeansCode
        {
            get
            {
                return this._paymentMeansCode;
            }
            set
            {
                this._paymentMeansCode = value;
            }
        }

        public Details Details
        {
            get
            {
                return this._details;
            }
            set
            {
                this._details = value;
            }
        }

        public bool partialPayment
        {
            get
            {
                return this._partialPayment;
            }
            set
            {
                this._partialPayment = value;
            }
        }
    }
}
