namespace Contract.InClass.Request.Payment;

 
public sealed record CreatePaymentPlanRequest(
    Guid SchoolId,
    Guid StudentApplicationId,
    Guid GradeId,
    string AcademicYear,       // e.g. "2024-2025" — parsed in controller
    int PlanType,              // 0=Annual, 1=Trimestrial, 2=Monthly, 3=Custom
    decimal TuitionTotal,
    decimal RegistrationFee,
    DateTime RegistrationDueDate,
    List<int>? CustomMonths = null);
 
public sealed record AddPaymentRequest(
    decimal Amount,
    DateTime Date,
    int Method,                // 0=Cash, 1=Cheque, 2=Virement, 3=Other
    int FeeType,               // 0=Registration, 1=Tuition, 2=Transport, 3=Other
    string? Note = null);
 
public sealed record EditPaymentRequest(
    decimal NewAmount,
    DateTime NewDate,
    int NewMethod,
    string? Note = null);
