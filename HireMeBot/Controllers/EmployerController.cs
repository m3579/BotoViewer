using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using HireMeBot.EmployerSide;
using HireMeBot.InterviewData;

namespace HireMeBot.Controllers
{
    /// <summary>
    /// The class responding to REST API calls from the employer
    /// web portal
    /// </summary>
    public class EmployerController : ApiController
    {
        // GET api/<controller>
        [Route("api/employer")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/key
        [Route("api/employer/{key}")]
        public IList<string> Get(string key)
        {
            Debug.WriteLine("Called with key: " + key);

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
        
        [Route("api/employer/characteristics")]
        public void Post([FromBody]IList<string> characteristics)
        {
            Debug.WriteLine("REST API call api/employer/characteristics");

            if (characteristics == null)
            {
                Debug.WriteLine("Empty HTTP message body (expected list of characteristics); will do nothing");
                return;
            }

            OverallCriteriaModel overallCriteria = OverallCriteriaModel.GetInstance();

            Debug.WriteLine(characteristics.Count);

            //foreach (string characteristic in characteristics)
            //{
            //    overallCriteria.Characteristics.Add(new Characteristic(characteristic));
            //    Debug.WriteLine("Added characteristic: |" + characteristic + "|");
            //}
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