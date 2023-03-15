using MyPortfolio.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Entities.Concrete
{
    public class Skill : IEntity
    {
        [Key]
        public int SkillID { get; set; }
        public string Title { get; set; }
        public string MyProperty { get; set; }
    }
}
