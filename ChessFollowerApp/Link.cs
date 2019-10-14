using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFollowerApp
{
    public class Link
    {
        // string value that is unique to this link. Often a username.
        public string name;
        // int value that is unique to this link. Often a rating.
        public int data;
        // Link to the next link.
        public Link next;

        /// <summary>
        /// Initialize values
        /// </summary>
        public Link()
        {
            name = "";
            data = 0;
            next = null;
        }
        public Link(int data, string name)
        {
            this.name = name;
            this.data = data;
            next = null;
        }

    }
}
