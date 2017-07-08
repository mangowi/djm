using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJMData
{
   public  class TrainingProductManager
    {

        private List<TrainingProduct> CreateMockData()
        {
            
            List<TrainingProduct> ret = new List<TrainingProduct>();


            ret.Add(new TrainingProduct()
            {
                ProductId = 1,
                ProductName = "ASP .NET MVC",
                IntroductionDate = Convert.ToDateTime("6/11/2017"),
                Url = "https//:mangowi.com",
                Price = Convert.ToDecimal(20.00)
            });

            return ret;
        }
    }
}
