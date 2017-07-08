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
            IsListAreaVisible = true;
            IsSearchAreaVisible = true;
            IsListAreaVisible = false;

            Products = new List<TrainingProduct>();
            SearchEntity = new TrainingProduct();
            EventCommand = "List";
        }

        public List<TrainingProduct> Products { get; set; }
       
        public string EventCommand { get; set; }
        public TrainingProduct SearchEntity { get; set; }
        public bool IsDetailAreaVisible { get; set; }
        public bool IsListAreaVisible { get; set; }
        public bool IsSearchAreaVisible { get; set; }

        private void ResetSearch()
        {
            SearchEntity = new TrainingProduct();
        }

        public void HandleRequest()
        {
            switch (EventCommand.ToLower())
            {
                case "list":
                case "search":
                    Get();
                    break;

                case "resetsearch":
                    ResetSearch();
                    break;

                case "add":
                    IsListAreaVisible = false;
                    IsSearchAreaVisible = false;
                    IsListAreaVisible = true;
                    break;

                default:
                    break;
            }
        }

        private void Get()
        {
            TrainingProductManager manager = new TrainingProductManager();



            Products = manager.Get(SearchEntity);
        }
    }
}
