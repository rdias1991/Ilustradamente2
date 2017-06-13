namespace IlustradaMente2
{
    partial class Som
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
            this.sim = new System.Windows.Forms.Button();
            this.não = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você falou em voz alta?";
            // 
            // sim
            // 
            this.sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sim.Location = new System.Drawing.Point(33, 88);
            this.sim.Name = "sim";
            this.sim.Size = new System.Drawing.Size(104, 42);
            this.sim.TabIndex = 1;
            this.sim.Text = "Sim";
            this.sim.UseVisualStyleBackColor = true;
            this.sim.Click += new System.EventHandler(this.sim_Click);
            // 
            // não
            // 
            this.não.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.não.Location = new System.Drawing.Point(269, 88);
            this.não.Name = "não";
            this.não.Size = new System.Drawing.Size(103, 42);
            this.não.TabIndex = 2;
            this.não.Text = "Não";
            this.não.UseVisualStyleBackColor = true;
            this.não.Click += new System.EventHandler(this.não_Click);
            // 
            // Som
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 155);
            this.Controls.Add(this.não);
            this.Controls.Add(this.sim);
            this.Controls.Add(this.label1);
            this.Name = "Som";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Som";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sim;
        private System.Windows.Forms.Button não;
    }
}