using Smartent.Orchard.Extensions.Cms;
using OrchardCore.Modules.Manifest;
using static Smartent.Orchard.Extensions.Cms.FeatureIds;

[assembly: Module(
    Name = "Smartent Orchard Extensions",
    Author = "Smartent",
    Version = "0.0.1",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions"
)]

[assembly: Feature(
    Id = CodeGeneration,
    Name = "Smartent Orchard Extensions - Code Generation Helpful Extensions",
    Category = "Development",
    Description = "Generates migrations from content type definitions.",
    Dependencies =
    [
        "OrchardCore.Resources",
    ]
)]

[assembly: Feature(
    Id = ContentSets,
    Name = "Smartent Orchard Extensions - Content Sets",
    Category = "Development",
    Description = "Create arbitrary collections of content items.",
    Dependencies =
    [
        "OrchardCore.ContentManagement",
    ]
)]

[assembly: Feature(
    Id = Flows,
    Name = "Smartent Orchard Extensions - Flows Helpful Extensions",
    Category = "Content",
    Description = "Adds additional styling capabilities to Flow Part.",
    Dependencies =
    [
        "OrchardCore.Flows",
    ]
)]

[assembly: Feature(
    Id = Widgets,
    Name = "Smartent Orchard Extensions - Helpful Widgets",
    Category = "Content",
    Description = "Adds helpful widgets such as Container or Liquid widgets.",
    Dependencies =
    [
        "OrchardCore.Html",
        "OrchardCore.Liquid",
        "OrchardCore.Title",
    ]
)]

[assembly: Feature(
    Id = ContentTypes,
    Name = "Smartent Orchard Extensions - Helpful Content Types",
    Category = "Content",
    Description = "Adds helpful content types such as Page.",
    Dependencies =
    [
        "OrchardCore.Autoroute",
        "OrchardCore.Flows",
        "OrchardCore.Title",
    ]
)]

[assembly: Feature(
    Id = Security,
    Name = "Smartent Orchard Extensions - Security Helpful Extensions",
    Category = "Security",
    Description = "Adds a content type definition setting and authorization handler for richer security options."
)]

[assembly: Feature(
    Id = ShapeTracing,
    Name = "Smartent Orchard Extensions - Shape Tracing Helpful Extensions",
    Category = "Development",
    Description = "Adds a dump of metadata to the output about every shape."
)]

[assembly: Feature(
    Id = FeatureIds.Shortcodes,
    Name = "Smartent Orchard Extensions - Shortcode Extensions",
    Category = "Content",
    Description = "Adds new shortcodes which can be used in HTML and Markdown templates."
)]

[assembly: Feature(
    Id = Emails,
    Name = "Smartent Orchard Extensions - Emails",
    Category = "Messaging",
    Description = "Adds shape-based email template rendering and helpful email sending services.",
    Dependencies =
    [
        "OrchardCore.Email"
    ]
)]

[assembly: Feature(
    Id = TargetBlank,
    Name = "Smartent Orchard Extensions - Target Blank",
    Category = "Content",
    Description = "Turns all external links into target=\"_blank\"."
)]

[assembly: Feature(
    Id = SiteTexts,
    Name = "Smartent Orchard Extensions - Site Texts",
    Category = "Content",
    Description =
        "Adds a content type that lets the users with admin dashboard access customize string/HTML resources on the " +
        "site via Markdown. If OrchardCore.ContentLocalization is enabled, it also tries to retrieve the localized " +
        "version if available.",
    Dependencies =
    [
        "OrchardCore.Markdown",
    ]
)]

[assembly: Feature(
    Id = OrchardRecipeMigration,
    Name = "Smartent Orchard Extensions - Orchard 1 Recipe Migration",
    Category = "Development",
    Description =
        "Convert Orchard 1's export XML files into Orchard Core recipes. This feature contains the basics like " +
        "CommonPart and BodyPart (full list is in the Helpful Extensions repository readme), but can be extended " +
        "with additional converters that only have to handle more specialized export data.",
    Dependencies =
    [
        "OrchardCore.Contents",
    ]
)]

[assembly: Feature(
    Id = ResetPasswordActivity,
    Name = "Smartent Orchard Extensions - Reset password workflow activity",
    Category = "Security",
    Description = "Adds generate reset password token activity.",
    Dependencies =
    [
        "OrchardCore.Users.ResetPassword",
        "OrchardCore.Workflows",
    ]
)]

[assembly: Feature(
    Id = Trumbowyg,
    Name = "Smartent Orchard Extensions - Trumbowyg code snippet",
    Category = "Content",
    Description = "Adds an option for inserting code snippets in the Trumbowyg editor."
)]

[assembly: Feature(
    Id = TrumbowygBlogPosts,
    Name = "Smartent Orchard Extensions - Trumbowyg code snippet - Blog Posts",
    Category = "Content",
    Description = "Adds an option for inserting code snippets in the Trumbowyg editor of Blog Post content items.",
    Dependencies = [Trumbowyg]
)]

[assembly: Feature(
    Id = GoogleTag,
    Name = "Smartent Orchard Extensions - Google Tag",
    Category = "Content",
    Description = "Adds a shape along with Razor and Liquid tag helpers for Google Analytics."
)]

[assembly: Feature(
    Id = Liquid,
    Name = "Smartent Orchard Extensions - Liquid Tags",
    Category = "Liquid",
    Description = "Adds various Liquid tags and filters."
)]

[assembly: Feature(
    Id = Lucide,
    Name = "Smartent Orchard Extensions - Lucide",
    Category = "Content",
    Description = "Adds the Lucide icon library as a resource and a TextField editor for picking Lucide icons.",
    Dependencies =
    [
        "OrchardCore.ContentFields",
        "OrchardCore.Resources",
    ]
)]

[assembly: Feature(
    Id = SimpleIcons,
    Name = "Smartent Orchard Extensions - Simple Icons",
    Category = "Content",
    Description = "Adds the Simple Icons icon library as a resource and the <simple-icon> tag helper.",
    Dependencies =
    [
        "OrchardCore.DisplayManagement",
    ]
)]
