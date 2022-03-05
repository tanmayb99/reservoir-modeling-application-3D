using System;
using System.IO;

namespace Fluid_Volume_Calculation.Validation
{
    public class Validator
    {
        public static string ValidateFilePath(string filePath)
        {
            if (null == filePath)
                throw new ArgumentNullException("Invalid top horizon data set file path. Please provide a valid path");
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Please ensure the file containing the data set for top horizon depths exist at the location [{filePath}]");
            return filePath;
        }

        public static decimal ValidateDecimal(string value)
        {
            if (null == value)
                throw new ArgumentNullException("Invalid value. Please enter a number");
            decimal number;
            if (decimal.TryParse(value, out number))
                return number;
            throw new FormatException($"The enetered value [{value}] is not a decimal number. Please enter a number.");
        }
    }
}
