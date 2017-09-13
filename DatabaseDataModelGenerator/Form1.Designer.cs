namespace DatabaseDataModelGenerator
{
    partial class Form1
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
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStoredProcedure = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbView = new System.Windows.Forms.CheckedListBox();
            this.cbTable = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntityFrameworkContextName = new System.Windows.Forms.TextBox();
            this.btnLoadDatabaseSchema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(109, 15);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(348, 20);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "Data Source=DESKTOP-AFPM7GO;Initial Catalog=DataModelGeneratorTutorial;Integrated" +
    " Security=True";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // cbStoredProcedure
            // 
            this.cbStoredProcedure.FormattingEnabled = true;
            this.cbStoredProcedure.Location = new System.Drawing.Point(365, 86);
            this.cbStoredProcedure.Name = "cbStoredProcedure";
            this.cbStoredProcedure.Size = new System.Drawing.Size(157, 94);
            this.cbStoredProcedure.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Views";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stored Procedures";
            // 
            // cbView
            // 
            this.cbView.FormattingEnabled = true;
            this.cbView.Location = new System.Drawing.Point(190, 86);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(157, 94);
            this.cbView.TabIndex = 8;
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(15, 86);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(157, 94);
            this.cbTable.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "EntityFrameworkContext Name";
            // 
            // txtEntityFrameworkContextName
            // 
            this.txtEntityFrameworkContextName.Location = new System.Drawing.Point(170, 41);
            this.txtEntityFrameworkContextName.Name = "txtEntityFrameworkContextName";
            this.txtEntityFrameworkContextName.Size = new System.Drawing.Size(352, 20);
            this.txtEntityFrameworkContextName.TabIndex = 10;
            // 
            // btnLoadDatabaseSchema
            // 
            this.btnLoadDatabaseSchema.Location = new System.Drawing.Point(464, 13);
            this.btnLoadDatabaseSchema.Name = "btnLoadDatabaseSchema";
            this.btnLoadDatabaseSchema.Size = new System.Drawing.Size(58, 23);
            this.btnLoadDatabaseSchema.TabIndex = 12;
            this.btnLoadDatabaseSchema.Text = "Load";
            this.btnLoadDatabaseSchema.UseVisualStyleBackColor = true;
            this.btnLoadDatabaseSchema.Click += new System.EventHandler(this.btnLoadDatabaseSchema_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 365);
            this.Controls.Add(this.btnLoadDatabaseSchema);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEntityFrameworkContextName);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.cbView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStoredProcedure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConnectionString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cbStoredProcedure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox cbView;
        private System.Windows.Forms.CheckedListBox cbTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntityFrameworkContextName;
        private System.Windows.Forms.Button btnLoadDatabaseSchema;
    }
}

