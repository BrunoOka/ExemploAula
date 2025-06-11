namespace ExemploAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text =="admin" && txtsenha.Text == "123456")
            {
                MessageBox.Show("usuario logado com sucesso");
                txtusuario.Clear();
                txtsenha.Clear();
            }
            else 
            {
                    MessageBox.Show("usuario/senha incorretos");
                    txtusuario.Clear();
                    txtsenha.Clear();
                }
            Hide();
            frmmenu menu= new frmmenu();
            menu.Show();
            }
        }
    }

