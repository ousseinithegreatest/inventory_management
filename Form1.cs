﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace gestion_stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Etudiant etu = new Etudiant();
            etu.Prenom = txtPrenom.Text;
            etu.Nom = txtNom.Text;
            etu.Age = int.Parse(txtAge.Text);
            etu.ajouter(etu);
            MessageBox.Show("Etudiant ajouter avec succée");
            txtPrenom.Text = "";
            txtNom.Text = "";
            txtAge.Text = "";
        }
    }
}
