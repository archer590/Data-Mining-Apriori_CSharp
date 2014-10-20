using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMining
{
    public class Item
    {

        String attributeName = null;
        Object attributeValue = null;

        public Item(String attributeName, Object attributeValue)
        {
            this.attributeName = attributeName;
            this.attributeValue = attributeValue;
        }

    }
}
