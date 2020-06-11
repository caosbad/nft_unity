﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NftUnity.Test
{
    public class TestConfiguration
    {
        public string WsEndpoint { get; set; } = null!;
        public AccountInfo Account1 { get; set; } = null!;

        public TestConfiguration()
        {
        }
        
        public static TestConfiguration Create()
        {
            var configurationRoot = new ConfigurationBuilder()
                .AddYamlFile("TestConfiguration.yml")
                .AddEnvironmentVariables()
                .Build();
            var testConfiguration = new TestConfiguration();
            configurationRoot.Bind(testConfiguration);
            return testConfiguration;
        }
    }
}