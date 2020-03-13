using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class SitePage
    {
        public int SitePageId { get; set; }

        [MaxLength(60)]
        [Required]
        public string Title { get; set; }

        public string MainContent { get; set; }

        public bool AllowDelete { get; set; }

        public bool IsIndex { get; set; }
    }
}
