namespace WinFormsPermClipCalc
{
    partial class PermCalcFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermCalcFrm));
            this.comStartFinish = new System.Windows.Forms.ComboBox();
            this.lblStartFinish = new System.Windows.Forms.Label();
            this.lblHorizontalZone = new System.Windows.Forms.Label();
            this.lblVerticalZoneSize = new System.Windows.Forms.Label();
            this.txtStartFinish = new System.Windows.Forms.TextBox();
            this.txtHorizontalZone = new System.Windows.Forms.TextBox();
            this.txtVerticalZone = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPerimeterClipCalc = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lstCalculate = new System.Windows.Forms.ListBox();
            this.lblResultDefine = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comStartFinish
            // 
            this.comStartFinish.FormattingEnabled = true;
            this.comStartFinish.Items.AddRange(new object[] {
            "Start",
            "Finish"});
            this.comStartFinish.Location = new System.Drawing.Point(12, 12);
            this.comStartFinish.Name = "comStartFinish";
            this.comStartFinish.Size = new System.Drawing.Size(121, 21);
            this.comStartFinish.TabIndex = 0;
            // 
            // lblStartFinish
            // 
            this.lblStartFinish.AutoSize = true;
            this.lblStartFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartFinish.Location = new System.Drawing.Point(12, 93);
            this.lblStartFinish.Name = "lblStartFinish";
            this.lblStartFinish.Size = new System.Drawing.Size(130, 20);
            this.lblStartFinish.TabIndex = 1;
            this.lblStartFinish.Text = "Start / Finish Dim";
            // 
            // lblHorizontalZone
            // 
            this.lblHorizontalZone.AutoSize = true;
            this.lblHorizontalZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorizontalZone.Location = new System.Drawing.Point(8, 141);
            this.lblHorizontalZone.Name = "lblHorizontalZone";
            this.lblHorizontalZone.Size = new System.Drawing.Size(157, 20);
            this.lblHorizontalZone.TabIndex = 2;
            this.lblHorizontalZone.Text = "Horizontal Zone Size";
            // 
            // lblVerticalZoneSize
            // 
            this.lblVerticalZoneSize.AutoSize = true;
            this.lblVerticalZoneSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerticalZoneSize.Location = new System.Drawing.Point(12, 187);
            this.lblVerticalZoneSize.Name = "lblVerticalZoneSize";
            this.lblVerticalZoneSize.Size = new System.Drawing.Size(138, 20);
            this.lblVerticalZoneSize.TabIndex = 3;
            this.lblVerticalZoneSize.Text = "Vertical Zone Size";
            // 
            // txtStartFinish
            // 
            this.txtStartFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartFinish.Location = new System.Drawing.Point(198, 90);
            this.txtStartFinish.Name = "txtStartFinish";
            this.txtStartFinish.Size = new System.Drawing.Size(100, 26);
            this.txtStartFinish.TabIndex = 4;
            // 
            // txtHorizontalZone
            // 
            this.txtHorizontalZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorizontalZone.Location = new System.Drawing.Point(198, 138);
            this.txtHorizontalZone.Name = "txtHorizontalZone";
            this.txtHorizontalZone.Size = new System.Drawing.Size(100, 26);
            this.txtHorizontalZone.TabIndex = 5;
            // 
            // txtVerticalZone
            // 
            this.txtVerticalZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerticalZone.Location = new System.Drawing.Point(198, 184);
            this.txtVerticalZone.Name = "txtVerticalZone";
            this.txtVerticalZone.Size = new System.Drawing.Size(100, 26);
            this.txtVerticalZone.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(550, 237);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(437, 236);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 36);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPerimeterClipCalc
            // 
            this.lblPerimeterClipCalc.AutoSize = true;
            this.lblPerimeterClipCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterClipCalc.Location = new System.Drawing.Point(375, 20);
            this.lblPerimeterClipCalc.Name = "lblPerimeterClipCalc";
            this.lblPerimeterClipCalc.Size = new System.Drawing.Size(411, 25);
            this.lblPerimeterClipCalc.TabIndex = 9;
            this.lblPerimeterClipCalc.Text = "CFR PERIMETER CLIP CALCULATOR";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(358, 75);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(450, 100);
            this.lblInstructions.TabIndex = 10;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lstCalculate
            // 
            this.lstCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCalculate.FormattingEnabled = true;
            this.lstCalculate.ItemHeight = 20;
            this.lstCalculate.Location = new System.Drawing.Point(437, 290);
            this.lstCalculate.Name = "lstCalculate";
            this.lstCalculate.Size = new System.Drawing.Size(262, 84);
            this.lstCalculate.TabIndex = 11;
            // 
            // lblResultDefine
            // 
            this.lblResultDefine.AutoSize = true;
            this.lblResultDefine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultDefine.Location = new System.Drawing.Point(12, 290);
            this.lblResultDefine.Name = "lblResultDefine";
            this.lblResultDefine.Size = new System.Drawing.Size(279, 40);
            this.lblResultDefine.TabIndex = 12;
            this.lblResultDefine.Text = "THE QTY. OF PERIMETER CLIPS IN \r\nTHE CORNER ZONE IS: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(203, 310);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 20);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "888.88";
            // 
            // PermCalcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 399);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResultDefine);
            this.Controls.Add(this.lstCalculate);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblPerimeterClipCalc);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtVerticalZone);
            this.Controls.Add(this.txtHorizontalZone);
            this.Controls.Add(this.txtStartFinish);
            this.Controls.Add(this.lblVerticalZoneSize);
            this.Controls.Add(this.lblHorizontalZone);
            this.Controls.Add(this.lblStartFinish);
            this.Controls.Add(this.comStartFinish);
            this.Name = "PermCalcFrm";
            this.Text = "Perimeter Clip Calculator";
            this.Load += new System.EventHandler(this.PermCalcFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comStartFinish;
        private System.Windows.Forms.Label lblStartFinish;
        private System.Windows.Forms.Label lblHorizontalZone;
        private System.Windows.Forms.Label lblVerticalZoneSize;
        private System.Windows.Forms.TextBox txtStartFinish;
        private System.Windows.Forms.TextBox txtHorizontalZone;
        private System.Windows.Forms.TextBox txtVerticalZone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPerimeterClipCalc;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ListBox lstCalculate;
        private System.Windows.Forms.Label lblResultDefine;
        private System.Windows.Forms.Label lblResult;
    }
}

