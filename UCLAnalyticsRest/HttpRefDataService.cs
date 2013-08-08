using System;
using System.Net;
using System.IO;
using System.Text;
using UCLAnalytics.Rest.TestServer.Resources;
using System.Runtime.Serialization.Json;
using OpenRasta.Hosting.InMemory;
using OpenRasta.Configuration;
using OpenRasta.Web;
using OpenRastaConfiguration = UCLAnalytics.Rest.TestServer.Config.WebConfiguration;
using UCLAnalytics.Rest.TestServer.Repositories;

namespace UCLAnalytics.Rest.TestServer
{
    public class HttpRefDataService : IGetRefData
    {
        private WebRequest request;
        private Stream dataStream;
        private string status;

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public void CreateRequest(string url, string cusip)
        {
            request = WebRequest.Create(url);
            request.Method = "GET";

            string dataToService = cusip;
            byte[] dataByteArray = Encoding.UTF8.GetBytes(dataToService);

            request.ContentType = "application/json";
            request.ContentLength = dataByteArray.Length;

            dataStream = request.GetRequestStream();
            dataStream.Write(dataByteArray, 0, dataByteArray.Length);

            dataStream.Close();
        }

        public RefData GetByCusip(string cusip)
        {
            return new RefData();
        }

        public RefData GetByCusip(string url, string cusip)
        {
            Console.WriteLine("Reached HttpRefDataService GetByCusip with url: " + url);

            return MockRefDataRepository.GetByCusip(cusip);

            //CreateRequest(url, cusip);

            //WebResponse response = request.GetResponse();

            //if (response != null)
            //{
            //    Console.WriteLine("HttpRefDataService got a response");
            //}

            //this.Status = ((HttpWebResponse)response).StatusDescription;

            //dataStream = response.GetResponseStream();

            //var ser = new DataContractJsonSerializer(typeof(RefData));

            //RefData refDataObject;
            //refDataObject = (RefData)ser.ReadObject(dataStream);


            ////     StreamReader sr = new StreamReader(dataStream);
            ////     string refDataResponse = sr.ReadToEnd();

            ////     sr.Close();
            //dataStream.Close();
            //response.Close();

            ////     return refDataResponse;
            //return refDataObject;
        }

        //public RefData GetByCusip(string url, string cusip)
        //{
        //    Console.WriteLine("Reached HttpRefDataService GetByCusip" + " : " + url);


        //    RefData refDataObject = null;

        //    using (var host = new InMemoryHost(new OpenRastaConfiguration()))
        //    {
        //        var request = new InMemoryRequest()
        //        {
        //            Uri = new Uri(url),
        //            HttpMethod = "GET"
        //        };

        //        // set up code formats

        //        request.Entity.ContentType = MediaType.Json;
        //        request.Entity.Headers["Accept"] = "application/json";

        //        // send the request and save the resulting response
        //        var response = host.ProcessRequest(request);
        //        int statusCode = response.StatusCode;

        //        // deserialize the content from the response

        //        if (response.Entity.ContentLength > 0)
        //        {
        //            // rewind the stream, as OpenRasta won't do this
        //            response.Entity.Stream.Seek(0, SeekOrigin.Begin);

        //            var serializer =
        //                new DataContractJsonSerializer(typeof(RefData));

        //            refDataObject = (RefData)serializer.ReadObject(response.Entity.Stream);
        //        }

        //        return refDataObject;
        //    }
        //}
    }
}
