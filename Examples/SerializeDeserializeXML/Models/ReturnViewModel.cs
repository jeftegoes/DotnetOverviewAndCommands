using System.Xml.Serialization;

namespace ExampleDotnetSerializeDeserializeXML.Models
{
    [XmlRoot("post-method")]
    public class PostMethod
    {
        [XmlElement("response-code")]
        public int ResponseCode { get; set; }

        [XmlElement("response-desc")]
        public string ResponseDesc { get; set; }

        [XmlElement("entity")]
        public Entity entity { get; set; }

        [XmlRoot("entity")]
        public class Entity
        {
            [XmlElement("content-type")]
            public string ContentType { get; set; }
            [XmlElement("content")]
            public Content Content { get; set; }
        }

        [XmlRoot("content")]
        public class Content
        {
            [XmlElement(ElementName = "Body", Namespace = "X")]
            public Body Body { get; set; }
        }

        [XmlRoot(ElementName = "Body")]
        public class Body
        {
            [XmlElement("execSyncResponse")]
            public ExecSyncResponse ExecSyncResponse { get; set; }
        }

        [XmlRoot("execSyncResponse")]
        public class ExecSyncResponse
        {
            [XmlElement("return")]
            public Return Return { get; set; }
        }

        [XmlRoot("return")]
        public class Return
        {
            [XmlElement("errorType")]
            public string ErrorType { get; set; }

            [XmlElement("serviceStatus")]
            public int ServiceStatus { get; set; }

            [XmlElement("serviceDescription")]
            public string ServiceDescription { get; set; }

            [XmlElement("serviceException")]
            public string ServiceException { get; set; }
        }
    }
}