using System;

namespace Mall.Client
{
    public class Client
    {
        private static Client instance;
        public  double Money { get; set; }
        

            private Client()
            {
                Money = 50000.0;
            }

            public static Client GetInstance()
            {
                if (instance == null)
                {
                    instance = new Client();
                }
                return instance;
            }

            public void DeductMoney(double payed)
            {
                if (Money >= payed)
                {
                    Money -=  payed;

                }
                else
                {
                    Console.WriteLine("Vous n'avez pas assez d'argent");
                }
                
                Console.WriteLine("Votre argent disponible : " + GetInstance().Money);
            }
    }
}