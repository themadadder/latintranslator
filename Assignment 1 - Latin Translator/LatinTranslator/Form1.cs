namespace LatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            translatedWord.Text = "Up";
        }

        private void secondWord_Click(object sender, EventArgs e)
        {
            translatedWord.Text = "Down";

        }

        private void thirdWord_Click(object sender, EventArgs e)
        {
            translatedWord.Text = "Center";

        }
    }
}
