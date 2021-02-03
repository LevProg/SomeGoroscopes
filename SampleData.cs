using SomeGoroscopes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeGoroscopes
{
    public class SampleData
    {
        public static void Initialize(HoroscopeContext context)
        {
            if (!context.Prediction.Any())
            {

                context.Prediction.AddRange(
                    new Prediction()
                   ,
                     new Prediction()
                   ,
                      new Prediction()
                ); ;
                context.SaveChanges();
            }
        }
    }
}