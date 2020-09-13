using GS_zadanie2.GUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace GS_zadanie2
{
    public partial class BIR1 : Form, IUslugaBIRzewnPubl
    {
        public BIR1()
        {
            InitializeComponent();
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

            UslugaBIRzewnPublClient polaczenie = new UslugaBIRzewnPublClient();
            string sid = polaczenie.Zaloguj("abcde12345abcde12345");

            try
            {
                //Środowisko testowe usługi BIR1.1
                OperationContextScope scope = new OperationContextScope(polaczenie.InnerChannel);

                HttpRequestMessageProperty requestMessageProperty = new HttpRequestMessageProperty();
                requestMessageProperty.Headers.Add("sid", sid);

                OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;

                StringBuilder sb = new StringBuilder();
                foreach (object o in listBoxNIP.SelectedItems)
                {
                    sb.AppendLine(o.ToString());
                }
                string s = sb.ToString();

                ParametryWyszukiwania parametryWyszukiwania = new ParametryWyszukiwania();
                parametryWyszukiwania.Nipy = s;

                DataSet dataSet = new DataSet();
                StringReader sr = new StringReader(polaczenie.DaneSzukajPodmioty(parametryWyszukiwania));

                string przekazanieKomunikatu = polaczenie.GetValue("KomunikatKod");
                int zwracanaWartosc = Convert.ToInt32(przekazanieKomunikatu);

                dataSet.ReadXml(sr);

                PrepareDataGridView1ForData();

                if (zwracanaWartosc == 4)
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Nie znaleziono żadnych podmiotów gospodarczych.";
                }

                else
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
            }
            catch (Exception)
            {
                string error = "Usługa BIR1 niedostępna lub żaden identyfikator NIP nie został dodany do listy wyszukiwania.";
                string caption = "Błąd";
                MessageBox.Show(error, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            polaczenie.Wyloguj(sid);
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
                for (int x = 0; x < listBoxNIP.Items.Count; x++)
                {
                    while (listBoxNIP.GetSelected(x) != true)
                    {
                        listBoxNIP.SetSelected(x, true);
                    }
                    if (listBoxNIP.Items.Count == 15)
                    {
                        buttonAdd.Enabled = false;
                    }
                    else
                    {
                        buttonAdd.Enabled = true;
                    }
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxNIP.Items.Count == 0)
            {
                //do nothing
            }
            else if (listBoxNIP.Items.Count <= 15)
            {
                buttonAdd.Enabled = true;
                listBoxNIP.Items.RemoveAt(listBoxNIP.Items.Count - 1);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxNIP.Items.Clear();
        }

        private void textBoxNIP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxNIP.Text, "[^0-9]"))
            {
                string error = "Identyfikator NIP może zawierać wyłącznie cyfry 0-9.";
                string caption = "Błąd";
                MessageBox.Show(error, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNIP.Text = string.Empty;
            }
        }

        private void textBoxNIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void listBoxNIP_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected then change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.White); //Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(listBoxNIP.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
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
