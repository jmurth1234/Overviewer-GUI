using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverviewerGUI
{
    public class ConsoleRedirect : TextWriter
    {
        TextBox _output = null;

        public ConsoleRedirect(TextBox output)
        {
            this._output = output;
        }

        public override void Write(char value)
        {
            MethodInvoker action = delegate { _output.AppendText(value.ToString()); };
            _output.BeginInvoke(action);
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
