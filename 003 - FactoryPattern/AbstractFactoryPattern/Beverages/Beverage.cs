using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }
    internal abstract class Beverage
    {
        public Size Size
        {
            get { return baseBeverage != null ? baseBeverage.Size : size; }
            set { if (baseBeverage != null) baseBeverage.Size = value; else size = value; }
        }
        private Size size;

        protected string description = "Unknown";
        protected Beverage baseBeverage = null;
        

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
