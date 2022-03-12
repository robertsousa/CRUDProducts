namespace CRUDProducts
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvProducts
            // 
            this.DgvProducts.AllowUserToAddRows = false;
            this.DgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.CodeColumn,
            this.DescriptionColumn,
            this.PriceColumn,
            this.QuantityColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvProducts.EnableHeadersVisualStyles = false;
            this.DgvProducts.Location = new System.Drawing.Point(0, 106);
            this.DgvProducts.MultiSelect = false;
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvProducts.RowHeadersVisible = false;
            this.DgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProducts.Size = new System.Drawing.Size(800, 344);
            this.DgvProducts.TabIndex = 0;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "Id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.ReadOnly = true;
            this.IDColumn.Visible = false;
            // 
            // CodeColumn
            // 
            this.CodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CodeColumn.DataPropertyName = "Code";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodeColumn.HeaderText = "Code";
            this.CodeColumn.Name = "CodeColumn";
            this.CodeColumn.ReadOnly = true;
            this.CodeColumn.Width = 70;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionColumn.DataPropertyName = "Description";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DescriptionColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PriceColumn.DataPropertyName = "Price";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.PriceColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 70;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantityColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = null;
            this.QuantityColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 94;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(713, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblSobre);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(754, 0);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(19, 20);
            this.lblSobre.TabIndex = 6;
            this.lblSobre.Text = "?";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(779, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(21, 20);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono ExtraLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "P r o d u c t s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "C R U D ";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreate.Location = new System.Drawing.Point(455, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 35);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRead.Location = new System.Drawing.Point(541, 61);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(80, 35);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(627, 61);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
    }
}

