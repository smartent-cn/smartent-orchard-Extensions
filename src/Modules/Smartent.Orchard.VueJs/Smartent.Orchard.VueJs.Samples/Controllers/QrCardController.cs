using Smartent.Orchard.VueJs.Samples.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using System.Threading.Tasks;
using static Smartent.Core.AspNet.Security.ContentSecurityPolicyDirectives;
using static Smartent.Core.AspNet.Security.ContentSecurityPolicyDirectives.CommonValues;

namespace Smartent.Orchard.VueJs.Samples.Controllers;

public sealed class QrCardController : Controller
{
    private readonly IContentManager _contentManager;

    public QrCardController(IContentManager contentManager) =>
        _contentManager = contentManager;

    /// <remarks><para>Open this from under /Smartent.Orchard.VueJs.Samples/QrCard/Index.</para></remarks>
    [ContentSecurityPolicy(Blob, WorkerSrc, ScriptSrc)]
    public ActionResult Index() =>
        View(new QrCardAppViewModel
        {
            ApiUrl = Url.Action(nameof(GetBusinessCard)),
        });

    public async Task<ActionResult> GetBusinessCard(string cardId)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        return await _contentManager.GetAsync(cardId) is { } businessCard
            ? Ok(businessCard)
            : NotFound();
    }
}
