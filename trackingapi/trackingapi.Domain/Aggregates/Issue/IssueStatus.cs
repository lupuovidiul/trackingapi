using System.ComponentModel.DataAnnotations;

namespace trackingapi.Domain.Aggregates.Issue
{
    public class IssueStatus
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
