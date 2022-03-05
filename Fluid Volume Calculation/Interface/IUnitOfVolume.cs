using Fluid_Volume_Calculation.Enum;

namespace Fluid_Volume_Calculation.Interface
{
    public interface IUnitOfVolume
    {
        decimal Value { get; set; }
        VolumeUnit Unit { get; set; }
    }
}
