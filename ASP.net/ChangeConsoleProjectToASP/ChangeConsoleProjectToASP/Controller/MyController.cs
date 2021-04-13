using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChangeConsoleProjectToASP
{
    public class MyController : Controller
    {
        [Route("test")]
        [HttpPost]
        public async Task Test1Async()
        {
            Console.WriteLine("test1");
            await Task.Delay(10).ConfigureAwait(false);
        }

        [Route("test")]
        [HttpGet]
        public async Task Test2Async()
        {
            Console.WriteLine("test2");
            await Task.Delay(10).ConfigureAwait(false);
        }

        //[Route("test")]
        //[HttpGet]
        //public async Task Test3Async()
        //{
        //    Console.WriteLine("test3");
        //    await Task.Delay(10).ConfigureAwait(false);
        //}
    }
}
