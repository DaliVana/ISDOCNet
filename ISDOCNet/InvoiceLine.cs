using System;

namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [Serializable]
    public partial class InvoiceLine
    {

        #region Private fields
        private string _id;

        private OrderLineReference _orderReference;

        private DeliveryNoteLineReference _deliveryNoteReference;

        private OriginalDocumentLineReference _originalDocumentReference;

        private ContractLineReference _contractReference;

        private string _egovClassifier;

        private Quantity _invoicedQuantity;

        private decimal _lineExtensionAmountCurr;

        private decimal _lineExtensionAmount;

        private decimal _lineExtensionAmountBeforeDiscount;

        private decimal _lineExtensionAmountTaxInclusiveCurr;

        private decimal _lineExtensionAmountTaxInclusive;

        private decimal _lineExtensionAmountTaxInclusiveBeforeDiscount;

        private decimal _lineExtensionTaxAmount;

        private decimal _unitPrice;

        private decimal _unitPriceTaxInclusive;

        private ClassifiedTaxCategory _classifiedTaxCategory;

        private Note _note;

        private Note _vATNote;

        private Item _item;

        private Extensions _extensions;
        #endregion

        public InvoiceLine()
        {
            this._extensions = new Extensions();
            this._item = new Item();
            this._vATNote = new Note();
            this._note = new Note();
            this._classifiedTaxCategory = new ClassifiedTaxCategory();
            this._invoicedQuantity = new Quantity();
            this._contractReference = new ContractLineReference();
            this._originalDocumentReference = new OriginalDocumentLineReference();
            this._deliveryNoteReference = new DeliveryNoteLineReference();
            this._orderReference = new OrderLineReference();
        }

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

        public OrderLineReference OrderReference
        {
            get
            {
                return this._orderReference;
            }
            set
            {
                this._orderReference = value;
            }
        }

        public DeliveryNoteLineReference DeliveryNoteReference
        {
            get
            {
                return this._deliveryNoteReference;
            }
            set
            {
                this._deliveryNoteReference = value;
            }
        }

        public OriginalDocumentLineReference OriginalDocumentReference
        {
            get
            {
                return this._originalDocumentReference;
            }
            set
            {
                this._originalDocumentReference = value;
            }
        }

        public ContractLineReference ContractReference
        {
            get
            {
                return this._contractReference;
            }
            set
            {
                this._contractReference = value;
            }
        }

        public string EgovClassifier
        {
            get
            {
                return this._egovClassifier;
            }
            set
            {
                this._egovClassifier = value;
            }
        }

        public Quantity InvoicedQuantity
        {
            get
            {
                return this._invoicedQuantity;
            }
            set
            {
                this._invoicedQuantity = value;
            }
        }

        public decimal LineExtensionAmountCurr
        {
            get
            {
                return this._lineExtensionAmountCurr;
            }
            set
            {
                this._lineExtensionAmountCurr = value;
            }
        }

        public decimal LineExtensionAmount
        {
            get
            {
                return this._lineExtensionAmount;
            }
            set
            {
                this._lineExtensionAmount = value;
            }
        }

        public decimal LineExtensionAmountBeforeDiscount
        {
            get
            {
                return this._lineExtensionAmountBeforeDiscount;
            }
            set
            {
                this._lineExtensionAmountBeforeDiscount = value;
            }
        }

        public decimal LineExtensionAmountTaxInclusiveCurr
        {
            get
            {
                return this._lineExtensionAmountTaxInclusiveCurr;
            }
            set
            {
                this._lineExtensionAmountTaxInclusiveCurr = value;
            }
        }

        public decimal LineExtensionAmountTaxInclusive
        {
            get
            {
                return this._lineExtensionAmountTaxInclusive;
            }
            set
            {
                this._lineExtensionAmountTaxInclusive = value;
            }
        }

        public decimal LineExtensionAmountTaxInclusiveBeforeDiscount
        {
            get
            {
                return this._lineExtensionAmountTaxInclusiveBeforeDiscount;
            }
            set
            {
                this._lineExtensionAmountTaxInclusiveBeforeDiscount = value;
            }
        }

        public decimal LineExtensionTaxAmount
        {
            get
            {
                return this._lineExtensionTaxAmount;
            }
            set
            {
                this._lineExtensionTaxAmount = value;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return this._unitPrice;
            }
            set
            {
                this._unitPrice = value;
            }
        }

        public decimal UnitPriceTaxInclusive
        {
            get
            {
                return this._unitPriceTaxInclusive;
            }
            set
            {
                this._unitPriceTaxInclusive = value;
            }
        }

        public ClassifiedTaxCategory ClassifiedTaxCategory
        {
            get
            {
                return this._classifiedTaxCategory;
            }
            set
            {
                this._classifiedTaxCategory = value;
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

        public Note VATNote
        {
            get
            {
                return this._vATNote;
            }
            set
            {
                this._vATNote = value;
            }
        }

        public Item Item
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

        public Extensions Extensions
        {
            get
            {
                return this._extensions;
            }
            set
            {
                this._extensions = value;
            }
        }
    }
}
