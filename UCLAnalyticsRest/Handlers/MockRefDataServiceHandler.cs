using System;
using System.Collections.Generic;
using OpenRasta.Web;
using UCLAnalytics.Rest.TestServer.Repositories;
using UCLAnalytics.Rest.TestServer.Resources;

namespace UCLAnalytics.Rest.TestServer.Handlers
{
    public class MockRefDataServiceHandler
    {
        public OperationResult GetByCusip(string cusip)
        {
            try
            {
                Console.WriteLine("Reached MockRefDataServiceHandler GetByCusip");
                return new OperationResult.OK { ResponseResource = MockRefDataRepository.GetByCusip(cusip) };
            }

            catch (KeyNotFoundException ex)
            {
                return new OperationResult.BadRequest { ResponseResource = ex.StackTrace };
            }
        }
    }
}
