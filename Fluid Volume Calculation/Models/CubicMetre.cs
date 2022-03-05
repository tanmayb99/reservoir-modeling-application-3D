using Fluid_Volume_Calculation.Enum;
using Fluid_Volume_Calculation.Interface;

namespace Fluid_Volume_Calculation.Models
{
    public class CubicMetre : IUnitOfVolume
    {
        public CubicMetre(decimal value) => this.Value = value;

        public decimal Value { get; set; }

        public VolumeUnit Unit { get; set; } = VolumeUnit.CubicMetre;

        /// <summary>Converts to string.</summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString() => this.Value.ToString("0.############################");

        /// <summary>Implements the operator ==.</summary>
        /// <param name="cubm1">The cubm1.</param>
        /// <param name="cubm2">The cubm2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(CubicMetre cubm1, CubicMetre cubm2) => cubm1.Value == cubm2.Value;

        /// <summary>Implements the operator !=.</summary>
        /// <param name="cubm1">The cubm1.</param>
        /// <param name="cubm2">The cubm2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(CubicMetre cubm1, CubicMetre cubm2) => !(cubm1 == cubm2);

        /// <summary>Determines whether the specified <see cref="System.Object"/>, is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            CubicMetre current = obj as CubicMetre;
            if (null == obj) return false;
            return this == current;
        }

        /// <summary>Implements the operator +.</summary>
        /// <param name="cubm1">The cubm1.</param>
        /// <param name="cubm2">The cubm2.</param>
        /// <returns>The result of the operator.</returns>
        public static CubicMetre operator +(CubicMetre cubm1, CubicMetre cubm2) => new CubicMetre(cubm1.Value + cubm2.Value);

        /// <summary>Implements the operator -.</summary>
        /// <param name="cubm1">The cubm1.</param>
        /// <param name="cubm2">The cubm2.</param>
        /// <returns>The result of the operator.</returns>
        public static CubicMetre operator -(CubicMetre cubm1, CubicMetre cubm2) => new CubicMetre(cubm1.Value - cubm2.Value);
    }
}
