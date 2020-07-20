using System.Collections.Generic;

namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Details
    {

        #region Private fields

        private string _bIC;

        private string _bankCode;

        private string _constantSymbol;

        private string _documentID;

        private string _iBAN;

        private string _iD;

        private string _issueDate;

        private string _name;

        private string _paymentDueDate;

        private string _specificSymbol;

        private string _variableSymbol;


        #endregion

        public bool ShouldSerializePaymentDueDate()
        {
            return _paymentDueDate != null;
        }

        public string PaymentDueDate
        {
            get
            {
                return this._paymentDueDate;
            }
            set
            {
                this._paymentDueDate = value;
            }
        }

        public bool ShouldSerializeID()
        {
            return _iD != null;
        }

        public string ID
        {
            get
            {
                return this._iD;
            }
            set
            {
                this._iD = value;
            }
        }

        public bool ShouldSerializeBankCode()
        {
            return _bankCode != null;
        }

        public string BankCode
        {
            get
            {
                return this._bankCode;
            }
            set
            {
                this._bankCode = value;
            }
        }

        public bool ShouldSerializeName()
        {
            return _name != null;
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

        public bool ShouldSerializeIBAN()
        {
            return _iBAN != null;
        }

        public string IBAN
        {
            get
            {
                return this._iBAN;
            }
            set
            {
                this._iBAN = value;
            }
        }

        public bool ShouldSerializeBIC()
        {
            return _bIC != null;
        }

        public string BIC
        {
            get
            {
                return this._bIC;
            }
            set
            {
                this._bIC = value;
            }
        }

        public bool ShouldSerializeVariableSymbol()
        {
            return _variableSymbol != null;
        }

        public string VariableSymbol
        {
            get
            {
                return this._variableSymbol;
            }
            set
            {
                this._variableSymbol = value;
            }
        }

        public bool ShouldSerializeConstantSymbol()
        {
            return _constantSymbol != null;
        }

        public string ConstantSymbol
        {
            get
            {
                return this._constantSymbol;
            }
            set
            {
                this._constantSymbol = value;
            }
        }

        public bool ShouldSerializeDocumentID()
        {
            return _documentID != null;
        }

        public string DocumentID
        {
            get
            {
                return this._documentID;
            }
            set
            {
                this._documentID = value;
            }
        }

        public bool ShouldSerializeIssueDate()
        {
            return _issueDate != null;
        }

        public string IssueDate
        {
            get
            {
                return this._issueDate;
            }
            set
            {
                this._issueDate = value;
            }
        }

        public bool ShouldSerializeSpecificSymbol()
        {
            return _specificSymbol != null;
        }

        public string SpecificSymbol
        {
            get
            {
                return this._specificSymbol;
            }
            set
            {
                this._specificSymbol = value;
            }
        }
    }
}
