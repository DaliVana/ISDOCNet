namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Contact
    {

        #region Private fields
        private string _name;

        private string _telephone;

        private string _electronicMail;
        #endregion

        public Contact()
        {

        }

        public Contact(string name, string telephone, string electronicMail)
        {
            _name = name;
            _telephone = telephone;
            _electronicMail = electronicMail;
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

        public string Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }

        public string ElectronicMail
        {
            get
            {
                return this._electronicMail;
            }
            set
            {
                this._electronicMail = value;
            }
        }
    }
}
