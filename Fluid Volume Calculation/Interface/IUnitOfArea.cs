using Fluid_Volume_Calculation.Enum;

namespace Fluid_Volume_Calculation.Interface
{
    public interface IUnitOfArea
    {
        decimal Value { get; set; }
        
        AreaUnit Unit { get; set; }
    }
}
