using FantasyQuest.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyQuest.Items.Models
{
    public class Item : IItem
    {
        public ItemType Name;
        public string Description;
        public int ObjectiveNumber;
        public int Weight;
        public int GoldValue;
    }
    public enum ItemType
    {
        Rope,
        Torch,
        HolySymbol,
        Water,
        Food,
        Tinderbox
    }
}
