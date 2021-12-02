namespace Sem_3_Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_encrypt_Click(object sender, EventArgs e)
        {
            string message = input_textBox.Text;
            int key = Convert.ToInt32(key_numericUpDown.Value);

            Viginer_modified Encrypt = new(message,key);
            
            Encrypt.Key_Encrypt();
            
            output_textBox.Text = Encrypt.GetMessage();
        }

        private void button_decrypt_Click(object sender, EventArgs e)
        {
            string message = input_textBox.Text;
            int key = Convert.ToInt32(key_numericUpDown.Value);

            Viginer_modified Decrypt = new(message,key);

            Decrypt.Key_Decrypt();

            output_textBox.Text = Decrypt.GetMessage();
        }
    }
}