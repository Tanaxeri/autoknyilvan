namespace autoknyilvan
{
    partial class AutoGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoGUI));
            this.Autok = new System.Windows.Forms.ListBox();
            this.Kivalasztottautoadatai = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdText = new System.Windows.Forms.TextBox();
            this.RendszamText = new System.Windows.Forms.TextBox();
            this.SzinText = new System.Windows.Forms.TextBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.EvjaratNum = new System.Windows.Forms.NumericUpDown();
            this.ujautobutton = new System.Windows.Forms.Button();
            this.Modositbutton = new System.Windows.Forms.Button();
            this.Torolbutton = new System.Windows.Forms.Button();
            this.Kivalasztottautoadatai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvjaratNum)).BeginInit();
            this.SuspendLayout();
            // 
            // Autok
            // 
            this.Autok.Dock = System.Windows.Forms.DockStyle.Left;
            this.Autok.FormattingEnabled = true;
            this.Autok.Location = new System.Drawing.Point(0, 0);
            this.Autok.Name = "Autok";
            this.Autok.Size = new System.Drawing.Size(120, 450);
            this.Autok.TabIndex = 0;
            // 
            // Kivalasztottautoadatai
            // 
            this.Kivalasztottautoadatai.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Kivalasztottautoadatai.Controls.Add(this.Torolbutton);
            this.Kivalasztottautoadatai.Controls.Add(this.Modositbutton);
            this.Kivalasztottautoadatai.Controls.Add(this.ujautobutton);
            this.Kivalasztottautoadatai.Controls.Add(this.EvjaratNum);
            this.Kivalasztottautoadatai.Controls.Add(this.SzinText);
            this.Kivalasztottautoadatai.Controls.Add(this.RendszamText);
            this.Kivalasztottautoadatai.Controls.Add(this.IdText);
            this.Kivalasztottautoadatai.Controls.Add(this.label4);
            this.Kivalasztottautoadatai.Controls.Add(this.label3);
            this.Kivalasztottautoadatai.Controls.Add(this.label2);
            this.Kivalasztottautoadatai.Controls.Add(this.label1);
            this.Kivalasztottautoadatai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kivalasztottautoadatai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kivalasztottautoadatai.Location = new System.Drawing.Point(120, 0);
            this.Kivalasztottautoadatai.Name = "Kivalasztottautoadatai";
            this.Kivalasztottautoadatai.Size = new System.Drawing.Size(680, 450);
            this.Kivalasztottautoadatai.TabIndex = 1;
            this.Kivalasztottautoadatai.TabStop = false;
            this.Kivalasztottautoadatai.Text = "Kiválasztott autó adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rendszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Évjárat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Szín:";
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(97, 36);
            this.IdText.Name = "IdText";
            this.IdText.ReadOnly = true;
            this.IdText.Size = new System.Drawing.Size(83, 26);
            this.IdText.TabIndex = 4;
            // 
            // RendszamText
            // 
            this.RendszamText.Location = new System.Drawing.Point(97, 69);
            this.RendszamText.Name = "RendszamText";
            this.RendszamText.Size = new System.Drawing.Size(100, 26);
            this.RendszamText.TabIndex = 5;
            // 
            // SzinText
            // 
            this.SzinText.Location = new System.Drawing.Point(97, 133);
            this.SzinText.Name = "SzinText";
            this.SzinText.Size = new System.Drawing.Size(100, 26);
            this.SzinText.TabIndex = 7;
            // 
            // EvjaratNum
            // 
            this.EvjaratNum.Location = new System.Drawing.Point(97, 101);
            this.EvjaratNum.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.EvjaratNum.Minimum = new decimal(new int[] {
            1916,
            0,
            0,
            0});
            this.EvjaratNum.Name = "EvjaratNum";
            this.EvjaratNum.Size = new System.Drawing.Size(70, 26);
            this.EvjaratNum.TabIndex = 8;
            this.EvjaratNum.Value = new decimal(new int[] {
            1916,
            0,
            0,
            0});
            // 
            // ujautobutton
            // 
            this.ujautobutton.Location = new System.Drawing.Point(16, 189);
            this.ujautobutton.Name = "ujautobutton";
            this.ujautobutton.Size = new System.Drawing.Size(80, 33);
            this.ujautobutton.TabIndex = 9;
            this.ujautobutton.Text = "Új Autó";
            this.ujautobutton.UseVisualStyleBackColor = true;
            this.ujautobutton.Click += new System.EventHandler(this.ujautobutton_Click);
            // 
            // Modositbutton
            // 
            this.Modositbutton.Location = new System.Drawing.Point(122, 189);
            this.Modositbutton.Name = "Modositbutton";
            this.Modositbutton.Size = new System.Drawing.Size(91, 33);
            this.Modositbutton.TabIndex = 10;
            this.Modositbutton.Text = "Módosítás";
            this.Modositbutton.UseVisualStyleBackColor = true;
            // 
            // Torolbutton
            // 
            this.Torolbutton.Location = new System.Drawing.Point(233, 189);
            this.Torolbutton.Name = "Torolbutton";
            this.Torolbutton.Size = new System.Drawing.Size(75, 33);
            this.Torolbutton.TabIndex = 11;
            this.Torolbutton.Text = "Törlés";
            this.Torolbutton.UseVisualStyleBackColor = true;
            // 
            // AutoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kivalasztottautoadatai);
            this.Controls.Add(this.Autok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoGUI";
            this.Text = "AutokNyilvanTartasa";
            this.Load += new System.EventHandler(this.AutoGUI_Load);
            this.Kivalasztottautoadatai.ResumeLayout(false);
            this.Kivalasztottautoadatai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EvjaratNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Autok;
        private System.Windows.Forms.GroupBox Kivalasztottautoadatai;
        private System.Windows.Forms.TextBox SzinText;
        private System.Windows.Forms.TextBox RendszamText;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EvjaratNum;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Button ujautobutton;
        private System.Windows.Forms.Button Torolbutton;
        private System.Windows.Forms.Button Modositbutton;
    }
}

