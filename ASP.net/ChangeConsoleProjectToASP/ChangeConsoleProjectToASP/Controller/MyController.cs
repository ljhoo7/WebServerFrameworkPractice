using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChangeConsoleProjectToASP
{
    [Route("test")]
    public class MyController : Controller
    {
        [HttpPost]
        [Route("test")]
        public static async Task TestAsync()
        {
            Console.WriteLine("test");
            await Task.Delay(10).ConfigureAwait(false);
        }
    }
}
