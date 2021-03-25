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
        ValidateHP(hp - damage);
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// Heal Damage ///
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        ValidateHP(hp + heal);
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    /// Validate HP, sets new value after Calculate Health ///
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;
    }

    /// Apply Modifier, apply to values ///
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2;
        else if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
        else
            return baseValue;
    }
}

/// Modifiers ///
public enum Modifier
{
    /// Weak mMdifier ///
    Weak,
    /// Normal/Base Modifier ///
    Base,
    /// Strong Modifier ///
    Strong
}

/// Calculate Modifier Delegate ///
public delegate float CalculateModifier(float baseValue, Modifier modifier);