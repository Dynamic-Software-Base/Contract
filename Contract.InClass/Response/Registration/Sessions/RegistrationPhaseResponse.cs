namespace Contract.InClass.Response.Registration.Sessions;

public record RegistrationPhaseResponse(
    DateOnly StartDate,
    DateOnly? EndDate,
    int PhaseType,
    int AllowedApplicantType);