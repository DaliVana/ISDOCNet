namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Supplement
    {

        #region Private fields
        private string _filename;

        private DigestMethod _digestMethod;

        private string _digestValue;

        private bool _preview;
        #endregion

        public Supplement()
        {
            this._digestMethod = new DigestMethod();
        }

        public string Filename
        {
            get
            {
                return this._filename;
            }
            set
            {
                this._filename = value;
            }
        }

        public DigestMethod DigestMethod
        {
            get
            {
                return this._digestMethod;
            }
            set
            {
                this._digestMethod = value;
            }
        }

        public string DigestValue
        {
            get
            {
                return this._digestValue;
            }
            set
            {
                this._digestValue = value;
            }
        }

        public bool preview
        {
            get
            {
                return this._preview;
            }
            set
            {
                this._preview = value;
            }
        }
    }
}
