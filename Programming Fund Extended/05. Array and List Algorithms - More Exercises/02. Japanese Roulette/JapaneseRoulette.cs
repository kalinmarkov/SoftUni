using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JapaneseRoulette
{
    static void Main()
    {
        var cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var players = Console.ReadLine().Split(' ').ToList();

        var firstBulletPosition = cylinder.IndexOf(1);        
        var lastPositionBullet = 0;
        var isDeath = false;

        for (int i = 0; i < players.Count; i++)
        {
            var commands = players[i].Split(',').ToArray();
            var strengthOfRotation = int.Parse(commands[0]);
            var direction = commands[1];

            if (direction == "Right")
            {
                lastPositionBullet = (firstBulletPosition + strengthOfRotation) % cylinder.Count;
                firstBulletPosition = lastPositionBullet;
            }
            else
            {
                lastPositionBullet = (firstBulletPosition - strengthOfRotation) % cylinder.Count;
                if (lastPositionBullet < 0)
                {
                    lastPositionBullet += cylinder.Count;
                }
                firstBulletPosition = lastPositionBullet;
                
            }

            if (lastPositionBullet == 2)
            {
                Console.WriteLine($"Game over! Player {i} is dead.");
                isDeath = true;
                break;
            }
            firstBulletPosition++;
        }

        if (!isDeath)
        {
            Console.WriteLine("Everybody got lucky!");
        }

    }
}

