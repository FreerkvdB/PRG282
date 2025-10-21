using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PRG282_Project.BusinessLogicLayer;

namespace PRG282_Project.DataLayer
{
    public class Superhero_repo
    {
        private readonly string filePath;

        public Superhero_repo()
        {
            // Set file path
            string projectFolder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            string dataFolder = Path.Combine(projectFolder, "DataLayer");
            Directory.CreateDirectory(dataFolder);
            filePath = Path.Combine(dataFolder, "superheroes.txt");

            if (!File.Exists(filePath))
                File.Create(filePath).Close(); // Create file if missing
        }

        private (string rank, string threat) GetRankAndThreat(int score)
        {
            // Determine rank and threat based on score
            if (score >= 81) return ("S-Rank", "Finals Week");
            if (score >= 61) return ("A-Rank", "Midterm Madness");
            if (score >= 41) return ("B-Rank", "Group Project Gone Wrong");
            return ("C-Rank", "Pop Quiz");
        }

        public bool IsDuplicateHeroID(string heroID, string ignoreHeroID = null)
        {
            // Check for duplicate Hero ID
            if (!File.Exists(filePath)) return false;
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 7 && parts[0] == heroID && parts[0] != ignoreHeroID)
                    return true;
            }
            return false;
        }

        public void AddHero(string heroID, string name, int age, string power, int score)
        {
            // Prevent duplicate ID
            if (IsDuplicateHeroID(heroID))
                throw new Exception("Hero ID already exists.");

            var result = GetRankAndThreat(score);
            string record = $"{heroID},{name},{age},{power},{score},{result.rank},{result.threat}";
            File.AppendAllText(filePath, record + Environment.NewLine); // Save new hero
        }

        public void LoadHeroesIntoGrid(DataGridView dgv)
        {
            if (!File.Exists(filePath))
            {
                dgv.DataSource = null;
                return;
            }

            var lines = File.ReadAllLines(filePath);
            DataTable dt = new DataTable();
            dt.Columns.Add("Hero ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Superpower");
            dt.Columns.Add("Exam Score");
            dt.Columns.Add("Rank");
            dt.Columns.Add("Threat Level");

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 7)
                    dt.Rows.Add(parts);
            }

            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Sort by Hero ID ascending
            dgv.Sort(dgv.Columns["Hero ID"], System.ComponentModel.ListSortDirection.Ascending);
        }

        public void DeleteHero(string heroID)
        {
            // Delete hero by ID
            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            var newLines = new List<string>();

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 7 && parts[0] != heroID)
                    newLines.Add(line);
            }

            File.WriteAllLines(filePath, newLines);
        }

        public void EditHero(string originalHeroID, string newHeroID, string name, int age, string power, int score)
        {
            // Prevent duplicate ID on edit
            if (IsDuplicateHeroID(newHeroID, originalHeroID))
                throw new Exception("Hero ID already exists.");

            if (!File.Exists(filePath)) return;

            var lines = File.ReadAllLines(filePath);
            var updated = new List<string>();
            var result = GetRankAndThreat(score);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 7 && parts[0] == originalHeroID)
                    updated.Add($"{newHeroID},{name},{age},{power},{score},{result.rank},{result.threat}"); // Update hero
                else
                    updated.Add(line);
            }

            File.WriteAllLines(filePath, updated); // Save changes
        }

        public string GenerateSummary(List<Superhero> heroes)
        {
            int total = heroes.Count;
            double avgAge = heroes.Count > 0 ? heroes.Average(h => h.SuperheroAge1) : 0;
            double avgScore = heroes.Count > 0 ? heroes.Average(h => h.ExamScore1) : 0;

            int sCount = heroes.Count(h => h.Rank1 == "S-Rank");
            int aCount = heroes.Count(h => h.Rank1 == "A-Rank");
            int bCount = heroes.Count(h => h.Rank1 == "B-Rank");
            int cCount = heroes.Count(h => h.Rank1 == "C-Rank");

            string summary =
                $"Total Heroes: {total}\n" +
                $"Average Age: {avgAge:F2}\n" +
                $"Average Score: {avgScore:F2}\n" +
                $"S-Rank: {sCount}\n" +
                $"A-Rank: {aCount}\n" +
                $"B-Rank: {bCount}\n" +
                $"C-Rank: {cCount}\n";

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "summary.txt");
            File.WriteAllText(filePath, summary);

            return summary;
        }

        public List<Superhero> GetAllHeroes()
        {
            var heroes = new List<Superhero>();

            if (!File.Exists(filePath))
                return heroes;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(',');
                if (parts.Length == 7)
                {
                    //parts: 0=ID, 1=Name, 2=Age, 3=Power, 4=Score, 5=Rank, 6=Threat Level
                    if (int.TryParse(parts[0], out int id) && int.TryParse(parts[2], out int age) && int.TryParse(parts[4], out int score))
                    {
                        heroes.Add(new Superhero(
                            id,               // SuperheroID1
                            parts[1],         // SuperheroName1
                            age,              // SuperheroAge1
                            parts[3],         // SuperPower1
                            score,            // ExamScore1
                            parts[5],         // Rank1
                            parts[6]          // ThreadLevel1
                        ));
                    }
                }
            }

            return heroes;
        }
    }
}
