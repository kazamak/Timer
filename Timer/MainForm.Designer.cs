namespace Timer
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBox_ElapsedTime = new System.Windows.Forms.TextBox();
            this.button_A = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.Color_panel = new System.Windows.Forms.Panel();
            this.button_Z = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Time_Records = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_C = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_D = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Color_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_ElapsedTime
            // 
            this.TextBox_ElapsedTime.Cursor = System.Windows.Forms.Cursors.No;
            this.TextBox_ElapsedTime.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBox_ElapsedTime.Location = new System.Drawing.Point(23, 64);
            this.TextBox_ElapsedTime.Name = "TextBox_ElapsedTime";
            this.TextBox_ElapsedTime.Size = new System.Drawing.Size(191, 39);
            this.TextBox_ElapsedTime.TabIndex = 0;
            this.TextBox_ElapsedTime.Text = "00:00";
            this.TextBox_ElapsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_A
            // 
            this.button_A.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_A.Location = new System.Drawing.Point(23, 35);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(91, 23);
            this.button_A.TabIndex = 1;
            this.button_A.Text = "A";
            this.button_A.UseVisualStyleBackColor = true;
            this.button_A.Click += new System.EventHandler(this.button_A_Click);
            // 
            // button_B
            // 
            this.button_B.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_B.Location = new System.Drawing.Point(120, 35);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(94, 24);
            this.button_B.TabIndex = 2;
            this.button_B.Text = "B";
            this.button_B.UseVisualStyleBackColor = true;
            this.button_B.Click += new System.EventHandler(this.button_B_Click);
            // 
            // Color_panel
            // 
            this.Color_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_panel.Controls.Add(this.textBox1);
            this.Color_panel.Location = new System.Drawing.Point(220, 9);
            this.Color_panel.Name = "Color_panel";
            this.Color_panel.Size = new System.Drawing.Size(524, 471);
            this.Color_panel.TabIndex = 4;
            // 
            // button_Z
            // 
            this.button_Z.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Z.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Z.Location = new System.Drawing.Point(23, 443);
            this.button_Z.Name = "button_Z";
            this.button_Z.Size = new System.Drawing.Size(191, 23);
            this.button_Z.TabIndex = 5;
            this.button_Z.Text = "Z";
            this.button_Z.UseVisualStyleBackColor = true;
            this.button_Z.Click += new System.EventHandler(this.button_Z_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Time_Records
            // 
            this.Time_Records.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Time_Records.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Time_Records.Location = new System.Drawing.Point(23, 109);
            this.Time_Records.Multiline = true;
            this.Time_Records.Name = "Time_Records";
            this.Time_Records.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Time_Records.Size = new System.Drawing.Size(191, 277);
            this.Time_Records.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Version";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "COM Port";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(82, 420);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(53, 20);
            this.comboBox2.TabIndex = 10;
            // 
            // button_C
            // 
            this.button_C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_C.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_C.Location = new System.Drawing.Point(141, 418);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(73, 23);
            this.button_C.TabIndex = 11;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(129, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 103);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            // 
            // button_D
            // 
            this.button_D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_D.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_D.Location = new System.Drawing.Point(23, 393);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(191, 23);
            this.button_D.TabIndex = 12;
            this.button_D.Text = "D";
            this.button_D.UseVisualStyleBackColor = true;
            this.button_D.Click += new System.EventHandler(this.button_D_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 492);
            this.Controls.Add(this.button_D);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time_Records);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Z);
            this.Controls.Add(this.Color_panel);
            this.Controls.Add(this.button_B);
            this.Controls.Add(this.button_A);
            this.Controls.Add(this.TextBox_ElapsedTime);
            this.Name = "MainForm";
            this.Text = "TM_Timer_main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Color_panel.ResumeLayout(false);
            this.Color_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_ElapsedTime;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Panel Color_panel;
        private System.Windows.Forms.Button button_Z;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Time_Records;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button_C;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Timer timer1;
    }
}

