using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageINF
{
    class ElementUnit
    {
        public ElementUnit(String unit)
        {
            this.unit = unit;
        }
        private String unit;
        public String getUnit(){return unit;}
        public void setUnit(String unit) { this.unit = unit;}
    }
    
}
