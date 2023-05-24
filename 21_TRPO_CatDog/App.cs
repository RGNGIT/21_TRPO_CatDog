using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace _21_TRPO_CatDog
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        void BuildReport(bool dated)
        {
            chartReport.Series.Clear();
            List<string> reasons = new List<string>();
            List<string> distinctReasons = new List<string>();
            foreach (PlainDatabase.Pet pet in PlainDatabase.Pets)
            {
                if (dated)
                {
                    if (dateTimePickerFrom.Value.Ticks <= pet.DateCall!.Value.Ticks && pet.DateCall!.Value.Ticks <= dateTimePickerTo.Value.Ticks)
                    {
                        reasons.Add(pet.ReasonCall!);
                    }
                }
                else
                {
                    reasons.Add(pet.ReasonCall!);
                }
            }
            foreach (string reason in reasons)
            {
                if (!distinctReasons.Contains(reason))
                {
                    distinctReasons.Add(reason);
                }
            }
            chartReport.Series.Add(new Series("Причины")
            {
                ChartType = SeriesChartType.Pie
            });
            int[] ReasonCount = new int[distinctReasons.Count];
            int current = 0;
            foreach (string distinctReason in distinctReasons)
            {
                foreach (string reason in reasons)
                {
                    ReasonCount[current]++;
                }
                current++;
            }
            chartReport.Series["Причины"].Points.DataBindXY(distinctReasons, ReasonCount);
        }

        private void buttonAddPet_Click(object sender, EventArgs e)
        {
            PlainDatabase.Pets.Add(new PlainDatabase.Pet(
                textBoxKlichka.Text,
                dateTimePickerDOB.Text,
                comboBoxKind.Text,
                comboBoxSex.Text,
                comboBoxPoroda.Text,
                textBoxFIOOwner.Text,
                dateTimePickerDateCall.Value,
                textBoxReason.Text
            ));
            UpdateVet();
        }

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            switch (tabControlDir.SelectedIndex)
            {
                case 0:
                    PlainDatabase.AnimalKind.Add(textBoxAnimalKind.Text);
                    break;
                case 1:
                    PlainDatabase.BreedKind.Add(textBoxBreed.Text);
                    break;
            }
            UpdateDir(tabControlDir.SelectedIndex);
        }

        void UpdateCombos()
        {
            comboBoxKind.Items.Clear();
            comboBoxPoroda.Items.Clear();
            foreach (string item in PlainDatabase.AnimalKind)
            {
                comboBoxKind.Items.Add(item);
            }
            foreach (string item in PlainDatabase.BreedKind)
            {
                comboBoxPoroda.Items.Add(item);
            }
        }

        void UpdateDir(int whichTable)
        {
            dataGridViewDir.Rows.Clear();
            switch (whichTable)
            {
                case 0:
                    foreach (string item in PlainDatabase.AnimalKind)
                    {
                        dataGridViewDir.Rows.Add(item);
                    }
                    break;
                case 1:
                    foreach (string item in PlainDatabase.BreedKind)
                    {
                        dataGridViewDir.Rows.Add(item);
                    }
                    break;
            }
        }

        void UpdateVet()
        {
            dataGridViewVet.Rows.Clear();
            foreach (PlainDatabase.Pet pet in PlainDatabase.Pets)
            {
                dataGridViewVet.Rows.Add(pet.Name, pet.DOB, pet.Kind, pet.Sex, pet.Breed, pet.OwnerFIO, pet.DateCall, pet.ReasonCall);
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    UpdateVet();
                    UpdateCombos();
                    break;
                case 1:
                    BuildReport(false);
                    break;
                case 2:
                    UpdateDir(tabControlDir.SelectedIndex);
                    break;
            }
        }

        private void tabControlDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDir(tabControlDir.SelectedIndex);
        }

        private void dataGridViewVet_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                MessageBox.Show(PlainDatabase.Pets[dataGridViewVet.SelectedRows[0].Index].ReasonCall, "Причина обращения");
            }
            catch
            {
                MessageBox.Show("Невозможно получить причину обращения!", "Причина обращения");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewVet.Rows.Count - 1; i++)
            {
                PlainDatabase.Pets[i].Updater(
                dataGridViewVet.Rows[i].Cells[0].Value.ToString()!,
                dataGridViewVet.Rows[i].Cells[1].Value.ToString()!,
                dataGridViewVet.Rows[i].Cells[2].Value.ToString()!,
                dataGridViewVet.Rows[i].Cells[3].Value.ToString()!,
                dataGridViewVet.Rows[i].Cells[4].Value.ToString()!,
                dataGridViewVet.Rows[i].Cells[5].Value.ToString()!,
                DateTime.Parse(dataGridViewVet.Rows[i].Cells[6].Value.ToString()!),
                dataGridViewVet.Rows[i].Cells[7].Value.ToString()!
            );
            }
            UpdateVet();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            PlainDatabase.Pets.RemoveAt(dataGridViewVet.SelectedRows[0].Index);
            UpdateVet();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            BuildReport(true);
        }
    }
}