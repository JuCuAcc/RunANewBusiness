namespace EmployeeManagementSystem.Models
{
    public class TotalPayoutsPerEmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal TotalPayouts { get; set; }
    }
}
