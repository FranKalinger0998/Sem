using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageINF
{
    class ElementSpecifications
    {
        public ElementSpecifications(String nameOfMasurment,double value,String unit)
        {
            specifications.Add(new SpecificationSet(nameOfMasurment, value, unit));
        }
    
        
        private List<SpecificationSet> specifications = new List<SpecificationSet>();
        public List<SpecificationSet> getSpecificationSet() { return specifications;}
        public void addSpecificationSet(String nameOfMasurment, double value,String unit ) { specifications.Add(new SpecificationSet(nameOfMasurment,value, unit)); }
        public void removeSpecificationSet(int numerator) { specifications.RemoveAt(numerator);}


    }
}
