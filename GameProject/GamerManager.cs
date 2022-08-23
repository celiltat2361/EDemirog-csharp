using PersonRegistrationSimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    // bIR MANAGER CLASS ICERISINDE BASKA BIR MANAGER CLASS KULLANACAKSAK NEW YAPMAYALIM ONUN YERINE CONSTRUCTOR YAPISI UYGUNDUR
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; // Constructor

        public GamerManager(IUserValidationService userValidationService) // generata constructor ile yapildi bu bir bagimliliktir, ben bir dogrulama
                                                                          //kullanacagim demek istiyoruz. Kimlik dogrulama servisinin kendisi degil
                                                                          //onun soyutudur.
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer added operation is successfuly");
            }
            else
            {
                Console.WriteLine("Registration failed");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer delete operation is successfuly");
            }
            else
            {
                Console.WriteLine("Delete operation failed");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer update operation is successfuly");
        }
    }
}
