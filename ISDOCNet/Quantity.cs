using System.Xml.Serialization;

namespace ISDOCNet
{

    public partial class Quantity
    {
        public Quantity()
        {

        }

        public Quantity(string unitCode, decimal value)
        {
            _unitCode = unitCode;
            _value = value;
        }


        #region Private fields
        private string _unitCode;

        private decimal _value;
        #endregion

        [XmlAttribute]
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

        [XmlText]
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
