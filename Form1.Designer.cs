namespace EcoÁgua
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSideBarTransition = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPainelPrincipal = new System.Windows.Forms.Panel();
            this.btnPainelPrincipal = new System.Windows.Forms.Button();
            this.menuConteiner = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnDicas = new System.Windows.Forms.Panel();
            this.btnDicas = new System.Windows.Forms.Button();
            this.pnConsequencias = new System.Windows.Forms.Panel();
            this.btnConsequencias = new System.Windows.Forms.Button();
            this.pnImportancia = new System.Windows.Forms.Panel();
            this.btnImportancia = new System.Windows.Forms.Button();
            this.pnQuiz = new System.Windows.Forms.Panel();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.pnCreditos = new System.Windows.Forms.Panel();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBarTransition)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnPainelPrincipal.SuspendLayout();
            this.menuConteiner.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnDicas.SuspendLayout();
            this.pnConsequencias.SuspendLayout();
            this.pnImportancia.SuspendLayout();
            this.pnQuiz.SuspendLayout();
            this.pnCreditos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSideBarTransition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.EdgeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(930, 45);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoÁgua.Properties.Resources.logo_png_vRtoSxkb9_transformed;
            this.pictureBox1.Location = new System.Drawing.Point(52, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(791, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "EcoÁgua";
            // 
            // btnSideBarTransition
            // 
            this.btnSideBarTransition.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSideBarTransition.Image = global::EcoÁgua.Properties.Resources.icons8_menu_48;
            this.btnSideBarTransition.Location = new System.Drawing.Point(5, 5);
            this.btnSideBarTransition.Name = "btnSideBarTransition";
            this.btnSideBarTransition.Size = new System.Drawing.Size(38, 35);
            this.btnSideBarTransition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSideBarTransition.TabIndex = 1;
            this.btnSideBarTransition.TabStop = false;
            this.btnSideBarTransition.Click += new System.EventHandler(this.btnSideBarTransition_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.SteelBlue;
            this.sidebar.Controls.Add(this.pnPainelPrincipal);
            this.sidebar.Controls.Add(this.menuConteiner);
            this.sidebar.Controls.Add(this.pnQuiz);
            this.sidebar.Controls.Add(this.pnCreditos);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 45);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(192, 455);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // pnPainelPrincipal
            // 
            this.pnPainelPrincipal.Controls.Add(this.btnPainelPrincipal);
            this.pnPainelPrincipal.Location = new System.Drawing.Point(3, 3);
            this.pnPainelPrincipal.Name = "pnPainelPrincipal";
            this.pnPainelPrincipal.Size = new System.Drawing.Size(147, 34);
            this.pnPainelPrincipal.TabIndex = 3;
            // 
            // btnPainelPrincipal
            // 
            this.btnPainelPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPainelPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainelPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnPainelPrincipal.Image = global::EcoÁgua.Properties.Resources.icons8_dashboard_layout_30;
            this.btnPainelPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainelPrincipal.Location = new System.Drawing.Point(-5, -21);
            this.btnPainelPrincipal.Name = "btnPainelPrincipal";
            this.btnPainelPrincipal.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnPainelPrincipal.Size = new System.Drawing.Size(206, 74);
            this.btnPainelPrincipal.TabIndex = 2;
            this.btnPainelPrincipal.Text = "         Painel Principal";
            this.btnPainelPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainelPrincipal.UseVisualStyleBackColor = false;
            this.btnPainelPrincipal.Click += new System.EventHandler(this.btnPainelPrincipal_Click);
            // 
            // menuConteiner
            // 
            this.menuConteiner.BackColor = System.Drawing.Color.SteelBlue;
            this.menuConteiner.Controls.Add(this.panel3);
            this.menuConteiner.Controls.Add(this.pnDicas);
            this.menuConteiner.Controls.Add(this.pnConsequencias);
            this.menuConteiner.Controls.Add(this.pnImportancia);
            this.menuConteiner.Location = new System.Drawing.Point(3, 43);
            this.menuConteiner.Name = "menuConteiner";
            this.menuConteiner.Size = new System.Drawing.Size(230, 45);
            this.menuConteiner.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMenu);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 37);
            this.panel3.TabIndex = 4;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::EcoÁgua.Properties.Resources.icons8_house_30;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(-8, -21);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(413, 77);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "         Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnDicas
            // 
            this.pnDicas.Controls.Add(this.btnDicas);
            this.pnDicas.Location = new System.Drawing.Point(3, 46);
            this.pnDicas.Name = "pnDicas";
            this.pnDicas.Size = new System.Drawing.Size(179, 34);
            this.pnDicas.TabIndex = 5;
            // 
            // btnDicas
            // 
            this.btnDicas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDicas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDicas.ForeColor = System.Drawing.Color.White;
            this.btnDicas.Image = global::EcoÁgua.Properties.Resources.icons8_currency_exchange_24;
            this.btnDicas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDicas.Location = new System.Drawing.Point(-5, -21);
            this.btnDicas.Name = "btnDicas";
            this.btnDicas.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDicas.Size = new System.Drawing.Size(206, 74);
            this.btnDicas.TabIndex = 2;
            this.btnDicas.Text = "        Dicas ";
            this.btnDicas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDicas.UseVisualStyleBackColor = false;
            this.btnDicas.Click += new System.EventHandler(this.btnDicas_Click);
            // 
            // pnConsequencias
            // 
            this.pnConsequencias.Controls.Add(this.btnConsequencias);
            this.pnConsequencias.Location = new System.Drawing.Point(3, 86);
            this.pnConsequencias.Name = "pnConsequencias";
            this.pnConsequencias.Size = new System.Drawing.Size(179, 34);
            this.pnConsequencias.TabIndex = 5;
            // 
            // btnConsequencias
            // 
            this.btnConsequencias.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConsequencias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsequencias.ForeColor = System.Drawing.Color.White;
            this.btnConsequencias.Image = global::EcoÁgua.Properties.Resources.icons8_flood_car_30;
            this.btnConsequencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsequencias.Location = new System.Drawing.Point(-5, -21);
            this.btnConsequencias.Name = "btnConsequencias";
            this.btnConsequencias.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnConsequencias.Size = new System.Drawing.Size(215, 74);
            this.btnConsequencias.TabIndex = 2;
            this.btnConsequencias.Text = "        Benefícios e Malefícios";
            this.btnConsequencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsequencias.UseVisualStyleBackColor = false;
            this.btnConsequencias.Click += new System.EventHandler(this.btnConsequencias_Click);
            // 
            // pnImportancia
            // 
            this.pnImportancia.Controls.Add(this.btnImportancia);
            this.pnImportancia.Location = new System.Drawing.Point(3, 126);
            this.pnImportancia.Name = "pnImportancia";
            this.pnImportancia.Size = new System.Drawing.Size(179, 34);
            this.pnImportancia.TabIndex = 6;
            // 
            // btnImportancia
            // 
            this.btnImportancia.BackColor = System.Drawing.Color.SteelBlue;
            this.btnImportancia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportancia.ForeColor = System.Drawing.Color.White;
            this.btnImportancia.Image = global::EcoÁgua.Properties.Resources.icons8_high_priority_message_24;
            this.btnImportancia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportancia.Location = new System.Drawing.Point(-5, -21);
            this.btnImportancia.Name = "btnImportancia";
            this.btnImportancia.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnImportancia.Size = new System.Drawing.Size(206, 74);
            this.btnImportancia.TabIndex = 2;
            this.btnImportancia.Text = "        Importância";
            this.btnImportancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportancia.UseVisualStyleBackColor = false;
            this.btnImportancia.Click += new System.EventHandler(this.btnImportancia_Click);
            // 
            // pnQuiz
            // 
            this.pnQuiz.Controls.Add(this.btnQuiz);
            this.pnQuiz.Location = new System.Drawing.Point(3, 94);
            this.pnQuiz.Name = "pnQuiz";
            this.pnQuiz.Size = new System.Drawing.Size(168, 34);
            this.pnQuiz.TabIndex = 4;
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuiz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.Color.White;
            this.btnQuiz.Image = global::EcoÁgua.Properties.Resources.icons8_idea_24;
            this.btnQuiz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuiz.Location = new System.Drawing.Point(-5, -21);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnQuiz.Size = new System.Drawing.Size(385, 74);
            this.btnQuiz.TabIndex = 2;
            this.btnQuiz.Text = "         Quiz";
            this.btnQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // pnCreditos
            // 
            this.pnCreditos.Controls.Add(this.btnCreditos);
            this.pnCreditos.Location = new System.Drawing.Point(3, 134);
            this.pnCreditos.Name = "pnCreditos";
            this.pnCreditos.Size = new System.Drawing.Size(168, 34);
            this.pnCreditos.TabIndex = 4;
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreditos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.ForeColor = System.Drawing.Color.White;
            this.btnCreditos.Image = global::EcoÁgua.Properties.Resources.icons8_user_groups_30;
            this.btnCreditos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditos.Location = new System.Drawing.Point(-6, -21);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnCreditos.Size = new System.Drawing.Size(219, 74);
            this.btnCreditos.TabIndex = 2;
            this.btnCreditos.Text = "         Créditos";
            this.btnCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditos.UseVisualStyleBackColor = false;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(930, 500);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.btnPainelPrincipal_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBarTransition)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnPainelPrincipal.ResumeLayout(false);
            this.menuConteiner.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnDicas.ResumeLayout(false);
            this.pnConsequencias.ResumeLayout(false);
            this.pnImportancia.ResumeLayout(false);
            this.pnQuiz.ResumeLayout(false);
            this.pnCreditos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private System.Windows.Forms.PictureBox btnSideBarTransition;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel pnPainelPrincipal;
        private System.Windows.Forms.Button btnPainelPrincipal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnQuiz;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Panel pnCreditos;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.Panel pnDicas;
        private System.Windows.Forms.Button btnDicas;
        private System.Windows.Forms.Panel pnConsequencias;
        private System.Windows.Forms.FlowLayoutPanel menuConteiner;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsequencias;
        private System.Windows.Forms.Panel pnImportancia;
        private System.Windows.Forms.Button btnImportancia;
    }
}

