using System;
using System.Collections.Generic;
using System.Text;

namespace polimorfismo.Entities
{
    class OutSourceEmployee : Employee
    {
        public double AdditionalCharge  { get; set; }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }

        public OutSourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
    }
}
