using NUnit.Framework;
using RestSharp;
using System;

namespace Restsharp_demo
{
    class Program1
    {

        public static void Main(string[] args)
        {
            RestClient client = new RestClient("https://chercher.tech/sample/api/product/");
            RestRequest request = new RestRequest("/read?id=6462", Method.GET);
            IRestResponse response = client.Execute(request);
            String res = response.Content.ToString();

            if (res.Contains("APIwithSelenium Edit"))
                Assert.IsTrue(true, "APIwithSelenium Edit");
            Console.WriteLine("Response matches");
            Console.WriteLine(res);

            int statuscode = (int)response.StatusCode;
            Console.WriteLine(statuscode);
            Assert.AreEqual(200, statuscode, "Status code is not 200");
            Assert.AreEqual(true, res.Contains("APIwithSelenium Edit"));

        }
    }
}
