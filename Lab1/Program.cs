using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
             //GÉNÉRATEUR ALÉATOIRE
            Random aleatoire = new Random();//générateur créer             
            //VARIABLES
            string hero;
            float vaisseau = 3;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //DEBUT
            Console.WriteLine(" Bienvenue dans le jeux don VOUS êtes le hero ! veuillez écrire votre nom ! ");
            hero = Console.ReadLine();
            Console.WriteLine("Bonjour " + hero + " ! ");
            Console.WriteLine("êtes vous prêt a jouer ? (p.s pour intéragir avec l'histoire vous devez répondre par 0 ou 1 ) ");
            Console.ReadLine();
            //Le jeux commence !
            Console.WriteLine("Vous êtes dans votre vaisseau avec votre équipage et vous vous dirigez vers un signal de détresse. ");
            Console.WriteLine("Rendu a destination,vous remarquez un vaisseau au loin, mais sans vie.");
            Console.WriteLine("voulez vous vous approchez (0) ou restez a distance ? (1) ");
            vaisseau = float.Parse(Console.ReadLine());
            //l'approche choix 1
            if (vaisseau == 0)
            {
                Console.WriteLine("vous vous approchez du vaisseau sans vie ,mais plus vous avancer plus vous sentez une menace vous envahir. ");
                Console.WriteLine("Tout-a-coup ! le vaisseau se met a bouger et se retourne vers vous !");
                Console.WriteLine("vous voyez ses armes se diriger vers vous ! Que faite vous ? ");
                Console.WriteLine("vous attaquez (0) ou essayez de fuire ? (1)");
                vaisseau = float.Parse(Console.ReadLine());
                //attaquer choix 2
                if (vaisseau == 0)
                {
                    int prc = aleatoire.Next(1, 3);//1 sur 2 chance 
                    if (prc == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("vous tirez ! mais l'ennemi a malheureusement bien esquivé.");
                        Console.WriteLine("L'autre vaisseau vous tire desus.......il n'y a pas d'échapatoir .....vous êtes mort ! ");
                        Console.WriteLine("dommage " + hero + " meilleur chance la prochaine fois ! ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("vous tirez ! et vous touché le vaisseau ennemi !!! ");
                        Console.WriteLine("Àpres cette attaque vous decidez de retourner chez vous en vie ! ");
                        Console.WriteLine("Félicitation ! " + hero + " vous avez survécu ! ");
                        Console.ReadLine();
                    }
                }
                //fuire choix 2
                else
                {
                    int prc = aleatoire.Next(1, 3);//1 sur 2 chance 
                    if (prc == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("vous essayez de fuire. ");
                        Console.WriteLine("Mais l'ennemi a déjà charger son tire");
                        Console.WriteLine("Il vous touche !....... vous malhaureusement sombrer avec votre équipage");
                        Console.WriteLine("dommage " + hero + " meilleur chance la prochaine fois ! ");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("vous essayez de fuire. ");
                        Console.WriteLine("Vous esquivez leur tire !");
                        Console.WriteLine("Vous activer votre hypervitesse et vous réussiser a survive ! ");
                        Console.WriteLine("Félicitation ! " + hero + " vous avez survécu ! ");
                        Console.ReadLine();
                    }
                }
            }
            //distance choix 1
            else
            {
                Console.WriteLine("vous décider de rester sur place. Vous regardez le vaisseau avec curiosité. ");
                Console.WriteLine("Tout-à-coup ! sans préter attention autour de vous. Un rocher s'approche dangeureusement de votre vaisseau !");
                Console.WriteLine("Que décider vous de faire ?");
                Console.WriteLine("de restez sur place (0) ou d'acvancer ? (1) ");
                vaisseau = float.Parse(Console.ReadLine());
                if (vaisseau == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("vous décider de rester sur place. avec une grande peur ! ");
                    Console.WriteLine("Soudain ! Un autre rocher cogne et dévi l'autre rocher et attéri sur le vaisseau voisin et l'explose.");
                    Console.WriteLine("confus vous repartez cher vous ");
                    Console.WriteLine("Félicitation ! " + hero + " vous avez survécu !........ je crois.");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("vous décider d'avancer. ");
                    Console.WriteLine("Soudain ! Un autre rocher cogne et dévi l'autre rocher et attéri sur votre vaisseau");
                    Console.WriteLine("Malheureusement vous exploser avec votre équipage.");
                    Console.WriteLine("dommage " + hero + " meilleur chance la prochaine fois !");
                    Console.ReadLine();
                }
            }
            //FIN
        }
    }
}
