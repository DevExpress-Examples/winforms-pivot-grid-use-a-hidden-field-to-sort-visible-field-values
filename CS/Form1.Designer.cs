namespace Q181341 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pivotGridControl1.Location = new System.Drawing.Point(13, 36);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.Size = new System.Drawing.Size(548, 378);
			this.pivotGridControl1.TabIndex = 0;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(13, 13);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(130, 17);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Enable custom sorting";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(573, 426);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.pivotGridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}
