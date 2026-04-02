namespace Contract.InClass.Request.Registration.Application;


public record SubmitApplicationRequest(
    Guid SessionId,
    string StudentFirstName,
    string StudentLastName,
    string ContactPhone,
    string? ContactEmail,
    bool IsReturning,
    string? IdentityKey,
    string FormValuesJson);