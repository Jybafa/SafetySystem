﻿namespace SafetySystem
{
	partial class SafetySystem
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafetySystem));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.work_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.time_refresh = new System.Windows.Forms.NumericUpDown();
			this.textBox_thing = new System.Windows.Forms.TextBox();
			this.textBox_service = new System.Windows.Forms.TextBox();
			this.textBox_key = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_server = new System.Windows.Forms.TextBox();
			this.textBox_log = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.button_load = new System.Windows.Forms.Button();
			this.listBox_UserParameters = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_range_1 = new System.Windows.Forms.TextBox();
			this.textBox_range_2 = new System.Windows.Forms.TextBox();
			this.textBox_range_3 = new System.Windows.Forms.TextBox();
			this.button_test_1 = new System.Windows.Forms.Button();
			this.button_test_2 = new System.Windows.Forms.Button();
			this.button_test_3 = new System.Windows.Forms.Button();
			this.button_test_4 = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.time_refresh)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.work_status,
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 534);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(773, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// work_status
			// 
			this.work_status.Name = "work_status";
			this.work_status.Size = new System.Drawing.Size(132, 17);
			this.work_status.Text = "Отправка остановлена";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// time_refresh
			// 
			this.time_refresh.Location = new System.Drawing.Point(573, 8);
			this.time_refresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.time_refresh.Name = "time_refresh";
			this.time_refresh.ReadOnly = true;
			this.time_refresh.Size = new System.Drawing.Size(47, 20);
			this.time_refresh.TabIndex = 5;
			this.toolTip1.SetToolTip(this.time_refresh, "Задержка перед отправкой запроса. Измеряется в секундах");
			this.time_refresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.time_refresh.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// textBox_thing
			// 
			this.textBox_thing.Location = new System.Drawing.Point(61, 126);
			this.textBox_thing.Name = "textBox_thing";
			this.textBox_thing.Size = new System.Drawing.Size(237, 20);
			this.textBox_thing.TabIndex = 1;
			// 
			// textBox_service
			// 
			this.textBox_service.Location = new System.Drawing.Point(61, 152);
			this.textBox_service.Name = "textBox_service";
			this.textBox_service.Size = new System.Drawing.Size(237, 20);
			this.textBox_service.TabIndex = 2;
			// 
			// textBox_key
			// 
			this.textBox_key.Location = new System.Drawing.Point(61, 178);
			this.textBox_key.Name = "textBox_key";
			this.textBox_key.Size = new System.Drawing.Size(237, 20);
			this.textBox_key.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "AppKey";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Service";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Thing";
			// 
			// button
			// 
			this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button.Location = new System.Drawing.Point(330, 152);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(124, 46);
			this.button.TabIndex = 6;
			this.button.Text = "Подключиться";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(12, 207);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server IP";
			// 
			// textBox_server
			// 
			this.textBox_server.Location = new System.Drawing.Point(88, 204);
			this.textBox_server.Name = "textBox_server";
			this.textBox_server.Size = new System.Drawing.Size(210, 20);
			this.textBox_server.TabIndex = 4;
			// 
			// textBox_log
			// 
			this.textBox_log.ContextMenuStrip = this.contextMenuStrip1;
			this.textBox_log.Location = new System.Drawing.Point(12, 246);
			this.textBox_log.Multiline = true;
			this.textBox_log.Name = "textBox_log";
			this.textBox_log.ReadOnly = true;
			this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_log.Size = new System.Drawing.Size(472, 273);
			this.textBox_log.TabIndex = 0;
			this.textBox_log.TabStop = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
			// 
			// очиститьToolStripMenuItem
			// 
			this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
			this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.очиститьToolStripMenuItem.Text = "Очистить";
			this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 230);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(153, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Протокол обработки команд";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(497, 10);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Time refresh";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(498, 39);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Файл настроек";
			// 
			// button_load
			// 
			this.button_load.Location = new System.Drawing.Point(590, 34);
			this.button_load.Name = "button_load";
			this.button_load.Size = new System.Drawing.Size(123, 23);
			this.button_load.TabIndex = 0;
			this.button_load.TabStop = false;
			this.button_load.Text = "Загрузить";
			this.button_load.UseVisualStyleBackColor = true;
			this.button_load.Click += new System.EventHandler(this.button_load_Click);
			// 
			// listBox_UserParameters
			// 
			this.listBox_UserParameters.FormattingEnabled = true;
			this.listBox_UserParameters.Location = new System.Drawing.Point(501, 63);
			this.listBox_UserParameters.Name = "listBox_UserParameters";
			this.listBox_UserParameters.Size = new System.Drawing.Size(252, 225);
			this.listBox_UserParameters.TabIndex = 0;
			this.listBox_UserParameters.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(501, 304);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(252, 23);
			this.button2.TabIndex = 0;
			this.button2.TabStop = false;
			this.button2.Text = "<- Установить настройки";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Дальность";
			// 
			// textBox_range_1
			// 
			this.textBox_range_1.Location = new System.Drawing.Point(81, 12);
			this.textBox_range_1.Name = "textBox_range_1";
			this.textBox_range_1.Size = new System.Drawing.Size(64, 20);
			this.textBox_range_1.TabIndex = 8;
			this.textBox_range_1.Text = "0";
			this.textBox_range_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox__KeyPress);
			// 
			// textBox_range_2
			// 
			this.textBox_range_2.Location = new System.Drawing.Point(151, 12);
			this.textBox_range_2.Name = "textBox_range_2";
			this.textBox_range_2.Size = new System.Drawing.Size(64, 20);
			this.textBox_range_2.TabIndex = 9;
			this.textBox_range_2.Text = "0";
			this.textBox_range_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox__KeyPress);
			// 
			// textBox_range_3
			// 
			this.textBox_range_3.Location = new System.Drawing.Point(221, 12);
			this.textBox_range_3.Name = "textBox_range_3";
			this.textBox_range_3.Size = new System.Drawing.Size(64, 20);
			this.textBox_range_3.TabIndex = 10;
			this.textBox_range_3.Text = "0";
			this.textBox_range_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox__KeyPress);
			// 
			// button_test_1
			// 
			this.button_test_1.Location = new System.Drawing.Point(15, 39);
			this.button_test_1.Name = "button_test_1";
			this.button_test_1.Size = new System.Drawing.Size(113, 81);
			this.button_test_1.TabIndex = 11;
			this.button_test_1.Text = "Тест 1";
			this.button_test_1.UseVisualStyleBackColor = true;
			this.button_test_1.Click += new System.EventHandler(this.button_test_1_Click);
			// 
			// button_test_2
			// 
			this.button_test_2.Location = new System.Drawing.Point(134, 39);
			this.button_test_2.Name = "button_test_2";
			this.button_test_2.Size = new System.Drawing.Size(113, 81);
			this.button_test_2.TabIndex = 12;
			this.button_test_2.Text = "Тест 2";
			this.button_test_2.UseVisualStyleBackColor = true;
			this.button_test_2.Click += new System.EventHandler(this.button_test_2_Click);
			// 
			// button_test_3
			// 
			this.button_test_3.Location = new System.Drawing.Point(253, 39);
			this.button_test_3.Name = "button_test_3";
			this.button_test_3.Size = new System.Drawing.Size(113, 81);
			this.button_test_3.TabIndex = 13;
			this.button_test_3.Text = "Тест 3";
			this.button_test_3.UseVisualStyleBackColor = true;
			this.button_test_3.Click += new System.EventHandler(this.button_test_3_Click);
			// 
			// button_test_4
			// 
			this.button_test_4.Location = new System.Drawing.Point(371, 39);
			this.button_test_4.Name = "button_test_4";
			this.button_test_4.Size = new System.Drawing.Size(113, 81);
			this.button_test_4.TabIndex = 14;
			this.button_test_4.Text = "Тест 4";
			this.button_test_4.UseVisualStyleBackColor = true;
			this.button_test_4.Click += new System.EventHandler(this.button_test_4_Click);
			// 
			// SafetySystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 556);
			this.Controls.Add(this.button_test_4);
			this.Controls.Add(this.button_test_3);
			this.Controls.Add(this.button_test_2);
			this.Controls.Add(this.button_test_1);
			this.Controls.Add(this.textBox_range_3);
			this.Controls.Add(this.textBox_range_2);
			this.Controls.Add(this.textBox_range_1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox_UserParameters);
			this.Controls.Add(this.button_load);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.time_refresh);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox_log);
			this.Controls.Add(this.textBox_server);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textBox_service);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_thing);
			this.Controls.Add(this.button);
			this.Controls.Add(this.textBox_key);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SafetySystem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Смарт-камера";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmartCamera_FormClosing);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.time_refresh)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel work_status;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox textBox_thing;
		private System.Windows.Forms.TextBox textBox_service;
		private System.Windows.Forms.TextBox textBox_key;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_server;
		private System.Windows.Forms.TextBox textBox_log;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown time_refresh;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button_load;
		private System.Windows.Forms.ListBox listBox_UserParameters;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_range_1;
		private System.Windows.Forms.TextBox textBox_range_2;
		private System.Windows.Forms.TextBox textBox_range_3;
		private System.Windows.Forms.Button button_test_1;
		private System.Windows.Forms.Button button_test_2;
		private System.Windows.Forms.Button button_test_3;
		private System.Windows.Forms.Button button_test_4;
	}
}

