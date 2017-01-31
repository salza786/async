using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncWorthAwait
{
    internal class Action2
    {
        
        public async static Task<string> ExecuteA()
        {
            await Task.Delay(2000);
            return DateTime.Now.ToString("hh:mm:ss:ff");
        }

        public async static Task<string> ExecuteB()
        {
            await Task.Delay(4000);
            return DateTime.Now.ToString("hh:mm:ss:ff");
        }
    }
}
