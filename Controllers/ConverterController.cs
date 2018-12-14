using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Converter.Models;
using ConversionLib;

namespace Converter.Controllers
{
     public class ConverterController : Controller
    {
       
        public string FeetToMeter(decimal number)
        {
            LengthConvert convert = new LengthConvert();
            decimal result = convert.FeetToMeter(number);
            return $"The length is: {result}";
        }
        public string FeetToYard(decimal number)
        {
            LengthConvert convert = new LengthConvert();
            decimal result = convert.FeetToYard(number);
            return $"The length is: {result}";
        }
        public string YardToMeter(decimal number)
        {
            LengthConvert convert = new LengthConvert();
            decimal result = convert.YardToMeter(number);
            return $"The length is: {result}";
        }
        public string YardToFeet(decimal number)
        {
            LengthConvert convert = new LengthConvert();
            decimal result = convert.YardToFeet(number);
            return $"The length is: {result}";
        }
        public string MeterToFeet(decimal number)
        {
            LengthConvert convert = new LengthConvert();
            decimal result = convert.MeterToFeet(number);
            return $"The length is: {result}";
        }
        public string MeterToYard(decimal number)
        {
            LengthConvert convert = new LengthConvert();
            decimal result = convert.MeterToYard(number);
            return $"The length is: {result}";
        } 
        public string OuncesToPounds(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.OuncesToPounds(number);
            return $"The mass is: {result}";
        }
        public string OuncesToGrams(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.OuncesToGrams(number);
            return $"The mass is: {result}";
        }
        public string OuncesToKilos(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.OuncesToKilos(number);
            return $"The mass is: {result}";
        }

        public string PoundsToOunces(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.PoundsToOunces(number);
            return $"The mass is: {result}";
        }

        public string PoundsToGrams(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.PoundsToGrams(number);
            return $"The mass is: {result}";
        }
        public string PoundsToKilos(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.PoundsToKilos(number);
            return $"The mass is: {result}";
        }
        public string GramsToPounds(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.GramsToPounds(number);
            return $"The mass is: {result}";
        }public string GramsToKilos(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.GramsToKilos(number);
            return $"The mass is: {result}";
        }
        public string GramsToOunces(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.GramsToOunces(number);
            return $"The mass is: {result}";
        }
        public string KilosToGrams(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.KilosToGrams(number);
            return $"The mass is: {result}";
        }public string KilosToPounds(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.KilosToPounds(number);
            return $"The mass is: {result}";
        }
        public string KilosToOunces(decimal number)
        {
            MassConvert convert = new MassConvert();
            decimal result = convert.KilosToOunces(number);
            return $"The mass is: {result}";
        }
        public string FahrenheitToCelsius(decimal number)
        {
            TemperatureConvert convert = new TemperatureConvert();
            decimal result = convert.FahrenheitToCelsius(number);
            return $"The temperature is: {result}";
        }
        public string FahrenheitToKelvin(decimal number)
        {
            TemperatureConvert convert = new TemperatureConvert();
            decimal result = convert.FahrenheitToKelvin(number);
            return $"The temperature is: {result}";
        }
        public string CelsiusToFahrenheit(decimal number)
        {
            TemperatureConvert convert = new TemperatureConvert();
            decimal result = convert.CelsiusToFahrenheit(number);
            return $"The temperature is: {result}";
        }
        public string CelsiusToKelvin(decimal number)
        {
            TemperatureConvert convert = new TemperatureConvert();
            decimal result = convert.CelsiusToKelvin(number);
            return $"The temperature is: {result}";
        }
        public string KelvinToFahrenheit(decimal number)
        {
            TemperatureConvert convert = new TemperatureConvert();
            decimal result = convert.KelvinToFahrenheit(number);
            return $"The temperature is: {result}";
        }
        public string KelvinToCelsius(decimal number)
        {
            TemperatureConvert convert = new TemperatureConvert();
            decimal result = convert.KelvinToCelsius(number);
            return $"The temperature is: {result}";
        }


    }
}