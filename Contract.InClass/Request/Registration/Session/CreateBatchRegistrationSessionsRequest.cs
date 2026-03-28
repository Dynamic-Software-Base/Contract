namespace Contract.InClass.Request.Registration.Session;

public record CreateBatchRegistrationSessionsRequest(
    Guid SchoolId,
    string AcademicYear,
    List<Guid> GradeDefinitionIds,
    DateTime OpenDate,
    DateTime CloseDate,
    int AssignmentStrategy,
    List<RegistrationPhaseRequest> Phases,
    int? DailyQuota = null,
    TimeOnly? DailyCutoffTime = null);
    
public record RegistrationPhaseRequest(
    DateTime StartDate,
    DateTime EndDate,
    int PhaseType,
    int AllowedApplicantType);