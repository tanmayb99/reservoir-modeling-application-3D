using Fluid_Volume_Calculation.Enum;

namespace Fluid_Volume_Calculation.Interface
{
    public interface IUnitOfLength
    {
        decimal Value { get; set; }

        LengthUnit Unit { get; set; }
    }
}
