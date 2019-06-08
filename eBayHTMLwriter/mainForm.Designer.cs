namespace eBayHTMLwriter
{
    partial class mainForm
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
            this.writeButton = new System.Windows.Forms.Button();
            this.photoLinkTB = new System.Windows.Forms.TextBox();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.mainPhotoButton = new System.Windows.Forms.Button();
            this.mainPhotoTB = new System.Windows.Forms.TextBox();
            this.addTitleButton = new System.Windows.Forms.Button();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.propInfoTB = new System.Windows.Forms.TextBox();
            this.propTitleTB = new System.Windows.Forms.TextBox();
            this.propTitleLabel = new System.Windows.Forms.Label();
            this.propInfoLabel = new System.Windows.Forms.Label();
            this.newListingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(12, 266);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 9;
            this.writeButton.Text = "&Write File";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Visible = false;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // photoLinkTB
            // 
            this.photoLinkTB.Location = new System.Drawing.Point(12, 149);
            this.photoLinkTB.Name = "photoLinkTB";
            this.photoLinkTB.Size = new System.Drawing.Size(463, 20);
            this.photoLinkTB.TabIndex = 5;
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.Location = new System.Drawing.Point(363, 175);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(112, 23);
            this.addPhotoButton.TabIndex = 6;
            this.addPhotoButton.Text = "Add &Photo Link";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // mainPhotoButton
            // 
            this.mainPhotoButton.Location = new System.Drawing.Point(339, 242);
            this.mainPhotoButton.Name = "mainPhotoButton";
            this.mainPhotoButton.Size = new System.Drawing.Size(136, 23);
            this.mainPhotoButton.TabIndex = 8;
            this.mainPhotoButton.Text = "Add &Main Photo Link";
            this.mainPhotoButton.UseVisualStyleBackColor = true;
            this.mainPhotoButton.Click += new System.EventHandler(this.mainPhotoButton_Click);
            // 
            // mainPhotoTB
            // 
            this.mainPhotoTB.Location = new System.Drawing.Point(12, 216);
            this.mainPhotoTB.Name = "mainPhotoTB";
            this.mainPhotoTB.Size = new System.Drawing.Size(463, 20);
            this.mainPhotoTB.TabIndex = 7;
            // 
            // addTitleButton
            // 
            this.addTitleButton.Location = new System.Drawing.Point(391, 44);
            this.addTitleButton.Name = "addTitleButton";
            this.addTitleButton.Size = new System.Drawing.Size(84, 23);
            this.addTitleButton.TabIndex = 1;
            this.addTitleButton.Text = "Add &Title";
            this.addTitleButton.UseVisualStyleBackColor = true;
            this.addTitleButton.Click += new System.EventHandler(this.addTitleButton_Click);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(12, 18);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(463, 20);
            this.titleTB.TabIndex = 0;
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Location = new System.Drawing.Point(391, 109);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(84, 23);
            this.addPropertyButton.TabIndex = 4;
            this.addPropertyButton.Text = "Add P&roperty";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // propInfoTB
            // 
            this.propInfoTB.Location = new System.Drawing.Point(129, 83);
            this.propInfoTB.Name = "propInfoTB";
            this.propInfoTB.Size = new System.Drawing.Size(346, 20);
            this.propInfoTB.TabIndex = 3;
            // 
            // propTitleTB
            // 
            this.propTitleTB.Location = new System.Drawing.Point(12, 83);
            this.propTitleTB.Name = "propTitleTB";
            this.propTitleTB.Size = new System.Drawing.Size(111, 20);
            this.propTitleTB.TabIndex = 2;
            // 
            // propTitleLabel
            // 
            this.propTitleLabel.AutoSize = true;
            this.propTitleLabel.Location = new System.Drawing.Point(9, 67);
            this.propTitleLabel.Name = "propTitleLabel";
            this.propTitleLabel.Size = new System.Drawing.Size(69, 13);
            this.propTitleLabel.TabIndex = 10;
            this.propTitleLabel.Text = "Property Title";
            // 
            // propInfoLabel
            // 
            this.propInfoLabel.AutoSize = true;
            this.propInfoLabel.Location = new System.Drawing.Point(129, 67);
            this.propInfoLabel.Name = "propInfoLabel";
            this.propInfoLabel.Size = new System.Drawing.Size(67, 13);
            this.propInfoLabel.TabIndex = 11;
            this.propInfoLabel.Text = "Property Info";
            // 
            // newListingButton
            // 
            this.newListingButton.Location = new System.Drawing.Point(93, 266);
            this.newListingButton.Name = "newListingButton";
            this.newListingButton.Size = new System.Drawing.Size(103, 23);
            this.newListingButton.TabIndex = 10;
            this.newListingButton.Text = "S&tart New Listing";
            this.newListingButton.UseVisualStyleBackColor = true;
            this.newListingButton.Visible = false;
            this.newListingButton.Click += new System.EventHandler(this.newListingButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 301);
            this.Controls.Add(this.newListingButton);
            this.Controls.Add(this.propInfoLabel);
            this.Controls.Add(this.propTitleLabel);
            this.Controls.Add(this.propTitleTB);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.propInfoTB);
            this.Controls.Add(this.addTitleButton);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.mainPhotoButton);
            this.Controls.Add(this.mainPhotoTB);
            this.Controls.Add(this.addPhotoButton);
            this.Controls.Add(this.photoLinkTB);
            this.Controls.Add(this.writeButton);
            this.Name = "mainForm";
            this.Text = "eBay HTML Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.TextBox photoLinkTB;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.Button mainPhotoButton;
        private System.Windows.Forms.TextBox mainPhotoTB;
        private System.Windows.Forms.Button addTitleButton;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.TextBox propInfoTB;
        private System.Windows.Forms.TextBox propTitleTB;
        private System.Windows.Forms.Label propTitleLabel;
        private System.Windows.Forms.Label propInfoLabel;
        private System.Windows.Forms.Button newListingButton;
    }
}

