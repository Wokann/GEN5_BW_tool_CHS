/*
 * Created by SharpDevelop.
 * User: suloku
 * Date: 03/03/2016
 * Time: 17:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BW_tool
{
	partial class TrainerRec
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.NumericUpDown record_value;
		private System.Windows.Forms.ComboBox record_index;
		
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
		private void InitializeComponent()
		{
			this.record_value = new System.Windows.Forms.NumericUpDown();
			this.record_index = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.record_value)).BeginInit();
			this.SuspendLayout();
			// 
			// record_value
			// 
			this.record_value.Location = new System.Drawing.Point(284, 50);
			this.record_value.Maximum = new decimal(new int[]{
			-1,
			0,
			0,
			0});
			this.record_value.Name = "record_value";
			this.record_value.Size = new System.Drawing.Size(120, 20);
			this.record_value.TabIndex = 0;
			// 
			// record_index
			// 
			this.record_index.FormattingEnabled = true;
			this.record_index.Items.AddRange(new object[] {
			"001",
			"002",
			"003",
			"004",
			"005 - 野生宝可梦相遇次数",
			"006 - 对战过的训练家",
			"007",
			"008",
			"009",
			"010",
			"011",
			"012",
			"013",
			"014",
			"015",
			"016",
			"017",
			"018",
			"019",
			"020",
			"021",
			"022",
			"023",
			"024",
			"025",
			"026",
			"027",
			"028",
			"029",
			"030",
			"031",
			"032",
			"033",
			"034",
			"035",
			"036",
			"037",
			"038",
			"039",
			"040",
			"041",
			"042",
			"043",
			"044",
			"045",
			"046",
			"047",
			"048",
			"049",
			"050",
			"051",
			"052",
			"053",
			"054",
			"055",
			"056",
			"057",
			"058",
			"059",
			"060",
			"061",
			"062",
			"063",
			"064",
			"065",
			"066",
			"067",
			"068",
			"069",
			"070",
			"071",
			"072",
			"073",
			"074",
			"075",
			"076",
			"077",
			"078",
			"079",
			"080",
			"081",
			"082",
			"083",
			"084",
			"085",
			"086",
			"087",
			"088",
			"089",
			"090",
			"091",
			"092",
			"093",
			"094",
			"095",
			"096",
			"097",
			"098",
			"099",
			"100",
			"101",
			"102",
			"103",
			"104",
			"105",
			"106",
			"107",
			"108",
			"109",
			"110",
			"111",
			"112",
			"113",
			"114",
			"115",
			"116",
			"117",
			"118"});
			this.record_index.Location = new System.Drawing.Point(56, 49);
			this.record_index.Name = "record_index";
			this.record_index.Size = new System.Drawing.Size(121, 21);
			this.record_index.TabIndex = 1;
			this.record_index.SelectedIndexChanged += new System.EventHandler(this.Record_indexSelectedIndexChanged);
			// 
			// TrainerRec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 286);
			this.Controls.Add(this.record_index);
			this.Controls.Add(this.record_value);
			this.Name = "TrainerRec";
			this.Text = "训练家卡片记录编辑器";
			((System.ComponentModel.ISupportInitialize)(this.record_value)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
