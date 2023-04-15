using ProjetGestionhotelFinal;

class Program
{

    static void Main(string[] args)
    {
        Hotel hotel = new Hotel();

        while (true)
        {
            // Demander les informations du client 
            Console.WriteLine("Bonjour monsieur ,S'il vous plait entrez votre nom");
            string nom = Console.ReadLine();
            if (nom.ToLower() == "q")
                break;

            Console.WriteLine("Entrez votre prenom s'il vous plait  :");
            string prenom = Console.ReadLine();

            Console.WriteLine("Entrez votre courriel s'il vous plait  ::");
            string courriel = Console.ReadLine();

            Console.WriteLine("Entrez votre numéro du carte de crédit s'il vous plait  ::");
            string carteCredit = Console.ReadLine();

            Console.WriteLine("Entrez votre numéro de la chambre s'il vous plait  : :");
            int numeroChambre = int.Parse(Console.ReadLine());

            // Créer un nouveau client et l'ajouter à la liste de clients de l'hôtel
            Client nouveauClient = new Client(nom, prenom, courriel, carteCredit, numeroChambre);
            hotel.AjouterClient(nouveauClient);

            Console.WriteLine("Merci pour votre Reservation.");
        }

        Console.WriteLine("voila vos information :");
        foreach (Client client in hotel.Clients)
        {
            Console.WriteLine("{0} {1} - Chambre {2}", client.Prenom, client.Nom, client.NumeroChambre);
        }

        Console.ReadLine();
    }
}