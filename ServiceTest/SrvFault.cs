using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ServiceTest
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://eservices.momra.gov.sa/momra/commonTypes/version/1/messages")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://eservices.momra.gov.sa/momra/commonTypes/version/1/messages", IsNullable = false)]
    public partial class fault
    {

        private string errorCodeField;

        private string errorMessageField;

        private string errorTypeField;

        private faultDetails detailsField;

        private faultLocation locationField;

        /// <remarks/>
        public string errorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        public string errorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }

        /// <remarks/>
        public string errorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        public faultDetails details
        {
            get
            {
                return this.detailsField;
            }
            set
            {
                this.detailsField = value;
            }
        }

        /// <remarks/>
        public faultLocation location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://eservices.momra.gov.sa/momra/commonTypes/version/1/messages")]
    public partial class faultDetails
    {

        private detail detailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public detail detail
        {
            get
            {
                return this.detailField;
            }
            set
            {
                this.detailField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class detail
    {

        private SamisNPVError samisNPVErrorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
        public SamisNPVError SamisNPVError
        {
            get
            {
                return this.samisNPVErrorField;
            }
            set
            {
                this.samisNPVErrorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel", IsNullable = false)]
    public partial class SamisNPVError
    {

        private ushort errorCodeField;

        private string errorTypeField;

        private SamisNPVErrorGroupErrorRes[] samisWSFaultField;

        /// <remarks/>
        public ushort ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        public string ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GroupErrorRes", IsNullable = false)]
        public SamisNPVErrorGroupErrorRes[] SamisWSFault
        {
            get
            {
                return this.samisWSFaultField;
            }
            set
            {
                this.samisWSFaultField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/SamisObjectModel")]
    public partial class SamisNPVErrorGroupErrorRes
    {

        private string errorGroupDescriptionField;

        private byte errorGroupFieldNumberField;

        /// <remarks/>
        public string ErrorGroupDescription
        {
            get
            {
                return this.errorGroupDescriptionField;
            }
            set
            {
                this.errorGroupDescriptionField = value;
            }
        }

        /// <remarks/>
        public byte ErrorGroupFieldNumber
        {
            get
            {
                return this.errorGroupFieldNumberField;
            }
            set
            {
                this.errorGroupFieldNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://eservices.momra.gov.sa/momra/commonTypes/version/1/messages")]
    public partial class faultLocation
    {

        private string nodeField;

        private string pathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.bea.com/wli/sb/context")]
        public string node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.bea.com/wli/sb/context")]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }



}
