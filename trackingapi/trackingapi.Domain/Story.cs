namespace trackingapi.Domain
{
    public class Story : BaseIssue, IHasEpic
    {
        public Guid? EpicId { get; set; }
    }
}
