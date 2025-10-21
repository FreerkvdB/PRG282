using PRG282_Project.DataLayer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class MainForm : Form
    {
        private Superhero_repo repo = new Superhero_repo(); // repo instance
        private string originalHeroID; // stores currently selected hero ID

        public MainForm()
        {
            InitializeComponent(); // initialize form components
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            repo.LoadHeroesIntoGrid(dgvHeroes); // load heroes into grid on form load
            UpdateSummary(); //loads summary with form
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            try
            {
                string heroID = txtHeroID.Text; // get input
                string name = txtHeroName.Text;
                string power = txtHeroSuperPower.Text;
                int age = int.Parse(txtHeroAge.Text);
                int score = (int)numHeroExamScore.Value;

                if (string.IsNullOrWhiteSpace(heroID) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(power))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error");
                    return;
                }

                if (age <= 0 || age > 120)
                {
                    MessageBox.Show("Please enter a valid age.", "Input Error");
                    return;
                }

                repo.AddHero(heroID, name, age, power, score); // add hero to file
                repo.LoadHeroesIntoGrid(dgvHeroes); // refresh grid
                ClearInputs(); // clear inputs
                dgvHeroes.ClearSelection(); // deselect grid
                UpdateSummary(); //updates summary
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure Age and Score are numeric.", "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Unexpected Error");
            }
        }

        private void btnDeleteHero_Click(object sender, EventArgs e)
        {
            if (dgvHeroes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a hero to delete.", "No Selection");
                return;
            }

            string heroID = dgvHeroes.SelectedRows[0].Cells["Hero ID"].Value.ToString(); // get selected hero
            var confirm = MessageBox.Show($"Delete hero {heroID}?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                repo.DeleteHero(heroID); // delete hero from file
                repo.LoadHeroesIntoGrid(dgvHeroes); // refresh grid
                ClearInputs(); // clear inputs
                dgvHeroes.ClearSelection(); // deselect grid
            }
            UpdateSummary(); //updates summary
        }

        private void btnEditHero_Click(object sender, EventArgs e)
        {
            if (dgvHeroes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a hero to edit.", "No Selection");
                return;
            }

            try
            {
                string heroID = txtHeroID.Text; // get inputs
                string name = txtHeroName.Text;
                string power = txtHeroSuperPower.Text;
                int age = int.Parse(txtHeroAge.Text);
                int score = (int)numHeroExamScore.Value;

                repo.EditHero(originalHeroID, heroID, name, age, power, score); // update hero
                repo.LoadHeroesIntoGrid(dgvHeroes); // refresh grid
                ClearInputs(); // clear inputs
                dgvHeroes.ClearSelection(); // deselect grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Error");
            }
            UpdateSummary(); //updates summary
        }

        private void dgvHeroes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHeroes.Rows[e.RowIndex]; // get clicked row
                txtHeroID.Text = row.Cells["Hero ID"].Value.ToString();
                txtHeroName.Text = row.Cells["Name"].Value.ToString();
                txtHeroAge.Text = row.Cells["Age"].Value.ToString();
                txtHeroSuperPower.Text = row.Cells["Superpower"].Value.ToString();
                numHeroExamScore.Value = int.Parse(row.Cells["Exam Score"].Value.ToString());
                originalHeroID = row.Cells["Hero ID"].Value.ToString(); // store original ID
            }
        }

        private void ClearInputs()
        {
            txtHeroID.Clear();
            txtHeroName.Clear();
            txtHeroAge.Clear();
            txtHeroSuperPower.Clear();
            numHeroExamScore.Value = 0; 
            originalHeroID = null; 
        }

        private void UpdateSummary()
        {
            var heroes = repo.GetAllHeroes();               // get hero list
            string summary = repo.GenerateSummary(heroes);  // write summary.txt

            lblTotalHeroes.Text = $"Total Heroes: {heroes.Count}";
            lblAvgAge.Text = heroes.Count > 0 ? $"Average Age: {heroes.Average(h => h.SuperheroAge1):F2}" : "Average Age: 0.00";
            lblAvgScore.Text = heroes.Count > 0 ? $"Average Score: {heroes.Average(h => h.ExamScore1):F2}" : "Average Score: 0.00";

            lblSRank.Text = $"S-Rank: {heroes.Count(h => h.Rank1 == "S-Rank")}";
            lblARank.Text = $"A-Rank: {heroes.Count(h => h.Rank1 == "A-Rank")}";
            lblBRank.Text = $"B-Rank: {heroes.Count(h => h.Rank1 == "B-Rank")}";
            lblCRank.Text = $"C-Rank: {heroes.Count(h => h.Rank1 == "C-Rank")}";
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
 * btnDeleteHero
 * 
 * Data Grid View:
 * dgvHeroes
 */


