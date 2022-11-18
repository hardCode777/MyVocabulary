
namespace MyVocabulary
{
    partial class ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.englishWordsList = new System.Windows.Forms.ListBox();
            this.englishText = new System.Windows.Forms.TextBox();
            this.translationText = new System.Windows.Forms.TextBox();
            this.transcriptionText = new System.Windows.Forms.TextBox();
            this.referencesText = new System.Windows.Forms.TextBox();
            this.noteText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // englishWordsList
            // 
            this.englishWordsList.FormattingEnabled = true;
            this.englishWordsList.ItemHeight = 15;
            this.englishWordsList.Location = new System.Drawing.Point(12, 9);
            this.englishWordsList.Name = "englishWordsList";
            this.englishWordsList.Size = new System.Drawing.Size(310, 409);
            this.englishWordsList.TabIndex = 0;
            // 
            // englishText
            // 
            this.englishText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.englishText.Location = new System.Drawing.Point(368, 12);
            this.englishText.Name = "englishText";
            this.englishText.Size = new System.Drawing.Size(294, 32);
            this.englishText.TabIndex = 1;
            // 
            // translationText
            // 
            this.translationText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.translationText.Location = new System.Drawing.Point(368, 68);
            this.translationText.Name = "translationText";
            this.translationText.Size = new System.Drawing.Size(294, 32);
            this.translationText.TabIndex = 2;
            
            // 
            // transcriptionText
            // 
            this.transcriptionText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transcriptionText.Location = new System.Drawing.Point(368, 125);
            this.transcriptionText.Name = "transcriptionText";
            this.transcriptionText.Size = new System.Drawing.Size(294, 32);
            this.transcriptionText.TabIndex = 3;
            
            // 
            // referencesText
            // 
            this.referencesText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.referencesText.Location = new System.Drawing.Point(368, 181);
            this.referencesText.Name = "referencesText";
            this.referencesText.Size = new System.Drawing.Size(294, 32);
            this.referencesText.TabIndex = 4;
            // 
            // noteText
            // 
            this.noteText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noteText.Location = new System.Drawing.Point(368, 241);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(294, 67);
            this.noteText.TabIndex = 5;
            
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(368, 361);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 46);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add New Word";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addNewWord);
            // 
            // resetbutton
            // 
            this.resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetbutton.Location = new System.Drawing.Point(594, 361);
            this.resetbutton.Name = "clearbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 46);
            this.resetbutton.TabIndex = 7;
            this.resetbutton.Text = "Clear";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delbutton.BackgroundImage")));
            this.Delbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Delbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delbutton.Location = new System.Drawing.Point(484, 361);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(64, 64);
            this.Delbutton.TabIndex = 8;
            this.Delbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Delbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Delbutton.UseVisualStyleBackColor = true;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.Delbutton);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.referencesText);
            this.Controls.Add(this.transcriptionText);
            this.Controls.Add(this.translationText);
            this.Controls.Add(this.englishText);
            this.Controls.Add(this.englishWordsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewForm";
            this.Text = "View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox englishWordsList;
        private System.Windows.Forms.TextBox englishText;
        private System.Windows.Forms.TextBox translationText;
        private System.Windows.Forms.TextBox transcriptionText;
        private System.Windows.Forms.TextBox referencesText;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button Delbutton;
    }
}