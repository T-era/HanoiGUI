namespace HanoiGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NumberOfPlates = new System.Windows.Forms.NumericUpDown();
            this.InitButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.field1 = new HanoiGUI.Field();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            // 
            // NumberOfPlates
            // 
            this.NumberOfPlates.Location = new System.Drawing.Point(12, 12);
            this.NumberOfPlates.Name = "NumberOfPlates";
            this.NumberOfPlates.Size = new System.Drawing.Size(120, 19);
            this.NumberOfPlates.TabIndex = 1;
            // 
            // InitButton
            // 
            this.InitButton.Location = new System.Drawing.Point(138, 9);
            this.InitButton.Name = "InitButton";
            this.InitButton.Size = new System.Drawing.Size(75, 23);
            this.InitButton.TabIndex = 2;
            this.InitButton.Text = "(&I)nitialize";
            this.InitButton.UseVisualStyleBackColor = true;
            this.InitButton.Click += new System.EventHandler(this.InitButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(301, 9);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 600;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // field1
            // 
            this.field1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.field1.Location = new System.Drawing.Point(12, 38);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(393, 130);
            this.field1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.InitButton);
            this.Controls.Add(this.NumberOfPlates);
            this.Controls.Add(this.field1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPlates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Field field1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown NumberOfPlates;
        private System.Windows.Forms.Button InitButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}

