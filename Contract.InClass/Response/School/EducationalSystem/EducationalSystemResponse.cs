namespace Contract.InClass.Response.School.EducationalSystem;


public sealed record EducationalSystemResponse(
    Guid Id,
    string Code,
    string Name_Fr,
    string Name_Ar,
    List<CycleResponse> Cycles);

public sealed record CycleResponse(
    Guid Id,
    string Code,
    string Name_Fr,
    string Name_Ar,
    int SortOrder,
    List<GradeResponse> Grades);

public sealed record GradeResponse(
    Guid Id,
    string Code,
    string Name_Fr,
    string Name_Ar,
    int SortOrder);
