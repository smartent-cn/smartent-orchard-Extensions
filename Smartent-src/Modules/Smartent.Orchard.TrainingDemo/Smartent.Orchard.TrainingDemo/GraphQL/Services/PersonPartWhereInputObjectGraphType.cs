using GraphQL.Types;
using Smartent.Orchard.TrainingDemo.Indexes;
using Smartent.Orchard.TrainingDemo.Models;
using Microsoft.Extensions.Localization;
using OrchardCore.Apis.GraphQL.Queries;
using static Smartent.Orchard.TrainingDemo.GraphQL.Services.PersonPartObjectGraphType;

namespace Smartent.Orchard.TrainingDemo.GraphQL.Services;

// This class adds a content part-specific section in the "where" filter. It relies on the content part index to
// automatically generate YesSql logic for database-side filtering.
public class PersonPartWhereInputObjectGraphType : WhereInputObjectGraphType<PersonPart>
{
    public PersonPartWhereInputObjectGraphType(IStringLocalizer<PersonPartWhereInputObjectGraphType> stringLocalizer)
        : base(stringLocalizer)
    {
        // Since filters depend on the index, we use their "nameof" as reference.
        AddScalarFilterFields<DateTimeGraphType>(nameof(PersonPartIndex.BirthDateUtc), BirthDateDescription);

        // Using the enumeration graph type turns the filter into a dropdown of the valid options in GraphiQL.
        AddScalarFilterFields<HandednessEnumerationGraphType>(nameof(PersonPartIndex.Handedness), HandednessDescription);
    }
}

// NEXT STATION: Services/PersonPartIndexAliasProvider.cs
