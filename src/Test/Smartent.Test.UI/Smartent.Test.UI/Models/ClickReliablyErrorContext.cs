#nullable enable

using Smartent.Test.UI.Services;
using OpenQA.Selenium;
using System;

namespace Smartent.Test.UI.Models;

internal sealed record ClickReliablyErrorContext(
    UITestContext Context,
    IWebElement Element,
    By? OriginalSelector,
    Exception Exception,
    bool ShouldThrow = false);
