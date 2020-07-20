namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class TaxCategory
    {

        #region Private fields
        private decimal? _percent;

        private string _taxScheme;

        private bool? _vATApplicable;

        private bool? _localReverseChargeFlag;
        #endregion

        public bool ShouldSerializePercent()
        {
            return _percent != null;
        }

        public decimal? Percent
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

        public bool ShouldSerializTaxScheme()
        {
            return _taxScheme != null;
        }

        public string TaxScheme
        {
            get
            {
                return this._taxScheme;
            }
            set
            {
                this._taxScheme = value;
            }
        }

        public bool ShouldSerializeVATApplicable()
        {
            return _vATApplicable != null;
        }

        public bool? VATApplicable
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

        public bool ShouldSerializeLocalReverseChargeFlag()
        {
            return _localReverseChargeFlag != null;
        }

        public bool? LocalReverseChargeFlag
        {
            get
            {
                return this._localReverseChargeFlag;
            }
            set
            {
                this._localReverseChargeFlag = value;
            }
        }
    }
}
