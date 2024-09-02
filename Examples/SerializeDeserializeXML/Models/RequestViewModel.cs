using System.Xml.Serialization;

namespace ExampleDotnetSerializeDeserializeXML.Models
{
    [XmlRoot(ElementName = "envelope")]
    public class Envelope
    {
        public Envelope()
        {
            header = new Header();
            body = new Body()
            {
                Order = new Order()
                {
                    ItemsOrdered = new ItemsOrdered()
                }
            };
        }

        [XmlElement("header")]
        public Header header { get; set; }

        [XmlElement("body")]
        public Body body { get; set; }

        [XmlRoot(ElementName = "header")]
        public class Header
        {

        }

        [XmlRoot(ElementName = "body")]
        public class Body
        {
            [XmlElement("order")]
            public Order Order { get; set; }
        }

        [XmlRoot(ElementName = "order")]
        public class Order
        {
            [XmlElement("number-order")]
            public int NumberOrder { get; set; }
            [XmlElement("items-ordered")]
            public ItemsOrdered ItemsOrdered { get; set; }
        }

        [XmlRoot(ElementName = "items-ordered")]
        public class ItemsOrdered
        {
            [XmlElement("item")]
            public string Item { get; set; }
        }
    }
}