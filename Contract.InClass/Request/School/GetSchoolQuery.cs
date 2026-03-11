using Contract.InClass.Common;

namespace Contract.InClass.Request.School;

public record GetSchoolQuery(string? NameSearch,string? City,GradeLevelOfferingDto? GradeLevelOffering);