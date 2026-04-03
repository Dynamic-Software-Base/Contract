namespace Contract.InClass.Request.Registration.Session;

public record UpdateRegistrationSessionQuotaRequest(
    Guid SessionId,
    int? DailyQuota,
    TimeOnly? DailyCutoffTime);