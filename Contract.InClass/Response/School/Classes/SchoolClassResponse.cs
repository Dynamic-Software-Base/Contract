namespace Contract.InClass.Response.School.Classes;

public record SchoolClassResponse(
    Guid Id,
    Guid GradeDefinitionId,
    string AcademicYear,
    string Name,
    int MaxStudents,
    int CurrentEnrollmentCount
    );
    