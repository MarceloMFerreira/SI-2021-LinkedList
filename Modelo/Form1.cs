using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Modelo
{
    public partial class Form1 : Form
    {
        LinkedList<String> lista = new LinkedList<String>();
       


        public Form1()
        {
            InitializeComponent();
            carregar();
            
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {

        }

        

        void mostra()
        {
            listPessoas.Items.Clear();
            foreach(String s in lista)
            {
                listPessoas.Items.Add(s);
            }

        }
        //---------------
        void limpa()
        {
            txtBeforeAfter.Clear();
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String s;
            s = txtNome.Text;
            lista.AddFirst(s);
            limpa();
            mostra();
        }



        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
            {
                String s;
                s = lista.First();
                lista.RemoveFirst();
                lblProx.Text = s;
                mostra();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }



        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (lista.Count > 0)
            {
               String s;
                s = lista.Last();
                lista.RemoveLast();
                lblProx.Text = s;
                mostra();
            }
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            String s;
            s = txtNome.Text; 
            lista.AddLast(s);
            limpa();
            mostra();
        }

        private void lblProx_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_before_Click(object sender, EventArgs e)
        {
            String s,add;
            s = txtNome.Text;
            add = txtBeforeAfter.Text;
            var ns = lista.Find(add);
            lista.AddBefore(ns, s);
            limpa();
            mostra();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_after_Click(object sender, EventArgs e)
        {
            String s, add;
            s = txtNome.Text;
            add = txtBeforeAfter.Text;
            var ns = lista.Find(add);
            lista.AddAfter(ns, s);
            limpa();
            mostra();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblProx.Text = lista.First();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            lblProx.Text = lista.Last();
        }
        void salvar()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("list.txt", FileMode.Create)))
            {
                writer.Write(lista.Count());
                foreach (String s in lista)
                {
                    writer.Write(s);    
                }
            }


        }

        void carregar()
        {
            if (File.Exists("list.txt"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open("list.txt", FileMode.Open)))
                {
                    int qtd = reader.ReadInt32();
                    for (int i = 0; i < qtd; i++)
                    {
                        String s;
                        s = reader.ReadString();
                        lista.AddLast(s);
                    }// fim for
                }

            }// Fila normal


            mostra();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            salvar();
        }
    }

}
