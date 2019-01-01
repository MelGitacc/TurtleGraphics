namespace TurtleGraphics
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
			this.txtBoxCmd = new System.Windows.Forms.TextBox();
			this.RunBtn = new System.Windows.Forms.Button();
			this.DrawingArea = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
			this.SuspendLayout();
			// 
			// txtBoxCmd
			// 
			this.txtBoxCmd.Location = new System.Drawing.Point(12, 50);
			this.txtBoxCmd.Multiline = true;
			this.txtBoxCmd.Name = "txtBoxCmd";
			this.txtBoxCmd.Size = new System.Drawing.Size(203, 281);
			this.txtBoxCmd.TabIndex = 0;
			// 
			// RunBtn
			// 
			this.RunBtn.Location = new System.Drawing.Point(140, 337);
			this.RunBtn.Name = "RunBtn";
			this.RunBtn.Size = new System.Drawing.Size(75, 23);
			this.RunBtn.TabIndex = 1;
			this.RunBtn.Text = "Run";
			this.RunBtn.UseVisualStyleBackColor = true;
			// 
			// DrawingArea
			// 
			this.DrawingArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.DrawingArea.Location = new System.Drawing.Point(361, 27);
			this.DrawingArea.Name = "DrawingArea";
			this.DrawingArea.Size = new System.Drawing.Size(541, 416);
			this.DrawingArea.TabIndex = 2;
			this.DrawingArea.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(914, 450);
			this.Controls.Add(this.DrawingArea);
			this.Controls.Add(this.RunBtn);
			this.Controls.Add(this.txtBoxCmd);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBoxCmd;
		private System.Windows.Forms.Button RunBtn;
		private System.Windows.Forms.PictureBox DrawingArea;
	}
}

