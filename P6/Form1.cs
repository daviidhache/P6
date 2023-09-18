namespace P6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Blue;
            Button boton = (Button)sender;
            int nElementos = flowLayoutPanel1.Controls.Count;
            if (boton.BackColor.Name == "Red")
            {
                boton.BackColor = Color.Green;
         
            }
            else
            {
                boton.BackColor = Color.Red;
               
            }

            int verde = 0;
            int rojo = 0;
            foreach (Control dato in flowLayoutPanel1.Controls) {
                if (dato.BackColor.Name == "Red") {
                    rojo++;
                }
                if (dato.BackColor.Name == "Green") {
                    verde++;
                }

                if (nElementos == rojo) {
                    button2.BackColor = Color.Red;
                }
            }

        








        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control dato in flowLayoutPanel1.Controls) {
                dato.BackColor = Color.Green;
            }
        }
    }

   
}