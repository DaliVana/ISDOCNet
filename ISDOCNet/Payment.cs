using System.Linq;
using System.Xml.Serialization;

namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Payment
    {

        #region Private fields
        private decimal? _paidAmount;

        private PaymentMeansCode _paymentMeansCode;

        private Details _details;

        private bool _partialPayment;
        #endregion

        public Payment()
        {
            //this._details = new Details();
        }

        public bool ShouldSerializePaidAmount()
        {
            return _paidAmount != null;
        }

        public decimal? PaidAmount
        {
            get
            {
                return this._paidAmount;
            }
            set
            {
                this._paidAmount = value;
            }
        }

        public bool ShouldSerializePaymentMeansCode()
        {
            return _paymentMeansCode != null;
        }

        public PaymentMeansCode PaymentMeansCode
        {
            get
            {
                return this._paymentMeansCode;
            }
            set
            {
                this._paymentMeansCode = value;
            }
        }

        public bool ShouldSerializeDetails()
        {
            return _details != null;
        }

        public Details Details
        {
            get
            {
                return this._details;
            }
            set
            {
                this._details = value;
            }
        }

        [XmlAttribute]
        public bool partialPayment
        {
            get
            {
                return this._partialPayment;
            }
            set
            {
                this._partialPayment = value;
            }
        }
    }
}
