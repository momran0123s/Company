using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    public class Project
    {
        [Key]
        public int PNumber { get; set; }
        public string PName { get; set; }
        public string PLocation { get; set; }
        public string City { get; set; }
        [ForeignKey("department")]
        public int? Dnum { get; set; }
        public virtual Department department { get; set; }
        public virtual List<WorksFor> worksFors { get; set; } 
    }
}
