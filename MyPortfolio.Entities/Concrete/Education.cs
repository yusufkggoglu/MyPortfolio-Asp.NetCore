using MyPortfolio.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Entities.Concrete
{
    public class Education : IEntity
    {
        [Key]
        public int EducationID { get; set; }
        public string School { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
    }
}
