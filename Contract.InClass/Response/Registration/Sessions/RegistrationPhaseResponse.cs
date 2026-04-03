namespace Contract.InClass.Response.Registration.Sessions;

public record RegistrationPhaseResponse(
    DateTime StartDate,
    DateTime EndDate,
    int PhaseType,
    int AllowedApplicantType);