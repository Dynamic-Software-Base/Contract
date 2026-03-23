namespace Contract.InClass.Request.Registration.Schemas;

public record CustomizeFormSchemaRequest(
    Guid SchoolId,
    Guid GradeDefinitionId,
    string SchemaJson);