using TextAnalyzerBatoman.TextBasics;

namespace TextAnalyzer
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            //TOdO: Execute analyzer class
            var txtAgent = TextAgent.Instance;
            Text txt = txtAgent.FromString(txtInput.Text);
            lblCharacterCount.Text = txt.CharactersCount.ToString();
            //txt.
            //Use TextBasics namespace if needed
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo... move to another class
            string fileContents = String.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Archivos .txt | *.txt";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            DialogResult diagResult = openFileDialog.ShowDialog();
            if (diagResult == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                try {
                    using (StringReader strReader = new StringReader(fileName)) { 
                        fileContents = strReader.ReadToEnd();
                    }
                }
                catch {
                    MessageBox.Show("Hubo un problema al abrir el archivo.");
                    return;
                }
            }
            //todo open word file with interop, do some namespace or class
            var txtAgent = TextAgent.Instance;
            Text txt = txtAgent.FromString(fileContents);
            txtInput.Text = txt.String;
        }
    }
}