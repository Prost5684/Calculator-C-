namespace Calculator
{
    partial class Form
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
            this.btnSign = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtScreen = new System.Windows.Forms.TextBox();
            this.btnMemClear = new System.Windows.Forms.Button();
            this.btnMemRecall = new System.Windows.Forms.Button();
            this.btnMemSub = new System.Windows.Forms.Button();
            this.btnMemStore = new System.Windows.Forms.Button();
            this.btnMemAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSign
            // 
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(14, 500);
            this.btnSign.Margin = new System.Windows.Forms.Padding(5);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(80, 80);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(104, 500);
            this.btnZero.Margin = new System.Windows.Forms.Padding(5);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(80, 80);
            this.btnZero.TabIndex = 1;
            this.btnZero.Tag = "0";
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDot
            // 
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(194, 500);
            this.btnDot.Margin = new System.Windows.Forms.Padding(5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(80, 80);
            this.btnDot.TabIndex = 2;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(294, 500);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 80);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnResult
            // 
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(384, 410);
            this.btnResult.Margin = new System.Windows.Forms.Padding(5);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(80, 170);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnThree
            // 
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(194, 410);
            this.btnThree.Margin = new System.Windows.Forms.Padding(5);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(80, 80);
            this.btnThree.TabIndex = 7;
            this.btnThree.Tag = "3";
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(104, 410);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(5);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(80, 80);
            this.btnTwo.TabIndex = 6;
            this.btnTwo.Tag = "2";
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnEight
            // 
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(104, 230);
            this.btnEight.Margin = new System.Windows.Forms.Padding(5);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(80, 80);
            this.btnEight.TabIndex = 5;
            this.btnEight.Tag = "8";
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSix
            // 
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(194, 320);
            this.btnSix.Margin = new System.Windows.Forms.Padding(5);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(80, 80);
            this.btnSix.TabIndex = 10;
            this.btnSix.Tag = "6";
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(104, 320);
            this.btnFive.Margin = new System.Windows.Forms.Padding(5);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(80, 80);
            this.btnFive.TabIndex = 9;
            this.btnFive.Tag = "5";
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnOne
            // 
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(14, 410);
            this.btnOne.Margin = new System.Windows.Forms.Padding(5);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(80, 80);
            this.btnOne.TabIndex = 8;
            this.btnOne.Tag = "1";
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnNine
            // 
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(194, 230);
            this.btnNine.Margin = new System.Windows.Forms.Padding(5);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(80, 80);
            this.btnNine.TabIndex = 13;
            this.btnNine.Tag = "9";
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(13, 230);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(80, 80);
            this.btnSeven.TabIndex = 12;
            this.btnSeven.Tag = "7";
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnFour
            // 
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(13, 320);
            this.btnFour.Margin = new System.Windows.Forms.Padding(5);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(80, 80);
            this.btnFour.TabIndex = 11;
            this.btnFour.Tag = "4";
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnSub
            // 
            this.btnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(294, 410);
            this.btnSub.Margin = new System.Windows.Forms.Padding(5);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(80, 80);
            this.btnSub.TabIndex = 14;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(294, 320);
            this.btnMult.Margin = new System.Windows.Forms.Padding(5);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(80, 80);
            this.btnMult.TabIndex = 15;
            this.btnMult.Text = "×";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(294, 230);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(80, 80);
            this.btnDiv.TabIndex = 16;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(384, 320);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 80);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "D";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(384, 230);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 80);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtScreen
            // 
            this.txtScreen.Font = new System.Drawing.Font("Roboto Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreen.Location = new System.Drawing.Point(14, 14);
            this.txtScreen.Margin = new System.Windows.Forms.Padding(5);
            this.txtScreen.Name = "txtScreen";
            this.txtScreen.ReadOnly = true;
            this.txtScreen.Size = new System.Drawing.Size(450, 102);
            this.txtScreen.TabIndex = 19;
            this.txtScreen.Text = "-1234567890";
            this.txtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMemClear
            // 
            this.btnMemClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemClear.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemClear.Location = new System.Drawing.Point(384, 140);
            this.btnMemClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemClear.Name = "btnMemClear";
            this.btnMemClear.Size = new System.Drawing.Size(80, 80);
            this.btnMemClear.TabIndex = 24;
            this.btnMemClear.Text = "MC";
            this.btnMemClear.UseVisualStyleBackColor = true;
            this.btnMemClear.Click += new System.EventHandler(this.btnMemClear_Click);
            // 
            // btnMemRecall
            // 
            this.btnMemRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemRecall.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemRecall.Location = new System.Drawing.Point(294, 140);
            this.btnMemRecall.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemRecall.Name = "btnMemRecall";
            this.btnMemRecall.Size = new System.Drawing.Size(80, 80);
            this.btnMemRecall.TabIndex = 23;
            this.btnMemRecall.Text = "MR";
            this.btnMemRecall.UseVisualStyleBackColor = true;
            this.btnMemRecall.Click += new System.EventHandler(this.btnMemRecall_Click);
            // 
            // btnMemSub
            // 
            this.btnMemSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemSub.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemSub.Location = new System.Drawing.Point(194, 140);
            this.btnMemSub.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemSub.Name = "btnMemSub";
            this.btnMemSub.Size = new System.Drawing.Size(80, 80);
            this.btnMemSub.TabIndex = 22;
            this.btnMemSub.Text = "M-";
            this.btnMemSub.UseVisualStyleBackColor = true;
            this.btnMemSub.Click += new System.EventHandler(this.btnMemSub_Click);
            // 
            // btnMemStore
            // 
            this.btnMemStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemStore.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemStore.Location = new System.Drawing.Point(13, 140);
            this.btnMemStore.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemStore.Name = "btnMemStore";
            this.btnMemStore.Size = new System.Drawing.Size(80, 80);
            this.btnMemStore.TabIndex = 21;
            this.btnMemStore.Text = "MS";
            this.btnMemStore.UseVisualStyleBackColor = true;
            this.btnMemStore.Click += new System.EventHandler(this.btnMemStore_Click);
            // 
            // btnMemAdd
            // 
            this.btnMemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemAdd.Font = new System.Drawing.Font("Roboto Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemAdd.Location = new System.Drawing.Point(104, 140);
            this.btnMemAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemAdd.Name = "btnMemAdd";
            this.btnMemAdd.Size = new System.Drawing.Size(80, 80);
            this.btnMemAdd.TabIndex = 20;
            this.btnMemAdd.Text = "M+";
            this.btnMemAdd.UseVisualStyleBackColor = true;
            this.btnMemAdd.Click += new System.EventHandler(this.btnMemAdd_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 594);
            this.Controls.Add(this.btnMemClear);
            this.Controls.Add(this.btnMemRecall);
            this.Controls.Add(this.btnMemSub);
            this.Controls.Add(this.btnMemStore);
            this.Controls.Add(this.btnMemAdd);
            this.Controls.Add(this.txtScreen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSign);
            this.Name = "Form";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtScreen;
        private System.Windows.Forms.Button btnMemClear;
        private System.Windows.Forms.Button btnMemRecall;
        private System.Windows.Forms.Button btnMemSub;
        private System.Windows.Forms.Button btnMemStore;
        private System.Windows.Forms.Button btnMemAdd;
    }
}

