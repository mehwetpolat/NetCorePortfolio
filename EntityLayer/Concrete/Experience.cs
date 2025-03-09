using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string ExperienceName { get; set; }
        public string ExperienceDate { get; set; }
        public string ExperienceImageUrl { get; set; }
        public string ExperienceDesription { get; set; }
    }
}
