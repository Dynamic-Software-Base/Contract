using Contract.InClass.Common;

namespace Contract.InClass.Response.School;

public record NearestSchoolDto(
    Guid SchoolId ,
    string Name,
    string? Description,
    string? ArName,
    string City,
    GradeLevelOfferingDto GradeLevelOffering,
    double Latitude,
    double Longitude,
    double DistanceKm,
    List<SchoolPictureResponse> Pictures);