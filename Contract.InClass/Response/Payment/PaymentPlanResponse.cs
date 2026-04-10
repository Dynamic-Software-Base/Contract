namespace Contract.InClass.Response.Payment;

public sealed record PaymentPlanResponse(
    Guid PaymentPlanId,
    string PlanType,
    decimal TuitionTotal,
    decimal RegistrationFee,
    decimal TotalPaid,
    decimal TotalRemaining,
    List<InstallmentResponse> Installments);

public sealed record InstallmentResponse(
    Guid InstallmentId,
    string FeeType,
    decimal Amount,
    decimal PaidAmount,
    decimal Remaining,
    DateTime DueDate,
    string Status,
    bool IsMandatory);

public sealed record PaymentHistoryResponse(
    List<PaymentHistoryItem> Payments);

public sealed record PaymentHistoryItem(
    Guid PaymentId,
    decimal Amount,
    DateTime Date,
    string Method,
    string FeeType,
    string? Note,
    List<AllocationDetail> Allocations);

public sealed record AllocationDetail(
    Guid InstallmentId,
    decimal AllocatedAmount,
    DateTime InstallmentDueDate,
    string FeeType);

public sealed record LastTuitionAmountResponse(
    decimal? Amount);