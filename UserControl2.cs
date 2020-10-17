using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenComponentes.Logica;

namespace ExamenComponentes
{
    public partial class UserControl2 : UserControl
    {
        logica lg = new logica(); 

        string codeUser;
        private int counter;
        public string code; //EN LA OTRA CLASE
        private const string chars = "ARBNVM";
        private int attempts=9;
        private string hints;
        private int numero = 8;
        

        public UserControl2()
        {
            InitializeComponent();

            counter = 1;

            this.label2.Text = counter.ToString();
            this.label4.Text = ""; //ACIERTOS TOTALES
            this.label3.Text = "";
            this.label10.Text = numero.ToString();

            var initial = new char[4];
            var random = new Random(); 

            for(int i = 0; i < initial.Length; i++)
            {
                initial[i] = chars[random.Next(chars.Length)]; 
            }

             code = new String(initial); 
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

         
            //CODIGO GENERADO: ####
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
            //EL USUARIO INGRESA SU INTENTO 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //CANTIDAD DE INTENTOS 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;

            this.label2.Text = counter.ToString();
            int restante = attempts - counter;
            //MUESTRA EL RESTANTE
            this.label10.Text = restante.ToString();

            if (counter == attempts)
            {
                MessageBox.Show("La secuencia era: " + code);
                textBox1.Enabled = false;
                button1.Enabled = false; //SINO READ ONLY
            }

            codeUser = textBox1.Text; //CODIGO DE USUARIO 

            if (codeUser.Equals(""))
            {
                MessageBox.Show("Ingrese una secuencia porfavor");
            }

            //VERIFICAR
            hints = lg.validar(code, codeUser);

            if (hints.Equals(""))
            {
                MessageBox.Show("Ha ganado el juego, felicidades");
                textBox1.Enabled = false;
                button1.Enabled = false;
            }
            else {
                string[] numeros = hints.Split(',');

                this.label4.Text = numeros[0]; //ACIERTOS TOTALES
                this.label3.Text = numeros[1];//ACIERTOS PARCIALES
                                              //VERIFICA SI GANO O SI NO SE CONECTA CON LA LOGICA 
            }




        }

        private void label3_Click(object sender, EventArgs e)
        {
            //ACIERTOS PARCIALES 
        }

        public void label4_Click(object sender, EventArgs e)
        {
            //ACIERTOS TOTALES
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //VOLVER AL INICIO
            //CAMBIAR DE FORM 
            UserControl1 userUno = new UserControl1();

            showControl(userUno);

        }

        private void showControl(UserControl us)
        {
            this.Controls.Clear();
            us.Dock = DockStyle.Fill;
            us.BringToFront();
            us.Focus();

            this.Controls.Add(us);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }
    }

}
