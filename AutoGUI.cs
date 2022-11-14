using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace autoknyilvan
{
    public partial class AutoGUI : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public AutoGUI()
        {
            InitializeComponent();
        }

        private void AutoGUI_Load(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "autok";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                //-- terv szerint
                connection.Open();
                command = connection.CreateCommand();

            }
            catch (MySqlException ex)
            {
                //-- váratlan hiba!
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!" ,"Program hiba!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);

            }
            finally
            {

                //-- Hiba és terv szerinti esetén is lefut
                connection.Close();

            }
            Autok_lista_update();

        }

        /*
         
            *public void Autok_lista_update()
            *Autók listájának frissítése az adatbázisból!

        */
        private void Autok_lista_update()
        {

            Autok.Items.Clear();
            command.CommandText = "SELECT `id`,`rendszám`,`üzembehelyezve`,`szín` FROM `autók` WHERE 1";
            connection.Open();
            using (MySqlDataReader dr = command.ExecuteReader()) {

                while (dr.Read())
                {

                    AutoAdat uj = new AutoAdat(dr.GetInt32("id"), dr.GetString("rendszám"), dr.GetInt32("üzembehelyezve"), dr.GetString("szín"));
                    Autok.Items.Add(uj);

                }

            }
            connection.Close();
        }

        private void ujautobutton_Click(object sender, EventArgs e)
        {

            //-- Szükséges adatok ellenőrzése
            if (string.IsNullOrEmpty(RendszamText.Text))
            {

                MessageBox.Show("Adjon meg rendszámot!" ,"Hiányzó adat!", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                RendszamText.Focus();
                return;

            }
            if (EvjaratNum.Value > DateTime.Now.Year)
            {

                MessageBox.Show("Érvénytelen évjárat!" , "Érvénytelen adat!" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                EvjaratNum.Value = DateTime.Now.Year;
                EvjaratNum.Focus();
                return;

            }
            if (string.IsNullOrEmpty(SzinText.Text))
            {

                MessageBox.Show("Adjon meg egy színt!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SzinText.Focus();
                return;

            }
            //-- Kiírjuk az adatbázisba -------
            command.CommandText = "INSERT INTO `autók` (`id`, `rendszám`, `üzembehelyezve`, `szín`) VALUES (NULL, @rendszam, @ev, @szin)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@rendszam",RendszamText.Text );
            command.Parameters.AddWithValue("@ev", EvjaratNum.Value.ToString());
            command.Parameters.AddWithValue("@szin", SzinText.Text);
            connection.Open();
            try
            {

                if (command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Sikeresen rögzítve", "Sikeres rögzítés!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    IdText.Text = "";
                    RendszamText.Text = "";
                    EvjaratNum.Value = EvjaratNum.Minimum;
                    SzinText.Text = "";

                }
                else
                {

                    MessageBox.Show("Sikertelen rügzítés!", "Sikertelen rögzítés", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message , "Sikertelen rögzítzés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            connection.Close();
            Autok_lista_update();
            

        }
    }
}
