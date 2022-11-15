
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
            this.SuspendLayout();
            // 
            // greetings
            // 
            this.greetings.AutoSize = true;
            this.greetings.Location = new System.Drawing.Point(210, 83);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(77, 15);
            this.greetings.TabIndex = 0;
            this.greetings.Text = "Приветствие";
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
            // 
            // counterLabel
            // 
            this.counterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterLabel.Location = new System.Drawing.Point(200, 165);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(100, 23);
            this.counterLabel.TabIndex = 4;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.exerciseButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.greetings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Vocabulary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button exerciseButton;
        private System.Windows.Forms.Label counterLabel;
    }
}

