namespace ISDOCNet
{
    using System.Collections.Generic;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class PaymentMeans
    {

        #region Private fields
        private List<Payment> _payment;

        private List<AlternateBankAccount> _alternateBankAccounts;
        #endregion

        public PaymentMeans()
        {
            this._alternateBankAccounts = new List<AlternateBankAccount>();
            this._payment = new List<Payment>();
        }

        public List<Payment> Payment
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
