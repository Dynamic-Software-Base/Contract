namespace Contract.InClass.Request.School;

public sealed class CreateSchoolRequestDto
{
    public string  Name                 { get; set; } = string.Empty;
    public string? Ar_Name              { get; set; }
    public string? Description          { get; set; }
    public Guid    EducationalSystemId  { get; set; }
    public List<Guid> SupportedGradeIds { get; set; } = [];

    public CreateSchoolAddressDto    Address     { get; set; } = new();
    public CreateSchoolContactDto    ContactInfo { get; set; } = new();
    public List<CreateSchoolPicturesDto> Pictures { get; set; } = [];
}

public sealed class CreateSchoolAddressDto
{
    public string  StreetAddress    { get; set; } = string.Empty;
    public string? BuildingNumber   { get; set; }
    public string? ApartmentNumber  { get; set; }
    public string  City             { get; set; } = string.Empty;
    public string  Province         { get; set; } = string.Empty;
    public string  Region           { get; set; } = string.Empty;
    public string  PostalCode       { get; set; } = string.Empty;
}

public sealed class CreateSchoolContactDto
{
    public string  Email                 { get; set; } = string.Empty;
    public string  PrimaryPhoneNumber    { get; set; } = string.Empty;
    public string? SecondaryPhoneNumber  { get; set; }
}

public sealed class CreateSchoolPicturesDto
{
    public Guid PictureId { get; set; }
    public bool IsMain    { get; set; }
}