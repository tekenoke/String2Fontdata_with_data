
namespace String2Fontdata
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnFileLoad = new System.Windows.Forms.Button();
			this.btnFsave = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tbxChHeight = new System.Windows.Forms.TextBox();
			this.tbxChWidth = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tbxFname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxTFTgraphic = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Location = new System.Drawing.Point(12, 130);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(384, 192);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnFileLoad
			// 
			this.btnFileLoad.Location = new System.Drawing.Point(18, 20);
			this.btnFileLoad.Name = "btnFileLoad";
			this.btnFileLoad.Size = new System.Drawing.Size(138, 92);
			this.btnFileLoad.TabIndex = 1;
			this.btnFileLoad.Text = "FileRead\r\n&&\r\nConvert";
			this.btnFileLoad.UseVisualStyleBackColor = true;
			this.btnFileLoad.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnFsave
			// 
			this.btnFsave.Enabled = false;
			this.btnFsave.Location = new System.Drawing.Point(628, 20);
			this.btnFsave.Name = "btnFsave";
			this.btnFsave.Size = new System.Drawing.Size(138, 92);
			this.btnFsave.TabIndex = 3;
			this.btnFsave.Text = "Textファイル\r\n書出し\r\n(上書き確認なし)";
			this.btnFsave.UseVisualStyleBackColor = true;
			this.btnFsave.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "bmp|*.bmp|png|*.png";
			// 
			// tbxChHeight
			// 
			this.tbxChHeight.Location = new System.Drawing.Point(80, 26);
			this.tbxChHeight.Name = "tbxChHeight";
			this.tbxChHeight.Size = new System.Drawing.Size(69, 25);
			this.tbxChHeight.TabIndex = 4;
			this.tbxChHeight.Text = "---";
			// 
			// tbxChWidth
			// 
			this.tbxChWidth.Location = new System.Drawing.Point(80, 63);
			this.tbxChWidth.Name = "tbxChWidth";
			this.tbxChWidth.Size = new System.Drawing.Size(69, 25);
			this.tbxChWidth.TabIndex = 5;
			this.tbxChWidth.Text = "---";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "Width";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Height";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("ＭＳ 明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.textBox1.Location = new System.Drawing.Point(3, 612);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(754, 444);
			this.textBox1.TabIndex = 4;
			this.textBox1.TabStop = false;
			this.textBox1.WordWrap = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbxChHeight);
			this.groupBox1.Controls.Add(this.tbxChWidth);
			this.groupBox1.Location = new System.Drawing.Point(172, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 100);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "キャラクタサイズ";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "txt|*.txt|bmp|*.bmp";
			// 
			// tbxFname
			// 
			this.tbxFname.Location = new System.Drawing.Point(362, 39);
			this.tbxFname.Name = "tbxFname";
			this.tbxFname.Size = new System.Drawing.Size(241, 25);
			this.tbxFname.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(358, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 18);
			this.label3.TabIndex = 11;
			this.label3.Text = "書出しファイル名";
			// 
			// cbxTFTgraphic
			// 
			this.cbxTFTgraphic.AutoSize = true;
			this.cbxTFTgraphic.Checked = true;
			this.cbxTFTgraphic.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbxTFTgraphic.Location = new System.Drawing.Point(362, 78);
			this.cbxTFTgraphic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.cbxTFTgraphic.Name = "cbxTFTgraphic";
			this.cbxTFTgraphic.Size = new System.Drawing.Size(117, 22);
			this.cbxTFTgraphic.TabIndex = 12;
			this.cbxTFTgraphic.Text = "UniGraphic";
			this.cbxTFTgraphic.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 1060);
			this.Controls.Add(this.cbxTFTgraphic);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbxFname);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnFsave);
			this.Controls.Add(this.btnFileLoad);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "ビットマップーキャラクタコード変換";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnFileLoad;
		private System.Windows.Forms.Button btnFsave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox tbxChHeight;
		private System.Windows.Forms.TextBox tbxChWidth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox tbxFname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cbxTFTgraphic;
	}
}

