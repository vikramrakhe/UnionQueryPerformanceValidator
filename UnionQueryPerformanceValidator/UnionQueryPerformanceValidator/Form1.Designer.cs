namespace UnionQueryPerformanceValidator
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
            this.ParallelQueryButton = new System.Windows.Forms.Button();
            this.UnionQueryButton = new System.Windows.Forms.Button();
            this.unionQueryText = new System.Windows.Forms.TextBox();
            this.parallelQueryText = new System.Windows.Forms.TextBox();
            this.ComapareButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParallelQueryButton
            // 
            this.ParallelQueryButton.Location = new System.Drawing.Point(12, 109);
            this.ParallelQueryButton.Name = "ParallelQueryButton";
            this.ParallelQueryButton.Size = new System.Drawing.Size(232, 39);
            this.ParallelQueryButton.TabIndex = 1;
            this.ParallelQueryButton.Text = "Execute Parallel Queries";
            this.ParallelQueryButton.UseVisualStyleBackColor = true;
            this.ParallelQueryButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnionQueryButton
            // 
            this.UnionQueryButton.Location = new System.Drawing.Point(12, 59);
            this.UnionQueryButton.Name = "UnionQueryButton";
            this.UnionQueryButton.Size = new System.Drawing.Size(232, 36);
            this.UnionQueryButton.TabIndex = 2;
            this.UnionQueryButton.Text = "Execute Union Query";
            this.UnionQueryButton.UseVisualStyleBackColor = true;
            this.UnionQueryButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // unionQueryText
            // 
            this.unionQueryText.Location = new System.Drawing.Point(129, 6);
            this.unionQueryText.Name = "unionQueryText";
            this.unionQueryText.Size = new System.Drawing.Size(95, 20);
            this.unionQueryText.TabIndex = 3;
            // 
            // parallelQueryText
            // 
            this.parallelQueryText.Location = new System.Drawing.Point(134, 6);
            this.parallelQueryText.Name = "parallelQueryText";
            this.parallelQueryText.Size = new System.Drawing.Size(95, 20);
            this.parallelQueryText.TabIndex = 4;
            // 
            // ComapareButton
            // 
            this.ComapareButton.Location = new System.Drawing.Point(148, 181);
            this.ComapareButton.Name = "ComapareButton";
            this.ComapareButton.Size = new System.Drawing.Size(232, 33);
            this.ComapareButton.TabIndex = 5;
            this.ComapareButton.Text = "Compare ResultSet";
            this.ComapareButton.UseVisualStyleBackColor = true;
            this.ComapareButton.Click += new System.EventHandler(this.ComapareButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Time Taken";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.parallelQueryText);
            this.panel1.Location = new System.Drawing.Point(250, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 35);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Time Taken";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.unionQueryText);
            this.panel2.Location = new System.Drawing.Point(250, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 36);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Compare Union Query With Parallel Queries ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComapareButton);
            this.Controls.Add(this.UnionQueryButton);
            this.Controls.Add(this.ParallelQueryButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Performance Validator Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ParallelQueryButton;
        private System.Windows.Forms.Button UnionQueryButton;
        private System.Windows.Forms.TextBox unionQueryText;
        private System.Windows.Forms.TextBox parallelQueryText;
        private System.Windows.Forms.Button ComapareButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

