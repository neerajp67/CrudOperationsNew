using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoREPOSITORY
{
   public class XpayModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal amount { get; set; }
        public string TermAndCondition { get; set; }
    }
}
