namespace Contract.InClass.Response.Registration;
// updated EnrollmentSessionDto — add one field
public sealed record EnrollmentSessionDto(
    Guid SessionId,
    Guid GradeDefinitionId,
    string GradeName_Fr,
    string GradeName_Ar,
    string GradeCode,
    Guid CycleId,
    string CycleName_Fr,
    string CycleName_Ar,
    string SessionStatus,
    string? ActivePhaseType,        // "ReRegistration" | "Open" | null
    string? ActivePhaseAllowedType, // "ReturningOnly" | "All" | null 
    DateTime OpenDate,
    DateTime? CloseDate,
    int MaxSlots,
    int ReservedCount,
    int EnrolledCount
);

public sealed record EnrollmentSessionsResponse(
    Guid SchoolId,
    string SchoolName,
    string AcademicYear,
    List<EnrollmentSessionDto> Sessions
);