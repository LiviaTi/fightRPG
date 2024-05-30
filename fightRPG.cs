/*
In this challenge, we will summarize the essentials of this interaction.
 A hero and a monster start with the same hit points. When it is the hero's turn, 
 it will generate a random value that will be subtracted from the monster's life.
  If the monster has life (greater than zero), it will, in turn, attack the hero.
  As long as the hero and monster have health (greater than zero), the battle will continue. 
*/
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
   
    
    