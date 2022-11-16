using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace User.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(250)]
        public string FormName { get; set; }

        [StringLength(250)]
        public string FormStatus { get; set; }
        [StringLength(200)]
        public string AdressLine1 { get; set; }
        [StringLength(200)]
        public string AdressLine2 { get; set; }

        public bool Active { get; set; }



        public static implicit operator Candidate(List<Candidate> v)
        {
            throw new NotImplementedException();
        }
    }
}