namespace Contract.InClass.Response.School;

public record OpenSessionSummaryDto(
    Guid SessionId,
    Guid GradeDefinitionId,
    string GradeName_Fr,
    string GradeName_Ar,
    string CycleName_Fr,
    string CycleName_Ar,
    DateTime OpenDate,
    DateTime? CloseDate,
    int MaxSlots,
    int ReservedCount,
    int EnrolledCount
    );