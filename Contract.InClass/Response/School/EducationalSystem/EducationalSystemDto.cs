namespace Contract.InClass.Response.School.EducationalSystem;

/// <summary>
/// Lightweight system row for the "choose your school system" dropdown.
/// </summary>
public sealed record EducationalSystemDto(
    Guid Id,
    string Code,
    string Name_Fr,
    string Name_Ar);
 
/// <summary>
/// A cycle with its child grade definitions.
/// Used to build the curriculum picker UI — owner can either
/// tick the whole cycle or expand and pick individual grades.
/// </summary>
public sealed record GradeCycleWithGradesDto(
    Guid CycleId,
    string Code,
    string Name_Fr,
    string Name_Ar,
    int SortOrder,
    List<GradeDefinitionDto> Grades);
    
public sealed record GradeDefinitionDto(
    Guid Id,
    string Code,
    string Name_Fr,
    string Name_Ar,
    int SortOrder,
    bool IsActive);
