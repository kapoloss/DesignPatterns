namespace DesignPattern.Behavioral.ChainOfResponsibility.ExampleUsage
{
    public class Enemy
    {
        public float Health { get; set; }
        public float Armor { get; set; }
        public bool IsResistant { get; set; }
        public bool IsRaging { get; set; }
        public float RageThreshold { get; set; }

        public Enemy(float health, float armor, bool isResistant, float rageThreshold)
        {
            Health = health;
            Armor = armor;
            IsResistant = isResistant;
            RageThreshold = rageThreshold;
        }
    }
}