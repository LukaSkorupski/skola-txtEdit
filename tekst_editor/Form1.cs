using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekst_editor
{
    public partial class Form1 : Form
    {
        string putanja = "";
        bool bold = false;
        bool italic = false;
        bool underline = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rich Text Files (.rtf)|*.rtf|Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.FileName = "Datoteka";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                putanja = openFileDialog.FileName;
                txtBox.LoadFile(putanja);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnSpremiKao_Click(object sender, EventArgs e)
        {
            if (!saveDialog()) return;
            save();
        }

        private void save()
        {
            if (putanja == "")
            {
                if (!saveDialog()) return;
            }
            if (Path.GetExtension(putanja) == ".rtf")
            {
                txtBox.SaveFile(putanja, RichTextBoxStreamType.RichText);
            } else 
            {
                txtBox.SaveFile(putanja, RichTextBoxStreamType.PlainText);
            }
        }

        private bool saveDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Files (.rtf)|*.rtf|Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.FileName = "Datoteka";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                putanja = saveFileDialog.FileName;
                return true;
            }
            return false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBox.Text = "";
            putanja = "";
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            bold = !bold;
            setFont();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            italic = !italic;
            setFont();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            underline = !underline;
            setFont();
        }

        private void setFont()
        {
            FontStyle fontStyle = FontStyle.Regular;
            if (bold)
            {
                fontStyle |= FontStyle.Bold;
            }
            if (italic)
            {
                fontStyle |= FontStyle.Italic;
            }
            if (underline)
            {
                fontStyle |= FontStyle.Underline;
            }
            txtBox.SelectionFont = new Font(txtBox.SelectionFont, fontStyle); ;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
