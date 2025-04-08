using System;
public class GameCharacter
{
    private string name;
    private int health;
    private int level;

    public GameCharacter(string name, int health, int level)
    {
        this.name = name;
        this.health = 100;
        this.level = 1;
    }

    public string Name { get { return name; } }
    public int Health { get { return health; } }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (damage < 0)
        {
            Console.WriteLine("Damage cannot be negative.");
            return;
        }
        if (health < 0)
        {
            health = 0;
        }
        Console.WriteLine($"{name} took {damage} damage. Character health:{health}");
    }
    public void Heal(int amount)
    {
        health += amount;
        if (amount < 0)
        {
            Console.WriteLine("Heal cannot be negative.");
            return;
        }
        if (health == 0)
        {
            Console.WriteLine($"{name} death");
            return;
        }
        if (health > 100)
        {
            Console.WriteLine("Can't treat maximum");
            health = 100;
        }
        Console.WriteLine($"{name} restored {amount} of health. Character health:{health}");
    }
    public void LevelUp()
    {
        level++;
        Console.WriteLine($"{name} level up! Level:{level}");
    }
}

