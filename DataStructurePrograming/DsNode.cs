using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograming
{
    public class DsNode
    {
        public int data;
        public DsNode next;
        public DsNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}

