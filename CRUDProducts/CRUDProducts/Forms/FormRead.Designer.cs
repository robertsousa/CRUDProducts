namespace CRUDProducts.Forms
{
    partial class FormRead
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCode.Location = new System.Drawing.Point(115, 60);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(36, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDescription.Location = new System.Drawing.Point(115, 86);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrice.Location = new System.Drawing.Point(115, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(36, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quantity";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblQuantity.Location = new System.Drawing.Point(115, 138);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(392, 155);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 190);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRead";
            this.Text = "Form Read";
            this.Load += new System.EventHandler(this.FormRead_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnClose;
    }
}