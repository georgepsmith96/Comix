using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comix.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public Comic[] Comics { get; set; }
    }
}