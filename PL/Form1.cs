using BLL;
using Enteties_Dto;

namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTxt = txtSearch.Text;

                if (Search_word.Checked)
                {
                    SmartSearch search = new SmartSearch();
                    List<LocationDto> results = search.searchWord(searchTxt);
                    dataGridView1.DataSource = results;
                }
                else if (searchPasukToName.Checked)
                {
                    SearchInJsonFile search = new SearchInJsonFile();
                    List<LocationDto2> results = search.searchPasukToName(searchTxt);
                    dataGridView1.DataSource = results;
                }
                else
                {
                    MessageBox.Show("Please select a search option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (BLLException bllEx)
            {
                MessageBox.Show($"BLL Exception: {bllEx.Message}", "BLL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_word_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void searchPasukToName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void titel_Click(object sender, EventArgs e)
        {

        }
    }
}