
namespace Passenger_Form
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_showInfo = new System.Windows.Forms.Button();
            this.cmb_showInfo = new System.Windows.Forms.ComboBox();
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.lbl_select = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showInfo
            // 
            this.btn_showInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_showInfo.BackColor = System.Drawing.Color.Black;
            this.btn_showInfo.ForeColor = System.Drawing.Color.White;
            this.btn_showInfo.Location = new System.Drawing.Point(415, 93);
            this.btn_showInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_showInfo.Name = "btn_showInfo";
            this.btn_showInfo.Size = new System.Drawing.Size(232, 37);
            this.btn_showInfo.TabIndex = 11;
            this.btn_showInfo.Text = "Show Info";
            this.btn_showInfo.UseVisualStyleBackColor = false;
            this.btn_showInfo.Click += new System.EventHandler(this.btn_showInfo_Click);
            // 
            // cmb_showInfo
            // 
            this.cmb_showInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_showInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_showInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_showInfo.FormattingEnabled = true;
            this.cmb_showInfo.Location = new System.Drawing.Point(366, 57);
            this.cmb_showInfo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_showInfo.Name = "cmb_showInfo";
            this.cmb_showInfo.Size = new System.Drawing.Size(352, 28);
            this.cmb_showInfo.TabIndex = 10;
            this.cmb_showInfo.SelectedIndexChanged += new System.EventHandler(this.cmb_showInfo_SelectedIndexChanged);
            // 
            // dgv_show
            // 
            this.dgv_show.AllowUserToAddRows = false;
            this.dgv_show.AllowUserToDeleteRows = false;
            this.dgv_show.AllowUserToResizeColumns = false;
            this.dgv_show.AllowUserToResizeRows = false;
            this.dgv_show.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_show.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_show.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.Location = new System.Drawing.Point(13, 134);
            this.dgv_show.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.ReadOnly = true;
            this.dgv_show.RowHeadersVisible = false;
            this.dgv_show.RowHeadersWidth = 50;
            this.dgv_show.Size = new System.Drawing.Size(993, 593);
            this.dgv_show.TabIndex = 12;
            // 
            // lbl_select
            // 
            this.lbl_select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_select.AutoSize = true;
            this.lbl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_select.Location = new System.Drawing.Point(202, 58);
            this.lbl_select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(158, 24);
            this.lbl_select.TabIndex = 13;
            this.lbl_select.Text = "Select a Trip Date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trips Info";
            // 
            // error_label
            // 
            this.error_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(726, 60);
            this.error_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(220, 20);
            this.error_label.TabIndex = 15;
            this.error_label.Text = "Error, you mut select a date.";
            this.error_label.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 740);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.dgv_show);
            this.Controls.Add(this.btn_showInfo);
            this.Controls.Add(this.cmb_showInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(907, 783);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showInfo;
        private System.Windows.Forms.ComboBox cmb_showInfo;
        private System.Windows.Forms.DataGridView dgv_show;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_label;
    }
}