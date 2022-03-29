using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Website.Controllers
{
    public class PrescriptionCreationController : ApiController
    {
        public IHttpActionResult CreatePrescription()
        {
            return Json("test");
        }
    }
}
