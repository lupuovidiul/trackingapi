﻿using System.ComponentModel.DataAnnotations;

namespace trackingapi.Domain.Aggregates.Issue
{
    public class IssuePriority
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
