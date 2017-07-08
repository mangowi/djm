using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
            EventCommand = "List";
        }

        public List<TrainingProduct> Products { get; set; }
       
        public string EventCommand { get; set; }


        public void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "list":
                    Get();
                    break;


                default:
                    break;
            }
        }

        private void Get()
        {
            TrainingProductManager manager = new TrainingProductManager();

            Products = manager.Get();
        }
    }
}
