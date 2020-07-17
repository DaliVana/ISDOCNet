namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Quantity
    {

        #region Private fields
        private string _unitCode;

        private decimal _value;
        #endregion

        public string unitCode
        {
            get
            {
                return this._unitCode;
            }
            set
            {
                this._unitCode = value;
            }
        }

        public decimal Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}
