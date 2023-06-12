namespace WFprj
{
    partial class WFERaa
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
            this.components = new System.ComponentModel.Container();
            this.LblRNo = new System.Windows.Forms.Label();
            this.LblAvg = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblM2 = new System.Windows.Forms.Label();
            this.LblM1 = new System.Windows.Forms.Label();
            this.LblSName = new System.Windows.Forms.Label();
            this.tbxRNo = new System.Windows.Forms.TextBox();
            this.tbxM2 = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.tbxAvg = new System.Windows.Forms.TextBox();
            this.tbxM1 = new System.Windows.Forms.TextBox();
            this.tbxSName = new System.Windows.Forms.TextBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.rdobtnPass = new System.Windows.Forms.RadioButton();
            this.rdobtnFail = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRNo
            // 
            this.LblRNo.AutoSize = true;
            this.LblRNo.Location = new System.Drawing.Point(30, 50);
            this.LblRNo.Name = "LblRNo";
            this.LblRNo.Size = new System.Drawing.Size(52, 17);
            this.LblRNo.TabIndex = 0;
            this.LblRNo.Text = "Roll no";
            // 
            // LblAvg
            // 
            this.LblAvg.AutoSize = true;
            this.LblAvg.Location = new System.Drawing.Point(33, 300);
            this.LblAvg.Name = "LblAvg";
            this.LblAvg.Size = new System.Drawing.Size(61, 17);
            this.LblAvg.TabIndex = 2;
            this.LblAvg.Text = "Average";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(33, 250);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(40, 17);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "Total";
            // 
            // LblM2
            // 
            this.LblM2.AutoSize = true;
            this.LblM2.Location = new System.Drawing.Point(30, 200);
            this.LblM2.Name = "LblM2";
            this.LblM2.Size = new System.Drawing.Size(52, 17);
            this.LblM2.TabIndex = 4;
            this.LblM2.Text = "Mark-2";
            this.LblM2.Click += new System.EventHandler(this.Label5_Click);
            // 
            // LblM1
            // 
            this.LblM1.AutoSize = true;
            this.LblM1.Location = new System.Drawing.Point(30, 150);
            this.LblM1.Name = "LblM1";
            this.LblM1.Size = new System.Drawing.Size(52, 17);
            this.LblM1.TabIndex = 5;
            this.LblM1.Text = "Mark-1";
            // 
            // LblSName
            // 
            this.LblSName.AutoSize = true;
            this.LblSName.Location = new System.Drawing.Point(30, 100);
            this.LblSName.Name = "LblSName";
            this.LblSName.Size = new System.Drawing.Size(98, 17);
            this.LblSName.TabIndex = 6;
            this.LblSName.Text = "Student Name";
            // 
            // tbxRNo
            // 
            this.tbxRNo.Location = new System.Drawing.Point(300, 50);
            this.tbxRNo.Name = "tbxRNo";
            this.tbxRNo.Size = new System.Drawing.Size(100, 22);
            this.tbxRNo.TabIndex = 7;
            // 
            // tbxM2
            // 
            this.tbxM2.Location = new System.Drawing.Point(300, 200);
            this.tbxM2.Name = "tbxM2";
            this.tbxM2.Size = new System.Drawing.Size(100, 22);
            this.tbxM2.TabIndex = 8;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(300, 250);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(100, 22);
            this.tbxTotal.TabIndex = 9;
            // 
            // tbxAvg
            // 
            this.tbxAvg.Location = new System.Drawing.Point(300, 300);
            this.tbxAvg.Name = "tbxAvg";
            this.tbxAvg.ReadOnly = true;
            this.tbxAvg.Size = new System.Drawing.Size(100, 22);
            this.tbxAvg.TabIndex = 11;
            // 
            // tbxM1
            // 
            this.tbxM1.Location = new System.Drawing.Point(300, 150);
            this.tbxM1.Name = "tbxM1";
            this.tbxM1.Size = new System.Drawing.Size(100, 22);
            this.tbxM1.TabIndex = 12;
            this.tbxM1.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // tbxSName
            // 
            this.tbxSName.Location = new System.Drawing.Point(300, 100);
            this.tbxSName.Name = "tbxSName";
            this.tbxSName.Size = new System.Drawing.Size(100, 22);
            this.tbxSName.TabIndex = 13;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(33, 350);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(48, 17);
            this.LblResult.TabIndex = 1;
            this.LblResult.Text = "Result";
            // 
            // rdobtnPass
            // 
            this.rdobtnPass.AutoSize = true;
            this.rdobtnPass.Enabled = false;
            this.rdobtnPass.Location = new System.Drawing.Point(300, 350);
            this.rdobtnPass.Name = "rdobtnPass";
            this.rdobtnPass.Size = new System.Drawing.Size(60, 21);
            this.rdobtnPass.TabIndex = 14;
            this.rdobtnPass.TabStop = true;
            this.rdobtnPass.Text = "Pass";
            this.rdobtnPass.UseVisualStyleBackColor = true;
            // 
            // rdobtnFail
            // 
            this.rdobtnFail.AutoSize = true;
            this.rdobtnFail.Location = new System.Drawing.Point(406, 350);
            this.rdobtnFail.Name = "rdobtnFail";
            this.rdobtnFail.Size = new System.Drawing.Size(51, 21);
            this.rdobtnFail.TabIndex = 15;
            this.rdobtnFail.TabStop = true;
            this.rdobtnFail.Text = "Fail";
            this.rdobtnFail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(30, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(300, 400);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 471);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rdobtnFail);
            this.Controls.Add(this.rdobtnPass);
            this.Controls.Add(this.tbxSName);
            this.Controls.Add(this.tbxM1);
            this.Controls.Add(this.tbxAvg);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxM2);
            this.Controls.Add(this.tbxRNo);
            this.Controls.Add(this.LblSName);
            this.Controls.Add(this.LblM1);
            this.Controls.Add(this.LblM2);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblAvg);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.LblRNo);
            this.Name = "Form1";
            this.Text = "FrmERaa";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRNo;
        private System.Windows.Forms.Label LblAvg;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblM2;
        private System.Windows.Forms.Label LblM1;
        private System.Windows.Forms.Label LblSName;
        private System.Windows.Forms.TextBox tbxRNo;
        private System.Windows.Forms.TextBox tbxM2;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.TextBox tbxAvg;
        private System.Windows.Forms.TextBox tbxM1;
        private System.Windows.Forms.TextBox tbxSName;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.RadioButton rdobtnPass;
        private System.Windows.Forms.RadioButton rdobtnFail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnFind;
    }
}

