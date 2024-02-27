using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    [PrimaryKey("ESSn", "Pno")]
    public class WorksFor
    {
        [ForeignKey("employee")]
        public int? ESSn { get; set; }
        [ForeignKey("project")]
        public int? Pno { get; set; }
        public int Hours { get; set; }
        public virtual Employee employee { get; set; }
        public virtual Project project { get; set; }
    }
}
