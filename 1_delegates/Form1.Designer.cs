namespace _1_delegates
{
    partial class frmCalculator
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
            txbNumber1 = new TextBox();
            txbNumber2 = new TextBox();
            label2 = new Label();
            txbResult = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnDiv = new Button();
            btnSub = new Button();
            btnMulti = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "1º number:";
            // 
            // txbNumber1
            // 
            txbNumber1.Location = new Point(84, 6);
            txbNumber1.Name = "txbNumber1";
            txbNumber1.Size = new Size(100, 23);
            txbNumber1.TabIndex = 1;
            // 
            // txbNumber2
            // 
            txbNumber2.Location = new Point(84, 35);
            txbNumber2.Name = "txbNumber2";
            txbNumber2.Size = new Size(100, 23);
            txbNumber2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "2º number:";
            // 
            // txbResult
            // 
            txbResult.Location = new Point(84, 65);
            txbResult.Name = "txbResult";
            txbResult.ReadOnly = true;
            txbResult.Size = new Size(100, 23);
            txbResult.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 68);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "result:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 98);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(60, 140);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(39, 36);
            btnDiv.TabIndex = 7;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(60, 98);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(39, 36);
            btnSub.TabIndex = 8;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(15, 140);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(39, 36);
            btnMulti.TabIndex = 9;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(198, 201);
            Controls.Add(btnMulti);
            Controls.Add(btnSub);
            Controls.Add(btnDiv);
            Controls.Add(btnAdd);
            Controls.Add(txbResult);
            Controls.Add(label3);
            Controls.Add(txbNumber2);
            Controls.Add(label2);
            Controls.Add(txbNumber1);
            Controls.Add(label1);
            Name = "frmCalculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbNumber1;
        private TextBox txbNumber2;
        private Label label2;
        private TextBox txbResult;
        private Label label3;
        private Button btnAdd;
        private Button btnDiv;
        private Button btnSub;
        private Button btnMulti;
    }
}