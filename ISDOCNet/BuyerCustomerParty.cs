namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class BuyerCustomerParty
    {

        #region Private fields
        private Party _party;
        #endregion

        public BuyerCustomerParty()
        {
            this._party = new Party();
        }

        public Party Party
        {
            get
            {
                return this._party;
            }
            set
            {
                this._party = value;
            }
        }
    }
}
