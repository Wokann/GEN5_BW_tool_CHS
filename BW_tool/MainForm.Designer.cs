/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 01/03/2016
 * Time: 20:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button loadsave_but;
		private System.Windows.Forms.TextBox savegamename;
		private System.Windows.Forms.Button save_but;
		private System.Windows.Forms.Label versiontext;
		private System.Windows.Forms.Button dumper_but;
		private System.Windows.Forms.Button chk_but;
		private System.Windows.Forms.Button chk_updt_but;
		private System.Windows.Forms.Button grotto_but;
		private System.Windows.Forms.Button trainer_records_but;
		private System.Windows.Forms.Button medal_but;
		private System.Windows.Forms.Button forest_but;
		private System.Windows.Forms.Button key_but;
		private System.Windows.Forms.Button join_but;
		private System.Windows.Forms.Button trainer_but;
		private System.Windows.Forms.Button about;
		private System.Windows.Forms.Button memory_but;
		private System.Windows.Forms.Button dlc_but;
		private System.Windows.Forms.Button dr_but;
		
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
			this.loadsave_but = new System.Windows.Forms.Button();
			this.savegamename = new System.Windows.Forms.TextBox();
			this.save_but = new System.Windows.Forms.Button();
			this.versiontext = new System.Windows.Forms.Label();
			this.dumper_but = new System.Windows.Forms.Button();
			this.chk_but = new System.Windows.Forms.Button();
			this.chk_updt_but = new System.Windows.Forms.Button();
			this.grotto_but = new System.Windows.Forms.Button();
			this.trainer_records_but = new System.Windows.Forms.Button();
			this.medal_but = new System.Windows.Forms.Button();
			this.forest_but = new System.Windows.Forms.Button();
			this.key_but = new System.Windows.Forms.Button();
			this.join_but = new System.Windows.Forms.Button();
			this.trainer_but = new System.Windows.Forms.Button();
			this.about = new System.Windows.Forms.Button();
			this.memory_but = new System.Windows.Forms.Button();
			this.dlc_but = new System.Windows.Forms.Button();
			this.dr_but = new System.Windows.Forms.Button();
			this.prop_but = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loadsave_but
			// 
			this.loadsave_but.Location = new System.Drawing.Point(12, 12);
			this.loadsave_but.Name = "loadsave_but";
			this.loadsave_but.Size = new System.Drawing.Size(132, 23);
			this.loadsave_but.TabIndex = 0;
			this.loadsave_but.Text = "读取存档";
			this.loadsave_but.UseVisualStyleBackColor = true;
			this.loadsave_but.Click += new System.EventHandler(this.Loadsave_butClick);
			// 
			// savegamename
			// 
			this.savegamename.Location = new System.Drawing.Point(12, 41);
			this.savegamename.Name = "savegamename";
			this.savegamename.Size = new System.Drawing.Size(484, 20);
			this.savegamename.TabIndex = 1;
			this.savegamename.TextChanged += new System.EventHandler(this.SavegamenameTextChanged);
			// 
			// save_but
			// 
			this.save_but.Enabled = false;
			this.save_but.Location = new System.Drawing.Point(421, 67);
			this.save_but.Name = "save_but";
			this.save_but.Size = new System.Drawing.Size(75, 23);
			this.save_but.TabIndex = 2;
			this.save_but.Text = "保存";
			this.save_but.UseVisualStyleBackColor = true;
			this.save_but.Click += new System.EventHandler(this.Save_butClick);
			// 
			// versiontext
			// 
			this.versiontext.Location = new System.Drawing.Point(150, 17);
			this.versiontext.Name = "versiontext";
			this.versiontext.Size = new System.Drawing.Size(100, 18);
			this.versiontext.TabIndex = 3;
			// 
			// dumper_but
			// 
			this.dumper_but.Enabled = false;
			this.dumper_but.Location = new System.Drawing.Point(323, 67);
			this.dumper_but.Name = "dumper_but";
			this.dumper_but.Size = new System.Drawing.Size(92, 23);
			this.dumper_but.TabIndex = 4;
			this.dumper_but.Text = "存档块导出";
			this.dumper_but.UseVisualStyleBackColor = true;
			this.dumper_but.Click += new System.EventHandler(this.Dumper_butClick);
			// 
			// chk_but
			// 
			this.chk_but.Enabled = false;
			this.chk_but.Location = new System.Drawing.Point(274, 12);
			this.chk_but.Name = "chk_but";
			this.chk_but.Size = new System.Drawing.Size(99, 23);
			this.chk_but.TabIndex = 5;
			this.chk_but.Text = "确认校验值";
			this.chk_but.UseVisualStyleBackColor = true;
			this.chk_but.Click += new System.EventHandler(this.Chk_butClick);
			// 
			// chk_updt_but
			// 
			this.chk_updt_but.Enabled = false;
			this.chk_updt_but.Location = new System.Drawing.Point(379, 12);
			this.chk_updt_but.Name = "chk_updt_but";
			this.chk_updt_but.Size = new System.Drawing.Size(117, 23);
			this.chk_updt_but.TabIndex = 6;
			this.chk_updt_but.Text = "更新校验值";
			this.chk_updt_but.UseVisualStyleBackColor = true;
			this.chk_updt_but.Click += new System.EventHandler(this.Chk_updt_butClick);
			// 
			// grotto_but
			// 
			this.grotto_but.Enabled = false;
			this.grotto_but.Location = new System.Drawing.Point(12, 78);
			this.grotto_but.Name = "grotto_but";
			this.grotto_but.Size = new System.Drawing.Size(140, 23);
			this.grotto_but.TabIndex = 7;
			this.grotto_but.Text = "隐藏洞穴和大量出现";
			this.grotto_but.UseVisualStyleBackColor = true;
			this.grotto_but.Click += new System.EventHandler(this.Grotto_butClick);
			// 
			// trainer_records_but
			// 
			this.trainer_records_but.Enabled = false;
			this.trainer_records_but.Location = new System.Drawing.Point(304, 107);
			this.trainer_records_but.Name = "trainer_records_but";
			this.trainer_records_but.Size = new System.Drawing.Size(140, 23);
			this.trainer_records_but.TabIndex = 8;
			this.trainer_records_but.Text = "训练家记录";
			this.trainer_records_but.UseVisualStyleBackColor = true;
			this.trainer_records_but.Visible = false;
			this.trainer_records_but.Click += new System.EventHandler(this.Trainer_records_butClick);
			// 
			// medal_but
			// 
			this.medal_but.Enabled = false;
			this.medal_but.Location = new System.Drawing.Point(12, 165);
			this.medal_but.Name = "medal_but";
			this.medal_but.Size = new System.Drawing.Size(140, 23);
			this.medal_but.TabIndex = 9;
			this.medal_but.Text = "奖牌";
			this.medal_but.UseVisualStyleBackColor = true;
			this.medal_but.Click += new System.EventHandler(this.Medal_butClick);
			// 
			// forest_but
			// 
			this.forest_but.Enabled = false;
			this.forest_but.Location = new System.Drawing.Point(158, 78);
			this.forest_but.Name = "forest_but";
			this.forest_but.Size = new System.Drawing.Size(140, 23);
			this.forest_but.TabIndex = 10;
			this.forest_but.Text = "连入之森";
			this.forest_but.UseVisualStyleBackColor = true;
			this.forest_but.Click += new System.EventHandler(this.Forest_butClick);
			// 
			// key_but
			// 
			this.key_but.Enabled = false;
			this.key_but.Location = new System.Drawing.Point(158, 136);
			this.key_but.Name = "key_but";
			this.key_but.Size = new System.Drawing.Size(140, 23);
			this.key_but.TabIndex = 11;
			this.key_but.Text = "钥匙系统";
			this.key_but.UseVisualStyleBackColor = true;
			this.key_but.Click += new System.EventHandler(this.Key_butClick);
			// 
			// join_but
			// 
			this.join_but.Enabled = false;
			this.join_but.Location = new System.Drawing.Point(12, 136);
			this.join_but.Name = "join_but";
			this.join_but.Size = new System.Drawing.Size(140, 23);
			this.join_but.TabIndex = 12;
			this.join_but.Text = "汇合大道";
			this.join_but.UseVisualStyleBackColor = true;
			this.join_but.Click += new System.EventHandler(this.Join_butClick);
			// 
			// trainer_but
			// 
			this.trainer_but.Enabled = false;
			this.trainer_but.Location = new System.Drawing.Point(158, 107);
			this.trainer_but.Name = "trainer_but";
			this.trainer_but.Size = new System.Drawing.Size(140, 23);
			this.trainer_but.TabIndex = 13;
			this.trainer_but.Text = "训练家信息";
			this.trainer_but.UseVisualStyleBackColor = true;
			this.trainer_but.Click += new System.EventHandler(this.Trainer_butClick);
			// 
			// about
			// 
			this.about.Location = new System.Drawing.Point(479, 166);
			this.about.Name = "about";
			this.about.Size = new System.Drawing.Size(17, 22);
			this.about.TabIndex = 14;
			this.about.Text = "?";
			this.about.UseVisualStyleBackColor = true;
			this.about.Click += new System.EventHandler(this.AboutClick);
			// 
			// memory_but
			// 
			this.memory_but.Enabled = false;
			this.memory_but.Location = new System.Drawing.Point(158, 165);
			this.memory_but.Name = "memory_but";
			this.memory_but.Size = new System.Drawing.Size(140, 23);
			this.memory_but.TabIndex = 15;
			this.memory_but.Text = "记忆连接";
			this.memory_but.UseVisualStyleBackColor = true;
			this.memory_but.Click += new System.EventHandler(this.Memory_butClick);
			// 
			// dlc_but
			// 
			this.dlc_but.Enabled = false;
			this.dlc_but.Location = new System.Drawing.Point(158, 194);
			this.dlc_but.Name = "dlc_but";
			this.dlc_but.Size = new System.Drawing.Size(140, 23);
			this.dlc_but.TabIndex = 16;
			this.dlc_but.Text = "DLC";
			this.dlc_but.UseVisualStyleBackColor = true;
			this.dlc_but.Visible = false;
			this.dlc_but.Click += new System.EventHandler(this.Dlc_butClick);
			// 
			// dr_but
			// 
			this.dr_but.Enabled = false;
			this.dr_but.Location = new System.Drawing.Point(12, 194);
			this.dr_but.Name = "dr_but";
			this.dr_but.Size = new System.Drawing.Size(140, 23);
			this.dr_but.TabIndex = 17;
			this.dr_but.Text = "3DS连接(AR搜寻器)";
			this.dr_but.UseVisualStyleBackColor = true;
			this.dr_but.Click += new System.EventHandler(this.Dr_butClick);
			// 
			// prop_but
			// 
			this.prop_but.Enabled = false;
			this.prop_but.Location = new System.Drawing.Point(12, 107);
			this.prop_but.Name = "prop_but";
			this.prop_but.Size = new System.Drawing.Size(140, 23);
			this.prop_but.TabIndex = 18;
			this.prop_but.Text = "物品箱";
			this.prop_but.UseVisualStyleBackColor = true;
			this.prop_but.Click += new System.EventHandler(this.Prop_butClick);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 239);
			this.Controls.Add(this.prop_but);
			this.Controls.Add(this.dr_but);
			this.Controls.Add(this.dlc_but);
			this.Controls.Add(this.memory_but);
			this.Controls.Add(this.about);
			this.Controls.Add(this.trainer_but);
			this.Controls.Add(this.join_but);
			this.Controls.Add(this.key_but);
			this.Controls.Add(this.forest_but);
			this.Controls.Add(this.medal_but);
			this.Controls.Add(this.trainer_records_but);
			this.Controls.Add(this.grotto_but);
			this.Controls.Add(this.chk_updt_but);
			this.Controls.Add(this.chk_but);
			this.Controls.Add(this.dumper_but);
			this.Controls.Add(this.versiontext);
			this.Controls.Add(this.save_but);
			this.Controls.Add(this.savegamename);
			this.Controls.Add(this.loadsave_but);
			this.Name = "MainForm";
			this.Text = "宝可梦Gen5存档工具 by suloku（汉化by卧看微尘/Wokann）";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainScreenDragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainScreenDragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button prop_but;
	}
}
