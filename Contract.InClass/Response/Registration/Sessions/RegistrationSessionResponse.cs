namespace Contract.InClass.Response.Registration.Sessions;


public record RegistrationSessionResponse(
    Guid Id,
    Guid GradeDefinitionId,
    string GradeNameFr,
    string CycleName,
    string AcademicYear,
    int Status,
    DateTime OpenDate,
    DateTime? CloseDate,
    int MaxSlots,
    int ReservedCount,
    int EnrolledCount,
    int WaitlistCount,
    int? DailyQuota,
    string DailyCutoffTime,
    int AssignmentStrategy,
    List<RegistrationPhaseResponse> Phases);