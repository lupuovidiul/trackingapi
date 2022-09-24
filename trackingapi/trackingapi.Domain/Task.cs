namespace trackingapi.Domain
{
    public class Task : BaseIssue, IHasEpic
    {
        public Guid? EpicId { get; set; }
    }
}
