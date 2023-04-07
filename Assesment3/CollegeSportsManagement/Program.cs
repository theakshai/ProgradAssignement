using System;
using Microsoft.Data.SqlClient;
namespace CollegeSportsManagement;
    class Program
    {

        private static readonly string connectionString = "Server=DESKTOP-RC6VO7O;Initial Catalog=College_Sports_Management;Encrypt=False;Integrated Security=True";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to College Sports Management System!");
            Console.WriteLine("1. Add Sports");
            Console.WriteLine("2. Add Scoreboard");
            Console.WriteLine("3. Add Tournament");
            Console.WriteLine("4. Remove Sports");
            Console.WriteLine("5. Edit Scoreboard");
            Console.WriteLine("6. Remove Players");
            Console.WriteLine("7. Remove Tournament");
            Console.WriteLine("Enter your choice (1-7):");


            /*
            Data Base schema can be designed as,
            1. 
            */

            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    AddSports();
                    break;
                case 2:
                    AddScoreboard();
                    break;
                case 3:
                    AddTournament();
                    break;
                case 4:
                    RemoveSport();
                    break;
                case 5:

                    UpdateScoreboard();
                    break;
                case 6:
                    RemovePlayer();
                    break;
                case 7:
                    RemoveTournament();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    


         static void AddSports()
        {
                    Console.WriteLine("Enter the name of the sport:");
                    string SportName = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Sports (SportName) VALUES ('{SportName}')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Sport added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to add sport.");
                    }
                }
            }
        }

         static void AddScoreboard()
        {
                    Console.WriteLine("enter the name of the scoreboard:");
                    string ScoreBoardName = Console.ReadLine();

                    Console.WriteLine("Enter the TeamName");
                    string TeamName = Console.ReadLine();

                    Console.WriteLine("Enter the score");
                    string Score = Console.ReadLine();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Scoreboards (TeamName, ScoreboardName, score) VALUES ('{teamName}, {ScoreBoardName}, {Score}')";

                try{

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Scoreboard added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to add scoreboard.");
                    }
                }
                }catch(Exception e){
                  Console.WriteLine(e.Message);
                }finally{
                  connection.Close();
                }
            }
        }

        static void AddTournament()
        {
                    Console.WriteLine("Enter the Tournament Name: ");
                    string tournamentName = Console.ReadLine();

                    Console.WriteLine("Enter the start date Tournament Name: ");
                    string StartDate = Console.ReadLine();
                    DateTime _StartDate = DateTime.Parse(StartDate);

                    Console.WriteLine("Enter the End date Tournament Name: ");
                    string EndDate = Console.ReadLine();
                    DateTime _EndDate = DateTime.Parse(EndDate);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"INSERT INTO Tournaments (TournamentName,StartDate,EndDate) VALUES ('{tournamentName},{_StartDate},{_EndDate}')";

            try{

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Tournament added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to add Tournament.");
                    }
                }
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
            
            finally{
                connection.Close();
            }
         }
        }

        static void RemoveSport()
        {

                    Console.WriteLine("Enter the Sportsname to be removed");
                    string SportsName = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM Sports WHERE Name = {SportsName}";

            try{
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"{SportsName} removed successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to remove the  sport.");
                    }
                }
            }
            catch(Exception e){
            Console.WriteLine(e.Message);
            }
            finally{
            connection.Close();
            }
        }
        }
        static void UpdateScoreboard()
        {

                    Console.WriteLine("Enter the ScoreBoard name to be updated");
                    string ScoreBoardName = Console.ReadLine();

                    Console.WriteLine("Enter the TeamName to update the scores ");
                    string TeamName = Console.ReadLine();

                    Console.WriteLine("Enter the score to be updated");
                    string Score = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Scoreboards SET Score = {Score} WHERE Name = {ScoreBoardName} AND TeamName = {TeamName}";

            try{
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Updated ScoreBoard Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Fail to update the scoreboard");
                    }
                }
            }
            catch(Exception e){
            Console.WriteLine(e.Message);
            }
            finally{
            connection.Close();
            }
        }
        }

       static void RemovePlayer()
        {

                    Console.WriteLine("Enter the player id to be removed:");
                    int PlayerId = Convert.ToInt32(Console.ReadLine());

              using (SqlConnection connection = new SqlConnection(connectionString))
              {
                connection.Open();
                
                string query = $"DELETE FROM Players WHERE PlayerId = {PlayerId}";
              try{
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Removed the player Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Fail to remove the player");
                    }
                }
            }
            catch(Exception e){
            Console.WriteLine(e.Message);
            }
            finally{
            connection.Close();
            }
        }
        }

         static void RemoveTournament()
        {
                    Console.WriteLine("Enter the Tournament id to be removed:");
                    int TournamentId = Convert.ToInt32(Console.ReadLine());


             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                connection.Open();
                
                string query = $"DELETE FROM Tournaments WHERE TournamentId = {TournamentId}";
             try{
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Removed the Tournament  Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Fail to remove the tournament");
                    }
                }
            }
            catch(Exception e){
            Console.WriteLine(e.Message);
            }
            
            finally{
            connection.Close();
            }
        }
        }
        }
        


