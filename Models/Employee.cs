using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public enum EmployeeType
    {
        Permanent,
        Contractual,
        PartTime
    }

    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public EmployeeType EmployeeType { get; set; }

        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal TotalSalary { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }

}