using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace httpClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Fetching Data from one API to another API
            using HttpClient c = new HttpClient();
            c.BaseAddress=new Uri("https://localhost:44383/api/Students/");
            HttpResponseMessage responseMessage=await c.GetAsync(c.BaseAddress);
            string str=await c.GetStringAsync(c.BaseAddress);
            Console.WriteLine("Status:"+responseMessage.StatusCode);
            Console.WriteLine("Response Data:"+str);
        }
    }
}
