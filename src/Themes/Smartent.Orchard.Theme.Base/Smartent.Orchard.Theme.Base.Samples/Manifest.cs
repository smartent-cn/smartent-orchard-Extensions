using Smartent.Orchard.Theme.Base.Core.Attributes;

// Theme manifests in Orchard Core are similar to module manifests (see "Module manifest" section in the Training Demo),
// except you have to use the Theme attribute. DerivedTheme is a specific variant of Theme where the BaseTheme property
// is automatically set to the constant at Smartent.Orchard.Theme.Base.Constants.FeatureIds.BaseTheme from the Smartent.Orchard.Theme.Base
// project and it has some additional properties.
[assembly: DerivedTheme(
    Name = "Smartent Orchard Theme Base - Sass - Samples",
    Author = "Smartent",
    Version = "0.0.1",
    Website = "https://gitee.com/smartent/smartent-orchard-Extensions",
    Description = "A sample theme that builds on Smartent Orchard Theme Base (Sass version).",
    // This is a new property in DerivedTheme. By setting it to a static resource you can define a default icon for this
    // theme. You can define other "link" resources too, using the LinkJson property. They should be valid Json strings.
    // For example:
    // LinksJson = "[{\"Href\": \"~/example/style.css\", \"Rel\": \"stylesheet\"}]"
    Favicon = "~/Smartent.Orchard.Theme.Base.Samples/icons/favicon.ico"
)]

// Steps you need to do outside of this project:
// - Reference the project in your web app.
// - Enable the "Smartent.Orchard.Theme.Base.Samples" feature in your setup recipe.
// - Set the site theme to "Smartent.Orchard.Theme.Base.Samples" in your setup recipe.
// You can see these in the "Smartent.Demo.Web.csproj" and the "Smartent.Demo.Tests.recipe.json" files in the
// https://gitee.com/smartent/smartent-orchard-Extensions repository.

// NEXT STATION: package.json
