using OpenRasta.Configuration;
using UCLAnalytics.Rest.TestServer.Resources;
using UCLAnalytics.Rest.TestServer.Handlers;


namespace UCLAnalytics.Rest.TestServer.Config
{
    public class WebConfiguration : IConfigurationSource
    {
        public void Configure()
        {
            ResourceSpace.Uses.Resolver.AddDependencyInstance(typeof(IGetRefData), new MockRefDataFetcher("http://localhost/Repositories/MockRefDataRepository"), OpenRasta.DI.DependencyLifetime.Singleton);
            ResourceSpace.Uses.Resolver.AddDependencyInstance(typeof(IAnalyticsService), new MockAnalytics(), OpenRasta.DI.DependencyLifetime.Singleton);
            
            using (OpenRasta.Configuration.OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Has.ResourcesOfType<RefData>()
                       .AtUri("/{cusip}/refData")
                       .HandledBy<RefDataHandler>()
                       .AsJsonDataContract();

                ResourceSpace.Has.ResourcesOfType<Price>()
                       .AtUri("/{cusip}/price?yield={yield}")
                       .HandledBy<BondPriceHandler>()
                       .AsJsonDataContract();

                ResourceSpace.Has.ResourcesOfType<Yield>()
                       .AtUri("/{cusip}/yield?price={price}")
                       .HandledBy<BondYieldHandler>()
                       .AsJsonDataContract();

                ResourceSpace.Has.ResourcesOfType<Accrued>()
                       .AtUri("/{cusip}/accrued")
                       .HandledBy<BondAccruedHandler>()
                       .AsJsonDataContract();

                ResourceSpace.Has.ResourcesOfType<Evaluation>()
                       .AtUri("/{cusip}/evaluation?quoteType={quoteType}&quote={quote}&tradeDate={tradeDate}" +
                        "&settleDate={settleDate}&notional={notional}")
                       .HandledBy<BondEvHandler>()
                       .AsJsonDataContract();

                //// for test purpose 
                //ResourceSpace.Has.ResourcesOfType<RefData>()
                //       .AtUri("/Repositories/MockRefDataRepository?cusip={cusip}")
                //       .HandledBy<MockRefDataServiceHandler>()
                //       .AsJsonDataContract();        
            }
        }

    }
}
