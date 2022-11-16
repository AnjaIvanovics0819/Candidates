using System.Collections.Generic;
using User.Models;

namespace User.ViewModels
{
    public class NewCandidateViewModel
    {
        public IEnumerable<FormAction> FormActions { get; set; }
        public Candidate Candidate { get; set; }

    }
}