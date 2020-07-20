namespace ISDOCNet
{
    using System.Collections.Generic;
    using System.Linq;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class PaymentMeans
    {

        #region Private fields
        private Payment _payment;

        private List<AlternateBankAccount> _alternateBankAccounts;
        #endregion

        public PaymentMeans()
        {
            //this._alternateBankAccounts = new List<AlternateBankAccount>();
            //this._payment = new List<Payment>();
        }

        public bool ShouldSerializePayment()
        {
            return _payment != null;
        }

        public Payment Payment
        {
            get
            {
                return this._payment;
            }
            set
            {
                this._payment = value;
            }
        }

        public bool ShouldSerializeAlternateBankAccounts()
        {
            return _alternateBankAccounts != null && _alternateBankAccounts.Any();
        }

        public List<AlternateBankAccount> AlternateBankAccounts
        {
            get
            {
                return this._alternateBankAccounts;
            }
            set
            {
                this._alternateBankAccounts = value;
            }
        }
    }
}
#pragma warning restore
