using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        
        public int CId { get; set; }
    }
}
