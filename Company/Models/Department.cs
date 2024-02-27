using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    public class Department
    {
        [Key]
        public int Dnum { get; set; }
        public string DName { get; set; }
        [ForeignKey("MGREmp")]
        public int? MGRSSN { get; set; }
        public DateTime MGRStartDate { get; set; }
        public virtual List<Employee> employees { get; set; }
        public virtual Employee MGREmp { get; set; }
        public virtual List<Project> projects { get; set; }
    }
}
