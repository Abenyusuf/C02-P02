namespace C02_P02
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
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.SetupButton = new System.Windows.Forms.Button();
            this.PunchLineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.Location = new System.Drawing.Point(283, 240);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(234, 27);
            this.DisplayLabel.TabIndex = 0;
            this.DisplayLabel.Text = "                                            ";
            this.DisplayLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SetupButton
            // 
            this.SetupButton.Location = new System.Drawing.Point(117, 69);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.Size = new System.Drawing.Size(80, 54);
            this.SetupButton.TabIndex = 1;
            this.SetupButton.Text = "Setup";
            this.SetupButton.UseVisualStyleBackColor = true;
            this.SetupButton.Click += new System.EventHandler(this.SetupButton_Click);
            // 
            // PunchLineButton
            // 
            this.PunchLineButton.Location = new System.Drawing.Point(596, 69);
            this.PunchLineButton.Name = "PunchLineButton";
            this.PunchLineButton.Size = new System.Drawing.Size(80, 54);
            this.PunchLineButton.TabIndex = 2;
            this.PunchLineButton.Text = "Punch Line";
            this.PunchLineButton.UseVisualStyleBackColor = true;
            this.PunchLineButton.Click += new System.EventHandler(this.PunchLineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PunchLineButton);
            this.Controls.Add(this.SetupButton);
            this.Controls.Add(this.DisplayLabel);
            this.Name = "Form1";
            this.Text = "Joke Buttons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Button PunchLineButton;
    }
}

