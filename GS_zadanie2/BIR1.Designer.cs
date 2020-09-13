namespace GS_zadanie2
{
    partial class BIR1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BIR1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxNIP = new System.Windows.Forms.TextBox();
            this.label1NIP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBoxNIP = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelErrorMsg = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelMenuBackground = new System.Windows.Forms.Panel();
            this.label2InfoAutor = new System.Windows.Forms.Label();
            this.labelErrorMsg2 = new System.Windows.Forms.Label();
            this.label1Info = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenuBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(12, 307);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(129, 37);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonSearch, "Szukaj");
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxNIP
            // 
            this.textBoxNIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNIP.Location = new System.Drawing.Point(12, 28);
            this.textBoxNIP.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.textBoxNIP.MaxLength = 10;
            this.textBoxNIP.Name = "textBoxNIP";
            this.textBoxNIP.Size = new System.Drawing.Size(129, 23);
            this.textBoxNIP.TabIndex = 1;
            this.textBoxNIP.TextChanged += new System.EventHandler(this.textBoxNIP_TextChanged);
            this.textBoxNIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNIP_KeyPress);
            // 
            // label1NIP
            // 
            this.label1NIP.AutoSize = true;
            this.label1NIP.Location = new System.Drawing.Point(12, 12);
            this.label1NIP.Name = "label1NIP";
            this.label1NIP.Size = new System.Drawing.Size(28, 13);
            this.label1NIP.TabIndex = 3;
            this.label1NIP.Text = "NIP:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 64);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(741, 407);
            this.dataGridView1.TabIndex = 7;
            // 
            // listBoxNIP
            // 
            this.listBoxNIP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxNIP.Enabled = false;
            this.listBoxNIP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxNIP.FormattingEnabled = true;
            this.listBoxNIP.Location = new System.Drawing.Point(12, 73);
            this.listBoxNIP.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.listBoxNIP.Name = "listBoxNIP";
            this.listBoxNIP.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxNIP.Size = new System.Drawing.Size(84, 212);
            this.listBoxNIP.TabIndex = 6;
            this.listBoxNIP.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxNIP_DrawItem);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(102, 73);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(39, 37);
            this.buttonAdd.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonAdd, "Dodaj");
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelErrorMsg
            // 
            this.labelErrorMsg.AutoSize = true;
            this.labelErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMsg.Location = new System.Drawing.Point(185, 474);
            this.labelErrorMsg.Name = "labelErrorMsg";
            this.labelErrorMsg.Size = new System.Drawing.Size(75, 13);
            this.labelErrorMsg.TabIndex = 9;
            this.labelErrorMsg.Text = "ErrorMsgLabel";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.Location = new System.Drawing.Point(102, 116);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(39, 37);
            this.buttonRemove.TabIndex = 3;
            this.toolTip.SetToolTip(this.buttonRemove, "Usuń");
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonClear.Image")));
            this.buttonClear.Location = new System.Drawing.Point(102, 248);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(39, 37);
            this.buttonClear.TabIndex = 4;
            this.toolTip.SetToolTip(this.buttonClear, "Wyczyść");
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelMenuBackground
            // 
            this.panelMenuBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.panelMenuBackground.Controls.Add(this.label2InfoAutor);
            this.panelMenuBackground.Controls.Add(this.labelErrorMsg2);
            this.panelMenuBackground.Controls.Add(this.buttonSearch);
            this.panelMenuBackground.Controls.Add(this.buttonClear);
            this.panelMenuBackground.Controls.Add(this.buttonAdd);
            this.panelMenuBackground.Controls.Add(this.textBoxNIP);
            this.panelMenuBackground.Controls.Add(this.label1NIP);
            this.panelMenuBackground.Controls.Add(this.buttonRemove);
            this.panelMenuBackground.Controls.Add(this.listBoxNIP);
            this.panelMenuBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuBackground.Location = new System.Drawing.Point(0, 0);
            this.panelMenuBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenuBackground.Name = "panelMenuBackground";
            this.panelMenuBackground.Size = new System.Drawing.Size(155, 503);
            this.panelMenuBackground.TabIndex = 10;
            // 
            // label2InfoAutor
            // 
            this.label2InfoAutor.AutoSize = true;
            this.label2InfoAutor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2InfoAutor.Location = new System.Drawing.Point(12, 448);
            this.label2InfoAutor.Name = "label2InfoAutor";
            this.label2InfoAutor.Size = new System.Drawing.Size(134, 39);
            this.label2InfoAutor.TabIndex = 10;
            this.label2InfoAutor.Text = "C# .NET Framework 4.8\r\nAutor: Tuszyński Rafał\r\ntuszynski.rafal@gmail.com";
            this.label2InfoAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelErrorMsg2
            // 
            this.labelErrorMsg2.AutoSize = true;
            this.labelErrorMsg2.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMsg2.Location = new System.Drawing.Point(12, 54);
            this.labelErrorMsg2.Name = "labelErrorMsg2";
            this.labelErrorMsg2.Size = new System.Drawing.Size(75, 13);
            this.labelErrorMsg2.TabIndex = 11;
            this.labelErrorMsg2.Text = "ErrorMsgLabel";
            // 
            // label1Info
            // 
            this.label1Info.AutoSize = true;
            this.label1Info.Location = new System.Drawing.Point(185, 12);
            this.label1Info.Name = "label1Info";
            this.label1Info.Size = new System.Drawing.Size(670, 39);
            this.label1Info.TabIndex = 8;
            this.label1Info.Text = resources.GetString("label1Info.Text");
            // 
            // BIR1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(963, 503);
            this.Controls.Add(this.label1Info);
            this.Controls.Add(this.panelMenuBackground);
            this.Controls.Add(this.labelErrorMsg);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BIR1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usługa BIR1 zadanie C#.2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenuBackground.ResumeLayout(false);
            this.panelMenuBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxNIP;
        private System.Windows.Forms.Label label1NIP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxNIP;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelErrorMsg;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelMenuBackground;
        private System.Windows.Forms.Label label1Info;
        private System.Windows.Forms.Label label2InfoAutor;
        private System.Windows.Forms.Label labelErrorMsg2;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

