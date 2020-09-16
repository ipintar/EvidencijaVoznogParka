namespace EvidencijaVoznogParka
{
    partial class Forma
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerDb = new System.Windows.Forms.SplitContainer();
            this.bttnInsert = new System.Windows.Forms.Button();
            this.textBoxIstekRegistracije = new System.Windows.Forms.TextBox();
            this.textBoxRegistarskaOznaka = new System.Windows.Forms.TextBox();
            this.textBoxVrstaMotora = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.automobiliDataSet = new EvidencijaVoznogParka.AutomobiliDataSet();
            this.automobiliDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bttnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDb)).BeginInit();
            this.splitContainerDb.Panel1.SuspendLayout();
            this.splitContainerDb.Panel2.SuspendLayout();
            this.splitContainerDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerDb
            // 
            this.splitContainerDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerDb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDb.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerDb.IsSplitterFixed = true;
            this.splitContainerDb.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDb.Name = "splitContainerDb";
            this.splitContainerDb.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDb.Panel1
            // 
            this.splitContainerDb.Panel1.Controls.Add(this.bttnUpdate);
            this.splitContainerDb.Panel1.Controls.Add(this.bttnInsert);
            this.splitContainerDb.Panel1.Controls.Add(this.textBoxIstekRegistracije);
            this.splitContainerDb.Panel1.Controls.Add(this.textBoxRegistarskaOznaka);
            this.splitContainerDb.Panel1.Controls.Add(this.textBoxVrstaMotora);
            this.splitContainerDb.Panel1.Controls.Add(this.textBoxModel);
            this.splitContainerDb.Panel1.Controls.Add(this.textBoxMarka);
            this.splitContainerDb.Panel1.Controls.Add(this.label6);
            this.splitContainerDb.Panel1.Controls.Add(this.label5);
            this.splitContainerDb.Panel1.Controls.Add(this.label4);
            this.splitContainerDb.Panel1.Controls.Add(this.label3);
            this.splitContainerDb.Panel1.Controls.Add(this.label2);
            this.splitContainerDb.Panel1.Controls.Add(this.label1);
            this.splitContainerDb.Panel1.Controls.Add(this.bttnRefresh);
            // 
            // splitContainerDb.Panel2
            // 
            this.splitContainerDb.Panel2.Controls.Add(this.dgvPodaci);
            this.splitContainerDb.Size = new System.Drawing.Size(664, 688);
            this.splitContainerDb.SplitterDistance = 266;
            this.splitContainerDb.TabIndex = 0;
            // 
            // bttnInsert
            // 
            this.bttnInsert.Location = new System.Drawing.Point(522, 62);
            this.bttnInsert.Name = "bttnInsert";
            this.bttnInsert.Size = new System.Drawing.Size(91, 59);
            this.bttnInsert.TabIndex = 12;
            this.bttnInsert.Text = "Dodaj novi zapis";
            this.bttnInsert.UseVisualStyleBackColor = true;
            this.bttnInsert.Click += new System.EventHandler(this.bttnInsert_Click);
            // 
            // textBoxIstekRegistracije
            // 
            this.textBoxIstekRegistracije.Location = new System.Drawing.Point(336, 210);
            this.textBoxIstekRegistracije.Name = "textBoxIstekRegistracije";
            this.textBoxIstekRegistracije.Size = new System.Drawing.Size(100, 20);
            this.textBoxIstekRegistracije.TabIndex = 11;
            // 
            // textBoxRegistarskaOznaka
            // 
            this.textBoxRegistarskaOznaka.Location = new System.Drawing.Point(336, 170);
            this.textBoxRegistarskaOznaka.Name = "textBoxRegistarskaOznaka";
            this.textBoxRegistarskaOznaka.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistarskaOznaka.TabIndex = 10;
            // 
            // textBoxVrstaMotora
            // 
            this.textBoxVrstaMotora.Location = new System.Drawing.Point(336, 131);
            this.textBoxVrstaMotora.Name = "textBoxVrstaMotora";
            this.textBoxVrstaMotora.Size = new System.Drawing.Size(100, 20);
            this.textBoxVrstaMotora.TabIndex = 9;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(336, 97);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 8;
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(336, 62);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarka.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Datum isteka registracije:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registarska oznaka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vrsta motora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model vozila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka vozila:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unos vozila:";
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.Location = new System.Drawing.Point(48, 99);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(91, 59);
            this.bttnRefresh.TabIndex = 0;
            this.bttnRefresh.Text = "Osvježi (dohvati) podatke";
            this.bttnRefresh.UseVisualStyleBackColor = true;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPodaci.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPodaci.Location = new System.Drawing.Point(0, 3);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.Size = new System.Drawing.Size(662, 413);
            this.dgvPodaci.TabIndex = 0;
            this.dgvPodaci.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPodaci_RowHeaderMouseClick);
            // 
            // automobiliDataSet
            // 
            this.automobiliDataSet.DataSetName = "AutomobiliDataSet";
            this.automobiliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automobiliDataSetBindingSource
            // 
            this.automobiliDataSetBindingSource.DataSource = this.automobiliDataSet;
            this.automobiliDataSetBindingSource.Position = 0;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(522, 164);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(91, 59);
            this.bttnUpdate.TabIndex = 13;
            this.bttnUpdate.Text = "Update zapis";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 688);
            this.Controls.Add(this.splitContainerDb);
            this.Name = "Forma";
            this.Text = "Form1";
            this.splitContainerDb.Panel1.ResumeLayout(false);
            this.splitContainerDb.Panel1.PerformLayout();
            this.splitContainerDb.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDb)).EndInit();
            this.splitContainerDb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerDb;
        private System.Windows.Forms.Button bttnInsert;
        private System.Windows.Forms.TextBox textBoxIstekRegistracije;
        private System.Windows.Forms.TextBox textBoxRegistarskaOznaka;
        private System.Windows.Forms.TextBox textBoxVrstaMotora;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private AutomobiliDataSet automobiliDataSet;
        private System.Windows.Forms.BindingSource automobiliDataSetBindingSource;
        private System.Windows.Forms.Button bttnUpdate;
    }
}