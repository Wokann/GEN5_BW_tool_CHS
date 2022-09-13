/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 15/03/2021
 * Time: 20:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
	partial class PropCase
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.Proplist = new System.Windows.Forms.ComboBox();
            this.hasprop_checkbox = new System.Windows.Forms.CheckBox();
            this.unloackAllBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.propHex = new System.Windows.Forms.Label();
            this.Exit_but = new System.Windows.Forms.Button();
            this.Saveexit_but = new System.Windows.Forms.Button();
            this.spriteBox = new System.Windows.Forms.PictureBox();
            this.removeAllBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spriteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Proplist
            // 
            this.Proplist.FormattingEnabled = true;
            this.Proplist.Items.AddRange(new object[] {
            "粉色发夹",
            "蓝色发夹",
            "红色发夹",
            "蓝色花朵",
            "红色围巾",
            "红色花朵",
            "大型发夹",
            "发箍",
            "方框眼镜",
            "条纹发夹",
            "小型发夹",
            "装饰缎带",
            "手提袋",
            "项链",
            "艳丽花朵",
            "圆形纽扣",
            "绿色发夹",
            "草帽",
            "雪结晶",
            "单枝的花",
            "画笔",
            "贝雷帽",
            "打蛋器",
            "汤勺",
            "蛋糕模型",
            "厨师帽",
            "平底锅",
            "围嘴",
            "红色阳伞",
            "伤风口罩",
            "铁锤",
            "缤纷阳伞",
            "扳手",
            "手提油灯",
            "发条",
            "安全头盔",
            "褶边围裙",
            "洋装领结",
            "丝质礼帽",
            "红色披风",
            "玩具刀",
            "玩具剑",
            "海贼帽",
            "牛仔帽",
            "坚硬盾牌",
            "漆黑之翼",
            "女巫帽子",
            "纯白之翼",
            "茶色皮带",
            "带角头盔",
            "三叉戟",
            "魔杖",
            "红鼻子",
            "小丑帽",
            "晕晕眼镜",
            "王冠",
            "黑色领带",
            "黑色披风",
            "华丽眼镜",
            "褶边头带",
            "白色面具",
            "白色披风",
            "绅士帽",
            "手杖",
            "斜纹领带",
            "小怀表",
            "蝴蝶领结",
            "后冠",
            "蔷薇花",
            "单片眼镜",
            "横纹领带",
            "爆炸头",
            "立式话筒",
            "铃鼓",
            "小帽子",
            "手持话筒",
            "响葫芦",
            "喇叭",
            "桂冠",
            "白色绒球",
            "旗子",
            "球",
            "优胜腰带",
            "球拍",
            "电吉他",
            "玩具钓竿",
            "笑笑面具",
            "假肚脐",
            "博士帽",
            "草裙",
            "厚重的书",
            "捧花",
            "骨头仿品",
            "圆圆蘑菇",
            "手里剑",
            "红色帽子",
            "大布袋",
            "糖果",
            "密密胡子",
            "礼物盒"});
            this.Proplist.Location = new System.Drawing.Point(26, 26);
            this.Proplist.Name = "Proplist";
            this.Proplist.Size = new System.Drawing.Size(121, 20);
            this.Proplist.TabIndex = 0;
            this.Proplist.SelectedIndexChanged += new System.EventHandler(this.ProplistSelectedIndexChanged);
            // 
            // hasprop_checkbox
            // 
            this.hasprop_checkbox.Location = new System.Drawing.Point(168, 26);
            this.hasprop_checkbox.Name = "hasprop_checkbox";
            this.hasprop_checkbox.Size = new System.Drawing.Size(104, 22);
            this.hasprop_checkbox.TabIndex = 1;
            this.hasprop_checkbox.Text = "已获得";
            this.hasprop_checkbox.UseVisualStyleBackColor = true;
            this.hasprop_checkbox.CheckedChanged += new System.EventHandler(this.Hasprop_checkboxCheckedChanged);
            // 
            // unloackAllBut
            // 
            this.unloackAllBut.Location = new System.Drawing.Point(26, 63);
            this.unloackAllBut.Name = "unloackAllBut";
            this.unloackAllBut.Size = new System.Drawing.Size(102, 21);
            this.unloackAllBut.TabIndex = 2;
            this.unloackAllBut.Text = "解锁全部";
            this.unloackAllBut.UseVisualStyleBackColor = true;
            this.unloackAllBut.Click += new System.EventHandler(this.Button1Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "十六进制：";
            // 
            // propHex
            // 
            this.propHex.Location = new System.Drawing.Point(93, 87);
            this.propHex.Name = "propHex";
            this.propHex.Size = new System.Drawing.Size(290, 21);
            this.propHex.TabIndex = 4;
            this.propHex.Text = "0x";
            // 
            // Exit_but
            // 
            this.Exit_but.Location = new System.Drawing.Point(26, 102);
            this.Exit_but.Name = "Exit_but";
            this.Exit_but.Size = new System.Drawing.Size(102, 21);
            this.Exit_but.TabIndex = 21;
            this.Exit_but.Text = "退出";
            this.Exit_but.UseVisualStyleBackColor = true;
            this.Exit_but.Click += new System.EventHandler(this.Exit_butClick);
            // 
            // Saveexit_but
            // 
            this.Saveexit_but.Location = new System.Drawing.Point(133, 102);
            this.Saveexit_but.Name = "Saveexit_but";
            this.Saveexit_but.Size = new System.Drawing.Size(102, 21);
            this.Saveexit_but.TabIndex = 20;
            this.Saveexit_but.Text = "保存并退出";
            this.Saveexit_but.UseVisualStyleBackColor = true;
            this.Saveexit_but.Click += new System.EventHandler(this.Saveexit_butClick);
            // 
            // spriteBox
            // 
            this.spriteBox.Location = new System.Drawing.Point(254, 8);
            this.spriteBox.Name = "spriteBox";
            this.spriteBox.Size = new System.Drawing.Size(129, 73);
            this.spriteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.spriteBox.TabIndex = 22;
            this.spriteBox.TabStop = false;
            // 
            // removeAllBut
            // 
            this.removeAllBut.Location = new System.Drawing.Point(133, 63);
            this.removeAllBut.Name = "removeAllBut";
            this.removeAllBut.Size = new System.Drawing.Size(102, 21);
            this.removeAllBut.TabIndex = 23;
            this.removeAllBut.Text = "移除全部";
            this.removeAllBut.UseVisualStyleBackColor = true;
            this.removeAllBut.Click += new System.EventHandler(this.RemoveAllButClick);
            // 
            // PropCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 130);
            this.Controls.Add(this.removeAllBut);
            this.Controls.Add(this.unloackAllBut);
            this.Controls.Add(this.spriteBox);
            this.Controls.Add(this.Exit_but);
            this.Controls.Add(this.Saveexit_but);
            this.Controls.Add(this.propHex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hasprop_checkbox);
            this.Controls.Add(this.Proplist);
            this.Name = "PropCase";
            this.Text = "物品箱编辑器";
            ((System.ComponentModel.ISupportInitialize)(this.spriteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button removeAllBut;
		private System.Windows.Forms.PictureBox spriteBox;
		private System.Windows.Forms.Button Saveexit_but;
		private System.Windows.Forms.Button Exit_but;
		private System.Windows.Forms.Label propHex;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button unloackAllBut;
		private System.Windows.Forms.CheckBox hasprop_checkbox;
		private System.Windows.Forms.ComboBox Proplist;
	}
}
