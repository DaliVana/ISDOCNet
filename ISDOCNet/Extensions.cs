namespace ISDOCNet
{
    using System.Collections.Generic;

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public partial class Extensions
    {

        #region Private fields
        private List<System.Xml.XmlElement> _any;
        #endregion

        public Extensions()
        {
            this._any = new List<System.Xml.XmlElement>();
        }

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public List<System.Xml.XmlElement> Any
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
    }
}