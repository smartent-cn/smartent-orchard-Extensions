using Smartent.Orchard.Platform.GraphQL;
using Smartent.Orchard.TrainingDemo.Indexes;

namespace Smartent.Orchard.TrainingDemo.GraphQL.Services;

// If your content part's index ends with PartIndex (as it should) then you can use this base class from our Helpful
// Libraries project to eliminate boilerplate.
public class PersonPartIndexAliasProvider : PartIndexAliasProvider<PersonPartIndex>;

// NEXT STATION: Services/ContentItemTypeBuilder.cs
