using System;
using System.Collections.Generic;
using System.Linq;
using UCLAnalytics.Rest.TestServer.Resources;
using System.Text;

namespace UCLAnalytics.Rest.TestServer
{
    public interface IGetRefData
    {
        RefData GetByCusip(string cusip);
    }
}
