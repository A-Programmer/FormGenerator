using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class FormData
    {
        public int Id { get; set; }
        public string FormValues { get; set; }
        public int FormId { get; set; }
        [ForeignKey("FormId")]
        public Form Form { get; set; }

    }
}