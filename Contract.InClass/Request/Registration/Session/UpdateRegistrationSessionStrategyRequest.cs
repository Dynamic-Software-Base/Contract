namespace Contract.InClass.Request.Registration.Session;

public record UpdateRegistrationSessionStrategyRequest(
    Guid SessionId,
    int AssignmentStrategy);