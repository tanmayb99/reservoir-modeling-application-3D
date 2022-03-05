using Fluid_Volume_Calculation.Enum;
using Fluid_Volume_Calculation.Interface;

namespace Fluid_Volume_Calculation.Models
{
    public class SquareFeet : IUnitOfArea
    {
        public SquareFeet(decimal value) => this.Value = value;
        
        public decimal Value { get; set; }
       
        public AreaUnit Unit { get; set; } = AreaUnit.SquareFeet;

        /// <summary>Implements the operator ==.</summary>
        /// <param name="sf1">The SF1.</param>
        /// <param name="sf2">The SF2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(SquareFeet sf1, SquareFeet sf2) => sf1.Value == sf2.Value;

        /// <summary>Implements the operator !=.</summary>
        /// <param name="sf1">The SF1.</param>
        /// <param name="sf2">The SF2.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(SquareFeet sf1, SquareFeet sf2) => !(sf1 == sf2);

        /// <summary>Implements the operator +.</summary>
        /// <param name="sf1">The SF1.</param>
        /// <param name="sf2">The SF2.</param>
        /// <returns>The result of the operator.</returns>
        public static SquareFeet operator +(SquareFeet sf1, SquareFeet sf2) => new SquareFeet(sf1.Value + sf2.Value);

        /// <summary>Implements the operator -.</summary>
        /// <param name="sf1">The SF1.</param>
        /// <param name="sf2">The SF2.</param>
        /// <returns>The result of the operator.</returns>
        public static SquareFeet operator -(SquareFeet sf1, SquareFeet sf2) => new SquareFeet(sf1.Value - sf2.Value);

        /// <summary>Determines whether the specified <see cref="System.Object"/>, is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            SquareFeet current = obj as SquareFeet;
            if (null == obj) return false;
            return this == current;
        }

        /// <summary>Converts to string.</summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString() => this.Value.ToString("0.############################");
    }
}
