using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Avpm.Payments.Core.Models.FreedomPay
{
    [XmlRoot(ElementName = "POSResponse", Namespace = "http://schemas.datacontract.org/2004/07/Avpm.Payments.Core.Models.FreedomPay")]
    public class POSResponse
    {
        [XmlElement(ElementName = "decision")]
        public string Decision { get; set; } //A

        [XmlElement(ElementName = "errorCode")]
        public int ErrorCode { get; set; } //100

        public string message { get; set; } // Token Returned
        public string RequestGuid { get; set; } // 72041b0f-70ce-4af9-b2b5-2fa5925d1ee3
        public decimal ApprovedAmount { get; set; }
        public string Token { get; set; } // 8150146164081954
        public string MaskedCardNumber { get; set; } // 401200xxxxxx0026
        public string NameOnCard { get; set; } // BOYINGTON CLINTON C
        public string ExpiryDate { get; set; } // 1249
        public string MerchantReferenceCode { get; set; } // 2F231C42050241E1
        public DateTime TokenExpiration { get; set; } // 2019-05-24T00:00:00.0000000Z
        public bool DCCAccepted { get; set; }
        public string ReceiptText { get; set; }
        /* 
        ReceiptText:
        *************** PURCHASE ***************
                          APPROVED

        Card Type:  VISA
        Card Entry: SWIPED
        Acct #:     ************0026 ]
        Approval Code: ******

        X ______________________________________
        */
        public bool PinVerified { get; set; }
        public bool SignatureRequired { get; set; }
    }
}
