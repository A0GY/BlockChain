using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        /** Block Properties */
        DateTime timestamp;  // time block was created
        int index; // the current position of the block in blockchain
        String hash, prevHash; // the current hash and previous hash of block


        /* Genesis Block Constructor */ // Code for creating the first block without any inputs 
        public Block()
        {
            this.timestamp = DateTime.Now; // current time of block creation
            this.index = 0; // set value to 0 as its the first block
            this.prevHash = String.Empty; // No prior block hash as first block
            this.hash = CreateHash(); // creates its hash
        }
        /* Block Constructors */ // creation of our blocks
        public Block(int index, String hash) 
        { 
            this.timestamp = DateTime.Now; // get the current date/time
            this.index = index + 1; // we incrment the index by 1 as its the next block in our chain
            this.prevHash = hash; // creating block from previous hash
            this.hash = CreateHash();
        }


        // Overloaded block constructor accepting a Block object
        public Block(Block prevBlock) // creating block from a prev block
        {
            this.timestamp = DateTime.Now;
            this.index = prevBlock.index + 1;
            this.prevHash = prevBlock.hash;
            this.hash = CreateHash();
        }


        /* Generate a blocks hash using the SHA256 algorithm */ 
        public String CreateHash()
        {
            SHA256 hasher = SHA256Managed.Create(); 

            String input = index.ToString() + timestamp.ToString() + prevHash; 
            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input)); 

            String hash = string.Empty; 

            foreach (byte x in hashByte) 
                hash += String.Format("{0:x2}", x); 

            return hash;
        }


        /* Return a human-readable representation of a block */
        public override string ToString()
        {
            return
                "Index: " + index.ToString() + "\tTimestamp: " + timestamp.ToString() +
                "\nHash: " + hash +
                "\nPrevious Hash: " + prevHash;
        }
    }
}
