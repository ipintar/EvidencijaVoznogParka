using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EvidencijaVoznogParka
{
    public partial class Forma : Form
    {
        string id = "0";
        public Forma()
        {
            InitializeComponent();
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            //konekcijski string
            string konekcijskiString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Automobili.mdb";

            //kreiranje konekcije prema bazi podataka
            OleDbConnection konekcija = new OleDbConnection(konekcijskiString);

            try
            {

                //SQL upit
                string sqlUpit = "SELECT * FROM Automobili ORDER BY markaVozila";

                //otvaranje konekcije i slanje sql upita
                OleDbDataAdapter da = new OleDbDataAdapter(sqlUpit, konekcija);

                //kreiranje objekta za prihvat podataka
                DataSet ds = new DataSet();

                //popunjavanje objekta klase DataSet podacima iz baze podataka
                da.Fill(ds);

                //prikazivanje podataka na formi
                this.dgvPodaci.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //ispis pogreške
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //zatvaranje konekcije
                konekcija.Close();
            }
        }

        private void dgvPodaci_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dgvPodaci.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxMarka.Text = dgvPodaci.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxModel.Text = dgvPodaci.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxVrstaMotora.Text = dgvPodaci.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxRegistarskaOznaka.Text = dgvPodaci.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxIstekRegistracije.Text = dgvPodaci.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        //Update Record  
        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            //provjera da li su potrebna polja popunjena
            if (this.textBoxMarka.Text == string.Empty
                || this.textBoxModel.Text == string.Empty
                || this.textBoxVrstaMotora.Text == string.Empty
                || this.textBoxRegistarskaOznaka.Text == string.Empty
                || this.textBoxIstekRegistracije.Text == string.Empty)
            {
                MessageBox.Show("Niste unijeli sve potrebne podatke");
            }
            else
            {
                //konekcijski string
                string konekcijskiString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Automobili.mdb";

                //kreiranje konekcije prema bazi podataka
                OleDbConnection konekcija = new OleDbConnection(konekcijskiString);

                try
                {
                    //parametrizirani SQL upit
                    string sqlUpit = "UPDATE Automobili SET markaVozila=@markaVozila,modelVozila=@modelVozila,vrstaMotora=@vrstaMotora,registarskaOznaka=@registarskaOznaka,registriratnDo=@registriratnDo WHERE id=@id";


                    //kreiranje objekta za slanje SQL upita
                    OleDbCommand naredba = new OleDbCommand(sqlUpit, konekcija);

                    //dodavanje vrijednosti parametrima SQL upita

                    
                    naredba.Parameters.AddWithValue("@markaVozila", this.textBoxMarka.Text);
                    naredba.Parameters.AddWithValue("@modelVozila", this.textBoxModel.Text);
                    naredba.Parameters.AddWithValue("@vrstaMotora", this.textBoxVrstaMotora.Text);
                    naredba.Parameters.AddWithValue("@registarskaOznaka", this.textBoxRegistarskaOznaka.Text);
                    naredba.Parameters.AddWithValue("@registriratnDo", this.textBoxIstekRegistracije.Text);
                    naredba.Parameters.AddWithValue("@id", int.Parse(id));

                    //otvaranje konekcije prema bazi podataka
                    konekcija.Open();

                    //slanje sql upita i dohvaćanje rezultata (broj dodanih zapisa)
                    int uspjesnoDodanoZapisa = naredba.ExecuteNonQuery();

                    if (uspjesnoDodanoZapisa == 1)
                    {
                        MessageBox.Show("Podaci uspješno ažurirani!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Pogreška! Podaci nisu ažurirani!");
                    }


                }
                catch (Exception ex)
                {
                    //ispis poruke u pogrešci
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //zatvaranje konekcije
                    konekcija.Close();
                    this.textBoxMarka.Text = string.Empty;
                    this.textBoxModel.Text = string.Empty;
                    this.textBoxVrstaMotora.Text = string.Empty;
                    this.textBoxRegistarskaOznaka.Text = string.Empty;
                    this.textBoxIstekRegistracije.Text = string.Empty;
                    id = "0";
                }


             
            }
        }

        private void bttnInsert_Click(object sender, EventArgs e)
        {
            //provjera da li su potrebna polja popunjena
            if (this.textBoxMarka.Text == string.Empty 
                || this.textBoxModel.Text == string.Empty 
                || this.textBoxVrstaMotora.Text == string.Empty 
                || this.textBoxRegistarskaOznaka.Text == string.Empty
                || this.textBoxIstekRegistracije.Text == string.Empty)
            {
                MessageBox.Show("Niste unijeli sve potrebne podatke");
            }
            else
            {
                //konekcijski string
                string konekcijskiString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Automobili.mdb";

                //kreiranje konekcije prema bazi podataka
                OleDbConnection konekcija = new OleDbConnection(konekcijskiString);

                try
                {
                    //parametrizirani SQL upit
                    string sqlUpit = "INSERT INTO Automobili(markaVozila, modelVozila, vrstaMotora, registarskaOznaka, registriratnDo) Values (@markaVozila,@modelVozila,@vrstaMotora,@registarskaOznaka,@registriratnDo)";

                    //kreiranje objekta za slanje SQL upita
                    OleDbCommand naredba = new OleDbCommand(sqlUpit, konekcija);

                    //dodavanje vrijednosti parametrima SQL upita

                    naredba.Parameters.AddWithValue("@markaVozila", this.textBoxMarka.Text);
                    naredba.Parameters.AddWithValue("@modelVozila", this.textBoxModel.Text);
                    naredba.Parameters.AddWithValue("@vrstaMotora", this.textBoxVrstaMotora.Text);
                    naredba.Parameters.AddWithValue("@registarskaOznaka", this.textBoxRegistarskaOznaka.Text);
                    naredba.Parameters.AddWithValue("@registriratnDo", this.textBoxIstekRegistracije.Text);

                    //otvaranje konekcije prema bazi podataka
                    konekcija.Open();

                    //slanje sql upita i dohvaćanje rezultata (broj dodanih zapisa)
                    int uspjesnoDodanoZapisa = naredba.ExecuteNonQuery();

                    if(uspjesnoDodanoZapisa == 1)
                    {
                        MessageBox.Show("Podaci uspješno dodani!");
                    }
                    else
                    {
                        MessageBox.Show("Pogreška! Podaci nisu spremljeni!");
                    }


                }
                catch (Exception ex)
                {
                    //ispis poruke u pogrešci
                    MessageBox.Show(ex.Message); 
                }
                finally
                {
                    //zatvaranje konekcije
                    konekcija.Close();
                }
            }
        }

    }
}
