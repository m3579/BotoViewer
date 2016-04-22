using HireMeBot.InterviewData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HireMeBot.Controllers
{
    /// <summary>
    /// The class responding to REST API calls from the employer
    /// web portal
    /// </summary>
    public class EmployerController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/key
        public IList<string> Get(string key)
        {
            switch (key)
            {
                case "characteristics":
                    {
                        return Characteristic.GetCharacteristics();
                    }

                default:
                    {
                        return null;
                    }
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}