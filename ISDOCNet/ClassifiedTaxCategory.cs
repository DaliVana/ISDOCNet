namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class ClassifiedTaxCategory
    {

        #region Private fields
        private decimal _percent;

        private VATCalculationMethod _vATCalculationMethod;

        private bool _vATApplicable;

        private LocalReverseCharge _localReverseCharge;
        #endregion

        public ClassifiedTaxCategory()
        {
            this._localReverseCharge = new LocalReverseCharge();
        }

        public decimal Percent
        {
            get
            {
                return this._percent;
            }
            set
            {
                this._percent = value;
            }
        }

        public VATCalculationMethod VATCalculationMethod
        {
            get
            {
                return this._vATCalculationMethod;
            }
            set
            {
                this._vATCalculationMethod = value;
            }
        }

        public bool VATApplicable
        {
            get
            {
                return this._vATApplicable;
            }
            set
            {
                this._vATApplicable = value;
            }
        }

        public LocalReverseCharge LocalReverseCharge
        {
            get
            {
                return this._localReverseCharge;
            }
            set
            {
                this._localReverseCharge = value;
            }
        }
    }
}
