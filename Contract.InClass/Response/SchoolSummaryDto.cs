using Contract.InClass.Common;

namespace Contract.InClass.Response;

public sealed record SchoolSummaryDto(
    Guid SchoolId,
    string Name,
    string? ArName,
    string? City,
    string? Description,
    GradeLevelOfferingDto GradeLevelOffering,
    List<SchoolPictureResponse> Pictures);

public record SchoolPictureResponse(Guid StoredFileId,string Url,bool IsMain);