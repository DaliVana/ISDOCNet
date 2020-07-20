namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class RegisterIdentification
    {

        public RegisterIdentification()
        {

        }

        public RegisterIdentification(string preformatted)
        {
            _preformatted = preformatted;
        }

        #region Private fields
        private string _preformatted;

        private string _registerDate;

        private string _registerFileRef;

        private string _registerKeptAt;

        #endregion

        public bool ShouldSerializePreformatted()
        {
            return _preformatted != null;
        }

        public string Preformatted
        {
            get
            {
                return this._preformatted;
            }
            set
            {
                this._preformatted = value;
            }
        }

        public bool ShouldSerializeRegisterDate()
        {
            return _registerDate != null;
        }

        public string RegisterDate
        {
            get
            {
                return this._registerDate;
            }
            set
            {
                this._registerDate = value;
            }
        }

        public bool ShouldSerializeRegisterFileRef()
        {
            return _registerFileRef != null;
        }

        public string RegisterFileRef
        {
            get
            {
                return this._registerFileRef;
            }
            set
            {
                this._registerFileRef = value;
            }
        }

        public bool ShouldSerializeRegisterKeptAt()
        {
            return _registerKeptAt != null;
        }

        public string RegisterKeptAt
        {
            get
            {
                return this._registerKeptAt;
            }
            set
            {
                this._registerKeptAt = value;
            }
        }
    }
}
