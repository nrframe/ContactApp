using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ContactApplication.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string firstName { get; set; }
        [StringLength(20)]
        public string lastName { get; set; }
        [EmailAddress]
        public string userEmail { get; set; }
        [StringLength(100)]
        public string street { get; set; }
        [StringLength(50)]
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string optins { get; set; }
    }
}
