using MyPortfolio.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Entities.Concrete
{
    public class Service : IEntity
    {
        [Key]
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public bool Status { get; set; }

    }
}
