using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Company.Models
{
    public class Employee
    {
        [Key]
        public int SSN { get; set; }
        public string Fname { get; set; }
        public string? Lname { get; set; }
        public DateTime? BDate { get; set; }
        public string? Address { get; set; }
        public string? Sex { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Salary { get; set; }
        [ForeignKey("MGREmp")]
        public int? Superssn { get; set; }
        [ForeignKey("departmentAssigned")]
        public int? Dno { get; set; }
        public virtual Employee MGREmp { get; set; }
        [InverseProperty("MGREmp")]
        public virtual List<Employee> Employees { get; set; }
        public virtual List<Dependant> dependants { get; set; }
        [InverseProperty("employees")]
        public virtual Department departmentAssigned { get; set; }
        [InverseProperty("MGREmp")]
        public virtual Department departmentManaged { get; set; }
        public virtual List<WorksFor> worksFors { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
