namespace trackingapi.Domain
{
    public abstract class BaseIssue
    {
        public Guid Id { get; set; }      
        public string Summary { get; set; }
        public User Assignee { get; set; }
        public User Reporter { get; set; }
        public string AcceptanceCriteria { get; set; }
        public string Description { get; set; }
        public IssueRelationship LinkedIssuesRelationship { get; set; }
        public IssuePriority Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastEdited { get; set; }
        public IssueStatus Status { get; set; } 
    }
}
