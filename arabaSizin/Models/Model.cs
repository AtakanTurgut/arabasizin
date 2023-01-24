using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arabaSizin.Models
{
    public class Model
    {
        public int modelId { get; set; }
        public string modelAd { get; set; }
        public int markaId { get; set; }
        public virtual Marka Marka { get; set; }
    }
}