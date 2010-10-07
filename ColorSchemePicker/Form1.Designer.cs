namespace ColorSchemePicker
{
    partial class ColorSchemePickerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSchemePickerForm));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbScheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "test";
            this.notifyIcon.Visible = true;
            // 
            // cbScheme
            // 
            this.cbScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScheme.FormattingEnabled = true;
            this.cbScheme.Location = new System.Drawing.Point(118, 11);
            this.cbScheme.Name = "cbScheme";
            this.cbScheme.Size = new System.Drawing.Size(157, 21);
            this.cbScheme.TabIndex = 5;
            this.cbScheme.SelectedIndexChanged += new System.EventHandler(this.something_Changed);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 100);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(122, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 100);
            this.label2.TabIndex = 7;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(228, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 100);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(334, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 100);
            this.label4.TabIndex = 9;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(440, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 100);
            this.label5.TabIndex = 10;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_MouseClick);
            // 
            // lbColor
            // 
            this.lbColor.BackColor = System.Drawing.Color.Black;
            this.lbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbColor.ForeColor = System.Drawing.Color.White;
            this.lbColor.Location = new System.Drawing.Point(12, 11);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(100, 20);
            this.lbColor.TabIndex = 11;
            this.lbColor.Text = "Black";
            this.lbColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbColor.TextChanged += new System.EventHandler(this.something_Changed);
            this.lbColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbColor_MouseClick);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tab1);
            this.tabs.Controls.Add(this.tab2);
            this.tabs.Location = new System.Drawing.Point(12, 38);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(566, 152);
            this.tabs.TabIndex = 12;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(558, 126);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Schéma barev";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(545, 126);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Ukázka vzhledu";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // ColorSchemePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 202);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.cbScheme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ColorSchemePickerForm";
            this.Text = "ColorSchemePicker";
            this.tabs.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ComboBox cbScheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
    }
}

