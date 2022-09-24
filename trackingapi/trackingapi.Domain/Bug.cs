namespace trackingapi.Domain
{
    public class Bug : BaseIssue, IHasEpic
    {
        public Guid? EpicId { get; set; }
    }
}
