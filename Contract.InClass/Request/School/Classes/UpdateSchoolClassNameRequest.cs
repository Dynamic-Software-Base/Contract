namespace Contract.InClass.Request.School.Classes;
public record UpdateSchoolClassNameRequest(
    Guid SchoolClassId,
    string Name);

public record UpdateSchoolClassCapacityRequest(
    Guid SchoolClassId,
    int MaxStudents);