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
        public void Write(List<Superhero> superheroes)
        {
            string filename = @"superheroes.txt"; //Create a text file to store the data

            FileStream fs = new FileStream(filename, FileMode.Create); //Create a file stream to write to the file

            using (StreamWriter sw = new StreamWriter(fs)) // Create a strem writer to write to the file
            {
                string text;
                foreach (Superhero superhero in superheroes)
                {
                    text = superhero.SuperheroID1 + "," + superhero.SuperheroName1 + "," + superhero.SuperheroAge1 + ","
                           + superhero.SuperPower1 + "," + superhero.ExamScore1 + "," + superhero.Rank1 + "," + superhero.ThreadLevel1;

                    sw.WriteLine(text); // Write the text to the file
                }
            }

            fs.Close(); // Close the file stream
            Console.WriteLine("Data has been added successfully to " + filename);
            Console.ReadLine();
        }

        public List<Superhero> Read(List<Superhero> superheroes)
        {
            string filename = @"superheroes.txt";
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate); //Create a file stream to read from the file

            StreamReader sr = new StreamReader(fs); // Create a strem reader to read from the file
            string text;
            while ((text = sr.ReadLine()) != null)
            {
                string[] strings = text.Split(',');
                Superhero newsuperhero = new Superhero(int.Parse(strings[0]), strings[1], int.Parse(strings[2]),
                                         strings[3], int.Parse(strings[4]), strings[5], strings[6]);
                superheroes.Add(newsuperhero);
            }
            sr.Close(); // Close the stream reader
            fs.Close(); // Close the file stream
            return superheroes;
        }

    }
}
