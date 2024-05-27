﻿using System.ComponentModel.DataAnnotations;

namespace StudentsDetail.Models
{
    public class Students
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }
    }
}
