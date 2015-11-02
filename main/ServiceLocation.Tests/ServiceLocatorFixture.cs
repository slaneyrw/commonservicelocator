using System;
using Xunit;
using ServiceLocation;
using ServiceLocation.Tests.Mocks;

namespace ServiceLocation.Tests
{
    public class ServiceLocatorFixture
    {
        public ServiceLocatorFixture()
        {
            ServiceLocator.SetLocatorProvider(null);
        }

        [Fact]
        public void ServiceLocatorIsLocationProviderSetReturnsTrueWhenSet()
        {
            ServiceLocator.SetLocatorProvider(() => new MockServiceLocator());

            Assert.True(ServiceLocator.IsLocationProviderSet);
        }

        [Fact]
        public void ServiceLocatorIsLocationProviderSetReturnsFalseWhenNotSet()
        {
            Assert.False(ServiceLocator.IsLocationProviderSet);
        }

        [Fact]
        public void ServiceLocatorCurrentThrowsWhenLocationProviderNotSet()
        {
            IServiceLocator currentServiceLocator;
            var ex = Assert.Throws<InvalidOperationException>(() => currentServiceLocator = ServiceLocator.Current);

        }
    }
}
