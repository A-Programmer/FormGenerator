using System.Collections.Generic;

namespace Project.Models
{
    public class Form
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public List<FormField> Fields { get; set; }
    }
}