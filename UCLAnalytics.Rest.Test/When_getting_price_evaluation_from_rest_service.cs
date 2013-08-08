using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenRasta.Configuration;
using UCLAnalytics.Rest.TestServer.Repositories;
using UCLAnalytics.Rest.TestServer.Resources;
using OpenRastaConfiguration = UCLAnalytics.Rest.TestServer.Config.WebConfiguration;
using OpenRasta.Hosting.InMemory;
using System;
using OpenRasta.Web;
using System.IO;
using System.Runtime.Serialization.Json;

namespace UCLAnalytics.Rest.Test
{
    [TestFixture]
    public class When_getting_price_evaluation_from_rest_service : Given_a_rest_service
    {
        private Evaluation ev;

        protected override IConfigurationSource Config
        {
            get { return new OpenRastaConfiguration(); }
        }

        [SetUp]
        public void Create_server_and_issue_a_get_request()
        {
            using (var host = new InMemoryHost(new OpenRastaConfiguration()))
            {
                var request = new InMemoryRequest()
                {
                    Uri = new Uri("http://localhost/10000/yield?price=1.5"),
                    HttpMethod = "GET"
                };

                // set up code formats

                request.Entity.ContentType = MediaType.Json;
                request.Entity.Headers["Accept"] = "application/json";

                // send the request and save the resulting response
                var response = host.ProcessRequest(request);
                int statusCode = response.StatusCode;

                // deserialize the content from the response

                if (response.Entity.ContentLength > 0)
                {
                    // rewind the stream, as OpenRasta won't do this
                    response.Entity.Stream.Seek(0, SeekOrigin.Begin);

                    var serializer =
                        new DataContractJsonSerializer(typeof(Evaluation));

                    ev = (Evaluation)serializer.ReadObject(response.Entity.Stream);
                }
            }
        }
      
        [Test]
        public void Should_get_result_of_price_evaluation_by_cusip()
        {
            Assert.That(ev.Result, Is.EqualTo(2.54));
        }        
    }    
}
        
