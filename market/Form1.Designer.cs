namespace market
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
            label1 = new Label();
            tbprice = new TextBox();
            cbmember = new CheckBox();
            tbcash = new TextBox();
            label2 = new Label();
            button1 = new Button();
            lbbvat = new Label();
            lbvat = new Label();
            lbpricepvat = new Label();
            lblre = new Label();
            lbmemprice = new Label();
            lbk1000 = new Label();
            lbk500 = new Label();
            lbk100 = new Label();
            lbk50 = new Label();
            lbk20 = new Label();
            lbk10 = new Label();
            lbk5 = new Label();
            lbk1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 38);
            label1.TabIndex = 0;
            label1.Text = "price : ";
            // 
            // tbprice
            // 
            tbprice.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbprice.Location = new Point(131, 34);
            tbprice.Name = "tbprice";
            tbprice.Size = new Size(150, 43);
            tbprice.TabIndex = 1;
            tbprice.KeyPress += tbprice_KeyPress;
            // 
            // cbmember
            // 
            cbmember.AutoSize = true;
            cbmember.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            cbmember.Location = new Point(52, 159);
            cbmember.Name = "cbmember";
            cbmember.Size = new Size(229, 50);
            cbmember.TabIndex = 2;
            cbmember.Text = "membership";
            cbmember.UseVisualStyleBackColor = true;
            // 
            // tbcash
            // 
            tbcash.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbcash.Location = new Point(131, 96);
            tbcash.Name = "tbcash";
            tbcash.Size = new Size(150, 43);
            tbcash.TabIndex = 4;
            tbcash.KeyPress += tbcash_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 96);
            label2.Name = "label2";
            label2.Size = new Size(94, 38);
            label2.TabIndex = 3;
            label2.Text = "cash : ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(333, 52);
            button1.Name = "button1";
            button1.Size = new Size(229, 82);
            button1.TabIndex = 5;
            button1.Text = "click me ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbbvat
            // 
            lbbvat.AutoSize = true;
            lbbvat.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbbvat.Location = new Point(40, 227);
            lbbvat.Name = "lbbvat";
            lbbvat.Size = new Size(243, 38);
            lbbvat.TabIndex = 6;
            lbbvat.Text = "price before VAT : ";
            // 
            // lbvat
            // 
            lbvat.AutoSize = true;
            lbvat.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbvat.Location = new Point(40, 291);
            lbvat.Name = "lbvat";
            lbvat.Size = new Size(77, 38);
            lbvat.TabIndex = 7;
            lbvat.Text = "VAT :";
            // 
            // lbpricepvat
            // 
            lbpricepvat.AutoSize = true;
            lbpricepvat.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbpricepvat.Location = new Point(40, 348);
            lbpricepvat.Name = "lbpricepvat";
            lbpricepvat.Size = new Size(173, 38);
            lbpricepvat.TabIndex = 8;
            lbpricepvat.Text = "price + VAT :";
            // 
            // lblre
            // 
            lblre.AutoSize = true;
            lblre.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblre.Location = new Point(619, 159);
            lblre.Name = "lblre";
            lblre.Size = new Size(56, 38);
            lblre.TabIndex = 9;
            lblre.Text = "re :";
            // 
            // lbmemprice
            // 
            lbmemprice.AutoSize = true;
            lbmemprice.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbmemprice.Location = new Point(40, 405);
            lbmemprice.Name = "lbmemprice";
            lbmemprice.Size = new Size(94, 38);
            lbmemprice.TabIndex = 10;
            lbmemprice.Text = "mem :";
            // 
            // lbk1000
            // 
            lbk1000.AutoSize = true;
            lbk1000.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbk1000.Location = new Point(619, 215);
            lbk1000.Name = "lbk1000";
            lbk1000.Size = new Size(121, 38);
            lbk1000.TabIndex = 11;
            lbk1000.Text = "1000 x 0";
            // 
            // lbk500
            // 
            lbk500.AutoSize = true;
            lbk500.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbk500.Location = new Point(634, 253);
            lbk500.Name = "lbk500";
            lbk500.Size = new Size(106, 38);
            lbk500.TabIndex = 12;
            lbk500.Text = "500 x 0";
            // 
            // lbk100
            // 
            lbk100.AutoSize = true;
            lbk100.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbk100.Location = new Point(634, 291);
            lbk100.Name = "lbk100";
            lbk100.Size = new Size(106, 38);
            lbk100.TabIndex = 13;
            lbk100.Text = "100 x 0";
            // 
            // lbk50
            // 
            lbk50.AutoSize = true;
            lbk50.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbk50.Location = new Point(649, 329);
            lbk50.Name = "lbk50";
            lbk50.Size = new Size(91, 38);
            lbk50.TabIndex = 14;
            lbk50.Text = "50 x 0";
            // 
            // lbk20
            // 
            lbk20.AutoSize = true;
            lbk20.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbk20.Location = new Point(649, 367);
            lbk20.Name = "lbk20";
            lbk20.Size = new Size(91, 38);
            lbk20.TabIndex = 15;
            lbk20.Text = "20 x 0";
            // 
            // lbk10
            // 
            lbk10.AutoSize = true;
            lbk10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbk10.Location = new Point(773, 215);
            lbk10.Name = "lbk10";
            lbk10.Size = new Size(91, 38);
            lbk10.TabIndex = 16;
            lbk10.Text = "10 x 0";
            // 
            // lbk5
            // 
            lbk5.AutoSize = true;
            lbk5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbk5.Location = new Point(788, 253);
            lbk5.Name = "lbk5";
            lbk5.Size = new Size(76, 38);
            lbk5.TabIndex = 17;
            lbk5.Text = "5 x 0";
            // 
            // lbk1
            // 
            lbk1.AutoSize = true;
            lbk1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbk1.Location = new Point(788, 291);
            lbk1.Name = "lbk1";
            lbk1.Size = new Size(76, 38);
            lbk1.TabIndex = 18;
            lbk1.Text = "1 x 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 505);
            Controls.Add(lbk1);
            Controls.Add(lbk5);
            Controls.Add(lbk10);
            Controls.Add(lbk20);
            Controls.Add(lbk50);
            Controls.Add(lbk100);
            Controls.Add(lbk500);
            Controls.Add(lbk1000);
            Controls.Add(lbmemprice);
            Controls.Add(lblre);
            Controls.Add(lbpricepvat);
            Controls.Add(lbvat);
            Controls.Add(lbbvat);
            Controls.Add(button1);
            Controls.Add(tbcash);
            Controls.Add(label2);
            Controls.Add(cbmember);
            Controls.Add(tbprice);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbprice;
        private CheckBox cbmember;
        private TextBox tbcash;
        private Label label2;
        private Button button1;
        private Label lbbvat;
        private Label lbvat;
        private Label lbpricepvat;
        private Label lblre;
        private Label lbmemprice;
        private Label lbk1000;
        private Label lbk500;
        private Label lbk100;
        private Label lbk50;
        private Label lbk20;
        private Label lbk10;
        private Label lbk5;
        private Label lbk1;
    }
}