namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.drawPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDrawPts = new System.Windows.Forms.ToolStripButton();
            this.tsbRecognize = new System.Windows.Forms.ToolStripButton();
            this.tsbCalculate = new System.Windows.Forms.ToolStripButton();
            this.tslSquare = new System.Windows.Forms.ToolStripLabel();
            this.tslCircle = new System.Windows.Forms.ToolStripLabel();
            this.tslPI = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.Location = new System.Drawing.Point(12, 28);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(600, 600);
            this.drawPanel.TabIndex = 0;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDrawPts,
            this.tsbRecognize,
            this.tsbCalculate,
            this.tslSquare,
            this.tslCircle,
            this.tslPI});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDrawPts
            // 
            this.tsbDrawPts.AutoToolTip = false;
            this.tsbDrawPts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDrawPts.Image = ((System.Drawing.Image)(resources.GetObject("tsbDrawPts.Image")));
            this.tsbDrawPts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDrawPts.Name = "tsbDrawPts";
            this.tsbDrawPts.Size = new System.Drawing.Size(45, 22);
            this.tsbDrawPts.Text = "Throw";
            this.tsbDrawPts.Click += new System.EventHandler(this.tsbDrawPts_Click);
            // 
            // tsbRecognize
            // 
            this.tsbRecognize.AutoToolTip = false;
            this.tsbRecognize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRecognize.Enabled = false;
            this.tsbRecognize.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecognize.Image")));
            this.tsbRecognize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecognize.Name = "tsbRecognize";
            this.tsbRecognize.Size = new System.Drawing.Size(48, 22);
            this.tsbRecognize.Text = "Shapes";
            this.tsbRecognize.Click += new System.EventHandler(this.tsbRecognize_Click);
            // 
            // tsbCalculate
            // 
            this.tsbCalculate.AutoToolTip = false;
            this.tsbCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCalculate.Enabled = false;
            this.tsbCalculate.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalculate.Image")));
            this.tsbCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalculate.Name = "tsbCalculate";
            this.tsbCalculate.Size = new System.Drawing.Size(60, 22);
            this.tsbCalculate.Text = "Calculate";
            this.tsbCalculate.Click += new System.EventHandler(this.tsbCalculate_Click);
            // 
            // tslSquare
            // 
            this.tslSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslSquare.Name = "tslSquare";
            this.tslSquare.Size = new System.Drawing.Size(85, 22);
            this.tslSquare.Text = "Square points: ";
            // 
            // tslCircle
            // 
            this.tslCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslCircle.Name = "tslCircle";
            this.tslCircle.Size = new System.Drawing.Size(79, 22);
            this.tslCircle.Text = "Circle points: ";
            // 
            // tslPI
            // 
            this.tslPI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslPI.Name = "tslPI";
            this.tslPI.Size = new System.Drawing.Size(23, 22);
            this.tslPI.Text = "PI: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 640);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.drawPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDrawPts;
        private System.Windows.Forms.ToolStripButton tsbRecognize;
        private System.Windows.Forms.ToolStripButton tsbCalculate;
        private System.Windows.Forms.ToolStripLabel tslSquare;
        private System.Windows.Forms.ToolStripLabel tslCircle;
        private System.Windows.Forms.ToolStripLabel tslPI;
    }
}

