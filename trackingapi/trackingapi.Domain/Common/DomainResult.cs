namespace trackingapi.Domain.Common
{
    public class DomainResult
    {
        public Guid Id  { get; private set; }
        public bool Success { get; private set; }
        public string Message { get; private set; }

        public DomainResult(Guid id, bool success, string message)
        {
            Id = id;
            Success = success;
            Message = message;
        }
    }
}
