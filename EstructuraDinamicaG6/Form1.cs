using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDinamicaG6
{
    public partial class Form1 : Form
    {
        Stack<int> pila = new Stack<int> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(tbEdad.Text);
            pila.Push(edad);
            Mostrar();
        }

        private void Mostrar()
        {
            string msn = "";
            foreach(int edad in pila)
            {
                msn += " " + edad + " |";
            }
            lblEdades.Text = msn;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                Mostrar();
            }
            else
                MessageBox.Show("Pila vacía");
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                MessageBox.Show($"{pila.Peek()}");
            }
            else MessageBox.Show("Pila Vacía");
        }

        private void ordenar()
        {
            Stack<int> PilaAux = new Stack<int> ();

            while (pila.Count > 0)
            {
                int temp = pila.Pop();

                while (PilaAux.Count > 0 && PilaAux.Peek() > temp)
                {
                    pila.Push(PilaAux.Pop());
                }

                PilaAux.Push(temp);
            }

            pila = PilaAux;

            string msn = "";
            foreach (int edad in pila)
            {
                msn += " " + edad + " |";
            }
            lblEdades2.Text = msn;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenar();
        }
    }
}
