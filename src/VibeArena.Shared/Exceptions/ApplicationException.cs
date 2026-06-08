namespace VibeArena.Shared.Exceptions;

public class ApplicationException : Exception
{
    public string Code { get; set; }
    public ApplicationException(string message, string code = "ERROR") : base(message) => Code = code;
}

public class ValidationException : ApplicationException
{
    public ValidationException(string message) : base(message, "VALIDATION_ERROR") { }
}

public class NotFoundException : ApplicationException
{
    public NotFoundException(string message) : base(message, "NOT_FOUND") { }
}

public class ConflictException : ApplicationException
{
    public ConflictException(string message) : base(message, "CONFLICT") { }
}