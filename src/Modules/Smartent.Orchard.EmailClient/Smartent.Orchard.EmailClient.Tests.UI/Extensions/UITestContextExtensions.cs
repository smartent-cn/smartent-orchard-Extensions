using Smartent.Orchard.EmailClient.Samples.Controllers;
using Smartent.Orchard.EmailClient.Tests.UI.Constants;
using Smartent.Orchard.Platform.Mvc;
using Smartent.Test.UI.Extensions;
using Smartent.Test.UI.Services;
using OpenQA.Selenium;
using System;
using System.Threading.Tasks;

namespace Smartent.Orchard.EmailClient.Tests.UI.Extensions;

public static class UITestContextExtensions
{
    public static Task ExecuteEmailClientSampleRecipeDirectlyAsync(this UITestContext context) =>
        context.ExecuteRecipeDirectlyAsync("Smartent.Orchard.EmailClient.Samples");

    public static Task InitSampleEmailsAsync(this UITestContext context) =>
        context.CreateAndUseLocalSmtpClientToSendEmailsFromFilesAsync(TestEmailPaths.SampleEmailPaths);

    public static Task GoToImapTestAsync(this UITestContext context) =>
        context.GoToAsync<ImapController>(controller => controller.Index());

    public static async Task SetImapPortOnAdminAsync(this UITestContext context)
    {
        await context.GoToAdminRelativeUrlAsync("/Settings/ImapSettings");
        await context.FillInWithRetriesAsync(
            By.Id("ISite_ImapSettings_Port"),
            context.SmtpServiceRunningContext.ImapPort.ToTechnicalString());
        await context.ClickReliablyOnSubmitAsync();
    }
}
