using System.ComponentModel;

namespace FurnitureInventorySystem
{
    partial class UpdateSpeedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.SpeedTestLabel = new System.Windows.Forms.Label();
            this.SpeedText = new System.Windows.Forms.Label();
            this.NumberOfItems = new System.Windows.Forms.Label();
            this.SpeedTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpeedTestLabel
            // 
            this.SpeedTestLabel.AutoSize = true;
            this.SpeedTestLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpeedTestLabel.Location = new System.Drawing.Point(12, 26);
            this.SpeedTestLabel.Name = "SpeedTestLabel";
            this.SpeedTestLabel.Size = new System.Drawing.Size(375, 54);
            this.SpeedTestLabel.TabIndex = 0;
            this.SpeedTestLabel.Text = "Update Speed Test";
            // 
            // SpeedText
            // 
            this.SpeedText.AutoSize = true;
            this.SpeedText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpeedText.Location = new System.Drawing.Point(12, 115);
            this.SpeedText.Name = "SpeedText";
            this.SpeedText.Size = new System.Drawing.Size(306, 37);
            this.SpeedText.TabIndex = 2;
            this.SpeedText.Text = "You were able to update";
            this.SpeedText.Click += new System.EventHandler(this.SpeedText_Click);
            // 
            // NumberOfItems
            // 
            this.NumberOfItems.AutoSize = true;
            this.NumberOfItems.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumberOfItems.Location = new System.Drawing.Point(12, 184);
            this.NumberOfItems.Name = "NumberOfItems";
            this.NumberOfItems.Size = new System.Drawing.Size(144, 37);
            this.NumberOfItems.TabIndex = 3;
            this.NumberOfItems.Text = "500 Items";
            // 
            // SpeedTime
            // 
            this.SpeedTime.AutoSize = true;
            this.SpeedTime.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SpeedTime.Location = new System.Drawing.Point(12, 244);
            this.SpeedTime.Name = "SpeedTime";
            this.SpeedTime.Size = new System.Drawing.Size(306, 46);
            this.SpeedTime.TabIndex = 4;
            this.SpeedTime.Text = "In 250.59 seconds";
            // 
            // UpdateSpeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 312);
            this.Controls.Add(this.SpeedTime);
            this.Controls.Add(this.NumberOfItems);
            this.Controls.Add(this.SpeedText);
            this.Controls.Add(this.SpeedTestLabel);
            this.Name = "UpdateSpeedForm";
            this.Text = "SpeedForm";
            this.Load += new System.EventHandler(this.SpeedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SpeedTestLabel;
        private System.Windows.Forms.Label SpeedText;
        private System.Windows.Forms.Label NumberOfItems;
        private System.Windows.Forms.Label SpeedTime;
    }
}