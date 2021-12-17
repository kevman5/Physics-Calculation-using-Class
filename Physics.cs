using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Class_unit6
{
    class Physics
    {
        private int numerator;
        private int denominator;
        private int weight;
        private int power;
        private int time;
        private int work;
        
        public int getPower()
        {
            return power;
        }

        public int getTime()
        {
            return time;
        }

        public int getwork()
        {
            return work;
        }

        public int getWeight()
        {
            return weight;
        }
            
        public int getNumerator()
        {
            return numerator;
        }

        public int getDenominator()
        {
            return denominator;
        }

        public void setPower(int p1)
        {
            power = p1;
        }

        public void setTime(int t1)
        {
            time = t1;
        }

        public void setWork(int w1)
        {
            work = w1;
        }
        public void setWeight(int w1)
        {
            weight = w1;
        }
        public void setNumerator(int n)
        {
            numerator = n;

        }
        public void setDenominator(int d)
        {
            denominator = d;
        }
        public void calcWeight()
        {
            int w1;
            weight = numerator * denominator;
        }
        
        public void calcPower()
        {
            int p1;
            power = work / time;
        }
    }
}
