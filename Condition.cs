/*
Console.WriteLine("Entrez un nombre ");
string input = Console.ReadLine();
int nombreUtilisateur;
bool conversion = int.TryParse(input, out nombreUtilisateur );
if (nombreUtilisateur % 2 == 0)
{
    Console.WriteLine(" Le nombre entrée est pair " + nombreUtilisateur);
}else if (nombreUtilisateur % 2 == 1)
{
    Console.WriteLine("Le nombre entrée est impair " + nombreUtilisateur);
}
*/

                 //Deuxeime Methode 

/*
Console.WriteLine("Veuillez entrer un nombre entier :");
      
string input = Console.ReadLine();
      
if (int.TryParse(input, out int number))
{ 
    if (number % 2 == 0)
    {
        Console.WriteLine("Le nombre est pair.");
    }
    else
    {
        Console.WriteLine("Le nombre est impair.");
    }
}
else
{    
    Console.WriteLine("Erreur : Veuillez entrer un nombre entier valide.");
}

*/




                    // Troisieme Method( Prof ) 
/*
Console.Writeline ("Entrez un nombre");
Console.Writeline(
    int.Tryparse(Console.Readline(), out int n)
        ? n % 2 == 0
            ? "Le nombre est pair"
            : "Le nombre est impair"
        : "Nombre invalide");
*/


//************************Exo2***********************************
/*
Console.WriteLine("Entrez le premier nombre ");
string input = Console.ReadLine();
int nombreEntier;
bool conversion = int.TryParse(input, out nombreEntier);
Console.WriteLine("Entrez le deuxieme nombre ");
deuxieme = Console.ReadLine();
int nombreEntie;
bool conversionn = int.TryParse(input, out nombreEntier);
Console.WriteLine("Entrez un operateur(+,-,*,/)");
string operateur = Console.ReadLine();
int operateurInt = int.Parse(operateur);
switch (Char.TryParse(operateur, out nombreEntie)
{
    case + =
        Console.WriteLine("additionner");
        break;
    case - 
        Console.WriteLine("Soustraire");
        break;
    case *
        Console.WriteLine("multiplication");
        break;
    case /:
        Console.WriteLine("division");
        break;
        default;
        Console.WriteLine("Inconnu");
        break;
}
*/

       