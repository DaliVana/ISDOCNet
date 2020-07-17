namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class OrderLineReference
    {

        #region Private fields
        private string _lineID;

        private string _ref;
        #endregion

        public string LineID
        {
            get
            {
                return this._lineID;
            }
            set
            {
                this._lineID = value;
            }
        }

        public string @ref
        {
            get
            {
                return this._ref;
            }
            set
            {
                this._ref = value;
            }
        }
    }
}
