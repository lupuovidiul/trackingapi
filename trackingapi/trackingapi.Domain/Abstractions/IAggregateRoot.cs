namespace trackingapi.Domain.Abstractions
{
    internal interface IAggregateRoot
    {
        public Guid Id { get; }
    }
}
