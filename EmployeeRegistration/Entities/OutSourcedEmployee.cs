namespace EmployeeRegistration.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }
        public OutSourcedEmployee() { }
        public OutSourcedEmployee(string name, int hours, double valueHour, double additionalCharge)
            : base(name, hours, valueHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }


}
