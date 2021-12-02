namespace Sem_3_Lab_8
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
            this.button_encrypt = new System.Windows.Forms.Button();
            this.button_decrypt = new System.Windows.Forms.Button();
            this.main_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.key_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.output_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_encrypt
            // 
            this.button_encrypt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_encrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_encrypt.BackgroundImage")));
            this.button_encrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_encrypt.Location = new System.Drawing.Point(271, 589);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(64, 64);
            this.button_encrypt.TabIndex = 3;
            this.button_encrypt.UseVisualStyleBackColor = true;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // button_decrypt
            // 
            this.button_decrypt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_decrypt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_decrypt.BackgroundImage")));
            this.button_decrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_decrypt.Location = new System.Drawing.Point(689, 589);
            this.button_decrypt.Name = "button_decrypt";
            this.button_decrypt.Size = new System.Drawing.Size(64, 64);
            this.button_decrypt.TabIndex = 4;
            this.button_decrypt.UseVisualStyleBackColor = true;
            this.button_decrypt.Click += new System.EventHandler(this.button_decrypt_Click);
            // 
            // main_label
            // 
            this.main_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.main_label.BackColor = System.Drawing.SystemColors.Control;
            this.main_label.Font = new System.Drawing.Font("Stay Pixel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_label.Location = new System.Drawing.Point(271, 94);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(482, 87);
            this.main_label.TabIndex = 6;
            this.main_label.Text = "Viginer modificated";
            this.main_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::Sem_3_Lab_8.Properties.Resources.key;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(346, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // key_numericUpDown
            // 
            this.key_numericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.key_numericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.key_numericUpDown.Font = new System.Drawing.Font("Gorgeous Pixel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.key_numericUpDown.Location = new System.Drawing.Point(414, 381);
            this.key_numericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.key_numericUpDown.Name = "key_numericUpDown";
            this.key_numericUpDown.Size = new System.Drawing.Size(200, 31);
            this.key_numericUpDown.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(346, 317);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackgroundImage = global::Sem_3_Lab_8.Properties.Resources.Letter;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(346, 441);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // input_textBox
            // 
            this.input_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.input_textBox.AcceptsReturn = true;
            this.input_textBox.AcceptsTab = true;
            this.input_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.input_textBox.Font = new System.Drawing.Font("Gorgeous Pixel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_textBox.Location = new System.Drawing.Point(414, 317);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.PlaceholderText = "1234";
            this.input_textBox.Size = new System.Drawing.Size(200, 31);
            this.input_textBox.TabIndex = 1;
            // 
            // output_textBox
            // 
            this.output_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.output_textBox.AcceptsTab = true;
            this.output_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.output_textBox.Font = new System.Drawing.Font("Gorgeous Pixel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output_textBox.Location = new System.Drawing.Point(414, 441);
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.ReadOnly = true;
            this.output_textBox.Size = new System.Drawing.Size(200, 31);
            this.output_textBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sem_3_Lab_8.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.input_textBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.key_numericUpDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.button_decrypt);
            this.Controls.Add(this.button_encrypt);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Semestr 3 Lab 8 Shuvaev Vadim AB-021";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_encrypt;
        private Button button_decrypt;
        private Label main_label;
        private PictureBox pictureBox1;
        private NumericUpDown key_numericUpDown;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox input_textBox;
        private TextBox output_textBox;
    }
}