namespace ISDOCNet
{
    using System.Collections.Generic;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Party
    {

        #region Private fields
        private PartyIdentification _partyIdentification;

        private PartyName _partyName;

        private PostalAddress _postalAddress;

        private List<PartyTaxScheme> _partyTaxScheme;

        private RegisterIdentification _registerIdentification;

        private Contact _contact;
        #endregion

        public Party()
        {
            this._contact = new Contact();
            this._registerIdentification = new RegisterIdentification();
            this._partyTaxScheme = new List<PartyTaxScheme>();
            this._postalAddress = new PostalAddress();
            this._partyName = new PartyName();
            this._partyIdentification = new PartyIdentification();
        }

        public PartyIdentification PartyIdentification
        {
            get
            {
                return this._partyIdentification;
            }
            set
            {
                this._partyIdentification = value;
            }
        }

        public PartyName PartyName
        {
            get
            {
                return this._partyName;
            }
            set
            {
                this._partyName = value;
            }
        }

        public PostalAddress PostalAddress
        {
            get
            {
                return this._postalAddress;
            }
            set
            {
                this._postalAddress = value;
            }
        }

        public List<PartyTaxScheme> PartyTaxScheme
        {
            get
            {
                return this._partyTaxScheme;
            }
            set
            {
                this._partyTaxScheme = value;
            }
        }

        public RegisterIdentification RegisterIdentification
        {
            get
            {
                return this._registerIdentification;
            }
            set
            {
                this._registerIdentification = value;
            }
        }

        public Contact Contact
        {
            get
            {
                return this._contact;
            }
            set
            {
                this._contact = value;
            }
        }
    }
}
