namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Country
    {

        #region Private fields
        private string _identificationCode;

        private string _name;
        #endregion

        public string IdentificationCode
        {
            get
            {
                return this._identificationCode;
            }
            set
            {
                this._identificationCode = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
    }
}