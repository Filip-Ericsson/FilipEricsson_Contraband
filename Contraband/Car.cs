using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Car
    {
        public int passengers = 0;
        public int contrabandAmount = 0;
        public bool alreadyChecked;
        public Random generator = new Random();
        int foundContraband = 0;

        public bool Examine(int contrabandAmount)
        {
            if (alreadyChecked == false)
            {
                alreadyChecked = true;
                if (contrabandAmount == 0)
                {
                    return false;
                }
                else
                {
                    foundContraband = generator.Next(1, 10);
                    if (foundContraband > 8 && contrabandAmount == 1)
                    {
                        return true;
                    }
                    else if (foundContraband > 6 && contrabandAmount == 2)
                    {
                        return true;
                    }
                    else if (foundContraband > 4 && contrabandAmount == 3)
                    {
                        return true;
                    }
                    else if (foundContraband > 2 && contrabandAmount == 4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                Console.WriteLine("This car is already Checked");
                return false;
            }
            
        }
    }
}
