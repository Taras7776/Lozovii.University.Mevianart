﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Lozovii.University.Mevianart.Core;
using Lozovii.University.Mevianart.Database;

namespace Lozovii.University.Mevianart.Test
{
    public class TestBase
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public ILogger Logger { get; private set; }

        protected TestBase()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", false)
                        .AddJsonFile("appsettings.Development.json", true)
                        .AddUserSecrets<TestBase>();

            IConfigurationRoot configuration = builder.Build();

            var services = new ServiceCollection();

            services.AddLogging((config) => config.AddDebug());
            services.RegisterCoreDependencies();
            services.RegisterCoreConfiguration(configuration);
            services.RegisterDatabseDependencies(configuration);

            ServiceProvider = services.BuildServiceProvider();
            Logger = ServiceProvider.GetRequiredService<ILogger<TestBase>>();
        }

        protected T ResolveService<T>() where T : class
        {
            return ServiceProvider.GetRequiredService<T>();
        }
    }
}