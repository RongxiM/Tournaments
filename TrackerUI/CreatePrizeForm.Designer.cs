namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.headerLable = new System.Windows.Forms.Label();
            this.orLable = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.PlaceNumberLable = new System.Windows.Forms.Label();
            this.placeNameLable = new System.Windows.Forms.Label();
            this.prizeAmountLable = new System.Windows.Forms.Label();
            this.prizePercentageLable = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Segoe UI Light", 27.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLable.Location = new System.Drawing.Point(23, 28);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(364, 87);
            this.headerLable.TabIndex = 15;
            this.headerLable.Text = "Create Prize";
            // 
            // orLable
            // 
            this.orLable.AutoSize = true;
            this.orLable.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.orLable.Location = new System.Drawing.Point(364, 508);
            this.orLable.Name = "orLable";
            this.orLable.Size = new System.Drawing.Size(111, 65);
            this.orLable.TabIndex = 24;
            this.orLable.Text = "-or-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(224, 754);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(390, 124);
            this.createPrizeButton.TabIndex = 29;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // PlaceNumberLable
            // 
            this.PlaceNumberLable.AutoSize = true;
            this.PlaceNumberLable.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceNumberLable.Location = new System.Drawing.Point(71, 161);
            this.PlaceNumberLable.Name = "PlaceNumberLable";
            this.PlaceNumberLable.Size = new System.Drawing.Size(325, 65);
            this.PlaceNumberLable.TabIndex = 30;
            this.PlaceNumberLable.Text = "Place Number";
            // 
            // placeNameLable
            // 
            this.placeNameLable.AutoSize = true;
            this.placeNameLable.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLable.Location = new System.Drawing.Point(71, 282);
            this.placeNameLable.Name = "placeNameLable";
            this.placeNameLable.Size = new System.Drawing.Size(277, 65);
            this.placeNameLable.TabIndex = 31;
            this.placeNameLable.Text = "Place Name";
            // 
            // prizeAmountLable
            // 
            this.prizeAmountLable.AutoSize = true;
            this.prizeAmountLable.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLable.Location = new System.Drawing.Point(71, 395);
            this.prizeAmountLable.Name = "prizeAmountLable";
            this.prizeAmountLable.Size = new System.Drawing.Size(314, 65);
            this.prizeAmountLable.TabIndex = 32;
            this.prizeAmountLable.Text = "Prize Amount";
            // 
            // prizePercentageLable
            // 
            this.prizePercentageLable.AutoSize = true;
            this.prizePercentageLable.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLable.Location = new System.Drawing.Point(71, 625);
            this.prizePercentageLable.Name = "prizePercentageLable";
            this.prizePercentageLable.Size = new System.Drawing.Size(378, 65);
            this.prizePercentageLable.TabIndex = 33;
            this.prizePercentageLable.Text = "Prize Percentage";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(455, 168);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(325, 57);
            this.placeNumberValue.TabIndex = 34;
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(455, 289);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(325, 57);
            this.placeNameValue.TabIndex = 35;
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(455, 403);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(325, 57);
            this.prizeAmountValue.TabIndex = 36;
            this.prizeAmountValue.Text = "0";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(455, 633);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(325, 57);
            this.prizePercentageValue.TabIndex = 37;
            this.prizePercentageValue.Text = "0";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 950);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.prizePercentageLable);
            this.Controls.Add(this.prizeAmountLable);
            this.Controls.Add(this.placeNameLable);
            this.Controls.Add(this.PlaceNumberLable);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLable);
            this.Controls.Add(this.headerLable);
            this.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLable;
        private System.Windows.Forms.Label orLable;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label PlaceNumberLable;
        private System.Windows.Forms.Label placeNameLable;
        private System.Windows.Forms.Label prizeAmountLable;
        private System.Windows.Forms.Label prizePercentageLable;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.TextBox prizePercentageValue;
    }
}