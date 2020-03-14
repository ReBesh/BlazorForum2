using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Theme
    {
        public int ThemeId { get; set; }

        public bool IsSelected { get; set; }

        [Required]
        [MaxLength(50)]
        public string TextDomain { get; set; }
    }
}
