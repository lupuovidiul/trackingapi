using System.ComponentModel.DataAnnotations;

namespace trackingapi.Domain
{
    public class IssueRelationship
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
