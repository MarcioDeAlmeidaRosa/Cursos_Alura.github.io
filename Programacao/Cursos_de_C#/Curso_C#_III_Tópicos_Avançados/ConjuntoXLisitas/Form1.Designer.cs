﻿namespace ConjuntoXLisitas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adiciona em Listas List<>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Adiciona Conjuntos  HashSet<>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista que sempre permite elementos dupplicados quando não checados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conjunto não ordenado que valida incusão de registro dulicado pel Equals";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Adiciona Conjuntos  SortedSet<>";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conjunto ordenado (de acordo com o tipo)  que valida incusão de registro duplicad" +
    "o pel Equals";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 38);
            this.button4.TabIndex = 6;
            this.button4.Text = "Coloções para trabalhar com chave/valor Dictionary<>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Não mantém a ordem dos elementos";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(134, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 38);
            this.button5.TabIndex = 8;
            this.button5.Text = "Coloções para trabalhar com chave/valor Sorted<>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mantém a ordem dos elementos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 409);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
    }
}

