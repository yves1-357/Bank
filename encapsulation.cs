//Cree un conducteur pour conduire la voiture puis ajouter le moteur et des roues à la voiture.


public class voiture
{
    public string demarrer;
    public  string accelerer;
    public string motor;

    public class moteur
    {
        public int puissance;
        public bool estAllumé;

        public moteur(int puissance)
        {
            puissance = puissance;
            estAllumé = false;

        }
        //methodes 
        public void myMethod(int demarrer)
        {
            if (!estAllumé)
            {
                estAllumé = true;
                Console.WriteLine("le moteur demarre");
            }
            else
            {
                
            }
        }
    }
}