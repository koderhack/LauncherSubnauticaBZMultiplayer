using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Threading;

namespace LauncherSubnauticaBZMultiplayer
{
    public class TextBoxWriter : TextWriter
    {
        MetroSet_UI.Controls.MetroSetTextBox _output = null;

        public TextBoxWriter(MetroSet_UI.Controls.MetroSetTextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);

            _output.Invoke(new MethodInvoker(() => _output.AppendText(value.ToString())));

        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
