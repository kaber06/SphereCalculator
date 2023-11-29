using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereCalculator
{
    public class CalculateSphere
    {
        public double volumeOfSphere(double radius)
        {
            if(radius > 0) 
            {
                double sphere = 4 / 3 * Math.PI * radius * radius * radius;
                sphere = Math.Round(sphere, 2);
                return sphere;
            }
            else
            {
                Console.WriteLine("Invalid value. Please enter numeric value");
                return 0;
            }
                
                                    
        }
    }
}
