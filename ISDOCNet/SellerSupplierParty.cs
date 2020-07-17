namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class SellerSupplierParty
    {

        #region Private fields
        private Party _party;
        #endregion

        public SellerSupplierParty()
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
