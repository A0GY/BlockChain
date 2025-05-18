using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /* TRANSACTION MANAGEMENT */
        // Create a new pending transaction and add it to the transaction pool
        private void CreateTransaction_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(
                Public_Key.Text,
                reciever.Text,
                Double.Parse(amount.Text),
                Double.Parse(fee.Text),
                Private_Key.Text
            );
            blockchain.transactionPool.Add(transaction);
            UpdateText(transaction.ToString());
        }

        // Helper method to update the UI with a provided message
        private void UpdateText(String text)
        {
            // in the guide this was output.Text, 
            // in your app the main box is richTextBox1
            richTextBox1.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void newBlock_Click(object sender, EventArgs e)
        {
            
        
            // 1) pull the next batch of pending txs
            List<Transaction> txs = blockchain.GetPendingTransactions();
            // 2) mine a new block (PoW + rewards + Merkle)
            Block newBlock = new Block(blockchain.GetLastBlock(), txs, Public_Key.Text);
            // 3) append it to your chain
            blockchain.Blocks.Add(newBlock);
            // 4) show the updated chain in your console
            UpdateText(blockchain.ToString());
        }

    }
}











