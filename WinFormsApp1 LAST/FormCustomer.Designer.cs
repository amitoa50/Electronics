
namespace WinFormsApp1
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.label_customer = new System.Windows.Forms.Label();
            this.btn_Home_Page = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PowerStrip = new System.Windows.Forms.Button();
            this.btn_Oven = new System.Windows.Forms.Button();
            this.label_Elctric_Item = new System.Windows.Forms.Label();
            this.btn_Kettle = new System.Windows.Forms.Button();
            this.btn_Refrigerator = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_customer);
            this.panel1.Controls.Add(this.label_customer);
            this.panel1.Controls.Add(this.btn_Home_Page);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 517);
            this.panel1.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(74, 413);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 29);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.White;
            this.btn_customer.Location = new System.Drawing.Point(74, 275);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(124, 29);
            this.btn_customer.TabIndex = 2;
            this.btn_customer.Text = "SHOP CART";
            this.btn_customer.UseVisualStyleBackColor = false;
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_customer.Location = new System.Drawing.Point(26, 78);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(206, 31);
            this.label_customer.TabIndex = 1;
            this.label_customer.Text = "CUSTOMER MUNE";
            // 
            // btn_Home_Page
            // 
            this.btn_Home_Page.BackColor = System.Drawing.Color.White;
            this.btn_Home_Page.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Home_Page.Location = new System.Drawing.Point(74, 198);
            this.btn_Home_Page.Name = "btn_Home_Page";
            this.btn_Home_Page.Size = new System.Drawing.Size(124, 29);
            this.btn_Home_Page.TabIndex = 0;
            this.btn_Home_Page.Text = "HOME PAGE";
            this.btn_Home_Page.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_PowerStrip);
            this.panel2.Controls.Add(this.btn_Oven);
            this.panel2.Controls.Add(this.label_Elctric_Item);
            this.panel2.Controls.Add(this.btn_Kettle);
            this.panel2.Controls.Add(this.btn_Refrigerator);
            this.panel2.Location = new System.Drawing.Point(258, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 517);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "SIDES\r\nITEMS\r\n";
            // 
            // btn_PowerStrip
            // 
            this.btn_PowerStrip.Location = new System.Drawing.Point(12, 412);
            this.btn_PowerStrip.Name = "btn_PowerStrip";
            this.btn_PowerStrip.Size = new System.Drawing.Size(106, 29);
            this.btn_PowerStrip.TabIndex = 4;
            this.btn_PowerStrip.Text = "PowerStrip";
            this.btn_PowerStrip.UseVisualStyleBackColor = true;
            // 
            // btn_Oven
            // 
            this.btn_Oven.Location = new System.Drawing.Point(12, 275);
            this.btn_Oven.Name = "btn_Oven";
            this.btn_Oven.Size = new System.Drawing.Size(106, 29);
            this.btn_Oven.TabIndex = 3;
            this.btn_Oven.Text = "Oven";
            this.btn_Oven.UseVisualStyleBackColor = true;
            // 
            // label_Elctric_Item
            // 
            this.label_Elctric_Item.AutoSize = true;
            this.label_Elctric_Item.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Elctric_Item.Location = new System.Drawing.Point(13, 81);
            this.label_Elctric_Item.Name = "label_Elctric_Item";
            this.label_Elctric_Item.Size = new System.Drawing.Size(111, 62);
            this.label_Elctric_Item.TabIndex = 2;
            this.label_Elctric_Item.Text = "ELECTRIC\r\n  ITEMS\r\n";
            // 
            // btn_Kettle
            // 
            this.btn_Kettle.Location = new System.Drawing.Point(12, 224);
            this.btn_Kettle.Name = "btn_Kettle";
            this.btn_Kettle.Size = new System.Drawing.Size(106, 29);
            this.btn_Kettle.TabIndex = 1;
            this.btn_Kettle.Text = "Kettle";
            this.btn_Kettle.UseVisualStyleBackColor = true;
            // 
            // btn_Refrigerator
            // 
            this.btn_Refrigerator.Location = new System.Drawing.Point(12, 171);
            this.btn_Refrigerator.Name = "btn_Refrigerator";
            this.btn_Refrigerator.Size = new System.Drawing.Size(106, 29);
            this.btn_Refrigerator.TabIndex = 0;
            this.btn_Refrigerator.Text = "Refrigerators";
            this.btn_Refrigerator.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Tan;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(388, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 75);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(397, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOME PAGE";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Button btn_Home_Page;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Elctric_Item;
        private System.Windows.Forms.Button btn_Kettle;
        private System.Windows.Forms.Button btn_Refrigerator;
        private System.Windows.Forms.Button btn_PowerStrip;
        private System.Windows.Forms.Button btn_Oven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}