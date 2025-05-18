namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printBlock = new System.Windows.Forms.Button();
            this.blockIndex = new System.Windows.Forms.TextBox();
            this.GenW = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Public_Key = new System.Windows.Forms.TextBox();
            this.Private_Key = new System.Windows.Forms.TextBox();
            this.PK = new System.Windows.Forms.Label();
            this.PrK = new System.Windows.Forms.Label();
            this.CLEAR = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.fee = new System.Windows.Forms.TextBox();
            this.reciever = new System.Windows.Forms.TextBox();
            this.CreateTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newBlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(657, 314);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printBlock
            // 
            this.printBlock.Location = new System.Drawing.Point(12, 330);
            this.printBlock.Margin = new System.Windows.Forms.Padding(2);
            this.printBlock.Name = "printBlock";
            this.printBlock.Size = new System.Drawing.Size(47, 40);
            this.printBlock.TabIndex = 1;
            this.printBlock.Text = "Print Block";
            this.printBlock.UseVisualStyleBackColor = true;
            this.printBlock.Click += new System.EventHandler(this.button1_Click);
            // 
            // blockIndex
            // 
            this.blockIndex.Location = new System.Drawing.Point(73, 341);
            this.blockIndex.Margin = new System.Windows.Forms.Padding(2);
            this.blockIndex.Name = "blockIndex";
            this.blockIndex.Size = new System.Drawing.Size(43, 20);
            this.blockIndex.TabIndex = 2;
            // 
            // GenW
            // 
            this.GenW.Location = new System.Drawing.Point(560, 346);
            this.GenW.Name = "GenW";
            this.GenW.Size = new System.Drawing.Size(98, 59);
            this.GenW.TabIndex = 3;
            this.GenW.Text = "Generate Wallet";
            this.GenW.UseVisualStyleBackColor = true;
            this.GenW.Click += new System.EventHandler(this.GenW_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Validate Keys";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Public_Key
            // 
            this.Public_Key.Location = new System.Drawing.Point(270, 350);
            this.Public_Key.Name = "Public_Key";
            this.Public_Key.Size = new System.Drawing.Size(284, 20);
            this.Public_Key.TabIndex = 5;
            // 
            // Private_Key
            // 
            this.Private_Key.Location = new System.Drawing.Point(270, 376);
            this.Private_Key.Name = "Private_Key";
            this.Private_Key.Size = new System.Drawing.Size(284, 20);
            this.Private_Key.TabIndex = 6;
            // 
            // PK
            // 
            this.PK.AutoSize = true;
            this.PK.Location = new System.Drawing.Point(203, 353);
            this.PK.Name = "PK";
            this.PK.Size = new System.Drawing.Size(51, 13);
            this.PK.TabIndex = 7;
            this.PK.Text = "Pulic Key";
            this.PK.Click += new System.EventHandler(this.PK_Click);
            // 
            // PrK
            // 
            this.PrK.AutoSize = true;
            this.PrK.Location = new System.Drawing.Point(203, 379);
            this.PrK.Name = "PrK";
            this.PrK.Size = new System.Drawing.Size(61, 13);
            this.PrK.TabIndex = 8;
            this.PrK.Text = "Private Key";
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(28, 382);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 23);
            this.CLEAR.TabIndex = 9;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(270, 402);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 10;
            this.amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fee
            // 
            this.fee.Location = new System.Drawing.Point(270, 423);
            this.fee.Name = "fee";
            this.fee.Size = new System.Drawing.Size(100, 20);
            this.fee.TabIndex = 11;
            // 
            // reciever
            // 
            this.reciever.Location = new System.Drawing.Point(196, 449);
            this.reciever.Name = "reciever";
            this.reciever.Size = new System.Drawing.Size(174, 20);
            this.reciever.TabIndex = 12;
            // 
            // CreateTransaction
            // 
            this.CreateTransaction.Location = new System.Drawing.Point(395, 437);
            this.CreateTransaction.Name = "CreateTransaction";
            this.CreateTransaction.Size = new System.Drawing.Size(113, 23);
            this.CreateTransaction.TabIndex = 13;
            this.CreateTransaction.Text = "Make transaction";
            this.CreateTransaction.UseVisualStyleBackColor = true;
            this.CreateTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Set amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Set fee";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Send to :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // newBlock
            // 
            this.newBlock.Location = new System.Drawing.Point(10, 437);
            this.newBlock.Name = "newBlock";
            this.newBlock.Size = new System.Drawing.Size(106, 23);
            this.newBlock.TabIndex = 17;
            this.newBlock.Text = "Add new block";
            this.newBlock.UseVisualStyleBackColor = true;
            this.newBlock.Click += new System.EventHandler(this.newBlock_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 481);
            this.Controls.Add(this.newBlock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateTransaction);
            this.Controls.Add(this.reciever);
            this.Controls.Add(this.fee);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.PrK);
            this.Controls.Add(this.PK);
            this.Controls.Add(this.Private_Key);
            this.Controls.Add(this.Public_Key);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GenW);
            this.Controls.Add(this.blockIndex);
            this.Controls.Add(this.printBlock);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button printBlock;
        private System.Windows.Forms.TextBox blockIndex;
        private System.Windows.Forms.Button GenW;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Public_Key;
        private System.Windows.Forms.TextBox Private_Key;
        private System.Windows.Forms.Label PK;
        private System.Windows.Forms.Label PrK;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox fee;
        private System.Windows.Forms.TextBox reciever;
        private System.Windows.Forms.Button CreateTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newBlock;
    }
}

