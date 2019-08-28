using System.Xml.Serialization;

namespace Avpm.Payments.Core.Models.FreedomPay
{
    [XmlRoot(ElementName = "POSRequest")]
    public class POSRequest
    {
        [XmlElement(ElementName = "requestType")]
        public string RequestType { get; set; }//Sale

        [XmlElement(ElementName = "chargeAmount")]
        public decimal? ChargeAmount { get; set; }

        [XmlElement(ElementName = "clientEnvironment")]
        public string ClientEnvironment { get; set; } //FCCTestClient 4.0.3.5

        [XmlElement(ElementName = "StoreId")]
        public string StoreId { get; set; } //1413329017

        [XmlElement(ElementName = "TerminalId")]
        public string TerminalId { get; set; }

        [XmlElement(ElementName = "MerchantReferenceCode")]
        public string MerchantReferenceCode { get; set; } //2F231C42050241E1

        [XmlElement(ElementName = "InvoiceNumber")]
        public string InvoiceNumber { get; set; } // 1234567890
    }
}
