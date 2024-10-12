/*class monLivre
{
    public string Titre;
    public string Auteur;
    public int NombreDePages;

}

public partial class Program
{
    static void Main()
    {
        monLivre livre = new monLivre();
        livre.Titre = "C";
        livre.Auteur = "Cassa";
        livre.NombreDePages = 3;

// Afficher le contenu des champs de cet objet
        Console.WriteLine("Le titre du livre est " + livre.Titre);
        Console.WriteLine("Son auteur est " + livre.Auteur);
        Console.WriteLine("Il compte " + livre.NombreDePages + " pages ");
    }
}
*/

// Définir une des classes suivantes avec un constructeur, des attributs et des méthodes puis l'instancier et appeler ses méthodes :
// 1. Personne : modélise une personne avec des méthodes pour se présenter et modifier ses informations.
// 2. Animal : Décrit un animal avec des actions comme manger, dormir et se déplacer.
// 3. Livre : Représente un livre avec des méthodes pour afficher des infos et naviguer entre les pages.
//(Choisir un des trois).


/*
class Animal

{

    public string name;
    public int age;
    public string especes;
    public string color;

    public Animal(string animalName, string animalAge, string animalEspeces, string animalColor)
    {
        name = animalName;
        age = int.Parse(animalAge);
        especes = animalEspeces;
        color = animalColor;
    }

    static void Main(string[] args)
    {
        Animal tiger = new Animal("tiger", "25", "bali ", "red");
    }
    
}
*/

public class Moteur
{
    // Attributs
    public int Puissance { get; private set; } // Puissance du moteur en chevaux
    public bool EstAllume { get; private set; } // État du moteur (allumé ou éteint)

    // Constructeur
    public Moteur(int puissance)
    {
        Puissance = puissance;
        EstAllume = false; // Le moteur est éteint par défaut
    }

    // Méthodes
    public void Demarrer()
    {
        if (!EstAllume)
        {
            EstAllume = true;
            Console.WriteLine("Le moteur démarre.");
        }
        else
        {
            Console.WriteLine("Le moteur est déjà allumé.");
        }
    }

    public void Arreter()
    {
        if (EstAllume)
        {
            EstAllume = false;
            Console.WriteLine("Le moteur s'arrête.");
        }
        else
        {
            Console.WriteLine("Le moteur est déjà éteint.");
        }
    }
}
