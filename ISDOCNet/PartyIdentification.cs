namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class PartyIdentification
    {
        public PartyIdentification()
        {

        }

        public PartyIdentification(string userID, string catalogFirmIdentification, string iD)
        {
            _userID = userID;
            _catalogFirmIdentification = catalogFirmIdentification;
            _id = iD;
        }

        #region Private fields
        private string _userID;

        private string _catalogFirmIdentification;

        private string _id;
        #endregion

        public string UserID
        {
            get
            {
                return this._userID;
            }
            set
            {
                this._userID = value;
            }
        }

        public string CatalogFirmIdentification
        {
            get
            {
                return this._catalogFirmIdentification;
            }
            set
            {
                this._catalogFirmIdentification = value;
            }
        }

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
    }
}
