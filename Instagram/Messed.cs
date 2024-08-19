using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPchat
{
    class Messed
    {
        private string classify;
        private string text;
        public Messed()
        {
        }
        public Messed(string classify, string text)
        {
            this.classify = classify;
            this.text = text;
        }
        public string Classify { get => classify; set => classify = value; }
        public string Text { get => text; set => text = value; }
    }
}