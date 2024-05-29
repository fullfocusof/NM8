namespace LR8
{
    partial class IntegralForm
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
            this.buttonRectangleMethod = new System.Windows.Forms.Button();
            this.buttonTrapezMethod = new System.Windows.Forms.Button();
            this.buttonParabolaMethod = new System.Windows.Forms.Button();
            this.labelMethod = new System.Windows.Forms.Label();
            this.textBoxLeftData = new System.Windows.Forms.TextBox();
            this.labelLeftData = new System.Windows.Forms.Label();
            this.textBoxRightData = new System.Windows.Forms.TextBox();
            this.labelRightData = new System.Windows.Forms.Label();
            this.textBoxEps = new System.Windows.Forms.TextBox();
            this.labelEps = new System.Windows.Forms.Label();
            this.buttonExecInput = new System.Windows.Forms.Button();
            this.labelErrorInput = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonMonteKarloMethod = new System.Windows.Forms.Button();
            this.textBoxCntPts = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRectangleMethod
            // 
            this.buttonRectangleMethod.Location = new System.Drawing.Point(123, 37);
            this.buttonRectangleMethod.Name = "buttonRectangleMethod";
            this.buttonRectangleMethod.Size = new System.Drawing.Size(145, 23);
            this.buttonRectangleMethod.TabIndex = 0;
            this.buttonRectangleMethod.Text = "Метод прямоугольников";
            this.buttonRectangleMethod.UseVisualStyleBackColor = true;
            this.buttonRectangleMethod.Click += new System.EventHandler(this.buttonRectangleMethod_Click);
            // 
            // buttonTrapezMethod
            // 
            this.buttonTrapezMethod.Location = new System.Drawing.Point(123, 66);
            this.buttonTrapezMethod.Name = "buttonTrapezMethod";
            this.buttonTrapezMethod.Size = new System.Drawing.Size(145, 23);
            this.buttonTrapezMethod.TabIndex = 1;
            this.buttonTrapezMethod.Text = "Метод трапеций";
            this.buttonTrapezMethod.UseVisualStyleBackColor = true;
            this.buttonTrapezMethod.Click += new System.EventHandler(this.buttonTrapezMethod_Click);
            // 
            // buttonParabolaMethod
            // 
            this.buttonParabolaMethod.Location = new System.Drawing.Point(123, 95);
            this.buttonParabolaMethod.Name = "buttonParabolaMethod";
            this.buttonParabolaMethod.Size = new System.Drawing.Size(145, 23);
            this.buttonParabolaMethod.TabIndex = 2;
            this.buttonParabolaMethod.Text = "Метод парабол";
            this.buttonParabolaMethod.UseVisualStyleBackColor = true;
            this.buttonParabolaMethod.Click += new System.EventHandler(this.buttonParabolaMethod_Click);
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethod.Location = new System.Drawing.Point(61, 9);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(270, 20);
            this.labelMethod.TabIndex = 3;
            this.labelMethod.Text = "Выберите метод интегрирования:";
            // 
            // textBoxLeftData
            // 
            this.textBoxLeftData.Location = new System.Drawing.Point(106, 37);
            this.textBoxLeftData.Name = "textBoxLeftData";
            this.textBoxLeftData.Size = new System.Drawing.Size(57, 20);
            this.textBoxLeftData.TabIndex = 4;
            this.textBoxLeftData.Visible = false;
            this.textBoxLeftData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLeftData_KeyPress);
            // 
            // labelLeftData
            // 
            this.labelLeftData.AutoSize = true;
            this.labelLeftData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeftData.Location = new System.Drawing.Point(169, 37);
            this.labelLeftData.Name = "labelLeftData";
            this.labelLeftData.Size = new System.Drawing.Size(129, 20);
            this.labelLeftData.TabIndex = 5;
            this.labelLeftData.Text = "- левая граница";
            this.labelLeftData.Visible = false;
            // 
            // textBoxRightData
            // 
            this.textBoxRightData.Location = new System.Drawing.Point(106, 66);
            this.textBoxRightData.Name = "textBoxRightData";
            this.textBoxRightData.Size = new System.Drawing.Size(57, 20);
            this.textBoxRightData.TabIndex = 6;
            this.textBoxRightData.Visible = false;
            this.textBoxRightData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLeftData_KeyPress);
            // 
            // labelRightData
            // 
            this.labelRightData.AutoSize = true;
            this.labelRightData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRightData.Location = new System.Drawing.Point(169, 66);
            this.labelRightData.Name = "labelRightData";
            this.labelRightData.Size = new System.Drawing.Size(137, 20);
            this.labelRightData.TabIndex = 7;
            this.labelRightData.Text = "- правая граница";
            this.labelRightData.Visible = false;
            // 
            // textBoxEps
            // 
            this.textBoxEps.Location = new System.Drawing.Point(106, 95);
            this.textBoxEps.Name = "textBoxEps";
            this.textBoxEps.Size = new System.Drawing.Size(57, 20);
            this.textBoxEps.TabIndex = 8;
            this.textBoxEps.Visible = false;
            this.textBoxEps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLeftData_KeyPress);
            // 
            // labelEps
            // 
            this.labelEps.AutoSize = true;
            this.labelEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEps.Location = new System.Drawing.Point(169, 95);
            this.labelEps.Name = "labelEps";
            this.labelEps.Size = new System.Drawing.Size(89, 20);
            this.labelEps.TabIndex = 9;
            this.labelEps.Text = "- точность";
            this.labelEps.Visible = false;
            // 
            // buttonExecInput
            // 
            this.buttonExecInput.Location = new System.Drawing.Point(304, 150);
            this.buttonExecInput.Name = "buttonExecInput";
            this.buttonExecInput.Size = new System.Drawing.Size(75, 23);
            this.buttonExecInput.TabIndex = 10;
            this.buttonExecInput.Text = "ОК";
            this.buttonExecInput.UseVisualStyleBackColor = true;
            this.buttonExecInput.Visible = false;
            this.buttonExecInput.Click += new System.EventHandler(this.buttonExecInput_Click);
            // 
            // labelErrorInput
            // 
            this.labelErrorInput.AutoSize = true;
            this.labelErrorInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorInput.ForeColor = System.Drawing.Color.Red;
            this.labelErrorInput.Location = new System.Drawing.Point(102, 150);
            this.labelErrorInput.Name = "labelErrorInput";
            this.labelErrorInput.Size = new System.Drawing.Size(184, 20);
            this.labelErrorInput.TabIndex = 11;
            this.labelErrorInput.Text = "***Неверные данные***";
            this.labelErrorInput.Visible = false;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(12, 150);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 12;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Visible = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonMonteKarloMethod
            // 
            this.buttonMonteKarloMethod.Location = new System.Drawing.Point(123, 124);
            this.buttonMonteKarloMethod.Name = "buttonMonteKarloMethod";
            this.buttonMonteKarloMethod.Size = new System.Drawing.Size(145, 23);
            this.buttonMonteKarloMethod.TabIndex = 13;
            this.buttonMonteKarloMethod.Text = "Метод Монте-Карло";
            this.buttonMonteKarloMethod.UseVisualStyleBackColor = true;
            this.buttonMonteKarloMethod.Click += new System.EventHandler(this.buttonMonteKarloMethod_Click);
            // 
            // textBoxCntPts
            // 
            this.textBoxCntPts.Location = new System.Drawing.Point(106, 95);
            this.textBoxCntPts.Name = "textBoxCntPts";
            this.textBoxCntPts.Size = new System.Drawing.Size(57, 20);
            this.textBoxCntPts.TabIndex = 14;
            this.textBoxCntPts.Visible = false;
            this.textBoxCntPts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCntPts_KeyPress);
            // 
            // IntegralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 185);
            this.Controls.Add(this.textBoxCntPts);
            this.Controls.Add(this.buttonMonteKarloMethod);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.labelErrorInput);
            this.Controls.Add(this.buttonExecInput);
            this.Controls.Add(this.labelEps);
            this.Controls.Add(this.textBoxEps);
            this.Controls.Add(this.labelRightData);
            this.Controls.Add(this.textBoxRightData);
            this.Controls.Add(this.labelLeftData);
            this.Controls.Add(this.textBoxLeftData);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.buttonParabolaMethod);
            this.Controls.Add(this.buttonTrapezMethod);
            this.Controls.Add(this.buttonRectangleMethod);
            this.Name = "IntegralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Численное интегрирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRectangleMethod;
        private System.Windows.Forms.Button buttonTrapezMethod;
        private System.Windows.Forms.Button buttonParabolaMethod;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.TextBox textBoxLeftData;
        private System.Windows.Forms.Label labelLeftData;
        private System.Windows.Forms.TextBox textBoxRightData;
        private System.Windows.Forms.Label labelRightData;
        private System.Windows.Forms.TextBox textBoxEps;
        private System.Windows.Forms.Label labelEps;
        private System.Windows.Forms.Button buttonExecInput;
        private System.Windows.Forms.Label labelErrorInput;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonMonteKarloMethod;
        private System.Windows.Forms.TextBox textBoxCntPts;
    }
}

