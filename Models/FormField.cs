using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class FormField
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public FieldTypes Type { get; set; }

        public int FormId { get; set; }
        [ForeignKey("FormId")]
        public Form Form { get; set; }

    }
    public enum FieldTypes
    {
        [Display(Name = "ورودی متن")]
        text,
        [Display(Name = "فایل آپلود")]
        file

    }
}