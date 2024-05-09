using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace notes
{
    public partial class NoteForm : Form
    {
        private bool isTextChanged;
        private FileInfo? file;
        private int symbolsTyped;
        private const int Tick = 3000;
        private const int Minute = 60000;

        public NoteForm()
        {
            InitializeComponent();
            Text = "Новая заметка";
            cursorPosition.Text = "Текущая строка: 1 | Текущий столбец: 1 |";
            typingSpeedLabel.Text = "0 символов в минуту";
            timer1.Interval = Tick;
        }

        private void CurrentCursorPositionChanged()
        {
            var startSelectedIndex = textBoxNote.SelectionStart;
            var textBeforeCaret = textBoxNote.Text[..startSelectedIndex];
            var lineIndex = textBeforeCaret.Count(substr => substr == '\n');
            var amount = startSelectedIndex - textBeforeCaret.LastIndexOf('\n');
            cursorPosition.Text = $"Текущая строка: {lineIndex + 1} | Текущий столбец: {amount} |";
        }

        private static DialogResult exitForm() =>
            MessageBox.Show("Сохранить последние изменения в файле?", "Сохранение", MessageBoxButtons.YesNoCancel);

        private void Save()
        {
            if (file != null)
            {
                using var writer = file.CreateText();
                writer.Write(textBoxNote.Text);
                isTextChanged = false;
            }
            else
            {
                SaveAs();
            }
        }

        private void SaveAs()
        {
            var writer = new SaveFileDialog();
            writer.Filter = "Текстовый документ|*.txt";
            if (writer.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            file = new FileInfo(writer.FileName);
            Text = file.Name;
        }

        private void TextBoxNote_TextChanged(object sender, EventArgs e)
        {
            isTextChanged = true;
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isTextChanged)
            {
                switch (exitForm())
                {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isTextChanged)
            {
                if (exitForm() == DialogResult.Cancel)
                {
                    return;
                }
            }
            var opener = new OpenFileDialog();
            opener.Filter = "Текстовый документ|*.txt";
            if (opener.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            file = new FileInfo(opener.FileName);
            if (file != null)
            {
                using var reader = file.OpenText();
                textBoxNote.Text = reader.ReadToEnd();
                isTextChanged = false;
                Text = file.Name;
            }
        }

        private void TextBoxNote_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentCursorPositionChanged();
        }

        private void textBoxNote_KeyUp(object sender, KeyEventArgs e)
        {
            CurrentCursorPositionChanged();
        }

        private Color? ColorChangeRequest()
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            return colorDialog1.Color;
        }

        private void stripMenuChangeBackColor_Click(object sender, EventArgs e)
        {
            var color = ColorChangeRequest();
            if (color is not null)
            {
                textBoxNote.BackColor = color.Value;
            }
        }

        private (Font font, Color color)? FontChangeRequest()
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return null;
            }
            return (fontDialog1.Font, fontDialog1.Color);
        }

        private void stripMenuChangeFont_Click(object sender, EventArgs e)
        {
            var font = FontChangeRequest();
            if (font is not null)
            {
                textBoxNote.Font = font.Value.font;
                textBoxNote.ForeColor = font.Value.color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var typingSpeed = symbolsTyped * (Minute / Tick);
            typingSpeedLabel.Text = $"{typingSpeed} символов в минуту";
            symbolsTyped = 0;
        }

        private void textBoxNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
            }
            symbolsTyped++;
        }

    }
}
