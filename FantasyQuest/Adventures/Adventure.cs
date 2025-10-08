namespace FantasyQuest.Adventures
{
    public class Adventure
    {
        public string GUID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int completionXPReward { get; set; }
        public int completionGoldReward { get; set; }
        public int maxLevel {  get; set; }
        public int minimumLevel { get; set; }

        public Adventure() 
        {
            
        }
    }
}
