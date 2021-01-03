using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MarketObserver.Web.Autofac
{
    //public class HttpClientModule<TService> : Module
    //{
    //    public HttpClientModule(Action<HttpClient> clientConfigurator)
    //    {
    //        this._clientConfigurator = clientConfigurator;
    //    }

    //    private readonly Action<HttpClient> _clientConfigurator;

    //    protected override void AttachToComponentRegistration(IComponentRegistryBuilder componentRegistry, IComponentRegistration registration)
    //    {
    //        base.AttachToComponentRegistration(componentRegistry, registration);

    //        if (registration.Activator.LimitType == typeof(TService))
    //        {
    //            registration.
    //            registration.Preparing += (sender, e) =>
    //            {
    //                e.Parameters = e.Parameters.Union(
    //                  new[]
    //                  {
    //                new ResolvedParameter(
    //                    (p, i) => p.ParameterType == typeof(HttpClient),
    //                    (p, i) => {
    //                        HttpClient client = i.Resolve<IHttpClientFactory>().CreateClient();
    //                        this._clientConfigurator(client);
    //                        return client;
    //                    }
    //                )
    //                  });
    //            };
    //        }
    //    }

    //}
}
