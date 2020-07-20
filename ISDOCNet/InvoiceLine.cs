using System;

namespace ISDOCNet
{
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

        private decimal? _lineExtensionAmountCurr;

        private decimal? _lineExtensionAmount;

        private decimal? _lineExtensionAmountBeforeDiscount;

        private decimal? _lineExtensionAmountTaxInclusiveCurr;

        private decimal? _lineExtensionAmountTaxInclusive;

        private decimal? _lineExtensionAmountTaxInclusiveBeforeDiscount;

        private decimal? _lineExtensionTaxAmount;

        private decimal? _unitPrice;

        private decimal? _unitPriceTaxInclusive;

        private ClassifiedTaxCategory _classifiedTaxCategory;

        private Note _note;

        private Note _vATNote;

        private Item _item;

        private Extensions _extensions;
        #endregion

        public InvoiceLine()
        {
            //this._extensions = new Extensions();
            //this._item = new Item();
            //this._vATNote = new Note();
            //this._note = new Note();
            //this._classifiedTaxCategory = new ClassifiedTaxCategory();
            //this._invoicedQuantity = new Quantity();
            //this._contractReference = new ContractLineReference();
            //this._originalDocumentReference = new OriginalDocumentLineReference();
            //this._deliveryNoteReference = new DeliveryNoteLineReference();
            //this._orderReference = new OrderLineReference();
        }

        public bool ShouldSerializeID()
        {
            return _id != null;
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

        public bool ShouldSerializeOrderReference()
        {
            return _orderReference != null;
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

        public bool ShouldSerializeDeliveryNoteReference()
        {
            return _deliveryNoteReference != null;
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

        public bool ShouldSerializeOriginalDocumentReference()
        {
            return _originalDocumentReference != null;
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

        public bool ShouldSerializeContractReference()
        {
            return _contractReference != null;
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

        public bool ShouldSerializeEgovClassifier()
        {
            return _egovClassifier != null;
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

        public bool ShouldSerializeInvoicedQuantity()
        {
            return _invoicedQuantity != null;
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
        public bool ShouldSerializeLineExtensionAmountCurr()
        {
            return _lineExtensionAmountCurr != null;
        }

        public decimal? LineExtensionAmountCurr
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

        public bool ShouldSerializeLineExtensionAmount()
        {
            return _lineExtensionAmount != null;
        }

        public decimal? LineExtensionAmount
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

        public bool ShouldSerializeLineExtensionAmountBeforeDiscount()
        {
            return _lineExtensionAmountBeforeDiscount != null;
        }

        public decimal? LineExtensionAmountBeforeDiscount
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

        public bool ShouldSerializeLineExtensionAmountTaxInclusiveCurr()
        {
            return _lineExtensionAmountTaxInclusiveCurr != null;
        }

        public decimal? LineExtensionAmountTaxInclusiveCurr
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

        public bool ShouldSerializeLineExtensionAmountTaxInclusive()
        {
            return _lineExtensionAmountTaxInclusive != null;
        }

        public decimal? LineExtensionAmountTaxInclusive
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

        public bool ShouldSerializeLineExtensionAmountTaxInclusiveBeforeDiscount()
        {
            return _lineExtensionAmountTaxInclusiveBeforeDiscount != null;
        }

        public decimal? LineExtensionAmountTaxInclusiveBeforeDiscount
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

        public bool ShouldSerializeLineExtensionTaxAmount()
        {
            return _lineExtensionTaxAmount != null;
        }

        public decimal? LineExtensionTaxAmount
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

        public bool ShouldSerializeUnitPrice()
        {
            return _unitPrice != null;
        }

        public decimal? UnitPrice
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

        public bool ShouldSerializeUnitPriceTaxInclusive()
        {
            return _unitPriceTaxInclusive != null;
        }

        public decimal? UnitPriceTaxInclusive
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

        public bool ShouldSerializeClassifiedTaxCategory()
        {
            return _classifiedTaxCategory != null;
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

        public bool ShouldSerializeNote()
        {
            return _note != null;
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

        public bool ShouldSerializeVATNote()
        {
            return _vATNote != null;
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

        public bool ShouldSerializeItem()
        {
            return _item != null;
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

        public bool ShouldSerializeExtensions()
        {
            return _extensions != null;
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
