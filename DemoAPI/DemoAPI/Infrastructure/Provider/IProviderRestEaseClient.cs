using DemoAPI.Infrastructure.Provider.Model;
using RestEase;

namespace DemoAPI.Infrastructure.Provider;

public interface IProviderRestEaseClient
{
    [Get("api/Provider")]
    Task<Product> GetProviderDataAsync();
}
