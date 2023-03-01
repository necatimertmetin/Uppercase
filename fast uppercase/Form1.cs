using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fast_uppercase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text= richTextBox1.Text.ToUpper();
            richTextBox1.Select(richTextBox1.Text.Length, 0);
            richTextBox1.ScrollToCaret();
        }

        

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
            
            toolTip1.Active= true;
            toolTip1.ToolTipTitle = "kontroller";
            toolTip1.UseFading = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.SetToolTip(richTextBox1, "sag tik = hepsini sec ve kopyala \n sol tik = yapistir");

        }

       

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox1.SelectAll();
                Clipboard.SetText(richTextBox1.Text);
                richTextBox1.Text = "KOPYALANDI";
            }
            else
            {
                richTextBox1.Text = Clipboard.GetText();

            }
        }
    }
}