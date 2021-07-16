namespace ExamplePacketPlugin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnBypass = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.Label();
            this.fromIValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromIIndex = new System.Windows.Forms.NumericUpDown();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.toIIndex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toIValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fromIValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBypass
            // 
            this.btnBypass.Location = new System.Drawing.Point(97, 109);
            this.btnBypass.Name = "btnBypass";
            this.btnBypass.Size = new System.Drawing.Size(75, 23);
            this.btnBypass.TabIndex = 0;
            this.btnBypass.Text = "Bypass";
            this.btnBypass.UseVisualStyleBackColor = true;
            this.btnBypass.Click += new System.EventHandler(this.btnBypass_Click);
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Location = new System.Drawing.Point(10, 169);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(31, 13);
            this.lbLog.TabIndex = 1;
            this.lbLog.Text = "(Log)";
            // 
            // fromIValue
            // 
            this.fromIValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fromIValue.Location = new System.Drawing.Point(12, 33);
            this.fromIValue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.fromIValue.Name = "fromIValue";
            this.fromIValue.Size = new System.Drawing.Size(75, 20);
            this.fromIValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "from iValue:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "from iIndex";
            // 
            // fromIIndex
            // 
            this.fromIIndex.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.fromIIndex.Location = new System.Drawing.Point(96, 33);
            this.fromIIndex.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.fromIIndex.Name = "fromIIndex";
            this.fromIIndex.Size = new System.Drawing.Size(75, 20);
            this.fromIIndex.TabIndex = 5;
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(47, 111);
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(41, 20);
            this.numDelay.TabIndex = 6;
            this.numDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delay:";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(12, 142);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(159, 23);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toIIndex
            // 
            this.toIIndex.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.toIIndex.Location = new System.Drawing.Point(97, 78);
            this.toIIndex.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.toIIndex.Name = "toIIndex";
            this.toIIndex.Size = new System.Drawing.Size(75, 20);
            this.toIIndex.TabIndex = 12;
            this.toIIndex.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "to iIndex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "to iValue:";
            // 
            // toIValue
            // 
            this.toIValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.toIValue.Location = new System.Drawing.Point(13, 78);
            this.toIValue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.toIValue.Name = "toIValue";
            this.toIValue.Size = new System.Drawing.Size(75, 20);
            this.toIValue.TabIndex = 9;
            this.toIValue.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 194);
            this.Controls.Add(this.toIIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toIValue);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.fromIIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromIValue);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnBypass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Map Bypass";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fromIValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBypass;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.NumericUpDown fromIValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown fromIIndex;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown toIIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown toIValue;
    }
}