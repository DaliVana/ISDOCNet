namespace ISDOCNet
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class PostalAddress
    {

        #region Private fields
        private string _streetName;

        private string _buildingNumber;

        private string _cityName;

        private string _postalZone;

        private Country _country;
        #endregion

        public PostalAddress()
        {
            this._country = new Country();
        }

        public string StreetName
        {
            get
            {
                return this._streetName;
            }
            set
            {
                this._streetName = value;
            }
        }

        public string BuildingNumber
        {
            get
            {
                return this._buildingNumber;
            }
            set
            {
                this._buildingNumber = value;
            }
        }

        public string CityName
        {
            get
            {
                return this._cityName;
            }
            set
            {
                this._cityName = value;
            }
        }

        public string PostalZone
        {
            get
            {
                return this._postalZone;
            }
            set
            {
                this._postalZone = value;
            }
        }

        public Country Country
        {
            get
            {
                return this._country;
            }
            set
            {
                this._country = value;
            }
        }
    }
}
