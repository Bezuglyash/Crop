namespace Crop
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.картинка = new System.Windows.Forms.PictureBox();
            this.старт = new System.Windows.Forms.Button();
            this.таймер = new System.Windows.Forms.Timer(this.components);
            this.таймерСадовника = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.картинка)).BeginInit();
            this.SuspendLayout();
            // 
            // картинка
            // 
            this.картинка.Location = new System.Drawing.Point(-1, -1);
            this.картинка.Name = "картинка";
            this.картинка.Size = new System.Drawing.Size(714, 394);
            this.картинка.TabIndex = 0;
            this.картинка.TabStop = false;
            // 
            // старт
            // 
            this.старт.BackColor = System.Drawing.Color.Coral;
            this.старт.ForeColor = System.Drawing.Color.Black;
            this.старт.Location = new System.Drawing.Point(547, -1);
            this.старт.Name = "старт";
            this.старт.Size = new System.Drawing.Size(166, 33);
            this.старт.TabIndex = 1;
            this.старт.Text = "Начать!";
            this.старт.UseVisualStyleBackColor = false;
            this.старт.Click += new System.EventHandler(this.Старт_Click);
            // 
            // таймер
            // 
            this.таймер.Interval = 167;
            this.таймер.Tick += new System.EventHandler(this.Таймер_Tick);
            // 
            // таймерСадовника
            // 
            this.таймерСадовника.Interval = 228;
            this.таймерСадовника.Tick += new System.EventHandler(this.ТаймерСадовника_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 389);
            this.Controls.Add(this.старт);
            this.Controls.Add(this.картинка);
            this.MaximumSize = new System.Drawing.Size(728, 428);
            this.MinimumSize = new System.Drawing.Size(728, 428);
            this.Name = "Form1";
            this.Text = "Урожай";
            ((System.ComponentModel.ISupportInitialize)(this.картинка)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox картинка;
        private System.Windows.Forms.Button старт;
        private System.Windows.Forms.Timer таймер;
        private System.Windows.Forms.Timer таймерСадовника;
    }
}