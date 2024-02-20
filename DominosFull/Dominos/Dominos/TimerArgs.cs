using System;
using System.Windows.Forms;

namespace Dominos
{
    internal class TimerArgs : EventArgs
    {
        public int rt { get; set; }
        public Label lb { get; set; }
        public GroupBox gb { get; set; }
    }
}