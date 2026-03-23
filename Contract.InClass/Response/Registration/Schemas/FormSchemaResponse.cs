namespace Contract.InClass.Response.Registration.Schemas;

public record FormSchemaResponse(
    Guid Id,
    string SchemaCode,
    string Title,
    int Version,
    bool IsCustomized,
    string BaseVersion,
    List<FormFieldDto> Sections);

public record DisplayConditionDto(
    string Field,
    string Operator,
    string Value);

public record FormFieldDto(
    string Key,
    string Label,
    string FieldType,
    bool IsRequired,
    int SortOrder,
    string? Placeholder,
    string? Hont,
    List<SelectOptionDto> Options,
    DisplayConditionDto? DisplayCondition
);

public record FormSectionDto(
    string Key,
    string Title,
    int SortOrder,
    DisplayConditionDto? DisplayCondition,
    List<FormFieldDto> Fields);
    public record SelectOptionDto(string Value,string Label);