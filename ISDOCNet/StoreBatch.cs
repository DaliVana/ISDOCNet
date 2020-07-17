namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class StoreBatch
    {

        #region Private fields
        private string _name;

        private Note _note;

        private System.DateTime _expirationDate;

        private string _specification;

        private Quantity _quantity;

        private BatchOrSerialNumber _batchOrSerialNumber;

        private string _sealSeriesID;
        #endregion

        public StoreBatch()
        {
            this._quantity = new Quantity();
            this._note = new Note();
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

        public Note Note
        {
            get
            {
                return this._note;
            }
            set
            {
                this._note = value;
            }
        }

        public System.DateTime ExpirationDate
        {
            get
            {
                return this._expirationDate;
            }
            set
            {
                this._expirationDate = value;
            }
        }

        public string Specification
        {
            get
            {
                return this._specification;
            }
            set
            {
                this._specification = value;
            }
        }

        public Quantity Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }

        public BatchOrSerialNumber BatchOrSerialNumber
        {
            get
            {
                return this._batchOrSerialNumber;
            }
            set
            {
                this._batchOrSerialNumber = value;
            }
        }

        public string SealSeriesID
        {
            get
            {
                return this._sealSeriesID;
            }
            set
            {
                this._sealSeriesID = value;
            }
        }
    }
}
