using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageINF
{
    class Storage
    {

        private List<Element> elements = new List<Element>();

        public void NewElement(string nameOfElement, int amount, ElementSpecifications specifications)
        {
            elements.Add(new Element(nameOfElement, amount, specifications));
        }

    }
}
