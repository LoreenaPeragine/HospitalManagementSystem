using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        [Key]
        public int TransactionId { get; set; }

        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string? FirstName { get; set; }

        [DisplayName("Address")]
        public string? Address { get; set; }

        [DisplayName("City")]
        public string? City { get; set; }

        [DisplayName("Doctor")]
        public string? Doctor { get; set; }

        [DisplayName("Complaint")]
        public string? Complaint { get; set; }

        [DisplayName("Sex")]
        public string? Sex { get; set; }

        [DisplayName("Marital")]
        public string? Marital { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime DOB { get; set; }
    }
}