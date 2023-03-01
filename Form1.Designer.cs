namespace WFA
{
    partial class Form1
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSuccess = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.White;
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(569, 246);
            this.btnClick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(163, 65);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            this.btnClick.MouseLeave += new System.EventHandler(this.btnClick_MouseLeave);
            this.btnClick.MouseHover += new System.EventHandler(this.btnClick_MouseHover);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(57, 65);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 34);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseEnter += new System.EventHandler(this.btn1_MouseEnter);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1159, 65);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 34);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseEnter += new System.EventHandler(this.btn2_MouseEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1169, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSuccess
            // 
            this.btnSuccess.Location = new System.Drawing.Point(1169, 405);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(75, 34);
            this.btnSuccess.TabIndex = 1;
            this.btnSuccess.UseVisualStyleBackColor = true;
            this.btnSuccess.MouseEnter += new System.EventHandler(this.btnSuccess_MouseEnter);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(57, 405);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 34);
            this.btn3.TabIndex = 1;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseEnter += new System.EventHandler(this.btn3_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1316, 564);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnSuccess);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnClick);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.Button btn3;
    }
}

