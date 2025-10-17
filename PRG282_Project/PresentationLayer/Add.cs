using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRG282_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private (string rank, string threat) GetRankAndThreat(int score)
        {
            if (score >= 81)
                return ("S-Rank", "Finals Week");
            else if (score >= 61)
                return ("A-Rank", "Midterm Madness");
            else if (score >= 41)
                return ("B-Rank", "Group Project Gone Wrong");
            else
                return ("C-Rank", "Pop Quiz");
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            try
            {

                string heroID = txtHeroID.Text;
                string name = txtHeroName.Text;
                int age = int.Parse(txtHeroAge.Text);
                string power = txtHeroSuperPower.Text;
                int score = (int)numHeroExamScore.Value;

                if (string.IsNullOrWhiteSpace(heroID) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(power))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error");
                    return;
                }

                if (age <= 0 || age > 120)
                {
                    MessageBox.Show("Please enter a valid age.", "Input Error");
                    return;
                }

                var result = GetRankAndThreat(score);
                string rank = result.rank;
                string threat = result.threat;

                string record = $"{heroID},{name},{age},{power},{score},{rank},{threat}";

                string projectFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
                string dataFolder = Path.Combine(projectFolder, "DataLayer");
                Directory.CreateDirectory(dataFolder);
                string filePath = Path.Combine(dataFolder, "superheroes.txt");
                File.AppendAllText(filePath, record + Environment.NewLine);

                MessageBox.Show("Superhero added successfully!", "Success");
                txtHeroID.Clear();
                txtHeroName.Clear();
                txtHeroAge.Clear();
                txtHeroSuperPower.Clear();
                numHeroExamScore.Value = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure Age and Score are numeric.", "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "File Error");
            }
        }

        private void LoadHeroesIntoGrid()
        {
            try
            {
                string projectFolder = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
                string dataFolder = Path.Combine(projectFolder, "DataLayer");
                string filePath = Path.Combine(dataFolder, "superheroes.txt");

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("No superheroes found.", "Info");
                    dgvHeroes.DataSource = null;
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
                    {
                        dt.Rows.Add(parts);
                    }
                }

                dgvHeroes.DataSource = dt;

                dgvHeroes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading heroes: {ex.Message}", "Error");
            }
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadHeroesIntoGrid();
        }
    }
}

/*
 * Labels:
 * lblHeroID
 * lblHeroName
 * lblHeroAge
 * lblHeroSuperpower
 * lblExamScore
 * 
 * InputFields:
 * txtHeroID
 * txtHeroName
 * txtHeroAge
 * txtHeroSuperPower
 * numHeroExamScore
 * 
 * Buttons:
 * btnAddHero
 * 
 * Data Grid View:
 * dgvHeroes
 */


