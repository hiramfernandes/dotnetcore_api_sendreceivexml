using Avpm.Payments.Core.Models.FreedomPay;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_SendReceive_Xml.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XmlController : ControllerBase
    {
        public XmlController()
        {

        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/values
        [HttpPost, FormatFilter]
        [Produces("application/xml")]
        public POSResponse Post([FromBody] POSRequest request)
        {
            var response = new POSResponse()
            {
                ApprovedAmount = 123,
                DCCAccepted = true,
                MaskedCardNumber = "1234*****5678",
                ExpiryDate = DateTime.Now.AddYears(2).ToLongDateString(),
                MerchantReferenceCode = "ABC",
                message = "MESSAGE",
                NameOnCard = "AVPM Card",
                TokenExpiration = DateTime.Now.AddDays(1),
                ErrorCode = 0,
                Decision = "ABC",
                Token = "ABC123"
            };

            return response;
        }
    }
}
