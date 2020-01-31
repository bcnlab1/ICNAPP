using ICNAPPHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ICNAPP.API.Controllers
{
    public class RequestHandlerController : ApiController
    {
        ICNAPP.API.ICNImplementation.ICNImplementation _iCNImplementation; 
        public RequestHandlerController()
        {
            _iCNImplementation = new ICNImplementation.ICNImplementation();
        }

        [HttpGet]
        public IEnumerable<string> RequestProcessing(string interestName)
        {
            DateTime requestStartTime = DateTime.Now;

            LogHelper.WriteDebugLog("RequestProcessing");

            string resultStatus = _iCNImplementation.ProcessInterest(interestName,ConfigurationHelper.Face);

            return new string[] { resultStatus };
        }
    }
}
