namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class PartyName
    {
        public PartyName()
        {

        }

        public PartyName(string name)
        {
            _name = name;
        }


        #region Private fields
        private string _name;
        #endregion

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
