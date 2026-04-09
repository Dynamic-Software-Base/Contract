namespace Contract.InClass.Request.Registration.Session;

public record CreateBatchRegistrationSessionsRequest(
    Guid SchoolId,
    string AcademicYear,
    List<Guid> GradeDefinitionIds,
    DateOnly OpenDate,
    DateOnly? CloseDate,
    int AssignmentStrategy,
    List<RegistrationPhaseRequest> Phases,
    int? DailyQuota = null,
    TimeOnly? DailyCutoffTime = null);
    
public record RegistrationPhaseRequest(
    DateOnly StartDate,
    DateOnly? EndDate,
    int PhaseType,
    int AllowedApplicantType);