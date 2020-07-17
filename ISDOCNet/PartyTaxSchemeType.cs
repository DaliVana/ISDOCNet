namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class PartyTaxScheme
    {

        #region Private fields
        private string _companyID;

        private string _taxScheme;
        #endregion

        public string CompanyID
        {
            get
            {
                return this._companyID;
            }
            set
            {
                this._companyID = value;
            }
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
    }
}
