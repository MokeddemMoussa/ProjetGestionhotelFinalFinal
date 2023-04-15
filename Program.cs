using ProjetGestionhotelFinal;
class Program
{

    static void Main(string[] args)
    {
        Hotel hotel = new Hotel();

        while (true)
        {
            // Demander les informations du nouveau client de notre hotel 
            Console.WriteLine("Hello sir, Welcome to Hilton Hotel please enter your name.");
            string nom = Console.ReadLine();
            if (nom.ToLower() == "q")
                break;

            Console.WriteLine("Please enter your first name:");
            string prenom = Console.ReadLine();

            Console.WriteLine("Please enter your email address");
            string courriel = Console.ReadLine();

            Console.WriteLine("Please enter your credit card number:\"");
            string carteCredit = Console.ReadLine();

            Console.WriteLine("Please enter your room number");
            int numeroChambre = int.Parse(Console.ReadLine());

            // Créer un nouveau client et l'ajouter à la liste de clients de l'hôtel
            Client nouveauClient = new Client(nom, prenom, courriel, carteCredit, numeroChambre);
            hotel.AjouterClient(nouveauClient);

            // Afficher les informations du nouveau client ajouté
            Console.WriteLine("Nom : {0}, Prénom : {1}, Courriel : {2}, Carte de crédit : {3}, Numéro de chambre : {4}",
                nouveauClient.Nom, nouveauClient.Prenom, nouveauClient.Courriel, nouveauClient.CarteCredit, nouveauClient.NumeroChambre);

            Console.WriteLine("Thank you for your reservation.");
        }

        Console.WriteLine("these are your  informations :");

        // Boucle foreach pour afficher les informations de chaque client
        foreach (Client client in hotel.Clients)
        {
            Console.WriteLine("Nom: {0}Prenom: {1}Courriel: {2}Carte de credit: {3}Numero de chambre: {4}",
                              client.Nom , client.Prenom,  client.Courriel,  client.CarteCredit,  client.NumeroChambre);
        }

        Console.ReadLine();
    }

}