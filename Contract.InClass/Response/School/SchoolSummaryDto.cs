using Contract.InClass.Common;

namespace Contract.InClass.Response.School;

public sealed record SchoolSummaryDto(
    Guid SchoolId,
    string Name,
    string? ArName,
    string? City,
    string? Description,
    double? Latitude,
    double? Longitude,
    GradeLevelOfferingDto GradeLevelOffering,
    List<SchoolPictureResponse> Pictures);

public record SchoolPictureResponse(Guid StoredFileId,string Url,bool IsMain);