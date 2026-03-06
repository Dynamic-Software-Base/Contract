using Contract.InClass.Common;

namespace Contract.InClass.Response;

public sealed record SchoolSummaryDto(
    Guid SchoolId,
    string Name,
    string? ArName,
    string? City,
    string? Description,
    GradeLevelOfferingDto GradeLevelOffering
);