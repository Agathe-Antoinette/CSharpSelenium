using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Types
{
    class Money
    {
        private decimal value;
        
        public Money(decimal value)
        {
            this.value = value;
        }

        public decimal Value
        {
            get
            {
                return this.value;
            }

            set
            {
                this.value = value;
            }
        }

        public decimal GetValue()
        {
            return this.value;
        }

        public void SetValue(decimal value)
        {
            this.value = value;
        }
    }
}
