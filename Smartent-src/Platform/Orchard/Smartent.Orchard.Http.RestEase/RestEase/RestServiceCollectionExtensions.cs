using Microsoft.Extensions.DependencyInjection;
using RestEase;
using System;

namespace Smartent.Orchard.Http.RestEase;

public static class RestServiceCollectionExtensions
{
    /// <summary>
    /// 使用 RestEase 向服务集合添加类型化 HTTP 客户端。
    /// </summary>
    /// <typeparam name="TClient">API 客户端类型。</typeparam>
    /// <param name="services">服务集合。</param>
    /// <param name="name">HTTP 客户端名称。</param>
    /// <param name="getBaseUrl">返回 API 基址的函数。</param>
    /// <returns>HTTP 客户端构建器。</returns>
    public static IHttpClientBuilder AddRestEaseHttpClient<TClient>(
        this IServiceCollection services,
        string name,
        Func<IServiceProvider, string> getBaseUrl)
        where TClient : class =>
        services
            .AddHttpClient(name, (provider, client) => client.BaseAddress = new Uri(getBaseUrl(provider)))
            .AddTypedClient(RestClient.For<TClient>);
}