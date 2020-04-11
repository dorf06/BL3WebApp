using System;
using System.ComponentModel.DataAnnotations;

namespace BL3WebApp.Models
{
    public class Item
    {

        public int ID { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Element { get; set; }

        [Display(Name = "World Drop?")]
        public string WorldDrop { get; set; }

        [Display(Name = "Dropped By")]
        public string DroppedBy { get; set; }

        [Display(Name = "Quest/Challenge Name")]
        public string QuestChallengeName { get; set; }

        public string Location { get; set; }

        public string Summary { get; set; }

        [Display(Name = "Red Text")]
        public string RedText { get; set; }
    }
}