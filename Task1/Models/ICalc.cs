namespace Task1.Models
{
    public interface ICalc<T>
    {
        T Add(Value<T> value);
        T Mul(Value<T> value);
        T Div(Value<T> value);
        T Sub(Value<T> value);
    }
}
