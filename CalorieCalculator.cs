/////////////////////////////////////////////
// CalorieCalculator.cs                    //
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
    /// BMR calculations. A couple of diffrent values is possible
    /// to get thorugh three differnt methods. The result depends
    /// on waht values the instance variables are given through
    /// the "set"-metohds.
    /// </summary>
    class CalorieCalculator
    {
        //Declars instance variables
        private int activityLevel;
        private int age;
        private double height;
        private double weight;
        private bool isFemale;

        /// <summary>
        /// The method calculates snd returns the BMR value.
        /// Depending on gender the result is adjusted.
        /// </summary>
        /// <returns>A double</returns>
        public double CalcBasMetabolicRateBMR()
        {
            double bmr = 10 * weight + 6.25 * height - 5 * age;
            if(isFemale)
            {
                return (bmr - 161);
            }
            else
            {
                return (bmr + 5);
            }
        }

        /// <summary>
        /// Method that checks that no values are negative
        /// </summary>
        /// <returns>A boolean</returns>
        public bool noNegativeValues()
        {
            if(age < 0 || height < 0 || weight < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// This method is used to get the value of the activityLevel.
        /// The activityLevel value ranges from 0-4. Depending on
        /// the value a corresponding number is returned.
        /// </summary>
        /// <returns>A double</returns>
        private double GetActivityLevelFactor()
        {
            if(activityLevel == 0)
            {
                return 1.2;
            }
            else if(activityLevel == 1)
            {
                return 1.375;
            }
            else if (activityLevel == 2)
            {
                return 1.550;
            }
            else if (activityLevel == 3)
            {
                return 1.725;
            }
            else
            {
                return 1.9;
            }

        }

        /// <summary>
        /// This method takes two parameters. The first is the weight which is to be
        /// calculated and the other is if a boolean on wheter to lose or gain weight.
        /// </summary>
        /// <param name="inWeight"></param>
        /// <param name="lose"></param>
        /// <returns>A double</returns>
        public double LoseOrGainWeightCalories(double inWeight, bool lose)
        {
            double loseOrGain = MaintainWeightCalories();
            if (lose)
            {
                loseOrGain = loseOrGain - (inWeight * 1000);
            }
            else
            {
                loseOrGain = loseOrGain + (inWeight * 1000);
            }

            return loseOrGain;
        }

        /// <summary>
        /// The method calculates and returns the value for maintaing ones weight.
        /// </summary>
        /// <returns>A double</returns>
        public double MaintainWeightCalories()
        {
            return (CalcBasMetabolicRateBMR() * GetActivityLevelFactor());
        }

        /// <summary>
        /// Metohd that returns the value of age
        /// </summary>
        /// <returns>A int</returns>
        public int GetAge()
        {
            return age;
        }

        /// <summary>
        /// Metohd that returns the value of height
        /// </summary>
        /// <returns>A double</returns>
        public double GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Metohd that returns the value of weight
        /// </summary>
        /// <returns>A double</returns>
        public double GetWeight()
        {
            return weight;
        }

        /// <summary>
        /// Method that updates the value of activityLevel variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetActivityLevel(int newValue)
        {
            activityLevel = newValue;
        }

        /// <summary>
        /// Method that updates the value of age variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetAge(int newValue)
        {
            age = newValue;
        }

        /// <summary>
        /// Method that updates the value of isFemale variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetGender(bool newValue)
        {
            isFemale = newValue;
        }

        /// <summary>
        /// Method that updates the value of height variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetHeight(double newValue)
        {
            height = newValue;
        }

        /// <summary>
        /// Method that updates the value of weight variable
        /// </summary>
        /// <param name="inValue"></param>
        public void SetWeight(double newValue)
        {
            weight = newValue;
        }

    }
}
