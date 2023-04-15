using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestionhotelFinal
{
    internal class Hotel
    {
        
            public ArrayList Clients { get; set; }

            public Hotel()
            {
                Clients = new ArrayList();
            }

            public void AjouterClient(Client client)
            {
                Clients.Add(client);
            }
        

    }
}
