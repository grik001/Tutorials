using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAppThreadTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public async Task<dynamic> Get1(string token)
        {
            int threadID = Thread.CurrentThread.ManagedThreadId;

            var t = Task.Run(() => SetToken(token));
            await t;

            var logToken = log4net.ThreadContext.Properties["token"];

            var result = $"ThreadID:{threadID}|Token:{logToken}";
            return result;
        }

        public void SetToken(string token)
        {
            log4net.ThreadContext.Properties["token"] = token;
        }

        // GET api/values/5
        public dynamic Get2()
        {
            var token = log4net.ThreadContext.Properties["token"];
            int threadID = Thread.CurrentThread.ManagedThreadId;
            var result = $"ThreadID:{threadID}|Token:{token}";
            return result;
        }


    }
}
