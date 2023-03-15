using MyPortfolio.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Entities.Concrete
{
    public class Portfolio : IEntity
    {
        [Key]
        public int PortfolioID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string ImageUrl { get; set; }
    }
}
