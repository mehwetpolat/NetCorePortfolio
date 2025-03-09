using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioImageUrl { get; set; }
        public string PortfolioProjectUrl { get; set; }
        public string PortfolioImageUrl2 { get; set; }
    }
}
