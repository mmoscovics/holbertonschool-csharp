using System;

/// Class Player ///
public class Player
{
    string name;
    float maxHp;
    float hp;

    /// Player Constructor ///
    public Player(string name ="Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// Health info ///
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// Calculate Health Delegate
    public delegate void CalculateHealth(float amount);

    /// Take Damage ///
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// Heal Damage ///
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}