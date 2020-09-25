using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_simulator.Classes
{
    public static class State
    {
        public static bool startNodeState { get; set; }
        public static bool endNodeState { get; set; }
        public static int item { get; set; }
        static State()
        {
            startNodeState = false;
            endNodeState = false;
            item = -1; 
        }
    }
}
