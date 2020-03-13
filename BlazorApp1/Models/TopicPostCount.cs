using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class TopicPostCount
    {
        public int ParentItemId { get; set; }
        public int ChildCount { get; set; }
    }
}
