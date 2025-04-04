using RegonAPI.GUS;
using RegonAPI.Interfaces;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegonAPI
{
    public partial class BIR1 : Form
    {
        private readonly IBusinessSearchService _searchService;

        public BIR1(IBusinessSearchService searchService)
        {
            InitializeComponent();
            _searchService = searchService;
            labelErrorMsg.Visible = false;
            labelErrorMsg2.Visible = false;
        }

        private void PrepareDataGridView1ForData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            labelErrorMsg.Visible = false;
            var sb = new StringBuilder();
            foreach (object o in listBoxNIP.SelectedItems)
            {
                sb.AppendLine(o.ToString());
            }
            string nipList = sb.ToString();

            try
            {
                var dataSet = _searchService.SearchEntities(nipList);
                PrepareDataGridView1ForData();

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Nie znaleziono żadnych podmiotów gospodarczych.";
                }
                else
                {
                    ConfigureDataGridView(dataSet);
                }
            }
            catch (Exception)
            {
                ShowErrorMessage("Usługa BIR1 niedostępna lub żaden identyfikator NIP nie został dodany do listy wyszukiwania.");
            }
        }

        private void ConfigureDataGridView(DataSet dataSet)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Regon";
            dataGridView1.Columns[0].HeaderText = "REGON";
            dataGridView1.Columns[0].DataPropertyName = "Regon";

            dataGridView1.Columns[1].HeaderText = "Nip";
            dataGridView1.Columns[1].Name = "NIP";
            dataGridView1.Columns[1].DataPropertyName = "Nip";

            dataGridView1.Columns[2].Name = "Nazwa";
            dataGridView1.Columns[2].HeaderText = "Nazwa";
            dataGridView1.Columns[2].DataPropertyName = "Nazwa";

            dataGridView1.Columns[3].Name = "Ulica";
            dataGridView1.Columns[3].HeaderText = "Ulica";
            dataGridView1.Columns[3].DataPropertyName = "Ulica";

            dataGridView1.Columns[4].Name = "Miejscowosc";
            dataGridView1.Columns[4].HeaderText = "Miejscowość";
            dataGridView1.Columns[4].DataPropertyName = "Miejscowosc";

            dataGridView1.Columns[5].Name = "KodPocztowy";
            dataGridView1.Columns[5].HeaderText = "Kod Pocztowy";
            dataGridView1.Columns[5].DataPropertyName = "KodPocztowy";

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNIP.Text.Length != 10)
            {
                labelErrorMsg2.Visible = true;
                labelErrorMsg2.Text = "Nieprawidłowy numer NIP";
            }
            else
            {
                listBoxNIP.Items.Add(textBoxNIP.Text);
                labelErrorMsg2.Visible = false;
                UpdateListBoxSelection();
            }
        }

        private void UpdateListBoxSelection()
        {
            for (int x = 0; x < listBoxNIP.Items.Count; x++)
            {
                while (!listBoxNIP.GetSelected(x))
                {
                    listBoxNIP.SetSelected(x, true);
                }
                buttonAdd.Enabled = listBoxNIP.Items.Count < 15;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxNIP.Items.Count > 0)
            {
                listBoxNIP.Items.RemoveAt(listBoxNIP.Items.Count - 1);
                buttonAdd.Enabled = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxNIP.Items.Clear();
            buttonAdd.Enabled = true;
        }

        private void textBoxNIP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxNIP.Text, "[^0-9]"))
            {
                ShowErrorMessage("Identyfikator NIP może zawierać wyłącznie cyfry 0-9.");
                textBoxNIP.Text = string.Empty;
            }
        }

        private void textBoxNIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void listBoxNIP_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, e.ForeColor, Color.White);
            }
            e.DrawBackground();
            e.Graphics.DrawString(listBoxNIP.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
        }

        private void ShowErrorMessage(string message)
        {
            string caption = "Błąd";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DanePobierzPelnyRaportResponse DanePobierzPelnyRaport(DanePobierzPelnyRaportRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(DanePobierzPelnyRaportRequest request)
        {
            throw new NotImplementedException();
        }

        public DanePobierzRaportZbiorczyResponse DanePobierzRaportZbiorczy(DanePobierzRaportZbiorczyRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(DanePobierzRaportZbiorczyRequest request)
        {
            throw new NotImplementedException();
        }

        public DaneSzukajPodmiotyResponse DaneSzukajPodmioty(DaneSzukajPodmiotyRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(DaneSzukajPodmiotyRequest request)
        {
            throw new NotImplementedException();
        }

        public GetValueResponse GetValue(GetValueRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<GetValueResponse> GetValueAsync(GetValueRequest request)
        {
            throw new NotImplementedException();
        }

        public WylogujResponse Wyloguj(WylogujRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<WylogujResponse> WylogujAsync(WylogujRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ZalogujResponse> ZalogujAsync(ZalogujRequest request)
        {
            throw new NotImplementedException();
        }

        public ZalogujResponse Zaloguj(ZalogujRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
