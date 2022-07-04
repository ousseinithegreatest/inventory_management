using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace gestion_stock
{
    class Etudiant
    {
        private int id;
        private string prenom;
        private string nom;
        private int age;


        //constructeur sans paramètre
        public Etudiant()
        {

        }
        public Etudiant(int id, string prenom, string nom, int age)
        {
            this.id = id;
            this.prenom = prenom;
            this.nom = nom;
            this.age = age;
        }
        //constructeur avec paramètre
        public Etudiant(string prenom, string nom, int age)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.age = age;
        }



        //Getters et Setters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //methode permetant d'ajouter un etudiants
        public void ajouter(Etudiant e)
        {
            //connection à la base de données
            MySqlConnection conn = new MySqlConnection();
            conn = Myconnection.getConnection();
            //ajout dans la table etudiant
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO etudiants(prenom,nom,age) VALUES(@prenom,@nom,@age)", conn);
                cmd.Parameters.AddWithValue("@prenom", e.Prenom);
                cmd.Parameters.AddWithValue("@nom", e.Nom);
                cmd.Parameters.AddWithValue("@age", e.Age);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.Close();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Erreur d'insertion !!!" + ex);
            }
        }
    }
    
}
