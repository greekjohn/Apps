using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WcfClient.ServiceReference1;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            UserClient client = new UserClient();
            string result = client.ShowName("this.test");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
