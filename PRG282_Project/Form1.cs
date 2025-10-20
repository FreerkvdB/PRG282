using PRG282_Project.DataLayer;
using System;
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
            repo.LoadHeroesIntoGrid(dgvHeroes); // load heroes into grid
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


