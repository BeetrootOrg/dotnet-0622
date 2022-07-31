using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class SenseBoxResponse
    {
        private HttpWebRequest _request;
        private string _url;
        public string Response { get; set; }

        internal SenseBoxResponse(string Url)
        {
            _url = Url;
        }
        public void Run()
        {
            _request = (HttpWebRequest)WebRequest.Create(_url);
            _request.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var stream = response.GetResponseStream();
                if (stream != null) Response = new StreamReader(stream).ReadToEnd();

        }
    }
}
