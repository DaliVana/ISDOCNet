namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class OrderReference
    {

        #region Private fields
        private string _salesOrderID;

        private string _externalOrderID;

        private System.DateTime _issueDate;

        private System.DateTime _externalOrderIssueDate;

        private string _uUID;

        private string _iSDS_ID;

        private string _fileReference;

        private string _referenceNumber;

        private string _id;
        #endregion

        public string SalesOrderID
        {
            get
            {
                return this._salesOrderID;
            }
            set
            {
                this._salesOrderID = value;
            }
        }

        public string ExternalOrderID
        {
            get
            {
                return this._externalOrderID;
            }
            set
            {
                this._externalOrderID = value;
            }
        }

        public System.DateTime IssueDate
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

        public System.DateTime ExternalOrderIssueDate
        {
            get
            {
                return this._externalOrderIssueDate;
            }
            set
            {
                this._externalOrderIssueDate = value;
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
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}
#pragma warning restore
