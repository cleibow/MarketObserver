using Autofac;
using MarketObserver.Business;
using MarketObserver.Business.BusinessLogic;
using MarketObserver.Business.Generics;
using MarketObserver.Business.HttpClients;
using MarketObserver.Business.Services;
using MarketObserver.Model.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MarketObserver.Web.Autofac
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterGeneric(typeof(MongoDataService<>)).As(typeof(IMongoDataService<>));
            builder.RegisterType<MarketObserverConfiguration>().As<IMarketObserverConfiguration>();

            builder.RegisterType<UserBusinessLogic>().As<IUserBusinessLogic>();
            builder.RegisterType<StockBusinessLogic>().As<IStockBusinessLogic>();

            builder.RegisterType<MarketStackHttpClient>().As<IMarketStackHttpClient>();

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<StockSeedDataService>().As<IStockSeedDataService>();
            builder.RegisterType<StockDataService>().As<IStockDataService>();
            //builder.Register(t =>
            //{
            //    var httpClient = new HttpClient
            //    {
            //        BaseAddress = new Uri("https://api.github.com")
            //    };

            //    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            //    return httpClient;
            //});

            //builder.RegisterType<MarketStackHttpClient>()
            //    .Named("MarketStackHttpClient", typeof(IHttpClient))
            //    .SingleInstance();
            //builder.Register(c => c.Resolve<MarketStackHttpClient>()._httpClient).As<IMarketStackHttpClient>();

        }
    }
}
