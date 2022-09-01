using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string MajorName { get; set; }
        public string School { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public string Grade { get; set; }
    }
}
