using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;


namespace EcoÁgua
{
    public partial class Form1 : Form
    {
        formImportancia importancia;
        formPainelPrincipal painelPrincipal;
        formConsequencias  consequencias;
        formCreditos creditos;
        formDicas dicas;
        formQuiz quiz;
        
        public Form1()
        {
            
            InitializeComponent();
        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuConteiner.Height += 10;
                if(menuConteiner.Height >= 157)
                {
                    menuTransition.Stop();
                    menuExpand = true;

                
                }
            }
            else
            {
                menuConteiner.Height -= 10;
                if( menuConteiner.Height <= 41)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                   
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 46)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
              
                }
            }
            else
            {
                sidebar.Width += 10;   
                if(sidebar.Width >=192)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
               
                }
            }
        }

        private void btnSideBarTransition_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnConsequencias_Click(object sender, EventArgs e)
        {
            if(consequencias == null)
            {
                consequencias = new formConsequencias();
                consequencias.FormClosed += Consequencias_FormClosed;
                consequencias.MdiParent = this;
                consequencias.Dock = DockStyle.Fill;
                consequencias.Show();
            }
            else
            {
                consequencias.Activate();
            }
        }

        private void Consequencias_FormClosed(object sender, FormClosedEventArgs e)
        {
           consequencias = null;
        }

        private void btnDicas_Click(object sender, EventArgs e)
        {
            if(dicas == null)
            {
                dicas = new formDicas();
                dicas.FormClosed += Dicas_FormClosed;
                dicas.MdiParent = this;
                dicas.Dock = DockStyle.Fill;
                dicas.Show();
            }
            else
            {
                dicas.Activate();
            }
        }

        private void Dicas_FormClosed(object sender, FormClosedEventArgs e)
        {
            dicas = null;
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            if(quiz == null)
            {
                quiz = new formQuiz();
                quiz.FormClosed += Quiz_FormClosed;
                quiz.MdiParent = this;
                quiz.Dock = DockStyle.Fill;
                quiz.Show();
            }
            else
            { 
                quiz.Activate(); 
            }

        }

        private void Quiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            quiz = null;
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            if (creditos == null)
            {
                creditos = new formCreditos();
                creditos.FormClosed += Creditos_FormClosed;
                creditos.MdiParent = this;
                creditos.Dock = DockStyle.Fill;
                creditos.Show();
            }
            else
            {
                creditos.Activate();
            }
        }

        private void Creditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            creditos = null;
        }
       

        private void btnPainelPrincipal_Click(object sender, EventArgs e)
        {
            if (painelPrincipal == null)
            {
                painelPrincipal = new formPainelPrincipal();
                painelPrincipal.FormClosed += PainelPrincipal_FormClosed;
                painelPrincipal.MdiParent = this;
                painelPrincipal.Dock = DockStyle.Fill;   
                painelPrincipal.Show();
            }
            else
            {
                painelPrincipal.Activate();
            }
        }

        private void PainelPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            painelPrincipal = null; 
        }

        private void btnImportancia_Click(object sender, EventArgs e)
        {
            if(importancia == null)
            {
                importancia = new formImportancia();
                importancia.FormClosed += Importancia_FormClosed;
                importancia.MdiParent = this;
                importancia.Dock = DockStyle.Fill;
                importancia.Show();    
            }
            else
            {
                importancia.Activate();
            }
        }

        private void Importancia_FormClosed(object sender, FormClosedEventArgs e)
        {
            importancia = null;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
