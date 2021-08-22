using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace LotteryTicketsClient.Requests
{
    public class CustomHttpRequest
    {

        private HttpClient client;

        public CustomHttpRequest()
        {
            this.client = new HttpClient();
        }

        public string post(string url, string jsonBody)
        {
            var response = client.PostAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            return response.ToString();
        }

        public string get(string url)
        {
            HttpWebRequest request =
            (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.Accept = "application/json";
            request.UserAgent = "Mozilla/5.0 ....";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder output = new StringBuilder();
            output.Append(reader.ReadToEnd());
            response.Close();
            return output.ToString();
        }

        public string put(string url, string jsonBody)
        {
            var response = client.PutAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            return response.ToString();
        }

        public string patch(string url, string jsonBody)
        {
            var response = client.PatchAsync(url, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

            return response.ToString();
        }

        public string delete(string url)
        {
            var response = client.DeleteAsync(url);

            return response.ToString();
        }
    }

}
