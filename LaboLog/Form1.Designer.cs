namespace LaboLog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomAnimal = new System.Windows.Forms.TextBox();
            this.rbChien = new System.Windows.Forms.RadioButton();
            this.rbChat = new System.Windows.Forms.RadioButton();
            this.btnAjouterZoo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNourriture = new System.Windows.Forms.TextBox();
            this.lbldsadas = new System.Windows.Forms.Label();
            this.txtNomNourrir = new System.Windows.Forms.TextBox();
            this.btnNourrir = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnReadLog = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndexPoids = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.btnafficherLeZoo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // txtNomAnimal
            // 
            this.txtNomAnimal.Location = new System.Drawing.Point(63, 72);
            this.txtNomAnimal.Name = "txtNomAnimal";
            this.txtNomAnimal.Size = new System.Drawing.Size(141, 20);
            this.txtNomAnimal.TabIndex = 2;
            // 
            // rbChien
            // 
            this.rbChien.AutoSize = true;
            this.rbChien.Location = new System.Drawing.Point(16, 9);
            this.rbChien.Name = "rbChien";
            this.rbChien.Size = new System.Drawing.Size(52, 17);
            this.rbChien.TabIndex = 3;
            this.rbChien.TabStop = true;
            this.rbChien.Text = "Chien";
            this.rbChien.UseVisualStyleBackColor = true;
            // 
            // rbChat
            // 
            this.rbChat.AutoSize = true;
            this.rbChat.Location = new System.Drawing.Point(16, 33);
            this.rbChat.Name = "rbChat";
            this.rbChat.Size = new System.Drawing.Size(47, 17);
            this.rbChat.TabIndex = 4;
            this.rbChat.TabStop = true;
            this.rbChat.Text = "Chat";
            this.rbChat.UseVisualStyleBackColor = true;
            // 
            // btnAjouterZoo
            // 
            this.btnAjouterZoo.Location = new System.Drawing.Point(16, 98);
            this.btnAjouterZoo.Name = "btnAjouterZoo";
            this.btnAjouterZoo.Size = new System.Drawing.Size(188, 33);
            this.btnAjouterZoo.TabIndex = 5;
            this.btnAjouterZoo.Text = "Ajouter Au Zoo";
            this.btnAjouterZoo.UseVisualStyleBackColor = true;
            this.btnAjouterZoo.Click += new System.EventHandler(this.btnAjouterZoo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nourriture";
            // 
            // txtNourriture
            // 
            this.txtNourriture.Location = new System.Drawing.Point(327, 34);
            this.txtNourriture.Name = "txtNourriture";
            this.txtNourriture.Size = new System.Drawing.Size(133, 20);
            this.txtNourriture.TabIndex = 7;
            // 
            // lbldsadas
            // 
            this.lbldsadas.AutoSize = true;
            this.lbldsadas.Location = new System.Drawing.Point(257, 62);
            this.lbldsadas.Name = "lbldsadas";
            this.lbldsadas.Size = new System.Drawing.Size(63, 13);
            this.lbldsadas.TabIndex = 8;
            this.lbldsadas.Text = "Nom Animal";
            this.lbldsadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomNourrir
            // 
            this.txtNomNourrir.Location = new System.Drawing.Point(327, 62);
            this.txtNomNourrir.Name = "txtNomNourrir";
            this.txtNomNourrir.Size = new System.Drawing.Size(133, 20);
            this.txtNomNourrir.TabIndex = 9;
            // 
            // btnNourrir
            // 
            this.btnNourrir.Location = new System.Drawing.Point(262, 91);
            this.btnNourrir.Name = "btnNourrir";
            this.btnNourrir.Size = new System.Drawing.Size(197, 40);
            this.btnNourrir.TabIndex = 10;
            this.btnNourrir.Text = "Nourrir";
            this.btnNourrir.UseVisualStyleBackColor = true;
            this.btnNourrir.Click += new System.EventHandler(this.btnNourrir_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 258);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(447, 20);
            this.txtStatus.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(470, 62);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 216);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // btnReadLog
            // 
            this.btnReadLog.Location = new System.Drawing.Point(757, 29);
            this.btnReadLog.Name = "btnReadLog";
            this.btnReadLog.Size = new System.Drawing.Size(162, 24);
            this.btnReadLog.TabIndex = 14;
            this.btnReadLog.Text = "Lire le LogFile";
            this.btnReadLog.UseVisualStyleBackColor = true;
            this.btnReadLog.Click += new System.EventHandler(this.btnReadLog_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Definir le poids";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Index";
            // 
            // txtIndexPoids
            // 
            this.txtIndexPoids.Location = new System.Drawing.Point(53, 148);
            this.txtIndexPoids.Name = "txtIndexPoids";
            this.txtIndexPoids.Size = new System.Drawing.Size(100, 20);
            this.txtIndexPoids.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Poids";
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(53, 181);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(100, 20);
            this.txtPoids.TabIndex = 19;
            // 
            // btnafficherLeZoo
            // 
            this.btnafficherLeZoo.Location = new System.Drawing.Point(731, 284);
            this.btnafficherLeZoo.Name = "btnafficherLeZoo";
            this.btnafficherLeZoo.Size = new System.Drawing.Size(188, 29);
            this.btnafficherLeZoo.TabIndex = 20;
            this.btnafficherLeZoo.Text = "Afficher le Zoo";
            this.btnafficherLeZoo.UseVisualStyleBackColor = true;
            this.btnafficherLeZoo.Click += new System.EventHandler(this.btnafficherLeZoo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 332);
            this.Controls.Add(this.btnafficherLeZoo);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIndexPoids);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReadLog);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnNourrir);
            this.Controls.Add(this.txtNomNourrir);
            this.Controls.Add(this.lbldsadas);
            this.Controls.Add(this.txtNourriture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouterZoo);
            this.Controls.Add(this.rbChat);
            this.Controls.Add(this.rbChien);
            this.Controls.Add(this.txtNomAnimal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomAnimal;
        private System.Windows.Forms.RadioButton rbChien;
        private System.Windows.Forms.RadioButton rbChat;
        private System.Windows.Forms.Button btnAjouterZoo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNourriture;
        private System.Windows.Forms.Label lbldsadas;
        private System.Windows.Forms.TextBox txtNomNourrir;
        private System.Windows.Forms.Button btnNourrir;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnReadLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIndexPoids;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.Button btnafficherLeZoo;
    }
}

