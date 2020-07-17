namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class LocalReverseCharge
    {

        #region Private fields
        private string _localReverseChargeCode;

        private Quantity _localReverseChargeQuantity;
        #endregion

        public LocalReverseCharge()
        {
            this._localReverseChargeQuantity = new Quantity();
        }

        public string LocalReverseChargeCode
        {
            get
            {
                return this._localReverseChargeCode;
            }
            set
            {
                this._localReverseChargeCode = value;
            }
        }

        public Quantity LocalReverseChargeQuantity
        {
            get
            {
                return this._localReverseChargeQuantity;
            }
            set
            {
                this._localReverseChargeQuantity = value;
            }
        }
    }
}
