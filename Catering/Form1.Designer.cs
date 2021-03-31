
namespace Catering
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_numGuests = new System.Windows.Forms.TextBox();
            this.lb_entree = new System.Windows.Forms.ListBox();
            this.cb_sides = new System.Windows.Forms.CheckedListBox();
            this.combo_desert = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_total = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cindy\'s Catering";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(340, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(467, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Guests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(176, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose an Entrée";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(336, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Choose Side (Up to 2)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(514, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Choose a Desert";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(210, 158);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 23);
            this.tb_name.TabIndex = 7;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(336, 158);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(100, 23);
            this.tb_phone.TabIndex = 8;
            // 
            // tb_numGuests
            // 
            this.tb_numGuests.Location = new System.Drawing.Point(470, 158);
            this.tb_numGuests.Name = "tb_numGuests";
            this.tb_numGuests.Size = new System.Drawing.Size(100, 23);
            this.tb_numGuests.TabIndex = 9;
            // 
            // lb_entree
            // 
            this.lb_entree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_entree.FormattingEnabled = true;
            this.lb_entree.ItemHeight = 17;
            this.lb_entree.Items.AddRange(new object[] {
            "Grilled Chicken",
            "Steak",
            "Salmon",
            "Salad"});
            this.lb_entree.Location = new System.Drawing.Point(190, 282);
            this.lb_entree.Name = "lb_entree";
            this.lb_entree.Size = new System.Drawing.Size(120, 89);
            this.lb_entree.TabIndex = 10;
            this.lb_entree.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cb_sides
            // 
            this.cb_sides.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_sides.FormattingEnabled = true;
            this.cb_sides.Items.AddRange(new object[] {
            "Fries",
            "Salad",
            "Potatoes",
            "Rice"});
            this.cb_sides.Location = new System.Drawing.Point(353, 282);
            this.cb_sides.Name = "cb_sides";
            this.cb_sides.Size = new System.Drawing.Size(120, 84);
            this.cb_sides.TabIndex = 11;
            this.cb_sides.SelectedIndexChanged += new System.EventHandler(this.cb_sides_SelectedIndexChanged);
            // 
            // combo_desert
            // 
            this.combo_desert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combo_desert.FormattingEnabled = true;
            this.combo_desert.Items.AddRange(new object[] {
            "Chocolate Cake",
            "Tiramisu",
            "Vanilla Ice Cream",
            "Cheesecake"});
            this.combo_desert.Location = new System.Drawing.Point(516, 282);
            this.combo_desert.Name = "combo_desert";
            this.combo_desert.Size = new System.Drawing.Size(121, 25);
            this.combo_desert.TabIndex = 12;
            this.combo_desert.SelectedIndexChanged += new System.EventHandler(this.combo_desert_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "$35 a Person";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Total.Location = new System.Drawing.Point(360, 447);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(137, 30);
            this.lbl_Total.TabIndex = 14;
            this.lbl_Total.Text = "Total ($USD)";
            this.lbl_Total.Click += new System.EventHandler(this.lbl_Total_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(390, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(364, 396);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(92, 23);
            this.btn_total.TabIndex = 16;
            this.btn_total.Text = "Calculate Total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_desert);
            this.Controls.Add(this.cb_sides);
            this.Controls.Add(this.lb_entree);
            this.Controls.Add(this.tb_numGuests);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cindy\'s Catering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_numGuests;
        private System.Windows.Forms.ListBox lb_entree;
        private System.Windows.Forms.CheckedListBox cb_sides;
        private System.Windows.Forms.ComboBox combo_desert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_total;
    }
}

