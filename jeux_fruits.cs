//Créez un jeu de gestion de panier de fruits au marché à l’aide d’un tableau de chaînes de caractères.
//L'utilisateur peut ajouter maximum 5 fruits, les retirer, les afficher et les rechercher.
//Gérez les doublons lors de l’ajout.
//Permettez à l’utilisateur de quitter le jeu via le menu.






/*
string[] panier = new string[5];
int nombreFruits = 0;

bool continuer = true;
while (continuer)
{
    Console.WriteLine("Menu;");
    Console.WriteLine("1. Ajouter un fruit");
    Console.WriteLine("2. Retirer un fruit");
    Console.WriteLine("3. Afficher les fruit");
    Console.WriteLine("4. Rechercher un fruit");
    Console.WriteLine("5. Quitter");

    string choix = Console.ReadLine();

    if (choix == "1")
    {
        if (nombreFruits < 5)
        {
            Console.WriteLine("Entrez le fruit à ajouter (séparés par des virgules):: ");
            string fruitAjouter = Console.ReadLine();

            string[] fruits = fruitAjouter.Split(','); // separer virgule

            foreach (string fruit in fruits)
            {
                string fruitNettoye = fruit.Trim();
                bool existeDeja = false; // verifie si le fruit est deja dans le panier.

                for (int i = 0; i < nombreFruits; i++)
                {
                    if (panier[i] == fruitAjouter)
                    {
                        existeDeja = true;
                        break;
                    }
                }

                if (!existeDeja && nombreFruits < 5)
                {
                    panier[nombreFruits] = fruitNettoye;
                    nombreFruits++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{fruitNettoye} a été ajoute au panier");
                    Console.ResetColor();

                }
                else if (existeDeja)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Ce fruit est deja dans le panier");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Panier plein, impossible d'ajouter de fruits ");
                    Console.ResetColor();

                    break;
                }
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Panier plein");
            Console.ResetColor();
        }
    }
    else if (choix == "2")
    {

        Console.WriteLine("Entrez un fruit à retirer: ");
        string fruitRetirer = Console.ReadLine();

        bool fruitTrouver = false;

//trouver le fruit 
        for (int i = 0; i < nombreFruits; i++)
        {
            if (panier[i] == fruitRetirer)
            {
                fruitTrouver = true;
                for (int p = i; p < nombreFruits - 1; p++)
                {
                    panier[p] = panier[p + 1];
                }


                panier[nombreFruits - 1] = null; // supprimer le fruit 
                nombreFruits--;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{fruitRetirer} a été retiré du panier");
                Console.ResetColor();

                break;
            }
        }

        if (!fruitTrouver)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{fruitRetirer}n'est pas dans le panier ");
            Console.ResetColor();
        }
    }
    
    else if (choix == "3")
    {

        Console.WriteLine("Les fruits dans votre panier sont");
        if (nombreFruits == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("le panier est vide");
            Console.ResetColor();
        }
        else
        {
            for (int i = 0; i < nombreFruits; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(panier[i]);
                Console.ResetColor();
            }
        }
    }
    else if (choix == "4")
    {

        Console.WriteLine("Entrez le fruit a rechercher");
        string fruitRechercher = Console.ReadLine();
        bool rechercher = false;
        for (int i = 0; i < nombreFruits; i++)
        {
            if (panier[i] == fruitRechercher)
            {
                rechercher = true;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"{fruitRechercher} est dans le panier");
                Console.ResetColor();

                break;
            }
        }

        if (!rechercher)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{fruitRechercher} n'est dans le panier"); 
            Console.ResetColor();
        }
    }
    else if (choix == "5")

    {
        continuer = false;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("le jeu est terminé");
        Console.ResetColor();
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Choix invalide, Reesayez");
            Console.ResetColor();
        }
    }

*/