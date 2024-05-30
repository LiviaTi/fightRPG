/*
In this challenge, we will summarize the essentials of this interaction.
 A hero and a monster start with the same hit points. When it is the hero's turn, 
 it will generate a random value that will be subtracted from the monster's life.
  If the monster has life (greater than zero), it will, in turn, attack the hero.
  As long as the hero and monster have health (greater than zero), the battle will continue. 
*/

    int lifeHero = 100;
    int lifeMonster = 100;
    Random  attackHero = new Random();
    int currentAttackHero = attackHero.Next(1, 51);
    Random attackMonster = new Random();
    int currentAttackMonster = attackMonster.Next(1, 51); 
    bool currentHero = true;
    bool currentMonster = false;

    while((lifeMonster >= 0) &&  (lifeHero >=0))
    {
        if(currentHero == true )
        {
            currentAttackHero = attackHero.Next(1, 51);
            lifeMonster = lifeMonster - currentAttackHero;
            currentHero = false;
            currentMonster = true;

            Console.WriteLine($" O Herói causou dano de {currentAttackHero} a vida do monstro é de:{lifeMonster}");
            continue;
        }

        if(currentMonster == true )
        {
            currentAttackMonster = attackMonster.Next(1, 51);
            lifeHero = lifeMonster - currentAttackHero;
            currentHero = true;
            currentMonster = false;

            Console.WriteLine($" O Monstro causou dano de {currentAttackMonster} a vida do Herói é de:{lifeHero}");
            continue;            
        }
      
    }

     if(lifeHero <= 0) Console.WriteLine("O herói morreu. Fim de jogo"); 
    
    if(lifeMonster <= 0) Console.WriteLine("O monstro morreu. Fim de jogo"); 
   
    
    