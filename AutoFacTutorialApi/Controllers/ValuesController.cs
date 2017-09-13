using AutoFacTutorialApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AutoFacTutorialApi.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IMessageHelper _messageHelper;

        //public ValuesController(IMessageHelper messageHelper)
        //{
        //    _messageHelper = messageHelper;
        //}

        // GET api/values
        public string Get()
        {
            return _messageHelper.GetMessage();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
