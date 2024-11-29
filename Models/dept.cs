using System.ComponentModel.DataAnnotations;

namespace MvCITI.Models
{
    public class dept
    {
        public int id { get; set; }
        public string name { get; set; }
        [Display(Name = "manaGer Name")]
        public string manager_name { get; set; }
        public  virtual List<Employee> Employee { get; set; }
    }
}
