namespace trackingapi.Domain.Aggregates.Issue
{
    public class IssueStatus
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; } //enum IssueStatusValue
    }
}
