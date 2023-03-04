using Autofac;
using NNChallenge.Contracts;
using NNChallenge.Services.Forecast;

namespace NNChallenge.Config
{
    public class AutofacConfig
    {
        public static ContainerBuilder CreateBuilder()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ServiceModule>();
            return builder;
        }

        private class ServiceModule : Autofac.Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<ForecastService>().As<IForecastService>();
            }
        }
    }
}
