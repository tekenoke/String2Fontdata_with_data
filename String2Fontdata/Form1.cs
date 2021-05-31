using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// ビットマップをフォントデータに変換する
// Ver1.0 2021/05/31	public版

namespace String2Fontdata
{
	public partial class Form1 : Form
	{
		const int Hcount = 6, Wcount = 16;
		int charW, charH;
		String fpath;
		public Form1()
		{
			InitializeComponent();
		}

		// *** file読込&変換button ***
 		private void button1_Click(object sender, EventArgs e) { 
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string fname = openFileDialog1.FileName;	// 読込ファイル名を.txt保存用にtextboxに保持しておく
				tbxFname.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + ".txt";
				tbxFname.Refresh();
				btnFsave.Enabled = true;
				fpath = Path.GetDirectoryName(openFileDialog1.FileName);
				Image img = Image.FromFile(fname);
				pictureBox1.Image=img;
				charH = pictureBox1.Height / Hcount;
				charW = pictureBox1.Width / Wcount;
				tbxChHeight.Text = charH.ToString();
				tbxChWidth.Text = charW.ToString();
				Bitmap bmp = new Bitmap(pictureBox1.Image);
				FormationOfTwoValues(ref bmp, 0.5f);	// 安全のため２値化する
				pictureBox1.Image = bmp;
				pictureBox1.Refresh();
				bmp2chcode(ref bmp);	// code変換
			}
		}

		// *** キャラクタコード変換 ***
		private void bmp2chcode(ref Bitmap bmp) {
			int charHcount = charH / 8; // 縦のバイト数
			String strg;

			textBox1.Clear();
			if (!cbxTFTgraphic.Checked) {	// AQM LCD表示用
				strg = "const\tunsigned char\t" + Path.GetFileNameWithoutExtension(tbxFname.Text) + 
					"[96][" + charHcount.ToString() + "][" + charW.ToString() + "] = {\r\n";
				textBox1.AppendText(strg);
				for (int ivt = 0; ivt < Hcount; ivt++) {   // 文字数縦カウント(縦48bitの場合0-5)
					for (int ihl = 0; ihl < Wcount; ihl++) {    // 文字数横カウント0-15
						strg = "\t{\r\n";
						for (int iyp = 0; iyp < charHcount; iyp++) {   // 1文字縦バイトカウント
							strg += "\t\t{";
							for (int ixp = 0; ixp < charW; ixp++) {   // 1文字横ビットカウント
								int bpat = 0x1, mpat = 0x0;
								for (int bcnt = 0; bcnt < 8; bcnt++) {     // 1文字内のビットカウント
									Color color = bmp.GetPixel(ihl * charW + ixp, ivt * charH + iyp * 8 + bcnt);
									float fTemp = color.GetBrightness();
									if (fTemp < 0.5f)
									{
										mpat |= bpat;
									}
									bpat <<= 1;
								}
								strg += "0x" + mpat.ToString("X2");
								if ((ixp != (charW - 1) && ivt != (charH - 1))) strg += ", ";
							}
							strg += "}";
							if (iyp != (charHcount - 1)) {
								strg += ",";
							}
							strg += "\r\n";
						}
						strg += "\t}";
						if ((ivt != (Hcount - 1)) || (ihl != (Wcount - 1))) {	// 最終data以外は','で区切る
							strg += ",";
						}
						strg += "\r\n";
						textBox1.AppendText(strg);
					}
				}
			} else {	// UniGraphicの場合、文字数,縦バイト数,横ビット数,縦バイト数のヘッダを付ける
				strg = "const\tunsigned char\t"+ Path.GetFileNameWithoutExtension(tbxFname.Text) + 
					"[] __attribute__((aligned (2))) = {\r\n\t" + (charH / 8 * charW + 1).ToString() + ", " + charW.ToString() + ", " +
					charH.ToString() + ", " + (charH / 8).ToString() + ", \r\n";
				textBox1.AppendText(strg);
				int iyp;
				for (int ivt = 0; ivt < Hcount; ivt++) {    // 文字数縦カウント(縦48bitの場合0-5)
					for (int ihl = 0; ihl < Wcount; ihl++) {    // 文字数横カウント0-15
						int ixp;	// プロポーショナルヘッダ計算
						for (ixp = 0; ixp < charW; ixp++) {
							if (bmp.GetPixel((ihl * charW + ixp), ivt * charH).GetBrightness() < 0.5f) {	// いちばん上のビットが黒の場合はそこで終了
								bmp.SetPixel((ihl * charW + ixp), ivt * charH, Color.White); // そのビットはとりあえず白で埋めておく
								break;
							}
						}
						strg = "\t0x" + ixp.ToString("X2") + ",";
						for (int ixp2 = 0; ixp2 < charW; ixp2++) {   // 1文字横ビットカウント
							for (iyp = 0; iyp < charHcount; iyp++) {   // 1文字縦バイトカウント
								int bpat = 0x1, mpat = 0x0;
								for (int bcnt = 0; bcnt < 8; bcnt++) {     // 1文字内のビットカウント
									Color color = bmp.GetPixel(ihl * charW + ixp2, ivt * charH + iyp * 8 + bcnt);
									float fTemp = color.GetBrightness();
									if (fTemp < 0.5f) {
										mpat |= bpat;
									}
									bpat <<= 1;
								}
								strg += "0x" + mpat.ToString("X2");
								if (iyp != (charHcount - 1)) {
									strg += ",";
								}
							}
							if ((ivt != (Hcount - 1)) || (ihl != (Wcount - 1)) || (ixp2 != (charW-1))) {
								strg += ",";
							}
						}
						strg += "\r\n";
						textBox1.AppendText(strg);
					}
				}
			}
			textBox1.AppendText("};\r\n");
		}

		// *** ２値化(th:0.0～1.0)*** 
		private void FormationOfTwoValues(ref Bitmap bmp, float th) {
			Color color;

			for (Int32 y = 0; y < bmp.Size.Height; y++) {
				for (Int32 x = 0; x < bmp.Size.Width; x++) {
					color = bmp.GetPixel(x, y);
					float fTemp = color.GetBrightness();
					if (fTemp < th) {
						bmp.SetPixel(x, y, Color.Black);
					} else {
						bmp.SetPixel(x, y, Color.White);
					}
				}
			}
			return;
		}

		private void btnConvert_Click(object sender, EventArgs e) {
			FileStream fs = new FileStream(fpath+"\\"+tbxFname.Text, FileMode.Create);
			StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("shift_jis"));
			sw.Write(textBox1.Text);
			sw.Close();
			fs.Close();
		}
	}
}
