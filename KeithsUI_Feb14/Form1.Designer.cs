namespace Vending_Machince
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoneyInputReadout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DollarButton = new System.Windows.Forms.Button();
            this.NickelButton = new System.Windows.Forms.Button();
            this.DimeButton = new System.Windows.Forms.Button();
            this.QuarterButton = new System.Windows.Forms.Button();
            this.ChangeReadout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CokeButton = new System.Windows.Forms.Button();
            this.OrangeCrushButton = new System.Windows.Forms.Button();
            this.GrapeFantaButton = new System.Windows.Forms.Button();
            this.PlainChipsButton = new System.Windows.Forms.Button();
            this.CheddarChipsButton = new System.Windows.Forms.Button();
            this.CheetosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoneyInputReadout
            // 
            this.MoneyInputReadout.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MoneyInputReadout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyInputReadout.ForeColor = System.Drawing.Color.Red;
            this.MoneyInputReadout.Location = new System.Drawing.Point(99, 64);
            this.MoneyInputReadout.Name = "MoneyInputReadout";
            this.MoneyInputReadout.Size = new System.Drawing.Size(96, 22);
            this.MoneyInputReadout.TabIndex = 0;
            this.MoneyInputReadout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount Inserted";
            // 
            // DollarButton
            // 
            this.DollarButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DollarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DollarButton.BackgroundImage")));
            this.DollarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DollarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DollarButton.ForeColor = System.Drawing.Color.Transparent;
            this.DollarButton.Location = new System.Drawing.Point(69, 90);
            this.DollarButton.Name = "DollarButton";
            this.DollarButton.Size = new System.Drawing.Size(126, 50);
            this.DollarButton.TabIndex = 2;
            this.DollarButton.UseVisualStyleBackColor = false;
            this.DollarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NickelButton
            // 
            this.NickelButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NickelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NickelButton.BackgroundImage")));
            this.NickelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NickelButton.Location = new System.Drawing.Point(66, 207);
            this.NickelButton.Name = "NickelButton";
            this.NickelButton.Size = new System.Drawing.Size(75, 55);
            this.NickelButton.TabIndex = 4;
            this.NickelButton.UseVisualStyleBackColor = false;
            this.NickelButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DimeButton
            // 
            this.DimeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DimeButton.BackgroundImage = global::Vending_Machince.Properties.Resources._2005_Dime_unc_GS__reverse_;
            this.DimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DimeButton.ForeColor = System.Drawing.Color.Transparent;
            this.DimeButton.Location = new System.Drawing.Point(147, 146);
            this.DimeButton.Name = "DimeButton";
            this.DimeButton.Size = new System.Drawing.Size(75, 55);
            this.DimeButton.TabIndex = 5;
            this.DimeButton.UseVisualStyleBackColor = false;
            this.DimeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // QuarterButton
            // 
            this.QuarterButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuarterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuarterButton.BackgroundImage")));
            this.QuarterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuarterButton.Location = new System.Drawing.Point(69, 146);
            this.QuarterButton.Name = "QuarterButton";
            this.QuarterButton.Size = new System.Drawing.Size(72, 55);
            this.QuarterButton.TabIndex = 6;
            this.QuarterButton.UseVisualStyleBackColor = false;
            this.QuarterButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // ChangeReadout
            // 
            this.ChangeReadout.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ChangeReadout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeReadout.ForeColor = System.Drawing.Color.Red;
            this.ChangeReadout.Location = new System.Drawing.Point(126, 273);
            this.ChangeReadout.Name = "ChangeReadout";
            this.ChangeReadout.Size = new System.Drawing.Size(96, 20);
            this.ChangeReadout.TabIndex = 7;
            this.ChangeReadout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change";
            // 
            // CokeButton
            // 
            this.CokeButton.BackColor = System.Drawing.Color.Transparent;
            this.CokeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CokeButton.BackgroundImage")));
            this.CokeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CokeButton.Location = new System.Drawing.Point(506, 35);
            this.CokeButton.Name = "CokeButton";
            this.CokeButton.Size = new System.Drawing.Size(34, 36);
            this.CokeButton.TabIndex = 9;
            this.CokeButton.UseVisualStyleBackColor = false;
            // 
            // OrangeCrushButton
            // 
            this.OrangeCrushButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrangeCrushButton.BackgroundImage")));
            this.OrangeCrushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrangeCrushButton.Location = new System.Drawing.Point(506, 77);
            this.OrangeCrushButton.Name = "OrangeCrushButton";
            this.OrangeCrushButton.Size = new System.Drawing.Size(34, 36);
            this.OrangeCrushButton.TabIndex = 10;
            this.OrangeCrushButton.UseVisualStyleBackColor = true;
            // 
            // GrapeFantaButton
            // 
            this.GrapeFantaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GrapeFantaButton.BackgroundImage")));
            this.GrapeFantaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrapeFantaButton.Location = new System.Drawing.Point(506, 119);
            this.GrapeFantaButton.Name = "GrapeFantaButton";
            this.GrapeFantaButton.Size = new System.Drawing.Size(34, 36);
            this.GrapeFantaButton.TabIndex = 11;
            this.GrapeFantaButton.UseVisualStyleBackColor = true;
            // 
            // PlainChipsButton
            // 
            this.PlainChipsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlainChipsButton.BackgroundImage")));
            this.PlainChipsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlainChipsButton.Location = new System.Drawing.Point(506, 163);
            this.PlainChipsButton.Name = "PlainChipsButton";
            this.PlainChipsButton.Size = new System.Drawing.Size(34, 36);
            this.PlainChipsButton.TabIndex = 12;
            this.PlainChipsButton.UseVisualStyleBackColor = true;
            // 
            // CheddarChipsButton
            // 
            this.CheddarChipsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheddarChipsButton.BackgroundImage")));
            this.CheddarChipsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheddarChipsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CheddarChipsButton.Location = new System.Drawing.Point(506, 203);
            this.CheddarChipsButton.Name = "CheddarChipsButton";
            this.CheddarChipsButton.Size = new System.Drawing.Size(34, 36);
            this.CheddarChipsButton.TabIndex = 13;
            this.CheddarChipsButton.UseVisualStyleBackColor = true;
            // 
            // CheetosButton
            // 
            this.CheetosButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheetosButton.BackgroundImage")));
            this.CheetosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheetosButton.Location = new System.Drawing.Point(506, 245);
            this.CheetosButton.Name = "CheetosButton";
            this.CheetosButton.Size = new System.Drawing.Size(34, 36);
            this.CheetosButton.TabIndex = 14;
            this.CheetosButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.CheddarChipsButton;
            this.ClientSize = new System.Drawing.Size(681, 324);
            this.Controls.Add(this.CheetosButton);
            this.Controls.Add(this.CheddarChipsButton);
            this.Controls.Add(this.PlainChipsButton);
            this.Controls.Add(this.GrapeFantaButton);
            this.Controls.Add(this.OrangeCrushButton);
            this.Controls.Add(this.CokeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeReadout);
            this.Controls.Add(this.QuarterButton);
            this.Controls.Add(this.DimeButton);
            this.Controls.Add(this.NickelButton);
            this.Controls.Add(this.DollarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoneyInputReadout);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Bender\'s Vending";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MoneyInputReadout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DollarButton;
        private System.Windows.Forms.Button NickelButton;
        private System.Windows.Forms.Button DimeButton;
        private System.Windows.Forms.Button QuarterButton;
        private System.Windows.Forms.TextBox ChangeReadout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CokeButton;
        private System.Windows.Forms.Button OrangeCrushButton;
        private System.Windows.Forms.Button GrapeFantaButton;
        private System.Windows.Forms.Button PlainChipsButton;
        private System.Windows.Forms.Button CheddarChipsButton;
        private System.Windows.Forms.Button CheetosButton;
    }
}

