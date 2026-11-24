# Smartent Orchard Marketing - URL Shortener for Orchard Core
> **中文说明**: [Readme-CN.md](Readme-CN.md)


[![Smartent.Orchard.Marketing.UrlShortener NuGet](https://img.shields.io/nuget/v/Smartent.Orchard.Marketing.UrlShortener?label=Smartent.Orchard.Marketing.UrlShortener)](https://www.nuget.org/packages/Smartent.Orchard.Marketing.UrlShortener/)

## About

This module adds short URL support to Orchard Core.

## Documentation

This module contains the feature below.

### `Smartent.Orchard.Marketing.UrlShortener`

This feature adds a `ShortUrl` content type that you can use to create short URL redirects.

Each short URL points to a destination URL. You can also store UTM values with the short URL entry.

The redirect itself goes to the configured destination URL as-is. The UTM values are not added to the browser redirect URL. The UTM values are sent to the registered `IShortUrlRedirectEventHandler` implementations as part of the redirect context, so you can use them for hit registration in your other modules.

The module also contains extension points that other modules can use when a short URL redirect happens. Implement a `IShortUrlRedirectEventHandler` to get notified about the redirect and access the short URL entry and the context of the request.

To use the module, follow these steps:

1. Enable the `Smartent.Orchard.Marketing.UrlShortener` feature from the admin.
2. Open `Tools -> Short URLs`.
3. Create a new short URL content item.
4. Set the short URL, destination URL, and optional UTM values.