namespace Contract.InClass.Request.Registration.Session;

public record UpdateRegistrationSessionPeriodRequest(
    Guid SessionId,
    DateTime OpenDate,
    DateTime CloseDate);