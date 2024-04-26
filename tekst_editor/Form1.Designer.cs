namespace tekst_editor
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.btnSpremiKao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(26, 45);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 39);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Otvori";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(353, 45);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 39);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnBold
            // 
            this.btnBold.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBold.Location = new System.Drawing.Point(606, 45);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(31, 39);
            this.btnBold.TabIndex = 3;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnItalic.Location = new System.Drawing.Point(643, 45);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(30, 39);
            this.btnItalic.TabIndex = 4;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnderline.Location = new System.Drawing.Point(679, 45);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(33, 39);
            this.btnUnderline.TabIndex = 5;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 90);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(776, 348);
            this.txtBox.TabIndex = 6;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnSpremiKao
            // 
            this.btnSpremiKao.Location = new System.Drawing.Point(222, 45);
            this.btnSpremiKao.Name = "btnSpremiKao";
            this.btnSpremiKao.Size = new System.Drawing.Size(116, 39);
            this.btnSpremiKao.TabIndex = 7;
            this.btnSpremiKao.Text = "Spremi kao";
            this.btnSpremiKao.UseVisualStyleBackColor = true;
            this.btnSpremiKao.Click += new System.EventHandler(this.btnSpremiKao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpremiKao);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.Button btnSpremiKao;
    }
}

