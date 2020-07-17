namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class DeliveryNoteReference
    {

        #region Private fields
        private string _id;

        private System.DateTime _issueDate;

        private string _uUID;

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
#pragma warning restore
