namespace Contract.InClass.Response.Registration;

public sealed record ApplicationPrefillResponse(
    string StudentFirstName,
    string StudentLastName,
    string ContactPhone,
    string? ContactEmail,
    Dictionary<string, object?> PreFilledFormValues,
    int MatchedFieldCount,
    int TotalFieldCount
);