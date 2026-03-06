using Contract.InClass.Common;

namespace Contract.InClass.Request.School;

public record GetSchoolsQuery(string? NameSearch, string? City, GradeLevelOfferingDto? GradeLevel, Guid? OwnerUserId);