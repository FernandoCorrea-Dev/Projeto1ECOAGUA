namespace EcoÁgua
{
    partial class formQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rbtnOption3 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new ReaLTaiizor.Controls.Button();
            this.rbtnOption1 = new System.Windows.Forms.RadioButton();
            this.rbtnOption2 = new System.Windows.Forms.RadioButton();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblQuestion = new System.Windows.Forms.RichTextBox();
            this.lblExplanation = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnOption3
            // 
            this.rbtnOption3.AutoSize = true;
            this.rbtnOption3.BackColor = System.Drawing.Color.White;
            this.rbtnOption3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOption3.ForeColor = System.Drawing.Color.Black;
            this.rbtnOption3.Location = new System.Drawing.Point(12, 234);
            this.rbtnOption3.Name = "rbtnOption3";
            this.rbtnOption3.Size = new System.Drawing.Size(121, 36);
            this.rbtnOption3.TabIndex = 1;
            this.rbtnOption3.TabStop = true;
            this.rbtnOption3.Text = "Opção 3";
            this.rbtnOption3.UseVisualStyleBackColor = false;
            this.rbtnOption3.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.EnteredBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.EnteredColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Image = null;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.InactiveColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(11, 311);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PressedBorderColor = System.Drawing.Color.White;
            this.btnSubmit.PressedColor = System.Drawing.Color.White;
            this.btnSubmit.Size = new System.Drawing.Size(253, 65);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Confirmar ";
            this.btnSubmit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSubmit.EnabledChanged += new System.EventHandler(this.Option_CheckedChanged);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbtnOption1
            // 
            this.rbtnOption1.AutoSize = true;
            this.rbtnOption1.BackColor = System.Drawing.Color.White;
            this.rbtnOption1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOption1.ForeColor = System.Drawing.Color.Black;
            this.rbtnOption1.Location = new System.Drawing.Point(11, 118);
            this.rbtnOption1.Name = "rbtnOption1";
            this.rbtnOption1.Size = new System.Drawing.Size(121, 36);
            this.rbtnOption1.TabIndex = 4;
            this.rbtnOption1.TabStop = true;
            this.rbtnOption1.Text = "Opção 1";
            this.rbtnOption1.UseVisualStyleBackColor = false;
            this.rbtnOption1.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rbtnOption2
            // 
            this.rbtnOption2.AutoSize = true;
            this.rbtnOption2.BackColor = System.Drawing.Color.White;
            this.rbtnOption2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOption2.ForeColor = System.Drawing.Color.Black;
            this.rbtnOption2.Location = new System.Drawing.Point(11, 174);
            this.rbtnOption2.Name = "rbtnOption2";
            this.rbtnOption2.Size = new System.Drawing.Size(121, 36);
            this.rbtnOption2.TabIndex = 3;
            this.rbtnOption2.TabStop = true;
            this.rbtnOption2.Text = "Opção 2";
            this.rbtnOption2.UseVisualStyleBackColor = false;
            this.rbtnOption2.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(603, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 803);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(29, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(225, 1108);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(52, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(173, 1101);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(38, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(135, 1108);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // lblQuestion
            // 
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 12);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(578, 100);
            this.lblQuestion.TabIndex = 11;
            this.lblQuestion.Text = "";
            // 
            // lblExplanation
            // 
            this.lblExplanation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblExplanation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanation.Location = new System.Drawing.Point(12, 399);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(591, 336);
            this.lblExplanation.TabIndex = 12;
            this.lblExplanation.Text = "";
            this.lblExplanation.Click += new System.EventHandler(this.btnSubmit_Click);
            this.lblExplanation.TextChanged += new System.EventHandler(this.lblExplanation_TextChanged);
            this.lblExplanation.VisibleChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // formQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 820);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbtnOption1);
            this.Controls.Add(this.rbtnOption3);
            this.Controls.Add(this.rbtnOption2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formQuiz";
            this.Text = "formQuiz";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnOption3;
        private System.Windows.Forms.RadioButton rbtnOption1;
        private System.Windows.Forms.RadioButton rbtnOption2;
        private ReaLTaiizor.Controls.Button btnSubmit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RichTextBox lblQuestion;
        private System.Windows.Forms.RichTextBox lblExplanation;
    }
}