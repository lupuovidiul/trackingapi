﻿using System.ComponentModel.DataAnnotations;

namespace trackingapi.Domain.Common
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
