using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageINF
{
    class SpecificationSet
    {
        private String nameOfMasurment;
        private ElementUnit unit;
        private double value;
        public SpecificationSet(String nameOfMasurment,double value,String unit)
        {
            this.nameOfMasurment = nameOfMasurment;
            this.unit = new ElementUnit(unit);
            this.value = value;
        }
        
        public String getNameOfMasurment() {return nameOfMasurment;}
        public void setNameOfMasurment(String nameOfMasurment) {this.nameOfMasurment = nameOfMasurment;}
        public String getElementUnit() {return unit.getUnit();}
        public void setElementUnit(String unit) {this.unit.setUnit(unit);}
    }
    

}
