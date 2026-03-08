namespace Contract.InClass.Response.Files;

public record UploadFileResult(Guid Id,string FileName,string Url,string ContentType,long SizeInBytes);