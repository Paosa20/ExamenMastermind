using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenComponentes
{
    public partial class UserControl1: UserControl
    {
        

        public UserControl1()
        {
            InitializeComponent();


            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //contador de oportunidades NO USARLO EN ESTE BOTON CAMBIAR DE LUGAR 
            //CAMBIAR DE FORM 
            UserControl2 userDos = new UserControl2();

            showControl(userDos);

           /* userDos.Show();
            
            userDos.Dock = DockStyle.Fill;
            */
            //this.Hide();


        }

        private void showControl(UserControl us)
        {
            this.Controls.Clear();
            us.Dock = DockStyle.Fill;
            us.BringToFront();
            us.Focus();

            this.Controls.Add(us);
        }

                                                                
      
    }
}
