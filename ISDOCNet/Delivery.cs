namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Delivery
    {

        #region Private fields
        private Party _party;
        #endregion

        public Delivery()
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