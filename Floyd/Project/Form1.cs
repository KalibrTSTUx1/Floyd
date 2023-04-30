namespace Project
{
    public partial class Form1 : Form
    {
        private string filePath;

        
        public Form1()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { filePath = openFileDialog1.FileName; }
            txBx_InpPath.Text = filePath;
            progressBar.Visible = false;

        }

        private void button_OutPath_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            filePath = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { filePath = openFileDialog1.FileName; }
            txBx_OutPath.Text = filePath;
            progressBar.Visible = false;
        }

        private void chBx_ManualPath_CheckedChanged(object sender, EventArgs e)
        {
            if (chBx_ManualPath.Checked == true)
            {
                txBx_InpPath.ReadOnly = false;
                txBx_OutPath.ReadOnly = false;
                button_InpPath.Enabled = false;
                button_OutPath.Enabled = false;
            }
            else
            {
                txBx_InpPath.ReadOnly = true;
                txBx_OutPath.ReadOnly = true;
                button_InpPath.Enabled = true;
                button_OutPath.Enabled = true;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            
            if (txBx_OutPath.Text != String.Empty && txBx_InpPath.Text != String.Empty)
            {
                progressBar.Value = 0;
                progressBar.Visible = true;
                var enPoint = new entryPoint(txBx_InpPath.Text, txBx_OutPath.Text, ref progressBar);
                var log = enPoint.start();
                if (log == 1)
                {
                    errorProvider1.SetError(txBx_InpPath, "Файл пустой!");
                }
                if (log == 2) { errorProvider1.SetError(txBx_InpPath, "Неверный путь"); }
            }
            else { errorProvider1.SetError(button_Start, "Не все поля заполнены"); }
            
        }

    }
}