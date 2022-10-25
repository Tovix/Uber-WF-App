
using System;

namespace Passenger_Form
{
    partial class RequestTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestTrip));
            this.panel_dest = new System.Windows.Forms.Panel();
            this.panel_line = new System.Windows.Forms.Panel();
            this.panel_time = new System.Windows.Forms.Panel();
            this.now_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dest_textBox = new System.Windows.Forms.TextBox();
            this.time_label = new System.Windows.Forms.Label();
            this.confirmTrip_button = new System.Windows.Forms.Button();
            this.errorLoc_label = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.panel_dest.SuspendLayout();
            this.panel_time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_dest
            // 
            this.panel_dest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_dest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel_dest.Controls.Add(this.panel_line);
            this.panel_dest.Controls.Add(this.panel_time);
            this.panel_dest.Controls.Add(this.dest_textBox);
            this.panel_dest.ForeColor = System.Drawing.Color.SaddleBrown;
            this.panel_dest.Location = new System.Drawing.Point(16, 22);
            this.panel_dest.Name = "panel_dest";
            this.panel_dest.Size = new System.Drawing.Size(1042, 76);
            this.panel_dest.TabIndex = 0;
            // 
            // panel_line
            // 
            this.panel_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.panel_line.Location = new System.Drawing.Point(199, 8);
            this.panel_line.Name = "panel_line";
            this.panel_line.Size = new System.Drawing.Size(2, 61);
            this.panel_line.TabIndex = 1;
            // 
            // panel_time
            // 
            this.panel_time.BackColor = System.Drawing.Color.White;
            this.panel_time.Controls.Add(this.now_label);
            this.panel_time.Controls.Add(this.pictureBox2);
            this.panel_time.Controls.Add(this.pictureBox1);
            this.panel_time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_time.Location = new System.Drawing.Point(17, 8);
            this.panel_time.Name = "panel_time";
            this.panel_time.Size = new System.Drawing.Size(146, 59);
            this.panel_time.TabIndex = 0;
            this.panel_time.Click += new System.EventHandler(this.TimeSelect_Click);
            this.panel_time.MouseEnter += new System.EventHandler(this.TimeSelect_MouseEnter);
            this.panel_time.MouseLeave += new System.EventHandler(this.TimeSelect_MouseLeave);
            // 
            // now_label
            // 
            this.now_label.AutoSize = true;
            this.now_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.now_label.ForeColor = System.Drawing.Color.Black;
            this.now_label.Location = new System.Drawing.Point(48, 19);
            this.now_label.Name = "now_label";
            this.now_label.Size = new System.Drawing.Size(51, 25);
            this.now_label.TabIndex = 2;
            this.now_label.Text = "Now";
            this.now_label.Click += new System.EventHandler(this.TimeSelect_Click);
            this.now_label.MouseEnter += new System.EventHandler(this.TimeSelect_MouseEnter);
            this.now_label.MouseLeave += new System.EventHandler(this.TimeSelect_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.TimeSelect_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.TimeSelect_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.TimeSelect_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.TimeSelect_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.TimeSelect_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.TimeSelect_MouseLeave);
            // 
            // dest_textBox
            // 
            this.dest_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dest_textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "البعيرات الأقصر",
            "الطود الأقصر",
            "نجع المهيدات الأقصر",
            "الجمرك الإسكندرية",
            "الشرق الإسكندرية",
            "العامرية الإسكندرية",
            "العجمي الإسكندرية",
            "المنتزة الإسكندرية",
            "الوسط الإسكندرية",
            "برج العرب الإسكندرية",
            "الإسماعيلية الإسماعيلية",
            "التل الكبير الإسماعيلية",
            "القصاصين الإسماعيلية",
            "القنطرة شرق الإسماعيلية",
            "القنطرة غرب الإسماعيلية",
            "أبو صوير الإسماعيلية",
            "فايد الإسماعيلية",
            "الغردقة البحر الأحمر",
            "القصير البحر الأحمر",
            "راس غارب البحر الأحمر",
            "سفاجا البحر الأحمر",
            "شلاتين البحر الأحمر",
            "مرسى علم البحر الأحمر",
            "الدلنجات البحيرة",
            "الرحمانية البحيرة",
            "المحمودية البحيرة",
            "النوبارية الجديدة البحيرة",
            "ايتاي البارود البحيرة",
            "أبو المطامير البحيرة",
            "أبو حمص البحيرة",
            "إدكو البحيرة",
            "حوش عيسى البحيرة",
            "دمنهور البحيرة",
            "رشيد البحيرة",
            "شبراخيت البحيرة",
            "كفر الدوار البحيرة",
            "كوم حمادة البحيرة",
            "وادي النطرون البحيرة",
            "اطفيح الجيزة",
            "البدرشين الجيزة",
            "الدقي الجيزة",
            "السادس من اكتوبر الجيزة",
            "الصف الجيزة",
            "العياط الجيزة",
            "المهندسين الجيزة",
            "الواحات البحرية الجيزة",
            "امبابة الجيزة",
            "حي الهرم الجيزة",
            "حي فيصل الجيزة",
            "مركز الجيزة الجيزة",
            "الجمالية الدقهلية",
            "السنبلاوين الدقهلية",
            "الكردي الدقهلية",
            "المطرية الدقهلية",
            "المنزلة الدقهلية",
            "المنصورة الدقهلية",
            "أجا الدقهلية",
            "بلقاس الدقهلية",
            "بنى عبيد الدقهلية",
            "تمى الأمديد الدقهلية",
            "جمصة الدقهلية",
            "دكرنس الدقهلية",
            "شربين الدقهلية",
            "طلخا الدقهلية",
            "منية النصر الدقهلية",
            "ميت سلسيل الدقهلية",
            "ميت غمر الدقهلية",
            "نبروه الدقهلية",
            "الحي الأول السادس من اكتوبر",
            "الحي التاسع السادس من اكتوبر",
            "الحي الثالث السادس من اكتوبر",
            "الحي الثامن السادس من اكتوبر",
            "الحي الثاني السادس من اكتوبر",
            "الحي الثاني عشر السادس من اكتوبر",
            "الحي الحادي عشر السادس من اكتوبر",
            "الحي الخامس السادس من اكتوبر",
            "الحي الرابع السادس من اكتوبر",
            "الحي السابع السادس من اكتوبر",
            "الحي السادس السادس من اكتوبر",
            "الحي العاشر السادس من اكتوبر",
            "الأربعين السويس",
            "الجناين السويس",
            "السويس السويس",
            "عتاقة السويس",
            "الإبراهيمية الشرقية",
            "الحسينية الشرقية",
            "الزقازيق الشرقية",
            "الصالحية الشرقية",
            "العاشر من رمضان الشرقية",
            "القرين الشرقية",
            "القنايات الشرقية",
            "أبو حماد الشرقية",
            "أبو كبير الشرقية",
            "أولاد صقر الشرقية",
            "بلبيس الشرقية",
            "ديرب نجم الشرقية",
            "فاقوس الشرقية",
            "كفر صقر الشرقية",
            "مشتول السوق الشرقية",
            "منيا القمح الشرقية",
            "ههيا الشرقية",
            "السنطة الغربية",
            "المحلة الكبرى - حي أول الغربية",
            "المحلة الكبرى - حي ثاني الغربية",
            "بسيون الغربية",
            "زفتى الغربية",
            "سمنود الغربية",
            "طنطا - حي أول الغربية",
            "طنطا - حي ثاني الغربية",
            "قطور الغربية",
            "كفر الزيات الغربية",
            "الفيوم الفيوم",
            "أبشواي الفيوم",
            "أطسا الفيوم",
            "سنورس الفيوم",
            "طامية الفيوم",
            "البساتين ودار السلام القاهرة",
            "التبين القاهرة",
            "الخليفة و المقطم القاهرة",
            "الزاوية الحمراء القاهرة",
            "الزيتون القاهرة",
            "الساحل القاهرة",
            "السلام القاهرة",
            "السيدة زينب القاهرة",
            "الشرابية القاهرة",
            "المرج القاهرة",
            "المطرية القاهرة",
            "المعادي القاهرة",
            "الموسكي القاهرة",
            "النزهة القاهرة",
            "الوايلي القاهرة",
            "باب الشعرية القاهرة",
            "حدائق القبة القاهرة",
            "حلوان القاهرة",
            "روض الفرج القاهرة",
            "شبرا القاهرة",
            "عابدين القاهرة",
            "عين شمس القاهرة",
            "غرب القاهرة القاهرة",
            "مدينة نصر - شرق القاهرة",
            "مدينة نصر - غرب القاهرة",
            "مصر الجديدة القاهرة",
            "مصر القديمة القاهرة",
            "منشأة ناصر القاهرة",
            "وسط القاهرة القاهرة",
            "الخانكة القليوبية",
            "القناطر الخيرية القليوبية",
            "بنها العسل القليوبية",
            "شبرا الخيمة القليوبية",
            "شبين القناطر القليوبية",
            "طوخ القليوبية",
            "قليوب القليوبية",
            "كفر شكر القليوبية",
            "الباجور المنوفية",
            "الشهداء المنوفية",
            "أشمون المنوفية",
            "بركة السبع المنوفية",
            "تلا المنوفية",
            "سرس الليان المنوفية",
            "شبين الكوم المنوفية",
            "قويسنا المنوفية",
            "مدينة السادات المنوفية",
            "منوف المنوفية",
            "العدوة المنيا",
            "المنيا المنيا",
            "المنيا الجديدة المنيا",
            "أبو قرقاص المنيا",
            "بني مزار المنيا",
            "دير مواس المنيا",
            "سمالوط المنيا",
            "مطاي المنيا",
            "مغاغة المنيا",
            "ملوي المنيا",
            "الخارجة الوادي الجديد",
            "الداخلة الوادي الجديد",
            "الفرافرة الوادي الجديد",
            "أسوان أسوان",
            "إدفو أسوان",
            "دراو أسوان",
            "كوم امبو أسوان",
            "نصر النوبة أسوان",
            "البداري أسيوط",
            "الغنايم أسيوط",
            "الفتح أسيوط",
            "أبنوب أسيوط",
            "أبو تيج أسيوط",
            "أسيوط أسيوط",
            "ديروط أسيوط",
            "ساحل سليم أسيوط",
            "صدفا أسيوط",
            "قوصية أسيوط",
            "منفلوط أسيوط",
            "الفشن بني سويف",
            "الواسطى بني سويف",
            "أهناسيا بني سويف",
            "ببا بني سويف",
            "بني سويف بني سويف",
            "سمسطا بني سويف",
            "مدينة ناصر بني سويف",
            "حي الجنوب بورسعيد",
            "حي الزهور بورسعيد",
            "حي الشرق بورسعيد",
            "حي الضواحي بورسعيد",
            "حي العرب بورسعيد",
            "حي المناخ بورسعيد",
            "حي بورفؤاد بورسعيد",
            "دهب جنوب سيناء",
            "رأس سدر جنوب سيناء",
            "شرم الشيخ جنوب سيناء",
            "طابا جنوب سيناء",
            "نخل جنوب سيناء",
            "نويبع جنوب سيناء",
            "التبين حلوان",
            "المعصرة حلوان",
            "النهضة والهايكستب حلوان",
            "حي المستقبل.( مدينة 15 مايو سابقا) حلوان",
            "عين حلوان حلوان",
            "مدينة المعادى حلوان",
            "مركز ومدينة الصف حلوان",
            "مركز ومدينة أطفيح حلوان",
            "الزرقا دمياط",
            "دمياط دمياط",
            "فارسكور دمياط",
            "كفر سعد دمياط",
            "البلينا سوهاج",
            "المراغة سوهاج",
            "المنشاة سوهاج",
            "أخميم سوهاج",
            "جرجا سوهاج",
            "جهينة سوهاج",
            "دار السلام سوهاج",
            "ساقلتا سوهاج",
            "سوهاج سوهاج",
            "طما سوهاج",
            "طهطا سوهاج",
            "الحسنة شمال سيناء",
            "الشيخ زويد شمال سيناء",
            "العريش شمال سيناء",
            "بئر العبد شمال سيناء",
            "رفح شمال سيناء",
            "نخل شمال سيناء",
            "الأقصر قنا",
            "الوقف قنا",
            "أبو تشت قنا",
            "أرمنت قنا",
            "إسنا قنا",
            "دشنا قنا",
            "فرشوط قنا",
            "قفط قنا",
            "قنا قنا",
            "قوص قنا",
            "نجع حمادي قنا",
            "نقادة قنا",
            "الحامول كفر الشيخ",
            "الرياض كفر الشيخ",
            "بلطيم كفر الشيخ",
            "بيلا كفر الشيخ",
            "دسوق كفر الشيخ",
            "سيدي سالم كفر الشيخ",
            "فوة كفر الشيخ",
            "قلين كفر الشيخ",
            "كفر الشيخ كفر الشيخ",
            "مطوبس كفر الشيخ",
            "الحمام مطروح",
            "السلوم مطروح",
            "الضبعة مطروح",
            "العلمين مطروح",
            "النجيلة مطروح",
            "براني مطروح",
            "سيوة مطروح",
            "مطروح مطروح"});
            this.dest_textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dest_textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.dest_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dest_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dest_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dest_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.dest_textBox.Location = new System.Drawing.Point(223, 20);
            this.dest_textBox.Name = "dest_textBox";
            this.dest_textBox.Size = new System.Drawing.Size(804, 31);
            this.dest_textBox.TabIndex = 0;
            this.dest_textBox.Text = "إلى أين ؟";
            this.dest_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dest_textBox.Click += new System.EventHandler(this.dest_textBox_Click);
            this.dest_textBox.TextChanged += new System.EventHandler(this.dest_textBox_TextChanged);
            this.dest_textBox.Leave += new System.EventHandler(this.dest_textBox_Leave);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.White;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.Color.Black;
            this.time_label.Location = new System.Drawing.Point(14, 101);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(0, 25);
            this.time_label.TabIndex = 1;
            // 
            // confirmTrip_button
            // 
            this.confirmTrip_button.BackColor = System.Drawing.Color.Black;
            this.confirmTrip_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTrip_button.ForeColor = System.Drawing.Color.White;
            this.confirmTrip_button.Location = new System.Drawing.Point(394, 802);
            this.confirmTrip_button.Name = "confirmTrip_button";
            this.confirmTrip_button.Size = new System.Drawing.Size(225, 48);
            this.confirmTrip_button.TabIndex = 2;
            this.confirmTrip_button.Text = "Confirm Trip";
            this.confirmTrip_button.UseVisualStyleBackColor = false;
            this.confirmTrip_button.Click += new System.EventHandler(this.confirmTrip_button_Click);
            // 
            // errorLoc_label
            // 
            this.errorLoc_label.AutoSize = true;
            this.errorLoc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLoc_label.ForeColor = System.Drawing.Color.Red;
            this.errorLoc_label.Location = new System.Drawing.Point(217, 106);
            this.errorLoc_label.Name = "errorLoc_label";
            this.errorLoc_label.Size = new System.Drawing.Size(457, 20);
            this.errorLoc_label.TabIndex = 6;
            this.errorLoc_label.Text = "Invalid location, you must select a location from suggestions";
            this.errorLoc_label.Visible = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(16, 129);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1042, 667);
            this.map.TabIndex = 7;
            this.map.Visible = false;
            this.map.Zoom = 0D;
            // 
            // RequestTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 862);
            this.Controls.Add(this.map);
            this.Controls.Add(this.errorLoc_label);
            this.Controls.Add(this.confirmTrip_button);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.panel_dest);
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(820, 673);
            this.Name = "RequestTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RequestTrip_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_dest.ResumeLayout(false);
            this.panel_dest.PerformLayout();
            this.panel_time.ResumeLayout(false);
            this.panel_time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_line;
        private System.Windows.Forms.Panel panel_dest;
        private System.Windows.Forms.TextBox dest_textBox;
        private System.Windows.Forms.Label now_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_time;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Button confirmTrip_button;
        private System.Windows.Forms.Label errorLoc_label;
        private GMap.NET.WindowsForms.GMapControl map;
    }
}

