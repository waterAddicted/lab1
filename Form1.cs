using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab6
{
    public partial class Form1 : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Inchiriere_Masini;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();

        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();

        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void getById(int id_firma)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM Masina where id_firma= @id", cs);
            da.SelectCommand.Parameters.AddWithValue("@id", id_firma);
            ds2.Clear();

            da.Fill(ds2);
        
            dataGridView2.DataSource = ds2.Tables[0];
        }
        private void SelectionChangedFirme(object sender, EventArgs e)
        {
          
            if (dataGridView1.SelectedRows.Count != 1) return;
            int idFirma = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            textBoxIdFirma.Text = idFirma.ToString();
            getById(idFirma);
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM Firma", cs);
            ds.Clear();
            da.Fill(ds);

    
            dataGridView1.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];
        }

        private void adaugaBtnClick(object sender, EventArgs e)
        {
            try
            {
                cs.Open();
                
                da.InsertCommand = new SqlCommand("Insert into Masina(id_firma,nume,greutate,numar_inmatriculare)" +
                "values(@Id_Firma,@Nume,@Greutate,@Numar_Inmatriculare)", cs);

                da.InsertCommand.Parameters.AddWithValue("@Id_Firma", textBoxIdFirma.Text);
                da.InsertCommand.Parameters.AddWithValue("@Nume", textBoxNume.Text);
                da.InsertCommand.Parameters.AddWithValue("@Greutate", textBoxGreutate.Text);
                da.InsertCommand.Parameters.AddWithValue("@Numar_Inmatriculare",textBoxNrMat.Text);

                da.InsertCommand.ExecuteNonQuery();
                getById(Int32.Parse(textBoxIdFirma.Text));  //refresh
                MessageBox.Show("MASINA ADAUGATA CU SUCCES!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cs.Close();
                textBoxIdFirma.Clear();
                textBoxNume.Clear();
                textBoxGreutate.Clear();
                textBoxNrMat.Clear();
            }
        }
        private void stergeBtnClick(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1) return;
            try
            {
                cs.Open();
                da.DeleteCommand = new SqlCommand("Delete from Masina where id_masina = @IdMasina", cs);

                if (dataGridView2.SelectedRows.Count != 1) return;
                int idMasina = Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                da.DeleteCommand.Parameters.AddWithValue("@IdMasina", idMasina);

                da.DeleteCommand.ExecuteNonQuery();


                getById(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));  //refresh
                MessageBox.Show("MASINA STEARSA CU SUCCES!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cs.Close();
            }
        }

        private void updateBtnClick(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 1) return;

            try
            {
                cs.Open();
                da.UpdateCommand = new SqlCommand("Update Masina set id_firma=@Id_Firma, nume=@Nume," +
                "greutate=@Greutate, numar_inmatriculare=@Numar_Inmatriculare where id_masina=@IdMasina", cs);
                da.UpdateCommand.Parameters.AddWithValue("@Nume", textBoxNume.Text);
                da.UpdateCommand.Parameters.AddWithValue("@Id_Firma", textBoxIdFirma.Text);
                da.UpdateCommand.Parameters.AddWithValue("@Greutate", textBoxGreutate.Text);
                da.UpdateCommand.Parameters.AddWithValue("@Numar_Inmatriculare", textBoxNrMat.Text);

                int idMasina = Int32.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                da.UpdateCommand.Parameters.AddWithValue("@IdMasina", idMasina);

                da.UpdateCommand.ExecuteNonQuery();
                getById(Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));  //refresh
                MessageBox.Show("UPDATE MASINA EFECTUAT CU SUCCES!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cs.Close();
                textBoxIdFirma.Clear();
                textBoxNume.Clear();
                textBoxGreutate.Clear();
                textBoxNrMat.Clear();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
    }
}
