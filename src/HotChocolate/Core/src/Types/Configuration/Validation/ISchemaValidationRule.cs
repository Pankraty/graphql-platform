#nullable enable

using System.Collections.Generic;
using HotChocolate.Types.Descriptors;

namespace HotChocolate.Configuration.Validation;

internal interface ISchemaValidationRule
{
    void Validate(
        IDescriptorContext context,
        ISchema schema,
        ICollection<ISchemaError> errors);
}
