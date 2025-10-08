using FantasyQuest.Adventures;
using FantasyQuest.Entities.Interfaces;
using FantasyQuest.Entities.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyQuest.Entities
{
    public class CharacterService : ICharacterService
    {
        public Character LoadInitialCharacter()
        {
            var bathPath = $"{AppDomain.CurrentDomain.BaseDirectory}/Characters";
            var initialCharacter = new Character();

            if (File.Exists($"{bathPath}\\cloud.json"))
            {
                var directory = new DirectoryInfo(bathPath);
                var initialJsonfile = directory.GetFiles("cloud.json");

                using StreamReader fi = File.OpenText(initialJsonfile[0].FullName);
                initialCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
            }

            return initialCharacter;
        }
    }
}
