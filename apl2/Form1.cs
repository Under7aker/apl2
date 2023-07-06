using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace apl2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // obj = new Cript();
        }
        // Cript obj;
        const string key = "blaser34rtsdrfsfghnbgfredvbhytg5";
        private void button1_Click(object sender, EventArgs e)
        {
            {

                byte[] iv = new byte[16];

                byte[] array;

                using (Aes aes = Aes.Create())

                {

                    aes.Key = Encoding.UTF8.GetBytes(key);

                    aes.IV = iv;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream())

                    {

                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))

                        {

                            using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))

                            {

                                streamWriter.Write(textBox1.Text);

                            }



                            array = memoryStream.ToArray();

                        }

                    }

                }



                textBox2.Text = Convert.ToBase64String(array);

            }


            //textBox2.Text =obj.encript(textBox1.Text);
        }

        private void Decript_Click(object sender, EventArgs e)
        {
            byte[] iv = new byte[16];

            string Message = string.Empty;

            byte[] buffer = Convert.FromBase64String(textBox2.Text);

            using (Aes aes = Aes.Create())

            {

                aes.Key = Encoding.UTF8.GetBytes(key);

                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))

                {

                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))

                    {

                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))

                        {

                            Message = streamReader.ReadToEnd();

                        }

                    }

                }

            }



            textBox3.Text = Message;
            // textBox1.Text = obj.decript(textBox2.Text);
        }
    }
}