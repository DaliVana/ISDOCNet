namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Note
    {

        #region Private fields
        private string _languageID;

        private string _value;
        #endregion

        public string languageID
        {
            get
            {
                return this._languageID;
            }
            set
            {
                this._languageID = value;
            }
        }

        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}
#pragma warning restore
