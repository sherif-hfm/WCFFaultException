using ServiceTest.Srv1Ref;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string xml2 = Resource1.err3;
            //var serializer2 = new XmlSerializer(typeof(fault));

            //using (TextReader reader = new StringReader(xml2))
            //{
            //    var result2 = (fault)serializer2.Deserialize(reader);
            //}

            //Srv1Ref
            try
            {
                Srv1Ref.Service1Client srv = new Srv1Ref.Service1Client();
                 var result = srv.GetData(6);
            }
            catch (FaultException ex)
            {
                var errorElement = XElement.Parse(ex.CreateMessageFault().GetReaderAtDetailContents().ReadOuterXml());

                string xml = errorElement.ToString();
                var serializer = new XmlSerializer(typeof(ExceptionContract));
                ExceptionContract result;

                using (TextReader reader = new StringReader(xml))
                {
                    result = (ExceptionContract)serializer.Deserialize(reader);
                }

                //MessageFault msgFault = ex.CreateMessageFault();
                //var msg = msgFault.GetReaderAtDetailContents();
            }
        }
    }


    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.datacontract.org/2004/07/WcfService1", IsNullable = false)]
    public partial class ExceptionContract
    {

        private string errMsgField;

        /// <remarks/>
        public string ErrMsg
        {
            get
            {
                return this.errMsgField;
            }
            set
            {
                this.errMsgField = value;
            }
        }
    }


}
