using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string IconCSS { get; set; } = string.Empty;
    }
}
