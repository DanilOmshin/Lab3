using System;
using System.IO;
using System.Windows.Forms;

namespace VectorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возникает в момент нажатия клавиши в текстовом поле
        /// </summary>
        private void coeffsTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char character = e.KeyChar;

            if (!char.IsControl(character)
                && !char.IsDigit(character)
                && (character != ',')
                && (character != '-'))
                e.Handled = true;

            if (character == ',' &&
                tb.Text.IndexOf(',') > -1)
                e.Handled = true;

            if (character == '-'
                && tb.Text.IndexOf('-') > -1)
                e.Handled = true;

            if (character == '-' &&
                    (tb.Text.IndexOf('-') > -1))
                e.Handled = true;

            if (character == '-' &&
                    (tb.SelectionStart != 0))
                e.Handled = true;

            if ((char.IsDigit(character) ||
                    (character == ',')) &&
                        (tb.Text.IndexOf('-') > -1) &&
                            tb.SelectionStart == 0)
                e.Handled = true;
        }

        /// <summary>
        /// Возникает при загрузке формы
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] txt = File.ReadAllLines("data.txt");
                X1tb.Text = txt[0];
                Y1tb.Text = txt[1];
                Z1tb.Text = txt[2];
                X2tb.Text = txt[3];
                Y2tb.Text = txt[4];
                Z2tb.Text = txt[5];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Данные не были сохранены или не могут быть загружены!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Возникает при закрытии формы
        /// </summary>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                TextWriter txt = new StreamWriter("data.txt");
                txt.WriteLine(X1tb.Text);
                txt.WriteLine(Y1tb.Text);
                txt.WriteLine(Z1tb.Text);
                txt.WriteLine(X2tb.Text);
                txt.WriteLine(Y2tb.Text);
                txt.WriteLine(Z2tb.Text);
                txt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка сохранения данных из формы!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Считывает значения координат из переданных текстовых полей
        /// </summary>
        private void ReadCoords(TextBox tb1, TextBox tb2, TextBox tb3, 
            ref double x1, ref double y1, ref double z1)
        {
            if (!double.TryParse(tb1.Text, out x1))
            {
                MessageBox.Show("Пустое поле для ввода X!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(tb2.Text, out y1))
            {
                MessageBox.Show("Пустое поле для ввода Y!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(tb3.Text, out z1))
            {
                MessageBox.Show("Пустое поле для ввода Z!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Создает новый вектор из заданных текстовых полей
        /// </summary>
        private Vector CreateVector(TextBox tb1, TextBox tb2, TextBox tb3)
        {
            double x = 0, y = 0, z = 0;
            ReadCoords(tb1, tb2, tb3, ref x, ref y, ref z);
            return new Vector(x, y, z);
        }

        /// <summary>
        /// Выводит результирующий вектор на форму
        /// </summary>
        private void PrintResVector(Vector vec)
        {
            XRtb.Text = vec.X.ToString();
            YRtb.Text = vec.Y.ToString();
            ZRtb.Text = vec.Z.ToString();
            LenResLabel.Text = "Длина вектора: " + 
                vec.GetLength().ToString();
        }

        /// <summary>
        /// Возникает при нажатии кнопки "Длина вектора" в группе "Вектор 1"
        /// </summary>
        private void V1LenButton_Click(object sender, EventArgs e)
        {
            Vector vec = CreateVector(X1tb, Y1tb, Z1tb);
            double len = vec.GetLength();
            Len1Label.Text = "Длина вектора: " + len.ToString();
        }

        /// <summary>
        /// Возникает при нажатии кнопки "Длина вектора" в группе "Вектор 2"
        /// </summary>
        private void V2LenButton_Click(object sender, EventArgs e)
        {
            Vector vec = CreateVector(X2tb, Y2tb, Z2tb);
            double len = vec.GetLength();
            Len2Label.Text = "Длина вектора: " + len.ToString();
        }

        /// <summary>
        /// Возникает при нажатии кнопки "Сложение векторов"
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Vector vec1 = CreateVector(X1tb, Y1tb, Z1tb);
            Vector vec2 = CreateVector(X2tb, Y2tb, Z2tb);
            Vector res = vec1 + vec2;
            PrintResVector(res);
        }

        /// <summary>
        /// Возникает при нажатии кнопки "Вычитание векторов"
        /// </summary>
        private void DiffButton_Click(object sender, EventArgs e)
        {
            Vector vec1 = CreateVector(X1tb, Y1tb, Z1tb);
            Vector vec2 = CreateVector(X2tb, Y2tb, Z2tb);
            Vector res = vec1 - vec2;
            PrintResVector(res);
        }

        /// <summary>
        /// Возникает при нажатии кнопки "Произведение векторов"
        /// </summary>
        private void MultButton_Click(object sender, EventArgs e)
        {
            Vector vec1 = CreateVector(X1tb, Y1tb, Z1tb);
            Vector vec2 = CreateVector(X2tb, Y2tb, Z2tb);
            Vector res = vec1 ^ vec2;
            PrintResVector(res);
        }

        /// <summary>
        /// Возникает при нажатии кнопки "Скалярное произведение"
        /// </summary>
        private void ScalarButton_Click(object sender, EventArgs e)
        {
            Vector vec1 = CreateVector(X1tb, Y1tb, Z1tb);
            Vector vec2 = CreateVector(X2tb, Y2tb, Z2tb);
            double res = vec1 * vec2;
            ScalarResLabel.Text = "Скалярное произведение: " + res.ToString();
        }

        /// <summary>
        /// Возникает при нажатии кнопки "Очистить все"
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            X1tb.Clear(); X2tb.Clear(); XRtb.Clear();
            Y1tb.Clear(); Y2tb.Clear(); YRtb.Clear();
            Z1tb.Clear(); Z2tb.Clear(); ZRtb.Clear();
            Len1Label.Text = "Длина вектора: ";
            Len2Label.Text = "Длина вектора: ";
            LenResLabel.Text = "Длина вектора: ";
            ScalarResLabel.Text = "Скалярное произведение: ";
        }
    }
}
