using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while(!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\brynn\logs\log.txt", true)
                {
                    file.WriteLine(player.Id);
                }

                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                try

                {
                    game.Play();
                }
                catch(FraudException ex)
                {
                    Console.WriteLine(ex.Message);
                    UpdateDbWithException(ex);
                    Console.ReadLine();
                    return;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("An error occured. Please contact your System Administrator");
                    UpdateDbWithException(ex)
                    Console.ReadLine();
                    return;
                }
                
                game -= player;
                Console.WriteLine("Thank you for palying!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();


        }
  
        private static void UpdateDbwithException (Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13'Initial Catalog=TwentyONeGame;Integrated Security=True;COnnect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=True;AppliactionIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
               
        }




    }

}