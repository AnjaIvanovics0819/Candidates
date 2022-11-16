using System;
using System.ComponentModel.DataAnnotations;

namespace User.Models
{
    public class FormAction
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public Candidate CandidateId { get; set; }


        public Form FormId { get; set; }


        [StringLength(80)]
        public string Action { get; set; }
        public DateTime ActionOn { get; set; }
    }
}