﻿namespace TextAnalyzer
{
    partial class MainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            lblCharacterCount = new Label();
            label7 = new Label();
            lblSentencesCount = new Label();
            label5 = new Label();
            lblWordCount = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAnalyze = new Button();
            button2 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtInput = new RichTextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, salirToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(224, 26);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Guardar";
            salirToolStripMenuItem.Visible = false;
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(224, 26);
            guardarComoToolStripMenuItem.Text = "Guardar Como";
            guardarComoToolStripMenuItem.Visible = false;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(224, 26);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCharacterCount);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblSentencesCount);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblWordCount);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(518, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 403);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Análisis";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblCharacterCount
            // 
            lblCharacterCount.AutoSize = true;
            lblCharacterCount.Location = new Point(166, 31);
            lblCharacterCount.Name = "lblCharacterCount";
            lblCharacterCount.Size = new Size(15, 20);
            lblCharacterCount.TabIndex = 5;
            lblCharacterCount.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 31);
            label7.Name = "label7";
            label7.Size = new Size(154, 20);
            label7.TabIndex = 4;
            label7.Text = "Longitud (Carácteres):";
            label7.Click += label7_Click;
            // 
            // lblSentencesCount
            // 
            lblSentencesCount.AutoSize = true;
            lblSentencesCount.Location = new Point(90, 93);
            lblSentencesCount.Name = "lblSentencesCount";
            lblSentencesCount.Size = new Size(15, 20);
            lblSentencesCount.TabIndex = 3;
            lblSentencesCount.Text = "-";
            lblSentencesCount.Visible = false;
            lblSentencesCount.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 93);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 2;
            label5.Text = "Oraciones:";
            label5.Visible = false;
            label5.Click += label5_Click;
            // 
            // lblWordCount
            // 
            lblWordCount.AutoSize = true;
            lblWordCount.Location = new Point(76, 61);
            lblWordCount.Name = "lblWordCount";
            lblWordCount.Size = new Size(15, 20);
            lblWordCount.TabIndex = 1;
            lblWordCount.Text = "-";
            lblWordCount.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Palabras:";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 50);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Texto Analizado";
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(402, 421);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(94, 29);
            btnAnalyze.TabIndex = 4;
            btnAnalyze.Text = "Analizar";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // button2
            // 
            button2.Location = new Point(302, 421);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 450);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(47, 20);
            toolStripStatusLabel1.Text = "v 0.01";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(29, 78);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(467, 337);
            txtInput.TabIndex = 7;
            txtInput.Text = "";
            // 
            // MainWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(txtInput);
            Controls.Add(statusStrip1);
            Controls.Add(button2);
            Controls.Add(btnAnalyze);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWin";
            Text = "Analizador de texto (Boceto)";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private GroupBox groupBox1;
        private Label lblSentencesCount;
        private Label label5;
        private Label lblWordCount;
        private Label label2;
        private Label label1;
        private Button btnAnalyze;
        private Button button2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label lblCharacterCount;
        private Label label7;
        private RichTextBox txtInput;
    }
}