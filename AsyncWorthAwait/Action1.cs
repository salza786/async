using System.Threading;
using System.Threading.Tasks;

namespace AsyncWorthAwait
{
    internal class Action1
    {
        internal static Task<string> Execute()
        {  
            return Task.Run(() =>
            {
                Thread.Sleep(3000);
                return "Action 1 completed";
            });
        }
    }
}

