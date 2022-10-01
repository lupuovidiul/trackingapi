using trackingapi.Domain.Abstractions;
using trackingapi.Domain.Common;
using trackingapi.Domain.Common.Enums;

namespace trackingapi.Domain.Aggregates.Issue
{
    public class IssueAggregate : IAggregateRoot
    {
        public Guid Id { get; set; }
        public IssueType? Type { get; set; }
        public string? Summary { get; set; }
        public Guid? Assignee { get; set; }
        public Guid? Reporter { get; set; }
        public string? AcceptanceCriteria { get; set; }
        public string? Description { get; set; }
        public Guid? LinkedIssuesRelationship { get; set; }
        public Guid? LinkedIssue { get; set; }
        public Guid? Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastEdited { get; set; }
        public Guid? Status { get; set; }

        private IssueAggregate()
        {
            Id = Guid.NewGuid();
            Created = DateTime.UtcNow;
        }

        public static DomainResult<IssueAggregate> Create()
        {
            DomainResult<IssueAggregate> result = new DomainResult<IssueAggregate>(new IssueAggregate(), true, "Issue Aggregate Created!");
            return result;
        }


        // domainResult ma inspir de la proiectul lui Cioti
        // o metoda de assignUser
    }
}
