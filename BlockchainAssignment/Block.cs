using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    /**
     * Class representing a single block in the blockchain,
     * complete with Proof-of-Work (PoW), transaction inclusion,
     * Merkle root calculation, and mining rewards.
     */
    class Block
    {
        // --- Block Metadata ---
        private DateTime timestamp;             // Time when this block was created
        private int index,                      // Position of the block in the chain
                    difficulty = 4;             // Number of leading zeros required in a valid hash

        // --- PoW & Chaining ---
        public long nonce;                      // Nonce value adjusted during mining
        public String prevHash,                 // Hash of the previous block
                      hash;                     // Hash of this block (meets difficulty)

        // --- Transaction Data ---
        public List<Transaction> transactionList; // Transactions included in this block
        public String merkleRoot;               // Merkle root of all transaction hashes

        // --- Reward Data ---
        public String minerAddress;             // Wallet address to receive mining reward
        public double reward;                   // Fixed reward + accumulated fees

        /* -----------------------------------------------
         * Genesis Block Constructor
         * Creates the very first block with no transactions.
         * It immediately runs PoW to set its hash.
         * --------------------------------------------- */
        public Block()
        {
            this.timestamp = DateTime.Now;          // creation time
            this.index = 0;                     // genesis index
            this.transactionList = new List<Transaction>();// no txs yet
            this.prevHash = String.Empty;          // no parent block
            this.hash = Mine();                // perform PoW for genesis
        }

        /* -----------------------------------------------
         * Standard Block Constructor
         * Builds a new block on top of the given lastBlock,
         * includes pending transactions, issues a reward,
         * computes Merkle root, then mines for a valid hash.
         *
         * @param lastBlock    The block to link from
         * @param transactions List of pending transactions
         * @param minerAddress Address to credit with reward
         * --------------------------------------------- */
        public Block(Block lastBlock, List<Transaction> transactions, String minerAddress)
        {
            this.timestamp = DateTime.Now;
            this.index = lastBlock.index + 1;    // next position
            this.prevHash = lastBlock.hash;         // link to parent
            this.minerAddress = minerAddress;           // who gets the coinbase
            this.reward = 1.0;                    // fixed block reward

            // 1) create and add the reward transaction (includes all tx fees)
            transactions.Add(createRewardTransaction(transactions));

            // 2) set our transactions and compute the Merkle root
            this.transactionList = new List<Transaction>(transactions);
            this.merkleRoot = MerkleRoot(transactionList);

            // 3) perform proof-of-work to find a valid hash
            this.hash = Mine();
        }

        /* -----------------------------------------------
         * Generate the SHA-256 hash of this block,
         * incorporating timestamp, index, prevHash,
         * nonce, and merkleRoot.
         * --------------------------------------------- */
        public String CreateHash()
        {
            SHA256 hasher = SHA256Managed.Create();
            // Concatenate all fields that define this block
            String input = timestamp.ToString()
                         + index
                         + prevHash
                         + nonce
                         + merkleRoot;
            Byte[] hashBytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Convert to hexadecimal string
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashBytes)
                sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }

        /* -----------------------------------------------
         * Proof-of-Work: repeatedly increment the nonce
         * and re-hash until the resulting hash has
         * 'difficulty' leading zeros.
         * --------------------------------------------- */
        public String Mine()
        {
            nonce = 0;
            String hash = CreateHash();
            String target = new string('0', difficulty);  // e.g. "0000" for difficulty=4

            while (!hash.StartsWith(target))
            {
                nonce++;
                hash = CreateHash();
            }
            return hash;  // valid PoW hash
        }

        /* -----------------------------------------------
         * Compute the Merkle root of a list of transactions.
         * Pairs up adjacent hashes, combines them, and
         * repeats until a single root remains.
         * --------------------------------------------- */
        public static String MerkleRoot(List<Transaction> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList();
            if (hashes.Count == 0) return String.Empty;
            if (hashes.Count == 1) return HashCode.HashTools.CombineHash(hashes[0], hashes[0]);

            // Pairwise combine
            while (hashes.Count > 1)
            {
                var nextLevel = new List<String>();
                for (int i = 0; i < hashes.Count; i += 2)
                {
                    if (i == hashes.Count - 1)
                        nextLevel.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i]));
                    else
                        nextLevel.Add(HashCode.HashTools.CombineHash(hashes[i], hashes[i + 1]));
                }
                hashes = nextLevel;
            }
            return hashes[0];
        }

        /* -----------------------------------------------
         * Create the special "coinbase" transaction that
         * pays out reward + total fees to the miner.
         * --------------------------------------------- */
        public Transaction createRewardTransaction(List<Transaction> transactions)
        {
            double totalFees = transactions.Aggregate(0.0, (sum, tx) => sum + tx.fee);
            return new Transaction(
                "Mine Rewards",         // reserved sender address
                minerAddress,           // who receives the coins
                reward + totalFees,     // reward + all fees
                0,                      // no fee on reward tx
                ""                      // no private key needed
            );
        }

        /* -----------------------------------------------
         * Nice, human-readable representation for UI output,
         * showing PoW status, rewards, and transaction list.
         * --------------------------------------------- */
        public override string ToString()
        {
            return "[BLOCK START]"
                + "\nIndex: " + index
                + "\tTimestamp: " + timestamp
                + "\nPrevious Hash: " + prevHash
                + "\n-- PoW --"
                + "\nDifficulty Level: " + difficulty
                + "\nNonce: " + nonce
                + "\nHash: " + hash
                + "\n-- Rewards --"
                + "\nReward: " + reward
                + "\nMiner Address: " + minerAddress
                + "\n-- " + transactionList.Count + " Transactions --"
                + "\nMerkle Root: " + merkleRoot
                + "\n" + String.Join("\n", transactionList)
                + "\n[BLOCK END]";
        }
    }
}
