namespace FantasyQuest.Entities.Models
{
    public abstract class Entity
    {
        public int HitPoint = 0;
        public Attack Attack;
    }

    public class Attack
    {
        public int BaseDie;
        public int BonusDamage;
    }
}
