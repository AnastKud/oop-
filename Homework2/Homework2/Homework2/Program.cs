using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameCharacter character = new GameCharacter("Hero", 100, 1);
            character.TakeDamage(20);
            character.Heal(10);
            character.LevelUp();
            character.TakeDamage(150);
            character.Heal(-10);
            character.Heal(200);
        }
    }
}
