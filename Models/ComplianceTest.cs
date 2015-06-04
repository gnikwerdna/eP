using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eP.Models
{
    public class ComplianceTest
    {
        public int ID { get; set; }
        public int Answer { get; set; }
        public virtual Product product { get; set; }
        public virtual Compliance compliance { get; set; }
    }



}