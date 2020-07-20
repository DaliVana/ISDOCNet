namespace ISDOCNet
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Serialization;

    [Serializable]
    public partial class Invoice
    {

        #region Private fields
        private DocumentType _document;

        private string _subDocument;

        private string _subDocumentOrigin;

        private string _targetConsolidator;

        private string _clientOnTargetConsolidator;

        private string _clientBankAccount;

        private string _id;

        private string _uUID;

        private bool? _egovFlag;

        private string _iSDS_ID;

        private string _fileReference;

        private string _referenceNumber;

        private List<string> _egovClassifiers;

        private string _issuingSystem;

        private System.DateTime? _issueDate;

        private System.DateTime? _taxPointDate;

        private bool? _vATApplicable;

        private Note _electronicPossibilityAgreementReference;

        private Note _note;

        private string _localCurrencyCode;

        private string _foreignCurrencyCode;

        private decimal? _currRate;

        private decimal? _refCurrRate;

        private Extensions _extensions;

        private AccountingSupplierParty _accountingSupplierParty;

        private AccountingCustomerParty _accountingCustomerParty;

        private SellerSupplierParty _sellerSupplierParty;

        private BuyerCustomerParty _buyerCustomerParty;

        private List<OrderReference> _orderReferences;

        private List<DeliveryNoteReference> _deliveryNoteReferences;

        private List<OriginalDocumentReference> _originalDocumentReferences;

        private List<ContractReference> _contractReferences;

        private Delivery _delivery;

        private List<InvoiceLine> _invoiceLines;

        private List<NonTaxedDeposit> _nonTaxedDeposits;

        private List<TaxedDeposit> _taxedDeposits;

        private TaxTotal _taxTotal;

        private LegalMonetaryTotal _legalMonetaryTotal;

        private PaymentMeans _paymentMeans;

        private List<Supplement> _supplementsList;

        private System.Xml.XmlElement _any;

        private string _version;
        #endregion

        public Invoice()
        {
            //this._supplementsList = new List<Supplement>();
            //this._paymentMeans = new PaymentMeans();
            //this._legalMonetaryTotal = new LegalMonetaryTotal();
            //this._taxTotal = new TaxTotal();
            //this._taxedDeposits = new List<TaxedDeposit>();
            //this._nonTaxedDeposits = new List<NonTaxedDeposit>();
            //this._invoiceLines = new List<InvoiceLine>();
            //this._delivery = new Delivery();
            //this._contractReferences = new List<ContractReference>();
            //this._originalDocumentReferences = new List<OriginalDocumentReference>();
            //this._deliveryNoteReferences = new List<DeliveryNoteReference>();
            //this._orderReferences = new List<OrderReference>();
            //this._buyerCustomerParty = new BuyerCustomerParty();
            //this._sellerSupplierParty = new SellerSupplierParty();
            //this._accountingSupplierParty = new AccountingSupplierParty();
            //this._extensions = new Extensions();
            //this._note = new Note();
            //this._electronicPossibilityAgreementReference = new Note();
            //this._egovClassifiers = new List<string>();
        }
        
        public DocumentType DocumentType
        {
            get
            {
                return this._document;
            }
            set
            {
                this._document = value;
            }
        }

        public bool ShouldSerializeSubDocument()
        {
            return _subDocument != null;
        }

        public string SubDocument
        {
            get
            {
                return this._subDocument;
            }
            set
            {
                this._subDocument = value;
            }
        }

        public bool ShouldSerializeSubDocumentOrigin()
        {
            return _subDocumentOrigin != null;
        }

        public string SubDocumentOrigin
        {
            get
            {
                return this._subDocumentOrigin;
            }
            set
            {
                this._subDocumentOrigin = value;
            }
        }

        public bool ShouldSerializeTargetConsolidator()
        {
            return _targetConsolidator != null;
        }

        public string TargetConsolidator
        {
            get
            {
                return this._targetConsolidator;
            }
            set
            {
                this._targetConsolidator = value;
            }
        }

        public bool ShouldSerializeClientOnTargetConsolidator()
        {
            return _clientOnTargetConsolidator != null;
        }

        public string ClientOnTargetConsolidator
        {
            get
            {
                return this._clientOnTargetConsolidator;
            }
            set
            {
                this._clientOnTargetConsolidator = value;
            }
        }

        public bool ShouldSerializeClientBankAccount()
        {
            return _clientBankAccount != null;
        }

        public string ClientBankAccount
        {
            get
            {
                return this._clientBankAccount;
            }
            set
            {
                this._clientBankAccount = value;
            }
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

        public bool ShouldSerializeUUID()
        {
            return _uUID != null;
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

        public bool ShouldSerializeEgovFlag()
        {
            return _egovFlag != null;
        }

        public bool? EgovFlag
        {
            get
            {
                return this._egovFlag;
            }
            set
            {
                this._egovFlag = value;
            }
        }

        public bool ShouldSerializeISDS_ID()
        {
            return _iSDS_ID != null;
        }

        public string ISDS_ID
        {
            get
            {
                return this._iSDS_ID;
            }
            set
            {
                this._iSDS_ID = value;
            }
        }

        public bool ShouldSerializeFileReference()
        {
            return _fileReference != null;
        }

        public string FileReference
        {
            get
            {
                return this._fileReference;
            }
            set
            {
                this._fileReference = value;
            }
        }

        public bool ShouldSerializeReferenceNumber()
        {
            return _referenceNumber != null;
        }

        public string ReferenceNumber
        {
            get
            {
                return this._referenceNumber;
            }
            set
            {
                this._referenceNumber = value;
            }
        }

        public bool ShouldSerializeEgovClassifiers()
        {
            return _egovClassifiers != null && _egovClassifiers.Count > 0;
        }

        public List<string> EgovClassifiers
        {
            get
            {
                return this._egovClassifiers;
            }
            set
            {
                this._egovClassifiers = value;
            }
        }

        public bool ShouldSerializeIssuingSystem()
        {
            return _issuingSystem != null;
        }

        public string IssuingSystem
        {
            get
            {
                return this._issuingSystem;
            }
            set
            {
                this._issuingSystem = value;
            }
        }

        public bool ShouldSerializeIssueDate()
        {
            return _issueDate != null;
        }

        [XmlElement(DataType = "date")]
        public System.DateTime? IssueDate
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

        public bool ShouldSerializeTaxPointDate()
        {
            return _taxPointDate != null;
        }

        [XmlElement(DataType = "date")]
        public System.DateTime? TaxPointDate
        {
            get
            {
                return this._taxPointDate;
            }
            set
            {
                this._taxPointDate = value;
            }
        }

        public bool ShouldSerializeVATApplicable()
        {
            return _vATApplicable != null;
        }

        public bool? VATApplicable
        {
            get
            {
                return this._vATApplicable;
            }
            set
            {
                this._vATApplicable = value;
            }
        }

        public bool ShouldSerializeElectronicPossibilityAgreementReference()
        {
            return _electronicPossibilityAgreementReference != null;
        }

        public Note ElectronicPossibilityAgreementReference
        {
            get
            {
                return this._electronicPossibilityAgreementReference;
            }
            set
            {
                this._electronicPossibilityAgreementReference = value;
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

        public bool ShouldSerializeLocalCurrencyCode()
        {
            return _localCurrencyCode != null;
        }

        public string LocalCurrencyCode
        {
            get
            {
                return this._localCurrencyCode;
            }
            set
            {
                this._localCurrencyCode = value;
            }
        }

        public bool ShouldSerializeForeignCurrencyCode()
        {
            return _foreignCurrencyCode != null;
        }

        public string ForeignCurrencyCode
        {
            get
            {
                return this._foreignCurrencyCode;
            }
            set
            {
                this._foreignCurrencyCode = value;
            }
        }

        public bool ShouldSerializeCurrRate()
        {
            return _currRate != null;
        }

        public decimal? CurrRate
        {
            get
            {
                return this._currRate;
            }
            set
            {
                this._currRate = value;
            }
        }

        public bool ShouldSerializeRefCurrRate()
        {
            return _refCurrRate != null;
        }

        public decimal? RefCurrRate
        {
            get
            {
                return this._refCurrRate;
            }
            set
            {
                this._refCurrRate = value;
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

        public bool ShouldSerializeAccountingSupplierParty()
        {
            return _accountingSupplierParty != null;
        }

        public AccountingSupplierParty AccountingSupplierParty
        {
            get
            {
                return this._accountingSupplierParty;
            }
            set
            {
                this._accountingSupplierParty = value;
            }
        }

        public bool ShouldSerializeSellerSupplierParty()
        {
            return _sellerSupplierParty != null;
        }

        public SellerSupplierParty SellerSupplierParty
        {
            get
            {
                return this._sellerSupplierParty;
            }
            set
            {
                this._sellerSupplierParty = value;
            }
        }

        public bool ShouldSerializeAccountingCustomerParty()
        {
            return _accountingSupplierParty != null;
        }

        public AccountingCustomerParty AccountingCustomerParty
        {
            get
            {
                return this._accountingCustomerParty;
            }
            set
            {
                this._accountingCustomerParty = value;
            }
        }

        public bool ShouldSerializeBuyerCustomerParty()
        {
            return _buyerCustomerParty != null;
        }

        public BuyerCustomerParty BuyerCustomerParty
        {
            get
            {
                return this._buyerCustomerParty;
            }
            set
            {
                this._buyerCustomerParty = value;
            }
        }

        public bool ShouldSerializeOrderReferences()
        {
            return _orderReferences != null && _orderReferences.Any();
        }

        public List<OrderReference> OrderReferences
        {
            get
            {
                return this._orderReferences;
            }
            set
            {
                this._orderReferences = value;
            }
        }

        public bool ShouldSerializeDeliveryNoteReferences()
        {
            return _deliveryNoteReferences != null && _deliveryNoteReferences.Any();
        }

        public List<DeliveryNoteReference> DeliveryNoteReferences
        {
            get
            {
                return this._deliveryNoteReferences;
            }
            set
            {
                this._deliveryNoteReferences = value;
            }
        }

        public bool ShouldSerializeOriginalDocumentReferences()
        {
            return _originalDocumentReferences != null && _originalDocumentReferences.Any();
        }

        public List<OriginalDocumentReference> OriginalDocumentReferences
        {
            get
            {
                return this._originalDocumentReferences;
            }
            set
            {
                this._originalDocumentReferences = value;
            }
        }

        public bool ShouldSerializeContractReferences()
        {
            return _contractReferences != null && _contractReferences.Any();
        }

        public List<ContractReference> ContractReferences
        {
            get
            {
                return this._contractReferences;
            }
            set
            {
                this._contractReferences = value;
            }
        }

        public bool ShouldSerializeDelivery()
        {
            return _delivery != null;
        }

        public Delivery Delivery
        {
            get
            {
                return this._delivery;
            }
            set
            {
                this._delivery = value;
            }
        }

        public bool ShouldSerializeInvoiceLines()
        {
            return _invoiceLines != null && _invoiceLines.Any();
        }

        public List<InvoiceLine> InvoiceLines
        {
            get
            {
                return this._invoiceLines;
            }
            set
            {
                this._invoiceLines = value;
            }
        }

        public bool ShouldSerializeNonTaxedDeposits()
        {
            return _nonTaxedDeposits != null && _nonTaxedDeposits.Any();
        }

        public List<NonTaxedDeposit> NonTaxedDeposits
        {
            get
            {
                return this._nonTaxedDeposits;
            }
            set
            {
                this._nonTaxedDeposits = value;
            }
        }

        public bool ShouldSerializeTaxedDeposits()
        {
            return _taxedDeposits != null && _taxedDeposits.Any();
        }

        public List<TaxedDeposit> TaxedDeposits
        {
            get
            {
                return this._taxedDeposits;
            }
            set
            {
                this._taxedDeposits = value;
            }
        }

        public bool ShouldSerializeTaxTotal()
        {
            return _taxTotal != null;
        }

        public TaxTotal TaxTotal
        {
            get
            {
                return this._taxTotal;
            }
            set
            {
                this._taxTotal = value;
            }
        }

        public bool ShouldSerializeLegalMonetaryTotal()
        {
            return _legalMonetaryTotal != null;
        }

        public LegalMonetaryTotal LegalMonetaryTotal
        {
            get
            {
                return this._legalMonetaryTotal;
            }
            set
            {
                this._legalMonetaryTotal = value;
            }
        }

        public bool ShouldSerializePaymentMeans()
        {
            return _paymentMeans != null;
        }

        public PaymentMeans PaymentMeans
        {
            get
            {
                return this._paymentMeans;
            }
            set
            {
                this._paymentMeans = value;
            }
        }

        public bool ShouldSerializeSupplementsList()
        {
            return _supplementsList != null && _supplementsList.Any();
        }

        public List<Supplement> SupplementsList
        {
            get
            {
                return this._supplementsList;
            }
            set
            {
                this._supplementsList = value;
            }
        }

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }

        [XmlAttribute]
        public string version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }

        public static Invoice Load(System.IO.Stream stream)
        {
            return Deserialize(stream);
        }

        public static Invoice Load(System.IO.TextReader textReader)
        {
            var reader = XmlReader.Create(textReader);
            return Deserialize(reader);
        }

        public static Invoice Load(string uriInput)
        {
            var reader = XmlReader.Create(uriInput);
            var result = Deserialize(reader);
            reader.Close();
            return result;
        }

        private static Invoice Deserialize(XmlReader reader)
        {
            XmlSerializer s = GetSerializer();
            if (s.CanDeserialize(reader))
            {
                var deserializedObj = s.Deserialize(reader);
                if (deserializedObj is Invoice)
                {
                    return (Invoice)deserializedObj;
                }
                else
                {
                    throw new System.Exception();
                }
            }
            else
            {
                throw new System.Exception();
            }
        }

        private static Invoice Deserialize(System.IO.Stream stream)
        {
            XmlSerializer s = GetSerializer();
            var deserializedObj = s.Deserialize(stream);
            if (deserializedObj is Invoice)
            {
                return (Invoice)deserializedObj;
            }
            else
            {
                throw new System.Exception();
            }
        }

        private static XmlSerializer GetSerializer()
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Invoice";
            xRoot.Namespace = @"http://isdoc.cz/namespace/2013";
            xRoot.IsNullable = true;            
            XmlSerializer s = new XmlSerializer(typeof(Invoice), xRoot);
            return s;
        }

        public void Save(string fileName)
        {
            var writer = XmlWriter.Create(fileName);
            XmlSerializer s = GetSerializer();
            s.Serialize(writer, this);
            writer.Close();
        }

        public void Save(System.IO.TextWriter writer)
        {
            XmlSerializer s = GetSerializer();
            s.Serialize(writer, this);
        }

        public void Save(XmlWriter writer)
        {
            XmlSerializer s = GetSerializer();
            s.Serialize(writer, this);
        }

        public void Save(System.IO.Stream stream)
        {
            XmlSerializer s = GetSerializer();
            s.Serialize(stream, this);
        }
    }
}
