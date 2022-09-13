/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 03/03/2016
 * Time: 19:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
	partial class Medals
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.NumericUpDown day;
		private System.Windows.Forms.NumericUpDown month;
		private System.Windows.Forms.NumericUpDown year;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox indexbox;
		private System.Windows.Forms.Button exit_but;
		private System.Windows.Forms.Button saveexit_but;
		private System.Windows.Forms.CheckBox flag1box;
		private System.Windows.Forms.CheckBox flag2box;
		private System.Windows.Forms.CheckBox flag3box;
		private System.Windows.Forms.CheckBox flag4box;
		private System.Windows.Forms.DateTimePicker medal_date;
		private System.Windows.Forms.CheckBox obtained;
		private System.Windows.Forms.Panel red_panel;
		private System.Windows.Forms.Button delete_but;
		private System.Windows.Forms.TextBox date_hex;
		private System.Windows.Forms.TextBox flag_hex;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		
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
		private void InitializeComponent()
		{
            this.day = new System.Windows.Forms.NumericUpDown();
            this.month = new System.Windows.Forms.NumericUpDown();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.indexbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flag1box = new System.Windows.Forms.CheckBox();
            this.flag2box = new System.Windows.Forms.CheckBox();
            this.flag3box = new System.Windows.Forms.CheckBox();
            this.flag4box = new System.Windows.Forms.CheckBox();
            this.medal_date = new System.Windows.Forms.DateTimePicker();
            this.obtained = new System.Windows.Forms.CheckBox();
            this.red_panel = new System.Windows.Forms.Panel();
            this.delete_but = new System.Windows.Forms.Button();
            this.date_hex = new System.Windows.Forms.TextBox();
            this.flag_hex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exit_but = new System.Windows.Forms.Button();
            this.saveexit_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(49, 36);
            this.day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(46, 21);
            this.day.TabIndex = 0;
            this.day.ValueChanged += new System.EventHandler(this.DayValueChanged);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(140, 36);
            this.month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(46, 21);
            this.month.TabIndex = 1;
            this.month.ValueChanged += new System.EventHandler(this.MonthValueChanged);
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(229, 36);
            this.year.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(46, 21);
            this.year.TabIndex = 2;
            this.year.ValueChanged += new System.EventHandler(this.YearValueChanged);
            // 
            // indexbox
            // 
            this.indexbox.FormattingEnabled = true;
            this.indexbox.Items.AddRange(new object[] {
            " ======= 特别奖牌 =======",
            "000 - 开始的一步",
            "001 - 目标奖励",
            "002 - 新秀奖牌得主",
            "003 - 精英奖牌得主",
            "004 - 大师奖牌得主",
            "005 - 传说奖牌得主",
            "006 - 王牌奖牌得主",
            "======= 冒险奖牌 =======",
            "007 - 轻级跑者",
            "008 - 中级跑者",
            "009 - 重级跑者",
            "010 - 名誉的足迹",
            "011 - 简短纪录者",
            "012 - 匆忙纪录者",
            "013 - 流畅纪录者",
            "014 - 奇迹笔尖",
            "015 - 宝可梦中心粉丝",
            "016 - 公告牌入门",
            "017 - 公告牌专家",
            "018 - 涂鸦千里眼",
            "019 - 初始骑行旅",
            "020 - 简单骑行旅",
            "021 - 困难骑行旅",
            "022 - 奔驰的传说",
            "023 - 破旧钓竿垂钓者",
            "024 - 好钓竿垂钓者",
            "025 - 厉害钓竿垂钓者",
            "026 - 妙手渔夫",
            "027 - 一般收集者",
            "028 - 火收集者",
            "029 - 水收集者",
            "030 - 电收集者",
            "031 - 草收集者",
            "032 - 冰收集者",
            "033 - 格斗收集者",
            "034 - 毒收集者",
            "035 - 地面收集者",
            "036 - 飞行收集者",
            "037 - 超能力收集者",
            "038 - 虫收集者",
            "039 - 岩石收集者",
            "040 - 幽灵收集者",
            "041 - 龙收集者",
            "042 - 恶收集者",
            "043 - 钢收集者",
            "044 - 合众收集者",
            "045 - 全国收集者",
            "046 - 装箱30",
            "047 - 装箱120",
            "048 - 装箱360",
            "049 - 箱子极限",
            "050 - 收服之王",
            "051 - 贩卖机大师",
            "052 - 再来一瓶",
            "053 - 进化希望",
            "054 - 进化技术高手",
            "055 - 进化专家",
            "056 - 行走的进化论",
            "057 - 王牌飞行员",
            "058 - 活化肌肉",
            "059 - 搜寻达人",
            "060 - 失物搜寻者",
            "061 - 失物猎人",
            "062 - 失物收集者",
            "063 - 探测之王",
            "064 - 起名之王",
            "065 - 电视小孩",
            "066 - 常客",
            "067 - 奢侈入门",
            "068 - 奢侈大户",
            "069 - 奢侈贵宾",
            "070 - 超级百万富翁",
            "071 - 购物能手",
            "072 - 甜蜜的家",
            "073 - 初次交错",
            "074 - 交错30",
            "075 - 交错100",
            "076 - 高峰时刻",
            "077 - 释出之力+",
            "078 - 释出之力++",
            "079 - 释出之力+++",
            "080 - 释出之力MAX",
            "081 - 迷糊收服者",
            "082 - 安眠收服者",
            "083 - 酣然收服者",
            "084 - 梦中相会",
            "085 - 隐藏洞穴达人",
            "086 - 孵蛋初学者",
            "087 - 孵蛋饲养员",
            "088 - 孵蛋运动员",
            "089 - 生命的奥秘",
            "090 - 培育屋狂",
            "091 - 古代浪漫家",
            "092 - 纯真无邪",
            "093 - 幸运色",
            "094 - 宝可病毒猎人",
            "095 - 飞云番长",
            "096 - 铁路狂",
            "097 - 吼鲸王观察者",
            "098 - 露面纪念",
            "099 - 重机狂",
            "100 - 遗迹大师",
            "101 - 冰晶",
            "102 - 桥梁狂",
            "103 - 环游合众",
            "104 - 冒险之王",
            "======= 对战奖牌 =======",
            "105 - 对战门生",
            "106 - 对战教练",
            "107 - 对战师傅",
            "108 - 历战的猛者",
            "109 - 对决新生",
            "110 - 对决先驱者",
            "111 - 对决专家",
            "112 - 为对战而生",
            "113 - 鲤鱼王奖",
            "114 - 永不言弃",
            "115 - 空打名人",
            "116 - 绝佳达人",
            "117 - 对战空档",
            "118 - 对战油门",
            "119 - 对战高速档",
            "120 - 失控特快车",
            "121 - 单人快车",
            "122 - 双人快车",
            "123 - 多人快车",
            "124 - 检定初学者",
            "125 - 检定粉丝",
            "126 - 检定狂",
            "127 - 热身大师",
            "128 - EXP百万富翁",
            "129 - ＢＰ百万富翁",
            "130 - 探索猎人",
            "131 - 对战重复者",
            "132 - 夕阳巡航",
            "133 - 帆巴最强",
            "134 - 租借之王",
            "135 - 混合之王",
            "136 - 合众最强",
            "137 - 关都最强",
            "138 - 城都最强",
            "139 - 丰缘最强",
            "140 - 神奥最强",
            "141 - 馆主最强",
            "142 - 世界最强",
            "143 - 租借之帝",
            "144 - 混合之帝",
            "145 - 全属性之王",
            "146 - 摩天楼过半",
            "147 - 摩天楼大师",
            "148 - 树洞过半",
            "149 - 树洞大师",
            "150 - 20人斩",
            "151 - 50人斩",
            "152 - 100人斩",
            "153 - 千人胜者",
            "154 - 全破简单",
            "155 - 全破大师",
            "156 - 狙击简单",
            "157 - 狙击大师",
            "158 - 速攻简单",
            "159 - 速攻大师",
            "160 - 对战将军",
            "======= 娱乐奖牌 =======",
            "161 - 最初交换",
            "162 - 慌张交换",
            "163 - 精明交换",
            "164 - 稻草富翁",
            "165 - 反转交换",
            "166 - 好朋友",
            "167 - 舞台天才",
            "168 - 出道明星",
            "169 - 中坚明星",
            "170 - 资深明星",
            "171 - 音乐剧首席",
            "172 - 时尚番长",
            "173 - 10个追随者",
            "174 - 朋友入门",
            "175 - 朋友广阔",
            "176 - 朋友拓展",
            "177 - 世界链接",
            "178 - 转蛋大师",
            "179 - 感情大师",
            "180 - 心之王牌",
            "181 - 约会达人",
            "182 - 引导新人",
            "183 - 引导精英",
            "184 - 引导老手",
            "185 - 引路之王",
            "186 - 店铺制造者",
            "187 - 店铺建造者",
            "188 - 店铺创造者",
            "189 - 商店之王",
            "190 - 便宜礼物",
            "191 - 昂贵礼物",
            "192 - 豪华礼物",
            "193 - 纪念品之王",
            "194 - 我的梦想大道",
            "195 - 小游戏爱好者",
            "196 - 小游戏狂",
            "197 - 小游戏名人",
            "198 - 最佳小游戏玩家",
            "199 - 气球新人",
            "200 - 气球技术高手",
            "201 - 气球行家",
            "202 - 气球之王",
            "203 - 新人英雄",
            "204 - 明星英雄",
            "205 - 警察电影大师",
            "206 - UFO电影大师",
            "207 - 怪兽专家",
            "208 - 科幻电影专家",
            "209 - 浪漫明星",
            "210 - 幻想大师",
            "211 - 喜剧明星",
            "212 - 惊悚明星",
            "213 - 机器人电影专家",
            "214 - 鬼怪电影大师",
            "215 - 英雄大团圆",
            "216 - 当红电影之星",
            "217 - 电影大卖",
            "218 - 名作电影之星",
            "219 - 最初的邪典",
            "220 - 邪典电影之星",
            "221 - 10人庆典",
            "222 - 30人庆典",
            "223 - 得分破百",
            "224 - 得分破千",
            "225 - 举办Lv1",
            "226 - 举办Lv2",
            "227 - 参加Lv1",
            "228 - 参加Lv2",
            "229 - 达成Lv1",
            "230 - 达成Lv2",
            "231 - 庆典完成",
            "232 - 晚安",
            "233 - 回忆的开始",
            "234 - 全部的回忆",
            "235 - 娱乐大师",
            "======= 挑战奖牌 =======",
            "236 - 一般冠军",
            "237 - 火冠军",
            "238 - 水冠军",
            "239 - 电冠军",
            "240 - 草冠军",
            "241 - 冰冠军",
            "242 - 格斗冠军",
            "243 - 毒冠军",
            "244 - 地面冠军",
            "245 - 飞行冠军",
            "246 - 超能力冠军",
            "247 - 虫冠军",
            "248 - 岩石冠军",
            "249 - 幽灵冠军",
            "250 - 龙冠军",
            "251 - 恶冠军",
            "252 - 钢冠军",
            "253 - 唯我独尊",
            "254 - 挑战天才"});
            this.indexbox.Location = new System.Drawing.Point(12, 11);
            this.indexbox.MaxDropDownItems = 10;
            this.indexbox.Name = "indexbox";
            this.indexbox.Size = new System.Drawing.Size(263, 20);
            this.indexbox.TabIndex = 4;
            this.indexbox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "日";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(101, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(192, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "年";
            // 
            // flag1box
            // 
            this.flag1box.Location = new System.Drawing.Point(12, 67);
            this.flag1box.Name = "flag1box";
            this.flag1box.Size = new System.Drawing.Size(104, 22);
            this.flag1box.TabIndex = 10;
            this.flag1box.Text = "旗标1";
            this.flag1box.UseVisualStyleBackColor = true;
            this.flag1box.CheckedChanged += new System.EventHandler(this.Flag1boxCheckedChanged);
            // 
            // flag2box
            // 
            this.flag2box.Location = new System.Drawing.Point(82, 67);
            this.flag2box.Name = "flag2box";
            this.flag2box.Size = new System.Drawing.Size(104, 22);
            this.flag2box.TabIndex = 11;
            this.flag2box.Text = "旗标2";
            this.flag2box.UseVisualStyleBackColor = true;
            this.flag2box.CheckedChanged += new System.EventHandler(this.Flag2boxCheckedChanged);
            // 
            // flag3box
            // 
            this.flag3box.Location = new System.Drawing.Point(12, 99);
            this.flag3box.Name = "flag3box";
            this.flag3box.Size = new System.Drawing.Size(104, 22);
            this.flag3box.TabIndex = 12;
            this.flag3box.Text = "旗标3";
            this.flag3box.UseVisualStyleBackColor = true;
            this.flag3box.CheckedChanged += new System.EventHandler(this.Flag3boxCheckedChanged);
            // 
            // flag4box
            // 
            this.flag4box.Location = new System.Drawing.Point(82, 99);
            this.flag4box.Name = "flag4box";
            this.flag4box.Size = new System.Drawing.Size(104, 22);
            this.flag4box.TabIndex = 13;
            this.flag4box.Text = "旗标4";
            this.flag4box.UseVisualStyleBackColor = true;
            this.flag4box.CheckedChanged += new System.EventHandler(this.Flag4boxCheckedChanged);
            // 
            // medal_date
            // 
            this.medal_date.Location = new System.Drawing.Point(12, 36);
            this.medal_date.Name = "medal_date";
            this.medal_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.medal_date.Size = new System.Drawing.Size(263, 21);
            this.medal_date.TabIndex = 14;
            this.medal_date.ValueChanged += new System.EventHandler(this.Medal_dateValueChanged);
            // 
            // obtained
            // 
            this.obtained.AutoCheck = false;
            this.obtained.Location = new System.Drawing.Point(12, 137);
            this.obtained.Name = "obtained";
            this.obtained.Size = new System.Drawing.Size(110, 21);
            this.obtained.TabIndex = 15;
            this.obtained.Text = "已获得";
            this.obtained.UseVisualStyleBackColor = true;
            // 
            // red_panel
            // 
            this.red_panel.Location = new System.Drawing.Point(12, 37);
            this.red_panel.Name = "red_panel";
            this.red_panel.Size = new System.Drawing.Size(232, 17);
            this.red_panel.TabIndex = 16;
            // 
            // delete_but
            // 
            this.delete_but.Location = new System.Drawing.Point(12, 163);
            this.delete_but.Name = "delete_but";
            this.delete_but.Size = new System.Drawing.Size(83, 32);
            this.delete_but.TabIndex = 17;
            this.delete_but.Text = "删除奖牌";
            this.delete_but.UseVisualStyleBackColor = true;
            this.delete_but.Click += new System.EventHandler(this.Delete_butClick);
            // 
            // date_hex
            // 
            this.date_hex.Location = new System.Drawing.Point(211, 67);
            this.date_hex.Name = "date_hex";
            this.date_hex.Size = new System.Drawing.Size(64, 21);
            this.date_hex.TabIndex = 18;
            // 
            // flag_hex
            // 
            this.flag_hex.Location = new System.Drawing.Point(211, 98);
            this.flag_hex.Name = "flag_hex";
            this.flag_hex.Size = new System.Drawing.Size(64, 21);
            this.flag_hex.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(140, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "数据\r\n(十六进制):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(141, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 37);
            this.label5.TabIndex = 21;
            this.label5.Text = "旗标\r\n(十六进制):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exit_but
            // 
            this.exit_but.Location = new System.Drawing.Point(178, 170);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(97, 25);
            this.exit_but.TabIndex = 8;
            this.exit_but.Text = "退出";
            this.exit_but.UseVisualStyleBackColor = true;
            this.exit_but.Click += new System.EventHandler(this.Exit_butClick);
            // 
            // saveexit_but
            // 
            this.saveexit_but.Location = new System.Drawing.Point(178, 200);
            this.saveexit_but.Name = "saveexit_but";
            this.saveexit_but.Size = new System.Drawing.Size(99, 27);
            this.saveexit_but.TabIndex = 9;
            this.saveexit_but.Text = "保存并退出";
            this.saveexit_but.UseVisualStyleBackColor = true;
            this.saveexit_but.Click += new System.EventHandler(this.Saveexit_butClick);
            // 
            // Medals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.flag_hex);
            this.Controls.Add(this.date_hex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete_but);
            this.Controls.Add(this.red_panel);
            this.Controls.Add(this.obtained);
            this.Controls.Add(this.medal_date);
            this.Controls.Add(this.flag4box);
            this.Controls.Add(this.flag3box);
            this.Controls.Add(this.flag2box);
            this.Controls.Add(this.flag1box);
            this.Controls.Add(this.saveexit_but);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indexbox);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Name = "Medals";
            this.Text = "奖牌";
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
