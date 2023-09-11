using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


namespace LTEHApps.Models
{
    public class Conflict
    {
        [Key]
        public int SerialNo{ get; set; }

        [Required(ErrorMessage = "Project Name is required.")]
        public string? ProjectName { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public string? ID { get; set; }

        [Required(ErrorMessage = "Discipline is required.")]
        public string? Discipline { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        public string? Subject { get; set; }

        [Required(ErrorMessage = "Company Standard Ref Doc is required.")]
        public string? CompanyStandardRefDoc { get; set; }

        [Required(ErrorMessage = "Standard Requirement is required.")]
        public string? StandardRequirement { get; set; }

        [Required(ErrorMessage = "Contractor Observation is required.")]
        public string? ContractorObservation { get; set; }

        [Required(ErrorMessage = "Company Response is required.")]
        public string? CompanyResponse { get; set; }

        // You can add additional properties for file uploads if needed.
        // For example, you can use a List<string> property to store file paths.

        public DateTime SubmissionDate { get; set; }
    }

    public class SearchViewModel
    {
        public string? CompanyLogoUrl { get; set; }
        public string? Keywords { get; set; }
    }
    public class SearchResult
    {
        public string? Title { get; set; }
        // Add more properties as needed, such as Description, DateCreated, etc.
    }



}
