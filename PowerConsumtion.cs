/////////////////////////////////////////////
// PowerConsumtion.cs                      //
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
    /// The class is used to calculate the power consumtion of
    /// electrical devices. It is possible to get the consumtion cost from two products and 
    /// alos get the differnce between them.
    /// </summary>
    class PowerConsumtion
    {
        //Declare variables
        private int oldConsumptionOn;
        private int oldConsumptionStandby;
        private int newConsumptionOn;
        private int newConsumptionStandby;
        private int usageOn;
        private int usageStandby;
        private double cost;
        //Declare and initiate variable daysYear, it's a constant because a year is most often 365 days 
        private const int daysYear = 365;

        /// <summary>
        /// Method that returns the yearly cost of the oldProduct
        /// </summary>
        /// <returns>A double</returns>
        public double oldProductYearlyCost()
        {
                double timeOn = (oldConsumptionOn * usageOn);
                double timeStandby = (oldConsumptionStandby * usageStandby);
                double timeCalc = (timeOn + timeStandby) / 1000;
                return ((timeCalc * 365) * cost);
        }

        /// <summary>
        /// Method that returns the yearly cost of the newProduct
        /// </summary>
        /// <returns>A double</returns>
        public double newProductYearlyCost()
        {
                double timeOn = (newConsumptionOn * usageOn);
                double timeStandby = (newConsumptionStandby * usageStandby);
                double timeCalc = (timeOn + timeStandby) / 1000;
                return ((timeCalc * 365) * cost);
        }

        /// <summary>
        /// Method that returns the differnce between products
        /// </summary>
        /// <returns>A double</returns>
        public double differenceCost()
        {
            return oldProductYearlyCost() - newProductYearlyCost();
        }

        /// <summary>
        /// Method that checks that no values are negative
        /// </summary>
        /// <returns>A boolean</returns>
        public bool noNegativeValues()
        {
            if (oldConsumptionOn < 0 || oldConsumptionStandby < 0 || newConsumptionOn < 0 || newConsumptionStandby < 0 || cost < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method that checks that total time for usage does not over exceed 24 hours 
        /// </summary>
        /// <returns>A boolean</returns>
        public bool hourCount()
        {
            if((usageOn + usageStandby) > 24)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method that updates the value of oldConsumptionOn variable
        /// </summary>
        /// <param name="inValue"></param>
        public void setOldConsumptionOn(int inValue)
        {
            oldConsumptionOn = inValue;
        }

        /// <summary>
        /// Method that updates the value of oldConsumptionStandby variable
        /// </summary>
        /// <param name="inValue"></param>
        public void setOldConsumptionStandby(int inValue)
        {
            oldConsumptionStandby = inValue;
        }

        /// <summary>
        /// Method that updates the value of newConsumptionOn variable
        /// </summary>
        /// <param name="inValue"></param>
        public void setNewConsumptionOn(int inValue)
        {
            newConsumptionOn = inValue;
        }

        /// <summary>
        /// Method that updates the value of newConsumptionStandby variable
        /// </summary>
        /// <param name="inValue"></param>
        public void setNewConsumptionStandby(int inValue)
        {
            newConsumptionStandby = inValue;
        }

        /// <summary>
        /// Method that updates the value of usageOn variable
        /// </summary>
        /// <param name="inValue"></param>
        public void setUsageOn(int inValue)
        {
            usageOn = inValue;
        }

        /// <summary>
        /// Method that updates the value of usageStandby variable
        /// </summary>
        /// <param name="inValue"></param>
        public void setUsageStandby(int inValue)
        {
            usageStandby = inValue;
        }

        /// <summary>
        /// Method that updates the value of cost variable
        /// </summary>
        /// <param name="inValue"></param>
        public void setCost(double inValue)
        {
            cost = inValue;
        }

        /// <summary>
        /// Metohd that returns the value of oldConsumptionOn
        /// </summary>
        /// <returns>An int</returns>
        public int getOldConsumptionOn()
        {
            return oldConsumptionOn;
        }

        /// <summary>
        /// Metohd that returns the value of oldConsumptionStandby
        /// </summary>
        /// <returns>An int</returns>
        public int getOldConsumptionStandby()
        {
            return oldConsumptionStandby;
        }

        /// <summary>
        /// Metohd that returns the value of newConsumptionOn
        /// </summary>
        /// <returns>An int</returns>
        public int getNewConsumptionOn()
        {
            return newConsumptionOn;
        }

        /// <summary>
        /// Metohd that returns the value of newConsumptionStandby
        /// </summary>
        /// <returns>An int</returns>
        public int getNewConsumptionStandby()
        {
            return newConsumptionStandby;
        }

        /// <summary>
        /// Metohd that returns the value of usageOn
        /// </summary>
        /// <returns>An int</returns>
        public int getUsageOn()
        {
            return usageOn;
        }

        /// <summary>
        /// Metohd that returns the value of usageStandby
        /// </summary>
        /// <returns>An int</returns>
        public int getUsageStandby()
        {
            return usageStandby;
        }

        /// <summary>
        /// Metohd that returns the value of cost
        /// </summary>
        /// <returns>A double</returns>
        public double getCost()
        {
            return cost;
        }
    }
}
