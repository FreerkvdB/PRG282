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
        private readonly string filepath = "superhero_repo.txt"; // Create a text file to store superhero data

        // We create a list to hold superhero objects
        public List<Superhero> GetAllHeroes()
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
    }
}