﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommercePortal.Controllers
{
    public class DriverController : ApiController
    {
        // GET: api/Driver
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Driver/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Driver
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Driver/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Driver/5
        public void Delete(int id)
        {
        }
    }
}
