using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Basket.API.Model
{
    public partial class TotalSegment
    {
        public string code { get; set; }
        public string title { get; set; }
        public decimal value { get; set; }
        public string area { get; set; }
        //public ExtensionAttributes ExtensionAttributes { get; set; }
    }
}