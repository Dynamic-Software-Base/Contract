namespace Contract.InClass.Response.Registration;

public sealed record FormSchemaResponse(
    Guid SchemaId,
    Guid GradeDefinitionId,
    bool IsCustomized,
    string SchemaJson,
    int Version
);