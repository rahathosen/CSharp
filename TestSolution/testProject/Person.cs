using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Person
    {
        #region Fild

        private string name;
        public double height;
        public double weight;

        #endregion Fild

        #region Property

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value != 0)
                    height = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        #endregion Property

        #region Method

        public void walk()
        {
            var mass = weight * height;
        }

        #endregion Method
    }
}