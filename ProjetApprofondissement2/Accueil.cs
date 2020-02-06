using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RestSharp;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProjetApprofondissement2
{
    public partial class Accueil : Form
    {
        // Connexion à la bd
        MySqlConnection connexion = new MySqlConnection("datasource=localhost;port=3306;username=root;password=#Bambino1234");
        MySqlDataAdapter adapter;
        MySqlCommand cmd;

        // Déclaration des variables
        int id;
        string name;
        string continent;

        // Liste de pages
        List<Panel> pages = new List<Panel>();

        /// <summary>
        /// Constructeur de mon application
        /// </summary>
        public Accueil()
        {
            InitializeComponent();
            panelSideMenu.SendToBack();
            pages.Add(panelCrud);
            pages.Add(panelApi); 
            pages.Add(panelAjouter);
            pages.Add(panelInfos);
            HideAllPanels();
            for (int i = 0; i < pages.Count; i++)
            {
                this.pages[i].Parent = this;
            }
        }

        // ---------------------------------------------------------------------------------------Accueil------------------------------------------------------------------------------------------------
        /// <summary>
        /// Quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Affiche la page de mon CRUD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCrud_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelCrud.Show();
            ClearData();
            DisplayDataCrud();
            labelTitle.Text = "CRUD";

        }

        /// <summary>
        /// Affiche la page de l'API
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCountryApi_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelApi.Show();
            labelTitle.Text = "API";
        }

        /// <summary>
        /// Cache tous les panels
        /// </summary>
        private void HideAllPanels()
        {
            for (int i = 0; i < pages.Count; i++)
            {
                pages[i].Hide();
            }
        }

        // ---------------------------------------------------------------------------------------CRUD------------------------------------------------------------------------------------------------
        /// <summary>
        /// Affiche toutes les données de la table "Utilisateur" dans le datagridView
        /// </summary>
        private void DisplayDataCrud()
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT id,prenom,nom,courriel,note FROM projetapprofondissement2.personnes", connexion);
                connexion.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "personnes");

                dataGridViewListePersonnes.DataSource = ds.Tables["personnes"];
                for (int i = 0; i < dataGridViewListePersonnes.Columns.Count; i++)
                {

                    string str = dataGridViewListePersonnes.Columns[i].HeaderText;
                    switch (str)
                    {
                        case "id":
                            dataGridViewListePersonnes.Columns[i].HeaderText = "Id";
                            break;

                        case "prenom":
                            dataGridViewListePersonnes.Columns[i].HeaderText = "Prénom";
                            break;
                        case "nom":
                            dataGridViewListePersonnes.Columns[i].HeaderText = "Nom";
                            break;
                        case "courriel":
                            dataGridViewListePersonnes.Columns[i].HeaderText = "Courriel";
                            break;
                        default:
                            break;
                    }
                }
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();
            }
        }
       
        /// <summary>
        /// Retire les données des Textbox de la page du CRUD et remet le ID à 0
        /// </summary>
        private void ClearData()
        {
            id = 0;
            textBoxPrenom.Text = "";
            textBoxNom.Text = "";
            textBoxCourriel.Text = "";
        }

   
        /// <summary>
        /// Permet de sélectionner une personne dans le datagridview et d'afficher son nom dans les textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewListeUtilisateurs_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridViewListePersonnes.Rows[e.RowIndex].Cells[0].Value);
                textBoxPrenom.Text = dataGridViewListePersonnes.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxNom.Text = dataGridViewListePersonnes.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxCourriel.Text = dataGridViewListePersonnes.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connexion.Close();
            }

        }
        private void buttonRecharger_Click(object sender, EventArgs e)
        {
            DisplayDataCrud();
        }

        /// <summary>
        /// Supprime l'élément sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                try
                {
                    cmd = new MySqlCommand("projetapprofondissement2.sp_deleteUtilisateur", connexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id", id);
                    connexion.Open();
                    int i = cmd.ExecuteNonQuery();

                    connexion.Close();
                    DisplayDataCrud();
                    ClearData();
                    if (i != 0)
                    {
                        MessageBox.Show("La personne a été supprimée !");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un champ à supprmier !");

            }
        }

        /// <summary>
        /// Recherche une personne selon son adresse courriel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRechercher_Click_1(object sender, EventArgs e)
        {
            try
            {
                adapter = new MySqlDataAdapter();
                string sql = "SELECT id,prenom,nom,courriel FROM projetapprofondissement2.personnes WHERE courriel=@courriel ";
                cmd = new MySqlCommand(sql, connexion);
                cmd.Parameters.AddWithValue("@courriel", textBoxCourriel.Text);
                adapter.SelectCommand = cmd;
                connexion.Open();

                DataTable table = new DataTable();
                adapter.Fill(table);

                BindingSource bSouce = new BindingSource();
                bSouce.DataSource = table;
                connexion.Close();
                if (textBoxCourriel.Text != "" & table.Rows.Count < 1)
                {
                    MessageBox.Show("Aucun utilisateur trouvé !");

                    DisplayDataCrud();
                    ClearData();

                }
                else if (textBoxCourriel.Text == "")
                {
                    MessageBox.Show("Vous devez entrer une adresse courriel pour effectuer une recherche.");
                }
                else
                {
                    dataGridViewListePersonnes.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        
        // ---------------------------------------------------------------------------------------Ajouter------------------------------------------------------------------------------------------------


        /// <summary>
        /// Affiche le formulaire d'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouter_Click_1(object sender, EventArgs e)
        {
            HideAllPanels();
            panelAjouter.Show();
        }

        /// <summary>
        /// Ajoute une personne à la base de données lorsque tous les champs sont remplis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2Ajouter_Click(object sender, EventArgs e)
        {
            if (textBoxAjouterPrenom.Text != "" && textBoxAjouterNom.Text != "" && textBoxAjouterCourriel.Text != "" && richTextBoxAjouterNote.Text != "")
            {
                try
                {
                    cmd = new MySqlCommand("projetapprofondissement2.sp_insertUtilisateur", connexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_prenom", textBoxAjouterPrenom.Text);
                    cmd.Parameters.AddWithValue("@p_nom", textBoxAjouterNom.Text);
                    cmd.Parameters.AddWithValue("@p_courriel", textBoxAjouterCourriel.Text);
                    cmd.Parameters.AddWithValue("@p_note", richTextBoxAjouterNote.Text);

                    connexion.Open();
                    int i = cmd.ExecuteNonQuery();
                    connexion.Close();
                    connexion.Close();
                    if (i != 0)
                    {
                        MessageBox.Show("La personne a été ajoutée !");
                        HideAllPanels();
                        panelCrud.Show();
                        ClearData();
                        DisplayDataCrud();
                        labelTitle.Text = "CRUD";
                    }
                }
                catch (Exception ex)
                {

                    if (ex.Message.Contains("UNIQUE"))
                    {
                        MessageBox.Show("Ce courriel existe déjà !");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Vous devez remplir tous les champs !");
            }
        }
        // ---------------------------------------------------------------------------------------Modifier------------------------------------------------------------------------------------------------
        /// <summary>
        /// Affiche le formulaire de modificaiton et rempli les textBox avec les bonnes informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierPersonne_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    HideAllPanels();
                    panelInfos.Show();
                    adapter = new MySqlDataAdapter();
                    string sql = "SELECT * FROM projetapprofondissement2.personnes WHERE id=@id ";
                    cmd = new MySqlCommand(sql, connexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    adapter.SelectCommand = cmd;
                    connexion.Open();

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    BindingSource bSouce = new BindingSource();
                    bSouce.DataSource = table;
                    connexion.Close();
                    textBoxInfoPrenom.Text = table.Rows[0].Field<string>("prenom");
                    textBoxInfoNom.Text = table.Rows[0].Field<string>("nom");
                    textBoxInfoCourriel.Text = table.Rows[0].Field<string>("courriel");
                    richTextBoxInfoNote.Text = table.Rows[0].Field<string>("note");
                }
                else
                {
                    MessageBox.Show("Vous devez selectionner une personne");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Modifie une personne lorsque les champs sont valides
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxInfoPrenom.Text != "" && textBoxInfoNom.Text != "" && textBoxInfoCourriel.Text != "" && richTextBoxInfoNote.Text != "" && id != 0)
            {
                try
                {
                    cmd = new MySqlCommand("projetapprofondissement2.sp_editUtilisateur", connexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id", id);
                    cmd.Parameters.AddWithValue("@p_prenom", textBoxInfoPrenom.Text);
                    cmd.Parameters.AddWithValue("@p_nom", textBoxInfoNom.Text);
                    cmd.Parameters.AddWithValue("@p_courriel", textBoxInfoCourriel.Text);
                    cmd.Parameters.AddWithValue("@p_note", richTextBoxInfoNote.Text);

                    connexion.Open();
                    int i = cmd.ExecuteNonQuery();

                    connexion.Close();

                    if (i != 0)
                    {
                        MessageBox.Show("La personne a été modifiée !");
                        HideAllPanels();
                        panelCrud.Show();
                        ClearData();
                        DisplayDataCrud();
                        labelTitle.Text = "CRUD";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Vous devez avoir une valeur dans tous les champs !");
            }
        }
        // ---------------------------------------------------------------------------------------API------------------------------------------------------------------------------------------------

        /// <summary>
        /// Recherche les datas dans l'api de pays selon le champ remplis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetAllData_Click(object sender, EventArgs e)
        {
            try
            {
                name = textBoxPays.Text;
                continent = textBoxContinent.Text;

                if (name != "" & continent == "")
                {
                    var client = new RestClient("https://restcountries-v1.p.rapidapi.com/name/" + name);
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("x-rapidapi-host", "restcountries-v1.p.rapidapi.com");
                    request.AddHeader("x-rapidapi-key", "eaf7a733bcmsh0e3f55665a2c298p107d3fjsnc86078c1e33a");
                    IRestResponse response = client.Execute(request);
                    List<Pays> pays = JsonConvert.DeserializeObject<List<Pays>>(response.Content);
                    dataGridViewPays.DataSource = pays;
                }
                else if (name == "" & continent != "")
                {
                    var client = new RestClient("https://restcountries-v1.p.rapidapi.com/region/" + continent);
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("x-rapidapi-host", "restcountries-v1.p.rapidapi.com");
                    request.AddHeader("x-rapidapi-key", "eaf7a733bcmsh0e3f55665a2c298p107d3fjsnc86078c1e33a");
                    IRestResponse response = client.Execute(request);
                    List<Pays> pays = JsonConvert.DeserializeObject<List<Pays>>(response.Content);
                    dataGridViewPays.DataSource = pays;
                }
                else
                {
                    MessageBox.Show("Vous devez entrer de l'information dans l'un des champs ! ");
                }
                for (int i = 0; i < dataGridViewPays.Columns.Count; i++)
                {

                    string str = dataGridViewPays.Columns[i].HeaderText;
                    switch (str)
                    {
                        case "Name":
                            dataGridViewPays.Columns[i].HeaderText = "Nom";
                            break;

                        case "Capital":
                            dataGridViewPays.Columns[i].HeaderText = "Capitale";
                            break;
                        case "Region":
                            dataGridViewPays.Columns[i].HeaderText = "Continent";
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'information que vous avez entrer est invalide");
            }
        }
        // Main source: https://www.c-sharpcorner.com/UploadFile/1e050f/insert-update-and-delete-record-in-datagridview-C-Sharp/

    }
}
