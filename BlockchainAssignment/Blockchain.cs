using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
       
        public List<Block> Blocks; // list of block in chain

        private int transactionsPerBlock = 5;
        public List<Transaction> transactionPool = new List<Transaction>();  // Pending transactions waiting to be mined
        /* Blockchain Constructor - Initialises a new blockchain with a single genesis block */
        public Blockchain()
        {
           this.Blocks = new List<Block>() {
                new Block()
            };
        }

        /* Helper function to get a block at a user specified index */
        public String getBlockAsString(int index)
        {
            if (index >= 0 && index < Blocks.Count)
                return Blocks[index].ToString();
            return "Block does not exist at index: " + index.ToString();
        }

        // ** NEW (Part 4) ** Retrieve up to 'transactionsPerBlock' pending transactions,
        // remove them from the pool, and return them to be included in the next block
        public List<Transaction> GetPendingTransactions()
        {
            int n = Math.Min(transactionsPerBlock, transactionPool.Count);
            List<Transaction> txs = transactionPool.GetRange(0, n);
            transactionPool.RemoveRange(0, n);
            return txs;
        }  // :contentReference[oaicite:0]{index=0}&#8203;:contentReference[oaicite:1]{index=1}





        // ** NEW (Part 4) ** Helper to grab the most recently added block in the chain
        public Block GetLastBlock()
        {
            return Blocks[Blocks.Count - 1];
        }  // :contentReference[o


        public override string ToString()
        {
            return String.Join("\n\n", Blocks);
        }



    }


}
