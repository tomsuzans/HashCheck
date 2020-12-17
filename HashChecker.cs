
using System;

using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;


namespace Hash_Checker
{
    public partial class Hash_Match : Form
    {
        public Hash_Match()
        {
            InitializeComponent();
        }

        private void FormHashChecker_Load(object sender, EventArgs e)
        {
            txtloc.Text = Application.ExecutablePath;
            texthash.CharacterCasing = CharacterCasing.Lower;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ofdFile.FileName = txtloc.Text;
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                txtloc.Text = ofdFile.FileName;
                textMD5.Clear();
                textSHA256.Clear();
                textSHA1.Clear();
            }
        }

        private void Hash_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtloc.Text))
            {
                textMD5.Text = BytesToString(GetHashMD5(txtloc.Text));
                textSHA256.Text = BytesToString(GetHashSha256(txtloc.Text));
                textSHA1.Text = BytesToString(GetHashSha1(txtloc.Text));
            }
            else
            {
                MessageBox.Show("File doesn't exist.", "Error: File not found");
            }

            if (texthash.Text == textSHA256.Text || texthash.Text == textSHA1.Text || texthash.Text == textMD5.Text )
            {
                match.ForeColor = System.Drawing.Color.Green;
                match.Text = "MATCH";
            }
            else
            {
                match.ForeColor = System.Drawing.Color.Red;
                match.Text = "NO MATCH";
            }
        }

        public static string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes)
            {
                result += b.ToString("x2");
            }
            return result;
        }

        //Algorithms
        //MD5
        readonly private MD5 Md5 = MD5.Create();

        private byte[] GetHashMD5(string filename)
        {
            using (FileStream stream = System.IO.File.OpenRead(filename))
            {
                return Md5.ComputeHash(stream);
            }
        }

        //SHA256
        readonly private SHA256 Sha256 = SHA256.Create();

        private byte[] GetHashSha256(string filename)
        {
            using (FileStream stream = System.IO.File.OpenRead(filename))
            {
                return Sha256.ComputeHash(stream);
            }
        }

        //SHA1
        readonly private SHA1 Sha1 = SHA1.Create();

        private byte[] GetHashSha1(string filename)
        {
            using (FileStream stream = System.IO.File.OpenRead(filename))
            {
                return Sha1.ComputeHash(stream);
            }
        }


        //Copy
        private void Copy1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textMD5.Text))
            {
                MessageBox.Show("Textbox cannot be null.", "Error: MD5");
            }
            else
            {
                Clipboard.SetText(textMD5.Text);
            }
        }

        private void Copy2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textSHA1.Text))
            {
                MessageBox.Show("Textbox cannot be null.", "Error: SHA1");
            }
            else
            {
                Clipboard.SetText(textSHA1.Text);
            }
        }

        private void Copy3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textSHA256.Text))
            {
                MessageBox.Show("Textbox cannot be null.", "Error: SHA256");
            }
            else
            {
                Clipboard.SetText(textSHA256.Text);
            }
        }

        

    }
}
