using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using HTGQD2.Models;
namespace HTGQD2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UniversitiesController : ApiController
    {
        private DataContext db = new DataContext();
        public IHttpActionResult Get()
        {
            return Ok(db.University);
        }
    }
}
