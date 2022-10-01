namespace trackingapi.Domain.Common
{
    public class DomainResult<T>
    {
        public T DataObject { get; private set; }
        public bool Success { get; private set; }
        public string Message { get; private set; }

        public DomainResult(T dataObject, bool success, string message)
        {
            DataObject = dataObject;
            Success = success;
            Message = message;
        }

        //facut frumos cu error codes + metode statice (static constructor methods)
    }
}
