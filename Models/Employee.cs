using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvCITI.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required]
        [MinLength(3)]
        public string name { get; set; }
        [RegularExpression("[0-9]{2}")]
        public int age { get; set; }
        [Range(2000,40000)]
        public decimal salary { get; set; }
        //[RegularExpression(@"[a-z]\.(jpg|png)")]
        public string address { get; set; }
        [ForeignKey("dept")]
        public int dept_id { get; set; }
        public virtual dept? dept { get; set; }
    }
}
