
namespace Lab_1
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tltExit = new System.Windows.Forms.ToolTip(this.components);
            this.tltReset = new System.Windows.Forms.ToolTip(this.components);
            this.tltEnter = new System.Windows.Forms.ToolTip(this.components);
            this.lstUnits = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.tltExit.SetToolTip(this.btnExit, "Closes the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(144, 228);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.tltReset.SetToolTip(this.btnReset, "Resets the units");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(38, 228);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 30);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "&Enter";
            this.tltReset.SetToolTip(this.btnEnter, "Adds the units");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tltExit
            // 
            this.tltExit.ToolTipTitle = "Exit";
            // 
            // tltReset
            // 
            this.tltReset.ToolTipTitle = "Reset";
            // 
            // tltEnter
            // 
            this.tltEnter.ToolTipTitle = "Enter";
            // 
            // lstUnits
            // 
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.ItemHeight = 20;
            this.lstUnits.Location = new System.Drawing.Point(93, 48);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(204, 144);
            this.lstUnits.TabIndex = 5;
            this.lstUnits.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(144, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 27);
            this.txtInput.TabIndex = 0;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(93, 15);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(45, 20);
            this.lblUnits.TabIndex = 5;
            this.lblUnits.Text = "Units:";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(250, 15);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(47, 20);
            this.lblDays.TabIndex = 6;
            this.lblDays.Text = "Day 1";
            // 
            // txtAvg
            // 
            this.txtAvg.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAvg.Location = new System.Drawing.Point(93, 195);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(204, 25);
            this.txtAvg.TabIndex = 4;
            this.txtAvg.WordWrap = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(392, 280);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lstUnits);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ToolTip tltExit;
        private System.Windows.Forms.ToolTip tltReset;
        private System.Windows.Forms.ToolTip tltEnter;
        private System.Windows.Forms.ListBox lstUnits;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtAvg;
    }
}

