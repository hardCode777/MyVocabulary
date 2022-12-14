
namespace MyVocabulary
{
    partial class MainMenu
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
            this.greetings = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.exerciseButton = new System.Windows.Forms.Button();
            this.counterLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetings
            // 
            this.greetings.AutoSize = true;
            this.greetings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greetings.Location = new System.Drawing.Point(158, 71);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(203, 42);
            this.greetings.TabIndex = 0;
            this.greetings.Text = "      Congratulations !!!\r\nYou have already learned";
            // 
            // viewButton
            // 
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewButton.Location = new System.Drawing.Point(81, 288);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(92, 60);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "VIEW";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // exerciseButton
            // 
            this.exerciseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exerciseButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exerciseButton.Location = new System.Drawing.Point(328, 288);
            this.exerciseButton.Name = "exerciseButton";
            this.exerciseButton.Size = new System.Drawing.Size(87, 60);
            this.exerciseButton.TabIndex = 2;
            this.exerciseButton.Text = "Exercise";
            this.exerciseButton.UseVisualStyleBackColor = true;
            this.exerciseButton.Click += new System.EventHandler(this.exerciseButton_Click);
            // 
            // counterLabel
            // 
            this.counterLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.counterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.counterLabel.ForeColor = System.Drawing.Color.Red;
            this.counterLabel.Location = new System.Drawing.Point(170, 128);
            this.counterLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.counterLabel.Size = new System.Drawing.Size(50, 27);
            this.counterLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(251, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "words";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.exerciseButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.greetings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Vocabulary";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button exerciseButton;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label label1;
    }
}

