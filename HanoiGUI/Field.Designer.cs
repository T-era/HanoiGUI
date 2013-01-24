namespace HanoiGUI
{
    partial class Field
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ColumnA = new HanoiGUI.Column();
            this.ColumnB = new HanoiGUI.Column();
            this.ColumnC = new HanoiGUI.Column();
            this.SuspendLayout();
            // 
            // ColumnA
            // 
            this.ColumnA.AllowDrop = true;
            this.ColumnA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColumnA.Location = new System.Drawing.Point(0, 0);
            this.ColumnA.Name = "ColumnA";
            this.ColumnA.Size = new System.Drawing.Size(50, 150);
            this.ColumnA.TabIndex = 0;
            this.ColumnA.Where = HanoiModel.Position.A;
            // 
            // ColumnB
            // 
            this.ColumnB.AllowDrop = true;
            this.ColumnB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ColumnB.Location = new System.Drawing.Point(56, 0);
            this.ColumnB.Name = "ColumnB";
            this.ColumnB.Size = new System.Drawing.Size(31, 150);
            this.ColumnB.TabIndex = 1;
            this.ColumnB.Where = HanoiModel.Position.B;
            // 
            // ColumnC
            // 
            this.ColumnC.AllowDrop = true;
            this.ColumnC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnC.Location = new System.Drawing.Point(93, 0);
            this.ColumnC.Name = "ColumnC";
            this.ColumnC.Size = new System.Drawing.Size(57, 150);
            this.ColumnC.TabIndex = 2;
            this.ColumnC.Where = HanoiModel.Position.C;
            // 
            // Field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColumnC);
            this.Controls.Add(this.ColumnB);
            this.Controls.Add(this.ColumnA);
            this.Name = "Field";
            this.SizeChanged += new System.EventHandler(this.Field_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Column ColumnA;
        private Column ColumnB;
        private Column ColumnC;
    }
}
