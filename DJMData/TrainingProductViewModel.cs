using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJMData
{
   public class TrainingProductViewModel
    {

        public TrainingProductViewModel()
        {
            Products = new List<TrainingProduct>();
        }

        public List<TrainingProduct> Products { get; set; }

        public void Get()
        {
            TrainingProductManager manager = new TrainingProductManager();

            Products = manager.Get();
        }
    }
}
