namespace HomeWork4
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.graphBox = new System.Windows.Forms.PictureBox();
            this.histoBox = new System.Windows.Forms.PictureBox();
            this.hacker = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.probability = new System.Windows.Forms.TextBox();
            this.hackerLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.probLabel = new System.Windows.Forms.Label();
            this.simulationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.graphBox.Location = new System.Drawing.Point(34, 87);
            this.graphBox.Name = "pictureBox1";
            this.graphBox.Size = new System.Drawing.Size(732, 370);
            this.graphBox.TabIndex = 0;
            this.graphBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.histoBox.Location = new System.Drawing.Point(772, 87);
            this.histoBox.Name = "pictureBox2";
            this.histoBox.Size = new System.Drawing.Size(334, 370);
            this.histoBox.TabIndex = 1;
            this.histoBox.TabStop = false;
            // 
            // textBox1
            // 
            this.hacker.Location = new System.Drawing.Point(34, 61);
            this.hacker.Name = "textBox1";
            this.hacker.Size = new System.Drawing.Size(100, 20);
            this.hacker.TabIndex = 2;
            // 
            // textBox2
            // 
            this.server.Location = new System.Drawing.Point(173, 61);
            this.server.Name = "textBox2";
            this.server.Size = new System.Drawing.Size(100, 20);
            this.server.TabIndex = 3;
            // 
            // textBox3
            // 
            this.probability.Location = new System.Drawing.Point(328, 61);
            this.probability.Name = "textBox3";
            this.probability.Size = new System.Drawing.Size(100, 20);
            this.probability.TabIndex = 4;
            // 
            // label1
            // 
            this.hackerLabel.AutoSize = true;
            this.hackerLabel.Location = new System.Drawing.Point(31, 45);
            this.hackerLabel.Name = "label1";
            this.hackerLabel.Size = new System.Drawing.Size(35, 13);
            this.hackerLabel.TabIndex = 5;
            this.hackerLabel.Text = "Number of hackers";
            // 
            // label2
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(170, 45);
            this.serverLabel.Name = "label2";
            this.serverLabel.Size = new System.Drawing.Size(35, 13);
            this.serverLabel.TabIndex = 6;
            this.serverLabel.Text = "Number of servers";
            // 
            // label3
            // 
            this.probLabel.AutoSize = true;
            this.probLabel.Location = new System.Drawing.Point(325, 45);
            this.probLabel.Name = "label3";
            this.probLabel.Size = new System.Drawing.Size(35, 13);
            this.probLabel.TabIndex = 7;
            this.probLabel.Text = "Probability of success";
            // 
            // button1
            // 
            this.simulationButton.Location = new System.Drawing.Point(772, 58);
            this.simulationButton.Name = "button1";
            this.simulationButton.Size = new System.Drawing.Size(75, 23);
            this.simulationButton.TabIndex = 8;
            this.simulationButton.Text = "Start attack";
            this.simulationButton.UseVisualStyleBackColor = true;
            this.simulationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 500);
            this.Controls.Add(this.simulationButton);
            this.Controls.Add(this.probLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.hackerLabel);
            this.Controls.Add(this.probability);
            this.Controls.Add(this.server);
            this.Controls.Add(this.hacker);
            this.Controls.Add(this.histoBox);
            this.Controls.Add(this.graphBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graphBox;
        private System.Windows.Forms.PictureBox histoBox;
        private System.Windows.Forms.TextBox hacker;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox probability;
        private System.Windows.Forms.Label hackerLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label probLabel;
        private System.Windows.Forms.Button simulationButton;
    }
}

