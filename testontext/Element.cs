using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageINF
{
    class Element
    {
        String ElementName;
        int amount;
        ElementSpecifications elementspecification;

        public Element(String ElementName, int amount,ElementSpecifications elementspecification)
        {
            this.elementspecification = elementspecification;
            this.ElementName = ElementName;
            this.amount = amount;
        }
        
    }
}
