using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Demon
{
    public string Name { get; set; }
    public decimal Health { get; set; }
    public decimal Damage { get; set; }

    public static Demon Parse(string demonName)
    {
        var demon = new Demon();

        demon.Name = demonName;

        demon.Health = CalculateHealth(demonName);
        demon.Damage = CalculateDamage(demonName);

        return demon;
    }

    private static decimal CalculateDamage(string demonName)
    {
        var damagePattern = @"[+-]?[0.0-9]+"; // [+-]?\d+(?:\.?\d+)?

        var damageNumbers = Regex.Matches(demonName, damagePattern);

        var damage = 0m;

        foreach (Match match in damageNumbers)
        {
            damage += decimal.Parse(match.Value);
        }

        var modifiers = demonName
            .Where(a => a == '*' || a == '/')
            .ToArray();

        foreach (var modifier in modifiers)
        {
            switch (modifier)
            {
                case '*':
                    damage *= 2;
                    break;
                case '/':
                    damage /= 2;
                    break;
            }
        }

        return damage;
    }

    private static decimal CalculateHealth(string demonName)
    {
        var healthPattern = @"[^0-9+\-*\.\/]";

        var healthChars = Regex.Matches(demonName, healthPattern);

        var health = 0m;

        foreach (Match match in healthChars)
        {
            health += char.Parse(match.Value);
        }

        return health;
    }
}

class NetherRealms
{
    static void Main()
    {
        var demons = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(Demon.Parse)
            .OrderBy(a => a.Name)
            .ToArray();

        foreach (var demon in demons)
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
        }
    }
}

