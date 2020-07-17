namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class ContractLineReference
    {

        #region Private fields
        private string _paragraphID;

        private string _ref;
        #endregion

        public string ParagraphID
        {
            get
            {
                return this._paragraphID;
            }
            set
            {
                this._paragraphID = value;
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
