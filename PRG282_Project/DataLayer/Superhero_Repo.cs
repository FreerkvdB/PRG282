using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// We need to reference the Business Logic Layer to use the Superhero class
using PRG282_Project.BusinessLogicLayer;

namespace PRG282_Project.Data_Layer
{
    internal class Superhero_Repo
    {
        private readonly string filepath = "superhero.txt"; // Create a text file to store superhero data

        // We create a list to hold superhero objects
        public List<Superhero> GetAllHeroes()
        {
            try
            {
                var heroes = new List<Superhero>();

                if (!File.Exists(filepath))
                {
                    File.Create(filepath).Close(); // Create the file if it doesn't exist
                }

                // Read all lines from the file and parse them into Superhero objects
                foreach (string line in File.ReadAllLines(filepath))
                {
                    var data = line.Split(','); // Assuming data is comma-separated

                    if (data.Length >= 7) // Ensure there are enough data fields
                    {
                        var hero = new Superhero
                        (
                           int.Parse(data[0]),
                           data[1],
                           int.Parse(data[2]),
                           data[3],
                           int.Parse(data[4]),
                           data[5],
                           data[6]
                        );
                        heroes.Add(hero);
                    }
                }

                return heroes;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return new List<Superhero>();
            }
        }

        //Save all heroes to the file
        public void SaveAllHeroes(List<Superhero> heroes)
        {
            try
            {
                var lines = new List<string>(); // Create a list to hold the lines to write to the file

                foreach (var hero in heroes)
                {
                    lines = heroes.Select(h => $"{h.SuperheroID1}\t {h.SuperheroName1}\t {h.SuperheroAge1}\t {h.SuperPower1}\t {h.ExamScore1}\t {h.Rank1}\t {h.ThreadLevel1}").ToList();
                    File.WriteAllLines(filepath, lines);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }

        // Delete a hero from file
        public void DeleteHero(int superheroID)
        {
            try
            {
                var heroes = GetAllHeroes();
                heroes.RemoveAll(h => h.SuperheroID1 == superheroID);
                SaveAllHeroes(heroes);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the hero: {ex.Message}");
            }
        }
    }
}