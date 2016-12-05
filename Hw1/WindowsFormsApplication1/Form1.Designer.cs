namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webcam = new System.Windows.Forms.PictureBox();
            this.convertToGrey = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.PictureBox();
            this.convertToBinarization = new System.Windows.Forms.Button();
            this.sobelOperator = new System.Windows.Forms.Button();
            this.convertToNegative = new System.Windows.Forms.Button();
            this.rotate = new System.Windows.Forms.Button();
            this.captureImage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.captureOutput = new Emgu.CV.UI.ImageBox();
            this.chooseImage = new Emgu.CV.UI.ImageBox();
            this.ocr = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.webcam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webcam
            // 
            this.webcam.Location = new System.Drawing.Point(12, 12);
            this.webcam.Name = "webcam";
            this.webcam.Size = new System.Drawing.Size(480, 360);
            this.webcam.TabIndex = 0;
            this.webcam.TabStop = false;
            // 
            // convertToGrey
            // 
            this.convertToGrey.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.convertToGrey.Location = new System.Drawing.Point(23, 39);
            this.convertToGrey.Name = "convertToGrey";
            this.convertToGrey.Size = new System.Drawing.Size(120, 40);
            this.convertToGrey.TabIndex = 1;
            this.convertToGrey.Text = "灰階";
            this.convertToGrey.UseVisualStyleBackColor = true;
            this.convertToGrey.Click += new System.EventHandler(this.convertToGrey_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(503, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(480, 360);
            this.output.TabIndex = 2;
            this.output.TabStop = false;
            // 
            // convertToBinarization
            // 
            this.convertToBinarization.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.convertToBinarization.Location = new System.Drawing.Point(176, 39);
            this.convertToBinarization.Name = "convertToBinarization";
            this.convertToBinarization.Size = new System.Drawing.Size(120, 40);
            this.convertToBinarization.TabIndex = 3;
            this.convertToBinarization.Text = "二值化";
            this.convertToBinarization.UseVisualStyleBackColor = true;
            this.convertToBinarization.Click += new System.EventHandler(this.convertToBinarization_Click);
            // 
            // sobelOperator
            // 
            this.sobelOperator.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sobelOperator.Location = new System.Drawing.Point(334, 39);
            this.sobelOperator.Name = "sobelOperator";
            this.sobelOperator.Size = new System.Drawing.Size(120, 40);
            this.sobelOperator.TabIndex = 4;
            this.sobelOperator.Text = "Sobel";
            this.sobelOperator.UseVisualStyleBackColor = true;
            this.sobelOperator.Click += new System.EventHandler(this.sobelOperator_Click);
            // 
            // convertToNegative
            // 
            this.convertToNegative.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.convertToNegative.Location = new System.Drawing.Point(97, 113);
            this.convertToNegative.Name = "convertToNegative";
            this.convertToNegative.Size = new System.Drawing.Size(120, 40);
            this.convertToNegative.TabIndex = 5;
            this.convertToNegative.Text = "負片";
            this.convertToNegative.UseVisualStyleBackColor = true;
            this.convertToNegative.Click += new System.EventHandler(this.convertToNegative_Click);
            // 
            // rotate
            // 
            this.rotate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rotate.Location = new System.Drawing.Point(255, 113);
            this.rotate.Name = "rotate";
            this.rotate.Size = new System.Drawing.Size(120, 40);
            this.rotate.TabIndex = 6;
            this.rotate.Text = "旋轉";
            this.rotate.UseVisualStyleBackColor = true;
            this.rotate.Click += new System.EventHandler(this.rotate_Click);
            // 
            // captureImage
            // 
            this.captureImage.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.captureImage.Location = new System.Drawing.Point(56, 26);
            this.captureImage.Name = "captureImage";
            this.captureImage.Size = new System.Drawing.Size(150, 40);
            this.captureImage.TabIndex = 7;
            this.captureImage.Text = "擷取視訊";
            this.captureImage.UseVisualStyleBackColor = true;
            this.captureImage.Click += new System.EventHandler(this.captureImage_Click);
            // 
            // captureOutput
            // 
            this.captureOutput.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.captureOutput.Location = new System.Drawing.Point(999, 12);
            this.captureOutput.Name = "captureOutput";
            this.captureOutput.Size = new System.Drawing.Size(480, 360);
            this.captureOutput.TabIndex = 2;
            this.captureOutput.TabStop = false;
            this.captureOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.webcam_MouseDown);
            this.captureOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.webcam_MouseMove);
            this.captureOutput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.webcam_MouseUp);
            // 
            // chooseImage
            // 
            this.chooseImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.chooseImage.Location = new System.Drawing.Point(999, 378);
            this.chooseImage.Name = "chooseImage";
            this.chooseImage.Size = new System.Drawing.Size(480, 175);
            this.chooseImage.TabIndex = 2;
            this.chooseImage.TabStop = false;
            // 
            // ocr
            // 
            this.ocr.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ocr.Location = new System.Drawing.Point(285, 26);
            this.ocr.Name = "ocr";
            this.ocr.Size = new System.Drawing.Size(150, 40);
            this.ocr.TabIndex = 8;
            this.ocr.Text = "數字辨識";
            this.ocr.UseVisualStyleBackColor = true;
            this.ocr.Click += new System.EventHandler(this.ocr_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextBox.Location = new System.Drawing.Point(191, 134);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(179, 34);
            this.resultTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(77, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "輸出結果：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sobelOperator);
            this.groupBox1.Controls.Add(this.convertToBinarization);
            this.groupBox1.Controls.Add(this.convertToGrey);
            this.groupBox1.Controls.Add(this.convertToNegative);
            this.groupBox1.Controls.Add(this.rotate);
            this.groupBox1.Location = new System.Drawing.Point(12, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 175);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影像處理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "※ 擷取視訊畫面後，將欲辨識之區域用滑鼠框選起來。\r\n    再按下「辨識」按鈕，便可將欲辨識之結果輸出至下方TextBox。\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.captureImage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ocr);
            this.groupBox2.Controls.Add(this.resultTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(503, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 175);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "數字辨識";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chooseImage);
            this.Controls.Add(this.captureOutput);
            this.Controls.Add(this.output);
            this.Controls.Add(this.webcam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webcam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captureOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox webcam;
        private System.Windows.Forms.Button convertToGrey;
        private System.Windows.Forms.PictureBox output;
        private System.Windows.Forms.Button convertToBinarization;
        private System.Windows.Forms.Button sobelOperator;
        private System.Windows.Forms.Button convertToNegative;
        private System.Windows.Forms.Button rotate;
        private System.Windows.Forms.Button captureImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private Emgu.CV.UI.ImageBox captureOutput;
        private Emgu.CV.UI.ImageBox chooseImage;
        private System.Windows.Forms.Button ocr;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

