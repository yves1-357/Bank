using System;
using System.Collections.Generic;

/*
class Supermarche
{
    // Collection des produits en stock (produit -> quantité)
    Dictionary<string, int> stockProduits = new Dictionary<string, int>()
    {
        { "Pomme", 50 },
        { "Banane", 30 },
        { "Orange", 40 }
    };

    // Liste des produits achetés par un client
    List<string> commandeClient = new List<string>();

    // File d'attente des clients pour le paiement
    Queue<string> fileClients = new Queue<string>();

    // Ensemble pour éviter d'ajouter deux fois le même client à la file
    HashSet<string> clientsEnAttente = new HashSet<string>();

    // Pile pour garder une trace des commandes traitées (annulation possible)
    Stack<List<string>> historiqueCommandes = new Stack<List<string>>();

    // Méthode pour ajouter un produit à la commande du client
    public void AjouterProduit(string produit)
    {
        if (stockProduits.ContainsKey(produit) && stockProduits[produit] > 0)
        {
            commandeClient.Add(produit);
            stockProduits[produit]--;  // Réduire la quantité du produit en stock
            Console.WriteLine($"{produit} ajouté à la commande.");
        }
        else
        {
            Console.WriteLine($"Le produit {produit} n'est pas disponible.");
        }
    }

    // Méthode pour ajouter un client à la file d'attente
    public void AjouterClientAFile(string client)
    {
        if (clientsEnAttente.Add(client))  // Ajouté seulement si le client n'est pas déjà dans la file
        {
            fileClients.Enqueue(client);
            Console.WriteLine($"{client} est ajouté à la file d'attente.");
        }
        else
        {
            Console.WriteLine($"{client} est déjà dans la file.");
        }
    }

    // Méthode pour traiter la commande et passer à la caisse
    public void PasserCommande(string client)
    {
        if (fileClients.Count > 0 && fileClients.Peek() == client)
        {
            Console.WriteLine($"Traitement de la commande pour {client}...");
            historiqueCommandes.Push(new List<string>(commandeClient));  // Enregistrer la commande
            commandeClient.Clear();  // Vider la liste des produits
            fileClients.Dequeue();  // Retirer le client de la file
            clientsEnAttente.Remove(client);  // Retirer des clients en attente
            Console.WriteLine($"Commande terminée pour {client}.");
        }
        else
        {
            Console.WriteLine($"{client} n'est pas le premier dans la file ou il n'y a personne en attente.");
        }
    }

    // Méthode pour annuler la dernière commande
    public void AnnulerDerniereCommande()
    {
        if (historiqueCommandes.Count > 0)
        {
            List<string> derniereCommande = historiqueCommandes.Pop();
            foreach (string produit in derniereCommande)
            {
                stockProduits[produit]++;  // Rendre le produit au stock
            }
            Console.WriteLine("Dernière commande annulée.");
        }
        else
        {
            Console.WriteLine("Aucune commande à annuler.");
        }
    }

    // Afficher le stock des produits
    public void AfficherStock()
    {
        Console.WriteLine("Stock des produits:");
        foreach (var produit in stockProduits)
        {
            Console.WriteLine($"{produit.Key} : {produit.Value} en stock");
        }
    }
}

class Programme
{
    static void Main()
    {
        Supermarche supermarche = new Supermarche();
        
        // Affichage du stock au début
        supermarche.AfficherStock();
        
        // Ajout d'un produit à la commande du client
        supermarche.AjouterProduit("Pomme");
        supermarche.AjouterProduit("Orange");

        // Ajout d'un client à la file
        supermarche.AjouterClientAFile("Alice");

        // Traitement de la commande
        supermarche.PasserCommande("Alice");

        // Annuler la dernière commande (juste pour montrer la fonctionnalité)
        supermarche.AnnulerDerniereCommande();

        // Réafficher le stock après les transactions
        supermarche.AfficherStock();
    }
}


//Ce code montre une application simple où chaque collection joue un rôle particulier pour résoudre un problème.
 //   Le dictionnaire gère le stock des produits.
//    La liste gère la commande du client.
//    La file gère l'ordre des clients en attente de paiement.
//    L'ensemble assure que chaque client est unique dans la file.
 //   La pile gère l'historique des commandes pour annuler si nécessaire.
 //   Chaque collection est utile en fonction de sa capacité à résoudre un besoin spécifique, comme l'accès rapide,
 // la gestion de l'ordre, ou la gestion de l'historique.
 
 */