using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Socket
{
    public interface ILogger
    {
        void writeEntry(ArrayList entry); // Write list of lines void writeEntry (String entry); // Write single line
        void writeEntry(string v);
    }
}
