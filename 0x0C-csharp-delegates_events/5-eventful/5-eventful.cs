using System;

/// Class Player ///
public class Player
{
    string name;
    float maxHp;
    float hp;

    EventHandler<CurrentHPArgs> HPCheck;

    private string status;

    /// Player Constructor ///
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
        this.status = $"{name} is ready to go!";
        HPCheck = CheckStatus;
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
        ValidateHP(hp - damage);
    }

    /// Heal Damage ///
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
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
        OnCheckStatus(new CurrentHPArgs(hp));
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

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float halfMax = maxHp / 2;
        float quartMax = maxHp / 4;

        if (e.currentHp == maxHp)
            status = $"{name} is in perfect health!";
        else if (e.currentHp >= halfMax)
            status = $"{name} is doing well!";
        else if (e.currentHp >= quartMax)
            status = $"{name} isn't doing too great...";
        else if (e.currentHp > 0)
            status = $"{name} needs help!";
        else if (e.currentHp == 0)
            status = $"{name} is knocked out!";
        Console.WriteLine(status);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
            Console.WriteLine("Health has reached zero!");
        else
            Console.WriteLine("Health is low!");
    }

    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
            HPCheck += HPValueWarning;
        HPCheck(this, e);
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

/// Class CurrentHPArgs, inherits EventArgs ///
public class CurrentHPArgs : EventArgs
{
    /// currentHp ///
    public float currentHp;

    /// CurrentHpArgs constructor ///
    public CurrentHPArgs(float currentHp)
    {
        this.currentHp = currentHp;
    }
}