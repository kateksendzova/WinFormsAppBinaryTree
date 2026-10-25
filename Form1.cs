using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAppBinaryTree
{
    public partial class Form1 : Form
    {
        private BinarySearchTree tree = new BinarySearchTree();

        public Form1()
        {
            InitializeComponent();
            int[] sampleData = { 50, 30, 70, 20, 44, 60, 82, 3, 45, 12, 90 };
            foreach (var val in sampleData)
            {
                tree.Insert(val);
            }


            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, panelTree, new object[] { true });

            panelTree.Paint += PanelTree_Paint;
        }

        private void PanelTree_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (tree.root != null)
            {
                int startX = panelTree.Width / 2;
                int startY = 30;
                int initialHSpace = panelTree.Width / 4;

                DrawNodeRecursive(g, tree.root, startX, startY, initialHSpace);
            }
        }

        private void DrawNodeRecursive(Graphics g, Node current, int x, int y, int hSpace)
        {
            int radius = 15;

            if (current.left != null)
            {
                int nextX = x - hSpace;
                int nextY = y + 60;
                g.DrawLine(Pens.DarkSlateGray, x, y, nextX, nextY);
                DrawNodeRecursive(g, current.left, nextX, nextY, hSpace / 2);
            }

            if (current.right != null)
            {
                int nextX = x + hSpace;
                int nextY = y + 60;
                g.DrawLine(Pens.DarkSlateGray, x, y, nextX, nextY);
                DrawNodeRecursive(g, current.right, nextX, nextY, hSpace / 2);
            }

            Brush circleBrush = Brushes.PaleGreen;
            g.FillEllipse(circleBrush, x - radius, y - radius, radius * 2, radius * 2);
            g.DrawEllipse(Pens.ForestGreen, x - radius, y - radius, radius * 2, radius * 2);

            using (Font font = new Font("Verdana", 9, FontStyle.Bold))
            {
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                {
                    g.DrawString(current.value.ToString(), font, Brushes.Black, x, y, sf);
                }
            }
        }

        private void button_BottomUpTraversal_Click(object sender, EventArgs e)
        {
            List<int> result = new List<int>();
            tree.BottomUpTraversal(tree.root, result);
            textBox_BottomUpTraversal.Text = string.Join(", ", result);
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_EnterElements.Text, out int searchVal))
            {
                bool exists = tree.Contains(searchVal);
                textBox_InTree.Text = exists ? "Так" : "Ні";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть ціле число!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_CheckTop_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_EnterTop.Text, out int targetVal))
            {
                Node foundNode = tree.FindNode(tree.root, targetVal);
                if (foundNode == null)
                {
                    MessageBox.Show("Таку вершину не знайдено в дереві!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Node parentNode = tree.FindParent(tree.root, targetVal);
                textBox_FatherTop.Text = parentNode != null ? parentNode.value.ToString() : "Немає";

                List<string> children = new List<string>();
                if (foundNode.left != null) children.Add($"Лівий: {foundNode.left.value}");
                if (foundNode.right != null) children.Add($"Правий: {foundNode.right.value}");

                textBox1.Text = children.Count > 0 ? string.Join(", ", children) : "Немає нащадків (листок)";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть ціле число вершини!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Find_Click(object sender, EventArgs e)
        {
            int? secondEven = tree.GetSecondEvenVertex();
            if (secondEven.HasValue)
            {
                textBox_SecondEvenTop.Text = secondEven.Value.ToString();
            }
            else
            {
                textBox_SecondEvenTop.Text = "Не знайдено";
            }
        }

        private void button_AddTop_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_AddTop.Text, out int newValue))
            {
                tree.Insert(newValue);
                textBox_AddTop.Clear();
                panelTree.Invalidate();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть ціле число для додавання!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}