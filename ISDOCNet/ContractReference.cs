using System.Xml.Serialization;

namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class ContractReference
    {

        #region Private fields
        private string _id;

        private string _uUID;

        private System.DateTime? _issueDate;

        private object _item;

        private string _iSDS_ID;

        private string _fileReference;

        private string _referenceNumber;

        private string idField1;
        #endregion

        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string UUID
        {
            get
            {
                return this._uUID;
            }
            set
            {
                this._uUID = value;
            }
        }

        public bool ShouldSerializeIssueDate()
        {
            return _issueDate != null;
        }

        [XmlElement(DataType = "date")]
        public System.DateTime? IssueDate
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

        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        public string ISDS_ID
        {
            get
            {
                return this._iSDS_ID;
            }
            set
            {
                this._iSDS_ID = value;
            }
        }

        public string FileReference
        {
            get
            {
                return this._fileReference;
            }
            set
            {
                this._fileReference = value;
            }
        }

        public string ReferenceNumber
        {
            get
            {
                return this._referenceNumber;
            }
            set
            {
                this._referenceNumber = value;
            }
        }

        public string id
        {
            get
            {
                return this.idField1;
            }
            set
            {
                this.idField1 = value;
            }
        }
    }
}
