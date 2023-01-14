
namespace _2022WITSFirstYearFinalAssignment
{
    partial class FINALASSIGN
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
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmtOwing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVatAmt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCard = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTabNo = new System.Windows.Forms.NumericUpDown();
            this.nudNoPeople = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEatin = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotCardPay = new System.Windows.Forms.Label();
            this.lblTotCashPay = new System.Windows.Forms.Label();
            this.lblAccVatamt = new System.Windows.Forms.Label();
            this.lblAccAmtown = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTabNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoPeople)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(641, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 46);
            this.label9.TabIndex = 44;
            this.label9.Text = "SO SUSHI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "VAT Amount";
            // 
            // lblAmtOwing
            // 
            this.lblAmtOwing.AutoSize = true;
            this.lblAmtOwing.Location = new System.Drawing.Point(517, 197);
            this.lblAmtOwing.Name = "lblAmtOwing";
            this.lblAmtOwing.Size = new System.Drawing.Size(40, 20);
            this.lblAmtOwing.TabIndex = 41;
            this.lblAmtOwing.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Amount Owing";
            // 
            // lblVatAmt
            // 
            this.lblVatAmt.AutoSize = true;
            this.lblVatAmt.Location = new System.Drawing.Point(892, 197);
            this.lblVatAmt.Name = "lblVatAmt";
            this.lblVatAmt.Size = new System.Drawing.Size(40, 20);
            this.lblVatAmt.TabIndex = 43;
            this.lblVatAmt.Text = "0.00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCash);
            this.groupBox2.Controls.Add(this.radCard);
            this.groupBox2.Location = new System.Drawing.Point(1061, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(312, 154);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Method";
            this.toolTip1.SetToolTip(this.groupBox2, "Please select payment method");
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(41, 118);
            this.radCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(71, 24);
            this.radCash.TabIndex = 1;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCard
            // 
            this.radCard.AutoSize = true;
            this.radCard.Location = new System.Drawing.Point(41, 55);
            this.radCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(68, 24);
            this.radCard.TabIndex = 0;
            this.radCard.TabStop = true;
            this.radCard.Text = "Card";
            this.radCard.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Table Number";
            // 
            // nudTabNo
            // 
            this.nudTabNo.Location = new System.Drawing.Point(927, 110);
            this.nudTabNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudTabNo.Name = "nudTabNo";
            this.nudTabNo.Size = new System.Drawing.Size(64, 26);
            this.nudTabNo.TabIndex = 37;
            // 
            // nudNoPeople
            // 
            this.nudNoPeople.Location = new System.Drawing.Point(621, 108);
            this.nudNoPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNoPeople.Name = "nudNoPeople";
            this.nudNoPeople.Size = new System.Drawing.Size(64, 26);
            this.nudNoPeople.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Number of people";
            // 
            // chkEatin
            // 
            this.chkEatin.AutoSize = true;
            this.chkEatin.Location = new System.Drawing.Point(336, 110);
            this.chkEatin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkEatin.Name = "chkEatin";
            this.chkEatin.Size = new System.Drawing.Size(78, 24);
            this.chkEatin.TabIndex = 34;
            this.chkEatin.Text = "Eat In";
            this.chkEatin.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(694, 520);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 58);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(310, 520);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(136, 58);
            this.btnProcess.TabIndex = 31;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1061, 520);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 58);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotCardPay);
            this.groupBox1.Controls.Add(this.lblTotCashPay);
            this.groupBox1.Controls.Add(this.lblAccVatamt);
            this.groupBox1.Controls.Add(this.lblAccAmtown);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(310, 280);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(970, 228);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary Totals";
            // 
            // lblTotCardPay
            // 
            this.lblTotCardPay.AutoSize = true;
            this.lblTotCardPay.Location = new System.Drawing.Point(811, 158);
            this.lblTotCardPay.Name = "lblTotCardPay";
            this.lblTotCardPay.Size = new System.Drawing.Size(18, 20);
            this.lblTotCardPay.TabIndex = 7;
            this.lblTotCardPay.Text = "0";
            // 
            // lblTotCashPay
            // 
            this.lblTotCashPay.AutoSize = true;
            this.lblTotCashPay.Location = new System.Drawing.Point(811, 54);
            this.lblTotCashPay.Name = "lblTotCashPay";
            this.lblTotCashPay.Size = new System.Drawing.Size(18, 20);
            this.lblTotCashPay.TabIndex = 6;
            this.lblTotCashPay.Text = "0";
            // 
            // lblAccVatamt
            // 
            this.lblAccVatamt.AutoSize = true;
            this.lblAccVatamt.Location = new System.Drawing.Point(307, 158);
            this.lblAccVatamt.Name = "lblAccVatamt";
            this.lblAccVatamt.Size = new System.Drawing.Size(40, 20);
            this.lblAccVatamt.TabIndex = 5;
            this.lblAccVatamt.Text = "0.00";
            // 
            // lblAccAmtown
            // 
            this.lblAccAmtown.AutoSize = true;
            this.lblAccAmtown.Location = new System.Drawing.Point(307, 54);
            this.lblAccAmtown.Name = "lblAccAmtown";
            this.lblAccAmtown.Size = new System.Drawing.Size(40, 20);
            this.lblAccAmtown.TabIndex = 4;
            this.lblAccAmtown.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total Card Payments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Accumulated VAT amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Cash Payments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Accumulated Amount Owing";
            // 
            // FINALASSIGN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 622);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAmtOwing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVatAmt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTabNo);
            this.Controls.Add(this.nudNoPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEatin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "FINALASSIGN";
            this.Text = "O.N WITS FINAL ASSIGNMENT 2022";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTabNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoPeople)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmtOwing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVatAmt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCard;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTabNo;
        private System.Windows.Forms.NumericUpDown nudNoPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkEatin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotCardPay;
        private System.Windows.Forms.Label lblTotCashPay;
        private System.Windows.Forms.Label lblAccVatamt;
        private System.Windows.Forms.Label lblAccAmtown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

