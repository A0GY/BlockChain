using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        /* Global Blockchain object - Our working blockchain */
        Blockchain blockchain;

        /* Initialize blockchain on startup of application UI */
        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
            richTextBox1.Text = "blockchain initialised!";
            CLEAR.Click += new EventHandler(CLEAR_Click);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Duplicate the value input into our new textbox (textBox1) in the large "console" (richTextBox1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(blockIndex.Text, out int index))
                richTextBox1.Text = blockchain.getBlockAsString(index);
            else
                richTextBox1.Text = "Please enter a valid number";

        }

        private void PK_Click(object sender, EventArgs e)
        {
            if (Wallet.Wallet.ValidatePrivateKey(Private_Key.Text, Public_Key.Text))
                richTextBox1.Text = "Private Key is valid";
            else
                richTextBox1.Text = "Private Key is invalid";


        }



        private void GenW_Click(object sender, EventArgs e) // generate the wallet 
        {
            String privateKey;
            Wallet.Wallet wallet = new Wallet.Wallet(out privateKey);
            Public_Key.Text = wallet.publicID;
            Private_Key.Text = privateKey;
        }












        // clear the screen
        private void CLEAR_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e) // validation of the private key using terneary conditional operator
        {
            richTextBox1.Text = Wallet.Wallet.ValidatePrivateKey(Private_Key.Text, Public_Key.Text)
                ? "Private Key is valid"
                : "Private Key is invalid";
        }
    }





}





