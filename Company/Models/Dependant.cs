using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Models
{
    [PrimaryKey("ESSN", "DependentName")]
    public class Dependant
    {
        [ForeignKey("employee")]
        public int? ESSN { get; set; }
        public string DependentName { get; set; }
        public string Sex { get; set; }
        public DateTime BDate { get; set; }
        public virtual Employee employee { get; set; }
    }
}
