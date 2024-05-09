namespace notes
{
    partial class NoteForm
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            stripMenuChangeFont = new ToolStripMenuItem();
            stripMenuChangeBackColor = new ToolStripMenuItem();
            textBoxNote = new TextBox();
            statusStrip1 = new StatusStrip();
            cursorPosition = new ToolStripStatusLabel();
            typingSpeedLabel = new ToolStripStatusLabel();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(305, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + S";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(305, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Shift + S";
            сохранитьКакToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            сохранитьКакToolStripMenuItem.Size = new Size(305, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            сохранитьКакToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { stripMenuChangeFont, stripMenuChangeBackColor });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(40, 20);
            видToolStripMenuItem.Text = "Вид";
            // 
            // stripMenuChangeFont
            // 
            stripMenuChangeFont.Name = "stripMenuChangeFont";
            stripMenuChangeFont.Size = new Size(200, 22);
            stripMenuChangeFont.Text = "Изменить шрифт";
            stripMenuChangeFont.Click += stripMenuChangeFont_Click;
            // 
            // stripMenuChangeBackColor
            // 
            stripMenuChangeBackColor.Name = "stripMenuChangeBackColor";
            stripMenuChangeBackColor.Size = new Size(200, 22);
            stripMenuChangeBackColor.Text = "Изменить цвет фона";
            stripMenuChangeBackColor.Click += stripMenuChangeBackColor_Click;
            // 
            // textBoxNote
            // 
            textBoxNote.AcceptsTab = true;
            textBoxNote.BorderStyle = BorderStyle.None;
            textBoxNote.Location = new Point(0, 27);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.ScrollBars = ScrollBars.Both;
            textBoxNote.Size = new Size(800, 398);
            textBoxNote.TabIndex = 0;
            textBoxNote.WordWrap = false;
            textBoxNote.TextChanged += TextBoxNote_TextChanged;
            textBoxNote.KeyPress += textBoxNote_KeyPress;
            textBoxNote.KeyUp += textBoxNote_KeyUp;
            textBoxNote.MouseDown += TextBoxNote_MouseDown;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { cursorPosition, typingSpeedLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // cursorPosition
            // 
            cursorPosition.Name = "cursorPosition";
            cursorPosition.Size = new Size(154, 17);
            cursorPosition.Text = "toolStripStatusLabel1";
            // 
            // typingSpeedLabel
            // 
            typingSpeedLabel.Name = "typingSpeedLabel";
            typingSpeedLabel.Size = new Size(154, 17);
            typingSpeedLabel.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(textBoxNote);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "NoteForm";
            Text = "Form1";
            FormClosing += NoteForm_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem stripMenuChangeFont;
        private ToolStripMenuItem stripMenuChangeBackColor;
        private TextBox textBoxNote;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel cursorPosition;
        private ToolStripStatusLabel typingSpeedLabel;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}
