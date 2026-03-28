namespace Contract.InClass.Request.Registration.Session;


public record CreateBatchSessionsResult(
    List<Guid> CreatedSessionIds,
    List<SkippedGradeResult> Skipped);

public record SkippedGradeResult(
    Guid GradeDefinitionId,
    string Reason);