namespace ISDOCNet
{
    using System.Collections.Generic;
    using System.Linq;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Item
    {

        #region Private fields
        private string _description;

        private CatalogueItemIdentification _catalogueItemIdentification;

        private SellersItemIdentification _sellersItemIdentification;

        private SecondarySellersItemIdentification _secondarySellersItemIdentification;

        private TertiarySellersItemIdentification _tertiarySellersItemIdentification;

        private BuyersItemIdentification _buyersItemIdentification;

        private List<StoreBatch> _storeBatches;
        #endregion

        public Item()
        {
            //this._storeBatches = new List<StoreBatch>();
            //this._buyersItemIdentification = new BuyersItemIdentification();
            //this._tertiarySellersItemIdentification = new TertiarySellersItemIdentification();
            //this._secondarySellersItemIdentification = new SecondarySellersItemIdentification();
            //this._sellersItemIdentification = new SellersItemIdentification();
            //this._catalogueItemIdentification = new CatalogueItemIdentification();
        }

        public bool ShouldSerializeDescription()
        {
            return _description != null;
        }

        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public bool ShouldSerializeCatalogueItemIdentification()
        {
            return _catalogueItemIdentification != null;
        }

        public CatalogueItemIdentification CatalogueItemIdentification
        {
            get
            {
                return this._catalogueItemIdentification;
            }
            set
            {
                this._catalogueItemIdentification = value;
            }
        }
        public bool ShouldSerializeSellersItemIdentification()
        {
            return _sellersItemIdentification != null;
        }

        public SellersItemIdentification SellersItemIdentification
        {
            get
            {
                return this._sellersItemIdentification;
            }
            set
            {
                this._sellersItemIdentification = value;
            }
        }
        public bool ShouldSerializeSecondarySellersItemIdentification()
        {
            return _secondarySellersItemIdentification != null;
        }

        public SecondarySellersItemIdentification SecondarySellersItemIdentification
        {
            get
            {
                return this._secondarySellersItemIdentification;
            }
            set
            {
                this._secondarySellersItemIdentification = value;
            }
        }
        public bool ShouldSerializeTertiarySellersItemIdentification()
        {
            return _tertiarySellersItemIdentification != null;
        }

        public TertiarySellersItemIdentification TertiarySellersItemIdentification
        {
            get
            {
                return this._tertiarySellersItemIdentification;
            }
            set
            {
                this._tertiarySellersItemIdentification = value;
            }
        }

        public bool ShouldSerializeBuyersItemIdentification()
        {
            return _buyersItemIdentification != null;
        }

        public BuyersItemIdentification BuyersItemIdentification
        {
            get
            {
                return this._buyersItemIdentification;
            }
            set
            {
                this._buyersItemIdentification = value;
            }
        }

        public bool ShouldSerializeStoreBatches()
        {
            return _storeBatches != null && _storeBatches.Any();  
        }

        public List<StoreBatch> StoreBatches
        {
            get
            {
                return this._storeBatches;
            }
            set
            {
                this._storeBatches = value;
            }
        }
    }
}
