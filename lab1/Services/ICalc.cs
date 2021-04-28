

namespace lab1.Services
{
    public interface ICalc
    {
        int Add();
        int Sub();
        int Div();
        int Mult();

        int value1 { get; }
        int value2 { get; }

    }
}
