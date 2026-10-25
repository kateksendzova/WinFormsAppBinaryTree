namespace WinFormsAppBinaryTree
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
            textBox_BottomUpTraversal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_EnterElements = new TextBox();
            label4 = new Label();
            textBox_InTree = new TextBox();
            button_BottomUpTraversal = new Button();
            button_Check = new Button();
            textBox_FatherTop = new TextBox();
            label5 = new Label();
            textBox_EnterTop = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            button_CheckTop = new Button();
            label8 = new Label();
            textBox_SecondEvenTop = new TextBox();
            button_Find = new Button();
            panelTree = new Panel();
            label9 = new Label();
            textBox_AddTop = new TextBox();
            label10 = new Label();
            button_AddTop = new Button();
            SuspendLayout();
            // 
            // textBox_BottomUpTraversal
            // 
            textBox_BottomUpTraversal.Location = new Point(924, 83);
            textBox_BottomUpTraversal.Name = "textBox_BottomUpTraversal";
            textBox_BottomUpTraversal.Size = new Size(947, 26);
            textBox_BottomUpTraversal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(282, 25);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 2;
            label1.Text = "Бінарне Дерево Пошуку";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(790, 86);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 3;
            label2.Text = "Висхідний обхід";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(790, 183);
            label3.Name = "label3";
            label3.Size = new Size(140, 18);
            label3.TabIndex = 4;
            label3.Text = "Введіть значення";
            // 
            // textBox_EnterElements
            // 
            textBox_EnterElements.Location = new Point(937, 180);
            textBox_EnterElements.Name = "textBox_EnterElements";
            textBox_EnterElements.Size = new Size(69, 26);
            textBox_EnterElements.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(790, 222);
            label4.Name = "label4";
            label4.Size = new Size(95, 18);
            label4.TabIndex = 6;
            label4.Text = "Присутнє - ";
            // 
            // textBox_InTree
            // 
            textBox_InTree.Location = new Point(880, 219);
            textBox_InTree.Name = "textBox_InTree";
            textBox_InTree.Size = new Size(69, 26);
            textBox_InTree.TabIndex = 7;
            // 
            // button_BottomUpTraversal
            // 
            button_BottomUpTraversal.BackColor = Color.PaleGreen;
            button_BottomUpTraversal.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_BottomUpTraversal.Location = new Point(1763, 123);
            button_BottomUpTraversal.Name = "button_BottomUpTraversal";
            button_BottomUpTraversal.Size = new Size(108, 45);
            button_BottomUpTraversal.TabIndex = 8;
            button_BottomUpTraversal.Text = "Обійти";
            button_BottomUpTraversal.UseVisualStyleBackColor = false;
            button_BottomUpTraversal.Click += button_BottomUpTraversal_Click;
            // 
            // button_Check
            // 
            button_Check.BackColor = Color.PaleGreen;
            button_Check.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Check.Location = new Point(1038, 180);
            button_Check.Name = "button_Check";
            button_Check.Size = new Size(134, 45);
            button_Check.TabIndex = 9;
            button_Check.Text = "Перевірка";
            button_Check.UseVisualStyleBackColor = false;
            button_Check.Click += button_Check_Click;
            // 
            // textBox_FatherTop
            // 
            textBox_FatherTop.Location = new Point(967, 377);
            textBox_FatherTop.Name = "textBox_FatherTop";
            textBox_FatherTop.Size = new Size(69, 26);
            textBox_FatherTop.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(790, 380);
            label5.Name = "label5";
            label5.Size = new Size(171, 18);
            label5.TabIndex = 12;
            label5.Text = "Батьківська вершина";
            // 
            // textBox_EnterTop
            // 
            textBox_EnterTop.Location = new Point(930, 340);
            textBox_EnterTop.Name = "textBox_EnterTop";
            textBox_EnterTop.Size = new Size(69, 26);
            textBox_EnterTop.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(790, 344);
            label6.Name = "label6";
            label6.Size = new Size(136, 18);
            label6.TabIndex = 10;
            label6.Text = "Введіть вершину";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(871, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1000, 26);
            textBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(790, 414);
            label7.Name = "label7";
            label7.Size = new Size(78, 18);
            label7.TabIndex = 15;
            label7.Text = "Нащадки";
            // 
            // button_CheckTop
            // 
            button_CheckTop.BackColor = Color.PaleGreen;
            button_CheckTop.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_CheckTop.Location = new Point(1069, 340);
            button_CheckTop.Name = "button_CheckTop";
            button_CheckTop.Size = new Size(134, 45);
            button_CheckTop.TabIndex = 16;
            button_CheckTop.Text = "Перевірка";
            button_CheckTop.UseVisualStyleBackColor = false;
            button_CheckTop.Click += button_CheckTop_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(790, 529);
            label8.Name = "label8";
            label8.Size = new Size(175, 18);
            label8.TabIndex = 17;
            label8.Text = "Друга парна вершина";
            // 
            // textBox_SecondEvenTop
            // 
            textBox_SecondEvenTop.Location = new Point(967, 526);
            textBox_SecondEvenTop.Name = "textBox_SecondEvenTop";
            textBox_SecondEvenTop.Size = new Size(69, 26);
            textBox_SecondEvenTop.TabIndex = 18;
            // 
            // button_Find
            // 
            button_Find.BackColor = Color.PaleGreen;
            button_Find.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Find.Location = new Point(924, 572);
            button_Find.Name = "button_Find";
            button_Find.Size = new Size(112, 45);
            button_Find.TabIndex = 19;
            button_Find.Text = "Знайти";
            button_Find.UseVisualStyleBackColor = false;
            button_Find.Click += button_Find_Click;
            // 
            // panelTree
            // 
            panelTree.BackColor = Color.White;
            panelTree.Location = new Point(48, 51);
            panelTree.Name = "panelTree";
            panelTree.Size = new Size(693, 566);
            panelTree.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(309, 651);
            label9.Name = "label9";
            label9.Size = new Size(156, 20);
            label9.TabIndex = 21;
            label9.Text = "Додати вершину";
            // 
            // textBox_AddTop
            // 
            textBox_AddTop.Location = new Point(422, 690);
            textBox_AddTop.Name = "textBox_AddTop";
            textBox_AddTop.Size = new Size(69, 26);
            textBox_AddTop.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(282, 694);
            label10.Name = "label10";
            label10.Size = new Size(136, 18);
            label10.TabIndex = 22;
            label10.Text = "Введіть вершину";
            // 
            // button_AddTop
            // 
            button_AddTop.BackColor = Color.PaleGreen;
            button_AddTop.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_AddTop.Location = new Point(330, 731);
            button_AddTop.Name = "button_AddTop";
            button_AddTop.Size = new Size(112, 45);
            button_AddTop.TabIndex = 24;
            button_AddTop.Text = "Додати";
            button_AddTop.UseVisualStyleBackColor = false;
            button_AddTop.Click += button_AddTop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1924, 786);
            Controls.Add(button_AddTop);
            Controls.Add(textBox_AddTop);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panelTree);
            Controls.Add(button_Find);
            Controls.Add(textBox_SecondEvenTop);
            Controls.Add(label8);
            Controls.Add(button_CheckTop);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(textBox_FatherTop);
            Controls.Add(label5);
            Controls.Add(textBox_EnterTop);
            Controls.Add(label6);
            Controls.Add(button_Check);
            Controls.Add(button_BottomUpTraversal);
            Controls.Add(textBox_InTree);
            Controls.Add(label4);
            Controls.Add(textBox_EnterElements);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_BottomUpTraversal);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Бінарне дерево";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_BottomUpTraversal;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_EnterElements;
        private Label label4;
        private TextBox textBox_InTree;
        private Button button_BottomUpTraversal;
        private Button button_Check;
        private TextBox textBox_FatherTop;
        private Label label5;
        private TextBox textBox_EnterTop;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private Button button_CheckTop;
        private Label label8;
        private TextBox textBox_SecondEvenTop;
        private Button button_Find;
        private Panel panelTree;
        private Label label9;
        private TextBox textBox_AddTop;
        private Label label10;
        private Button button_AddTop;
    }
}
