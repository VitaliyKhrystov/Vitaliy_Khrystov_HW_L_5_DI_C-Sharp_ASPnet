using Microsoft.AspNetCore.Server.IIS.Core;

namespace Task1.Models
{
    public class Calc : ICalc<double>
    {
        public double Add(Value<double> value)
        {
            return value.Value1 + value.Value2;
        }
        public double Mul(Value<double> value)
        {
            return value.Value1 * value.Value2;
        }
        public double Div(Value<double> value)
        {

            if (value.Value2 != 0)
            {
                return value.Value1 / value.Value2;
            }

            throw new Exception("Divide on zero");
        }

        public double Sub(Value<double> value)
        {
            return value.Value1 - value.Value2;
        }
    }
}
