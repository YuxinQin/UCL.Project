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
    public class When_getting_ref_data_from_a_rest_service : Given_a_rest_service
    {
        private RefData refData;

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
                    Uri = new Uri("http://localhost/10000/refData"),
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
                        new DataContractJsonSerializer(typeof(RefData));

                    refData = (RefData)serializer.ReadObject(response.Entity.Stream);
                }
            }
        }

        [Test]
        public void Should_get_a_ref_data_by_cusip()
        {                 
            Assert.That(refData.Cusip, Is.EqualTo("10000"));                
            Assert.That(refData.BondType, Is.EqualTo("Fixed Coupon"));
            Assert.That(refData.Maturity, Is.EqualTo(1.101F));
            Assert.That(refData.Coupon, Is.EqualTo(1.25F));
            Assert.That(refData.issuePrice, Is.EqualTo(80.03));
        }  
         
    }                          
}


