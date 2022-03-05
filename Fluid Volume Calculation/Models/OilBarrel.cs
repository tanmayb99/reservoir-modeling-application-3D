using Fluid_Volume_Calculation.Enum;
using Fluid_Volume_Calculation.Interface;

namespace Fluid_Volume_Calculation.Models
{
    public class OilBarrel : IUnitOfVolume
    {
        public OilBarrel(decimal value) => this.Value = value;

        public decimal Value { get; set; }

        public VolumeUnit Unit { get; set; } = VolumeUnit.Barrel;

        /// <summary>Converts to string.</summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString() => this.Value.ToString("0.############################");

        /// <summary>Implements the operator ==.</summary>
        /// <param name="brl1">The BRL1.</param>
        /// <param name="brl2">The BRL2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(OilBarrel brl1, OilBarrel brl2) => brl1.Value == brl2.Value;

        /// <summary>Implements the operator !=.</summary>
        /// <param name="brl1">The BRL1.</param>
        /// <param name="brl2">The BRL2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(OilBarrel brl1, OilBarrel brl2) => !(brl1 == brl2);

        /// <summary>Determines whether the specified <see cref="System.Object"/>, is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            OilBarrel current = obj as OilBarrel;
            if (null == obj) return false;
            return this == current;
        }

        /// <summary>Implements the operator +.</summary>
        /// <param name="brl1">The BRL1.</param>
        /// <param name="brl2">The BRL2.</param>
        /// <returns>The result of the operator.</returns>
        public static OilBarrel operator +(OilBarrel brl1, OilBarrel brl2) => new OilBarrel(brl1.Value + brl2.Value);

        /// <summary>Implements the operator -.</summary>
        /// <param name="brl1">The BRL1.</param>
        /// <param name="brl2">The BRL2.</param>
        /// <returns>The result of the operator.</returns>
        public static OilBarrel operator -(OilBarrel brl1, OilBarrel brl2) => new OilBarrel(brl1.Value - brl2.Value);
    }
}
