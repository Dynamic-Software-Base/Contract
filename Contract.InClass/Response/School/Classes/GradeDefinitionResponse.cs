namespace Contract.InClass.Response.School.Classes;

public record GradeDefinitionDto(
    Guid Id,
    string Code,
    string NameFr,
    string NameAr,
    int SortOrder
    );
public record SchoolSupportedGradesDto(
    string Code,
    string NameFr,
    string NameAr,
    string BroadLevel,
    int SortOrder,
    List<GradeDefinitionDto> Grades);
    
public record SchoolSupportedGradesResponse(
    List<SchoolSupportedGradesDto> Cycles);