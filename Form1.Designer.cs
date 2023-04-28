using System;
using System.Windows.Forms;

namespace lab6
{
    partial class Form1
    {

        public class DataGridViewCellEventArgs : EventArgs
        {
            private int columnIndex;

            private int rowIndex;

            //
            // Summary:
            //     Gets a value indicating the column index of the cell that the event occurs for.
            //
            // Returns:
            //     The index of the column containing the cell that the event occurs for.
            public int ColumnIndex => columnIndex;

            //
            // Summary:
            //     Gets a value indicating the row index of the cell that the event occurs for.
            //
            // Returns:
            //     The index of the row containing the cell that the event occurs for.
            public int RowIndex => rowIndex;

            internal DataGridViewCellEventArgs(DataGridViewCell dataGridViewCell)
                : this(dataGridViewCell.ColumnIndex, dataGridViewCell.RowIndex)
            {
            }

            //
            // Summary:
            //     Initializes a new instance of the System.Windows.Forms.DataGridViewCellEventArgs
            //     class.
            //
            // Parameters:
            //   columnIndex:
            //     The index of the column containing the cell that the event occurs for.
            //
            //   rowIndex:
            //     The index of the row containing the cell that the event occurs for.
            //
            // Exceptions:
            //   T:System.ArgumentOutOfRangeException:
            //     columnIndex is less than -1. -or- rowIndex is less than -1.
            public DataGridViewCellEventArgs(int columnIndex, int rowIndex)
            {
                if (columnIndex < -1)
                {
                    throw new ArgumentOutOfRangeException("columnIndex");
                }

                if (rowIndex < -1)
                {
                    throw new ArgumentOutOfRangeException("rowIndex");
                }

                this.columnIndex = columnIndex;
                this.rowIndex = rowIndex;
            }
        }
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idfirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numefirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsponsorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inchiriere_MasiniDataSet = new lab6.Inchiriere_MasiniDataSet();
            this.firmaTableAdapter = new lab6.Inchiriere_MasiniDataSetTableAdapters.FirmaTableAdapter();
            this.inchiriere_MasiniDataSet1 = new lab6.Inchiriere_MasiniDataSet1();
            this.masinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masinaTableAdapter = new lab6.Inchiriere_MasiniDataSet1TableAdapters.MasinaTableAdapter();
            this.masinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inchiriere_MasiniDataSet2 = new lab6.Inchiriere_MasiniDataSet2();
            this.masinaTableAdapter1 = new lab6.Inchiriere_MasiniDataSet2TableAdapters.MasinaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.masinaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inchiriere_MasiniDataSet3 = new lab6.Inchiriere_MasiniDataSet3();
            this.idmasinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfirmaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.greutateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarinmatriculareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masinaTableAdapter2 = new lab6.Inchiriere_MasiniDataSet3TableAdapters.MasinaTableAdapter();
            this.textBoxIdFirma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxGreutate = new System.Windows.Forms.TextBox();
            this.textBoxNrMat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriere_MasiniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriere_MasiniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriere_MasiniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriere_MasiniDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(435, 295);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFirmeClicked);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.SelectionChangedFirme);
            // 
            // idfirmaDataGridViewTextBoxColumn
            // 
            this.idfirmaDataGridViewTextBoxColumn.DataPropertyName = "id_firma";
            this.idfirmaDataGridViewTextBoxColumn.HeaderText = "id_firma";
            this.idfirmaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idfirmaDataGridViewTextBoxColumn.Name = "idfirmaDataGridViewTextBoxColumn";
            this.idfirmaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numefirmaDataGridViewTextBoxColumn
            // 
            this.numefirmaDataGridViewTextBoxColumn.DataPropertyName = "nume_firma";
            this.numefirmaDataGridViewTextBoxColumn.HeaderText = "nume_firma";
            this.numefirmaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numefirmaDataGridViewTextBoxColumn.Name = "numefirmaDataGridViewTextBoxColumn";
            this.numefirmaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idsponsorDataGridViewTextBoxColumn
            // 
            this.idsponsorDataGridViewTextBoxColumn.DataPropertyName = "id_sponsor";
            this.idsponsorDataGridViewTextBoxColumn.HeaderText = "id_sponsor";
            this.idsponsorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idsponsorDataGridViewTextBoxColumn.Name = "idsponsorDataGridViewTextBoxColumn";
            this.idsponsorDataGridViewTextBoxColumn.Width = 125;
            // 
            // firmaBindingSource
            // 
            this.firmaBindingSource.DataMember = "Firma";
            this.firmaBindingSource.DataSource = this.inchiriere_MasiniDataSet;
            // 
            // inchiriere_MasiniDataSet
            // 
            this.inchiriere_MasiniDataSet.DataSetName = "Inchiriere_MasiniDataSet";
            this.inchiriere_MasiniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaTableAdapter
            // 
            this.firmaTableAdapter.ClearBeforeFill = true;
            // 
            // inchiriere_MasiniDataSet1
            // 
            this.inchiriere_MasiniDataSet1.DataSetName = "Inchiriere_MasiniDataSet1";
            this.inchiriere_MasiniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masinaBindingSource
            // 
            this.masinaBindingSource.DataMember = "Masina";
            this.masinaBindingSource.DataSource = this.inchiriere_MasiniDataSet1;
            // 
            // masinaTableAdapter
            // 
            this.masinaTableAdapter.ClearBeforeFill = true;
            // 
            // masinaBindingSource1
            // 
            this.masinaBindingSource1.DataMember = "Masina";
            this.masinaBindingSource1.DataSource = this.inchiriere_MasiniDataSet2;
            // 
            // inchiriere_MasiniDataSet2
            // 
            this.inchiriere_MasiniDataSet2.DataSetName = "Inchiriere_MasiniDataSet2";
            this.inchiriere_MasiniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masinaTableAdapter1
            // 
            this.masinaTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "FIRMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(509, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "MASINA";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(181, 426);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(165, 69);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1088, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID. FIRMA";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(513, 31);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(789, 295);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // masinaBindingSource2
            // 
            this.masinaBindingSource2.DataMember = "Masina";
            this.masinaBindingSource2.DataSource = this.inchiriere_MasiniDataSet3;
            // 
            // inchiriere_MasiniDataSet3
            // 
            this.inchiriere_MasiniDataSet3.DataSetName = "Inchiriere_MasiniDataSet3";
            this.inchiriere_MasiniDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idmasinaDataGridViewTextBoxColumn
            // 
            this.idmasinaDataGridViewTextBoxColumn.DataPropertyName = "id_masina";
            this.idmasinaDataGridViewTextBoxColumn.HeaderText = "id_masina";
            this.idmasinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmasinaDataGridViewTextBoxColumn.Name = "idmasinaDataGridViewTextBoxColumn";
            this.idmasinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idfirmaDataGridViewTextBoxColumn1
            // 
            this.idfirmaDataGridViewTextBoxColumn1.DataPropertyName = "id_firma";
            this.idfirmaDataGridViewTextBoxColumn1.HeaderText = "id_firma";
            this.idfirmaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idfirmaDataGridViewTextBoxColumn1.Name = "idfirmaDataGridViewTextBoxColumn1";
            this.idfirmaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // greutateDataGridViewTextBoxColumn
            // 
            this.greutateDataGridViewTextBoxColumn.DataPropertyName = "greutate";
            this.greutateDataGridViewTextBoxColumn.HeaderText = "greutate";
            this.greutateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.greutateDataGridViewTextBoxColumn.Name = "greutateDataGridViewTextBoxColumn";
            this.greutateDataGridViewTextBoxColumn.Width = 125;
            // 
            // numarinmatriculareDataGridViewTextBoxColumn
            // 
            this.numarinmatriculareDataGridViewTextBoxColumn.DataPropertyName = "numar_inmatriculare";
            this.numarinmatriculareDataGridViewTextBoxColumn.HeaderText = "numar_inmatriculare";
            this.numarinmatriculareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numarinmatriculareDataGridViewTextBoxColumn.Name = "numarinmatriculareDataGridViewTextBoxColumn";
            this.numarinmatriculareDataGridViewTextBoxColumn.Width = 125;
            // 
            // masinaTableAdapter2
            // 
            this.masinaTableAdapter2.ClearBeforeFill = true;
            // 
            // textBoxIdFirma
            // 
            this.textBoxIdFirma.Location = new System.Drawing.Point(1189, 422);
            this.textBoxIdFirma.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdFirma.Name = "textBoxIdFirma";
            this.textBoxIdFirma.Size = new System.Drawing.Size(145, 22);
            this.textBoxIdFirma.TabIndex = 7;
            this.textBoxIdFirma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "NUME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "GREUTATE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 479);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "NUMAR INMATRICULARE:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(840, 373);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(145, 22);
            this.textBoxNume.TabIndex = 11;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxGreutate
            // 
            this.textBoxGreutate.Location = new System.Drawing.Point(840, 422);
            this.textBoxGreutate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGreutate.Name = "textBoxGreutate";
            this.textBoxGreutate.Size = new System.Drawing.Size(145, 22);
            this.textBoxGreutate.TabIndex = 12;
            this.textBoxGreutate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxNrMat
            // 
            this.textBoxNrMat.Location = new System.Drawing.Point(840, 475);
            this.textBoxNrMat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNrMat.Name = "textBoxNrMat";
            this.textBoxNrMat.Size = new System.Drawing.Size(145, 22);
            this.textBoxNrMat.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 586);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "ADAUGA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.adaugaBtnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(787, 586);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "STERGE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.stergeBtnClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(997, 586);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.updateBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 629);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxNrMat);
            this.Controls.Add(this.textBoxGreutate);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdFirma);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriere_MasiniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriere_MasiniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriere_MasiniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masinaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inchiriere_MasiniDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DataGridViewFirmeClicked(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Inchiriere_MasiniDataSet inchiriere_MasiniDataSet;
        private System.Windows.Forms.BindingSource firmaBindingSource;
        private Inchiriere_MasiniDataSetTableAdapters.FirmaTableAdapter firmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numefirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsponsorDataGridViewTextBoxColumn;
        private Inchiriere_MasiniDataSet1 inchiriere_MasiniDataSet1;
        private System.Windows.Forms.BindingSource masinaBindingSource;
        private Inchiriere_MasiniDataSet1TableAdapters.MasinaTableAdapter masinaTableAdapter;
        private Inchiriere_MasiniDataSet2 inchiriere_MasiniDataSet2;
        private System.Windows.Forms.BindingSource masinaBindingSource1;
        private Inchiriere_MasiniDataSet2TableAdapters.MasinaTableAdapter masinaTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Inchiriere_MasiniDataSet3 inchiriere_MasiniDataSet3;
        private System.Windows.Forms.BindingSource masinaBindingSource2;
        private Inchiriere_MasiniDataSet3TableAdapters.MasinaTableAdapter masinaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmasinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfirmaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn greutateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarinmatriculareDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxIdFirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxGreutate;
        private System.Windows.Forms.TextBox textBoxNrMat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        public DataGridViewCellEventHandler DataGridViewMasiniClicked { get; private set; }
    }
}

