
namespace ExercicioFuncTerceirizados.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsourcedEmployee() 
        {
        }

        public OutsourcedEmployee(String name, Int hours, Double valuePerHour, Double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override Double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
