namespace Contract.InClass.Request.School.Classes;

public record CreateSchoolClassRequest(
    Guid SchoolId,
    string Name,
    Guid GradeDefinitionId,
    string AcademicYear,
    int MaxStudents,
    int Gender
    );
public record CreateBatchSchoolClassesRequest(
    Guid SchoolId,
    Guid GradeDefinitionId,
    string AcademicYear,
    List<SchoolClassDefinition> Classes);

public record SchoolClassDefinition(
    string Name,
    int MaxStudents,
    int Gender);