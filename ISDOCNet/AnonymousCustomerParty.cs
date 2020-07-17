namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class AnonymousCustomerParty
    {

        #region Private fields
        private string _id;

        private string _iDScheme;
        #endregion

        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string IDScheme
        {
            get
            {
                return this._iDScheme;
            }
            set
            {
                this._iDScheme = value;
            }
        }
    }
}
#pragma warning restore
