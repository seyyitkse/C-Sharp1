namespace _31_Trafik_Lambasi
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
            this.components = new System.ComponentModel.Container();
            this.lightOnBtn = new System.Windows.Forms.Button();
            this.lightOffBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lightOnBtn
            // 
            this.lightOnBtn.Location = new System.Drawing.Point(101, 363);
            this.lightOnBtn.Name = "lightOnBtn";
            this.lightOnBtn.Size = new System.Drawing.Size(113, 29);
            this.lightOnBtn.TabIndex = 0;
            this.lightOnBtn.Text = "Işığı Çalıştır";
            this.lightOnBtn.UseVisualStyleBackColor = true;
            this.lightOnBtn.Click += new System.EventHandler(this.lightOnBtn_Click);
            // 
            // lightOffBtn
            // 
            this.lightOffBtn.Location = new System.Drawing.Point(241, 363);
            this.lightOffBtn.Name = "lightOffBtn";
            this.lightOffBtn.Size = new System.Drawing.Size(113, 29);
            this.lightOffBtn.TabIndex = 1;
            this.lightOffBtn.Text = "Işığı Durdur";
            this.lightOffBtn.UseVisualStyleBackColor = true;
            this.lightOffBtn.Click += new System.EventHandler(this.lightOffBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightOffBtn);
            this.Controls.Add(this.lightOnBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button lightOnBtn;
        private Button lightOffBtn;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}