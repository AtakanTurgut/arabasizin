using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arabaSizin.Models
{
    public class Marka
    {
        public int markaId { get; set; }
        public string markaAd { get; set; }
        public List<Model> Models { get; set; }
    }
}