
namespace Passenger_Form
{
    partial class TimeSelection
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
            this.customTime_panel = new System.Windows.Forms.Panel();
            this.date_coboBox = new System.Windows.Forms.ComboBox();
            this.minutes_comboBox = new System.Windows.Forms.ComboBox();
            this.hours_comboBox = new System.Windows.Forms.ComboBox();
            this.am_pm_comboBox = new System.Windows.Forms.ComboBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.now_radioButton = new System.Windows.Forms.RadioButton();
            this.custom_radioButton = new System.Windows.Forms.RadioButton();
            this.errorTime_label = new System.Windows.Forms.Label();
            this.customTime_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customTime_panel
            // 
            this.customTime_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customTime_panel.Controls.Add(this.date_coboBox);
            this.customTime_panel.Controls.Add(this.minutes_comboBox);
            this.customTime_panel.Controls.Add(this.hours_comboBox);
            this.customTime_panel.Controls.Add(this.am_pm_comboBox);
            this.customTime_panel.Location = new System.Drawing.Point(12, 154);
            this.customTime_panel.Name = "customTime_panel";
            this.customTime_panel.Size = new System.Drawing.Size(457, 76);
            this.customTime_panel.TabIndex = 0;
            this.customTime_panel.Visible = false;
            // 
            // date_coboBox
            // 
            this.date_coboBox.BackColor = System.Drawing.Color.White;
            this.date_coboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_coboBox.ForeColor = System.Drawing.Color.Black;
            this.date_coboBox.FormattingEnabled = true;
            this.date_coboBox.Location = new System.Drawing.Point(270, 24);
            this.date_coboBox.MaxDropDownItems = 2;
            this.date_coboBox.Name = "date_coboBox";
            this.date_coboBox.Size = new System.Drawing.Size(165, 28);
            this.date_coboBox.TabIndex = 4;
            // 
            // minutes_comboBox
            // 
            this.minutes_comboBox.BackColor = System.Drawing.Color.White;
            this.minutes_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes_comboBox.ForeColor = System.Drawing.Color.Black;
            this.minutes_comboBox.FormattingEnabled = true;
            this.minutes_comboBox.IntegralHeight = false;
            this.minutes_comboBox.ItemHeight = 20;
            this.minutes_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minutes_comboBox.Location = new System.Drawing.Point(184, 24);
            this.minutes_comboBox.Name = "minutes_comboBox";
            this.minutes_comboBox.Size = new System.Drawing.Size(58, 28);
            this.minutes_comboBox.TabIndex = 3;
            // 
            // hours_comboBox
            // 
            this.hours_comboBox.BackColor = System.Drawing.Color.White;
            this.hours_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_comboBox.ForeColor = System.Drawing.Color.Black;
            this.hours_comboBox.FormattingEnabled = true;
            this.hours_comboBox.IntegralHeight = false;
            this.hours_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.hours_comboBox.Location = new System.Drawing.Point(102, 24);
            this.hours_comboBox.Name = "hours_comboBox";
            this.hours_comboBox.Size = new System.Drawing.Size(58, 28);
            this.hours_comboBox.TabIndex = 2;
            // 
            // am_pm_comboBox
            // 
            this.am_pm_comboBox.BackColor = System.Drawing.Color.White;
            this.am_pm_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.am_pm_comboBox.ForeColor = System.Drawing.Color.Black;
            this.am_pm_comboBox.FormattingEnabled = true;
            this.am_pm_comboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.am_pm_comboBox.Location = new System.Drawing.Point(16, 24);
            this.am_pm_comboBox.MaxDropDownItems = 2;
            this.am_pm_comboBox.Name = "am_pm_comboBox";
            this.am_pm_comboBox.Size = new System.Drawing.Size(58, 28);
            this.am_pm_comboBox.TabIndex = 1;
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.Color.Black;
            this.confirm_button.ForeColor = System.Drawing.Color.White;
            this.confirm_button.Location = new System.Drawing.Point(114, 12);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(98, 40);
            this.confirm_button.TabIndex = 1;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.Color.Black;
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(282, 12);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(98, 40);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // now_radioButton
            // 
            this.now_radioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.now_radioButton.AutoSize = true;
            this.now_radioButton.Checked = true;
            this.now_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.now_radioButton.Location = new System.Drawing.Point(28, 82);
            this.now_radioButton.Name = "now_radioButton";
            this.now_radioButton.Size = new System.Drawing.Size(67, 26);
            this.now_radioButton.TabIndex = 3;
            this.now_radioButton.TabStop = true;
            this.now_radioButton.Text = "Now";
            this.now_radioButton.UseVisualStyleBackColor = true;
            this.now_radioButton.CheckedChanged += new System.EventHandler(this.now_radioButton_CheckedChanged);
            // 
            // custom_radioButton
            // 
            this.custom_radioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.custom_radioButton.AutoSize = true;
            this.custom_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom_radioButton.Location = new System.Drawing.Point(28, 120);
            this.custom_radioButton.Name = "custom_radioButton";
            this.custom_radioButton.Size = new System.Drawing.Size(92, 26);
            this.custom_radioButton.TabIndex = 4;
            this.custom_radioButton.Text = "Custom";
            this.custom_radioButton.UseVisualStyleBackColor = true;
            this.custom_radioButton.CheckedChanged += new System.EventHandler(this.custom_radioButton_CheckedChanged);
            // 
            // errorTime_label
            // 
            this.errorTime_label.AutoSize = true;
            this.errorTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTime_label.ForeColor = System.Drawing.Color.Red;
            this.errorTime_label.Location = new System.Drawing.Point(24, 221);
            this.errorTime_label.Name = "errorTime_label";
            this.errorTime_label.Size = new System.Drawing.Size(311, 20);
            this.errorTime_label.TabIndex = 5;
            this.errorTime_label.Text = "Invalid Time, you selected a passed time";
            this.errorTime_label.Visible = false;
            // 
            // TimeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(483, 252);
            this.ControlBox = false;
            this.Controls.Add(this.errorTime_label);
            this.Controls.Add(this.custom_radioButton);
            this.Controls.Add(this.now_radioButton);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.customTime_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeSelection";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.TimeSelection_Load);
            this.Shown += new System.EventHandler(this.TimeSelection_Shown);
            this.customTime_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel customTime_panel;
        private System.Windows.Forms.ComboBox am_pm_comboBox;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ComboBox minutes_comboBox;
        private System.Windows.Forms.ComboBox hours_comboBox;
        private System.Windows.Forms.ComboBox date_coboBox;
        private System.Windows.Forms.RadioButton now_radioButton;
        private System.Windows.Forms.RadioButton custom_radioButton;
        private System.Windows.Forms.Label errorTime_label;
    }
}