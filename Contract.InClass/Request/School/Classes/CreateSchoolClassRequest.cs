namespace Contract.InClass.Request.School.Classes;

public record CreateBatchSchoolClassesRequest(
    Guid SchoolId,
    Guid GradeDefinitionId,
    string AcademicYear,
    List<SchoolClassDefinition> Classes);

public record SchoolClassDefinition(
    string Name,
    int MaxStudents);