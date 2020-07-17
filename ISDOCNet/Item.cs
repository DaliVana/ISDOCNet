namespace ISDOCNet
{
    using System.Collections.Generic;

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
            this._storeBatches = new List<StoreBatch>();
            this._buyersItemIdentification = new BuyersItemIdentification();
            this._tertiarySellersItemIdentification = new TertiarySellersItemIdentification();
            this._secondarySellersItemIdentification = new SecondarySellersItemIdentification();
            this._sellersItemIdentification = new SellersItemIdentification();
            this._catalogueItemIdentification = new CatalogueItemIdentification();
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
