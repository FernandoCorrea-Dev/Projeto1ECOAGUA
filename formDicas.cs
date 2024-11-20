using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoÁgua
{
    public partial class formDicas : Form
    {
        public formDicas()
        {
            InitializeComponent();
            ConfigureRichTextBoxes();
        }
        private void ConfigureRichTextBoxes()
        {
            // Lista de todos os RichTextBoxes do form
            var richTextBoxes = new[]
            {
                ConcienciaDaAguatxt, ConcienciaDaAgua2txt
            };

            foreach (var rtb in richTextBoxes)
            {


                // Pegar o RTF atual
                string rtfAtual = rtb.Rtf;

                // Substituir o alinhamento padrão por justificado
                rtfAtual = rtfAtual.Replace(@"\ql", @"\qj");

                // Se não encontrou \ql, adiciona \qj após cada \pard
                if (!rtfAtual.Contains(@"\qj"))
                {
                    rtfAtual = rtfAtual.Replace(@"\pard", @"\pard\qj");
                }

                // Aplicar o RTF modificado
                rtb.Rtf = rtfAtual;
            }
        }

        private void formDicas_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void ConcienciaDaAgua_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConcienciaDaAgua2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
