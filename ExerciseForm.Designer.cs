
namespace MyVocabulary
{
    partial class ExerciseForm
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
            this.ListExercise = new System.Windows.Forms.ListBox();
            this.trueFalseLable = new System.Windows.Forms.Label();
            this.exerciseTextArea = new System.Windows.Forms.TextBox();
            this.languageCheckBox = new System.Windows.Forms.CheckBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListExercise
            // 
            this.ListExercise.FormattingEnabled = true;
            this.ListExercise.ItemHeight = 15;
            this.ListExercise.Location = new System.Drawing.Point(12, 12);
            this.ListExercise.Name = "ListExercise";
            this.ListExercise.Size = new System.Drawing.Size(310, 409);
            this.ListExercise.TabIndex = 1;
            // 
            // trueFalseLable
            // 
            this.trueFalseLable.AutoEllipsis = true;
            this.trueFalseLable.AutoSize = true;
            this.trueFalseLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trueFalseLable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trueFalseLable.Location = new System.Drawing.Point(425, 39);
            this.trueFalseLable.Name = "trueFalseLable";
            this.trueFalseLable.Size = new System.Drawing.Size(132, 23);
            this.trueFalseLable.TabIndex = 2;
            this.trueFalseLable.Text = "Верно / Неверно";
            // 
            // exerciseTextArea
            // 
            this.exerciseTextArea.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exerciseTextArea.Location = new System.Drawing.Point(348, 96);
            this.exerciseTextArea.Name = "exerciseTextArea";
            this.exerciseTextArea.Size = new System.Drawing.Size(294, 32);
            this.exerciseTextArea.TabIndex = 3;
            // 
            // languageCheckBox
            // 
            this.languageCheckBox.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.languageCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.languageCheckBox.Location = new System.Drawing.Point(434, 268);
            this.languageCheckBox.Name = "languageCheckBox";
            this.languageCheckBox.Size = new System.Drawing.Size(104, 45);
            this.languageCheckBox.TabIndex = 4;
            this.languageCheckBox.Text = "Eng / rus";
            this.languageCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.languageCheckBox.UseVisualStyleBackColor = true;
            this.languageCheckBox.CheckedChanged += new System.EventHandler(this.languageCheckBox_CheckedChanged);
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(447, 190);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(75, 23);
            this.compareButton.TabIndex = 5;
            this.compareButton.Text = "COMPARE";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(558, 149);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ExerciseForm
            // 
            this.AcceptButton = this.compareButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.languageCheckBox);
            this.Controls.Add(this.exerciseTextArea);
            this.Controls.Add(this.trueFalseLable);
            this.Controls.Add(this.ListExercise);
            this.MaximizeBox = false;
            this.Name = "ExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eng / Rus";
            this.Load += new System.EventHandler(this.ExerciseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListExercise;
        private System.Windows.Forms.Label trueFalseLable;
        private System.Windows.Forms.TextBox exerciseTextArea;
        private System.Windows.Forms.CheckBox languageCheckBox;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Button clearButton;
    }
}