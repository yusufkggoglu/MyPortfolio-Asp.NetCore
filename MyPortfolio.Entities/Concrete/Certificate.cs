using MyPortfolio.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio.Entities.Concrete
{
    public class Certificate : IEntity
    {
        [Key]
        public int CertificateID { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
