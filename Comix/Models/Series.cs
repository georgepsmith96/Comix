using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comix.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Series { get; set; }
        public Comic[] Comics { get; set; }
    }
}