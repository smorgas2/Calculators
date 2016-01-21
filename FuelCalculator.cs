/////////////////////////////////////////////
// FuelCalculator.cs                       //
// Created by: Markus Lidrot, 2015-10-24   //
/////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /// <summary>
    /// This class is used to do calculations regarding
    /// fuelconsumtion. Five diffrent values are possible do
    /// get depending on what values the instancevaribles are
    /// set to through the "set"-metohds.
    /// </summary>
    class FuelCalculator
    {
        //Declars instance variables
        private double currReading;
        private double fuelAmount;
        private double prevReading;
        private double unitPrice;

        /// <summary>
        /// This method calculates and returns the value of
        /// the fuelconsumtion kilometer per liter
        /// </summary>
        /// <returns>A double</returns>
        public double CalcConsumtionKilometerPerLiter()
        {
            double km = currReading - prevReading;
            return (km / fuelAmount);
        }

        /// <summary>
        /// This method calculates and returns the value of
        /// the fuelconsumtion per metric mile
        /// </summary>
        /// <returns>A double</returns>
        public double CalcConsumtionPerMetric()
        {
            const double kmToMileFactor = 0.621371192;
            return ((fuelAmount / (currReading - prevReading))/ kmToMileFactor);
        }

        /// <summary>
        /// This method calculates and returns the value of
        /// the fuelconsumtion the cost per kilometer
        /// </summary>
        /// <returns>A double</returns>
        public double CalcCostPerKm()
        {
            
            return ((fuelAmount / (currReading - prevReading))* unitPrice);
        }

        /// <summary>
        /// This method calculates and returns the value of
        /// the fuelconsumtion per liter every kilometer
        /// </summary>
        /// <returns>A double</returns>
        public double CalcFuelConsumtionPerKm()
        {
            return (fuelAmount / (currReading - prevReading));
        }

        /// <summary>
        /// This method calculates and returns the value of
        /// the fuelconsumtion per every swedish mile
        /// </summary>
        /// <returns>A double</returns>
        public double CalcFuelConsumtionPerSweMile()
        {
            return ((fuelAmount / (currReading - prevReading)) * 10);
        }

        /// <summary>
        /// Metohd that returns the value of currReading
        /// </summary>
        /// <returns>A double</returns>
        public double GetCurrentReading()
        {
            return currReading;
        }

        /// <summary>
        /// Metohd that returns the value of prevReading
        /// </summary>
        /// <returns>A double</returns>
        private double GetPreviousReading()
        {
            return prevReading;
        }

        /// <summary>
        /// Metohd that returns the value of fuelAmount
        /// </summary>
        /// <returns>A double</returns>
        public double GetFuelAmount()
        {
            return fuelAmount;
        }

        /// <summary>
        /// Metohd that returns the value of unirPrice
        /// </summary>
        /// <returns>A double</returns>
        public double GetUnitPrice()
        {
            return unitPrice;
        }

        /// <summary>
        /// Method that updates the value of currReading variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetCurrentReading(double newValue)
        {
            currReading = newValue;
        }

        /// <summary>
        /// Method that updates the value of fuelAmount variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetFuelAmount(double newValue)
        {
            fuelAmount = newValue;
        }

        /// <summary>
        /// Method that updates the value of prevReading variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetPreviousReading(double newValue)
        {
            prevReading = newValue;
        }

        /// <summary>
        /// Method that updates the value of unitPrice variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetUnitPrice(double newValue)
        {
            unitPrice = newValue;
        }

        /// <summary>
        /// Method that checks if current reading is bigger than previous reading.
        /// </summary>
        /// <returns>A boolean</returns>
        public bool ValidateOdometerValue()
        {
            if(currReading > prevReading)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method that checks that no values are negative
        /// fuelAmount must be postive for the method 
        /// CalcConsumtionKilometerPerLiter to work. 
        /// </summary>
        /// <returns>A boolean</returns>
        public bool noNegativeValues()
        {
            if (currReading < 0 || prevReading < 0 || fuelAmount <= 0 || unitPrice < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
