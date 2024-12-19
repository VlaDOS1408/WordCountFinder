using WordCountFinder.Settings;

namespace WordCountFinder
{
    public partial class WordCountFinder : Form
    {
        public WordCountFinder()
        {
            InitializeComponent();

            _textWrited = () => _wordsInputBox.TextLength > 0;
            _calculateMode = () => Config.WorkMode.Value;
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SplitContainer generalSplitContainer;
            Panel simbolsCountPartLabel;
            Panel wordCountsPartPannel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordCountFinder));
            _wordsInputBox = new RichTextBox();
            _realtimeCheckBox = new CheckBox();
            _btnCalculate = new Button();
            _inputTextOutputInfoGroupBox = new GroupBox();
            _simbolsCountValue = new Label();
            _simbolsCountLabel = new Label();
            _wordsCountValue = new Label();
            _wordsCountLabel = new Label();
            SettingsMenuStrip = new ContextMenuStrip(components);
            toolStripButton1 = new ToolStripDropDownButton();
            grgToolStripMenuItem = new ToolStripMenuItem();
            writeAndCompileToolStripMenuItem = new ToolStripMenuItem();
            realtimeCalculateToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            generalSplitContainer = new SplitContainer();
            simbolsCountPartLabel = new Panel();
            wordCountsPartPannel = new Panel();
            ((System.ComponentModel.ISupportInitialize)generalSplitContainer).BeginInit();
            generalSplitContainer.Panel1.SuspendLayout();
            generalSplitContainer.Panel2.SuspendLayout();
            generalSplitContainer.SuspendLayout();
            _inputTextOutputInfoGroupBox.SuspendLayout();
            simbolsCountPartLabel.SuspendLayout();
            wordCountsPartPannel.SuspendLayout();
            SettingsMenuStrip.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // generalSplitContainer
            // 
            generalSplitContainer.Dock = DockStyle.Fill;
            generalSplitContainer.Location = new Point(8, 8);
            generalSplitContainer.Margin = new Padding(0);
            generalSplitContainer.Name = "generalSplitContainer";
            // 
            // generalSplitContainer.Panel1
            // 
            generalSplitContainer.Panel1.Controls.Add(_wordsInputBox);
            // 
            // generalSplitContainer.Panel2
            // 
            generalSplitContainer.Panel2.Controls.Add(_realtimeCheckBox);
            generalSplitContainer.Panel2.Controls.Add(_btnCalculate);
            generalSplitContainer.Panel2.Controls.Add(_inputTextOutputInfoGroupBox);
            generalSplitContainer.Panel2.Margin = new Padding(10);
            generalSplitContainer.Size = new Size(472, 257);
            generalSplitContainer.SplitterDistance = 283;
            generalSplitContainer.TabIndex = 2;
            // 
            // _wordsInputBox
            // 
            _wordsInputBox.Dock = DockStyle.Fill;
            _wordsInputBox.Location = new Point(0, 0);
            _wordsInputBox.Name = "_wordsInputBox";
            _wordsInputBox.Size = new Size(283, 257);
            _wordsInputBox.TabIndex = 0;
            _wordsInputBox.Text = "";
            _wordsInputBox.TextChanged += _wordsInputBox_TextChanged;
            // 
            // _realtimeCheckBox
            // 
            _realtimeCheckBox.AutoSize = true;
            _realtimeCheckBox.Location = new Point(3, 198);
            _realtimeCheckBox.Name = "_realtimeCheckBox";
            _realtimeCheckBox.Size = new Size(133, 24);
            _realtimeCheckBox.TabIndex = 2;
            _realtimeCheckBox.Text = "Realtime mode";
            _realtimeCheckBox.UseVisualStyleBackColor = true;
            _realtimeCheckBox.CheckedChanged += _realtimeCheckBox_CheckedChanged;
            // 
            // _btnCalculate
            // 
            _btnCalculate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _btnCalculate.Dock = DockStyle.Bottom;
            _btnCalculate.Location = new Point(0, 228);
            _btnCalculate.Name = "_btnCalculate";
            _btnCalculate.Size = new Size(185, 29);
            _btnCalculate.TabIndex = 1;
            _btnCalculate.Text = "Calculate";
            _btnCalculate.UseVisualStyleBackColor = true;
            _btnCalculate.Click += _btnCalculate_Click;
            // 
            // _inputTextOutputInfoGroupBox
            // 
            _inputTextOutputInfoGroupBox.AutoSize = true;
            _inputTextOutputInfoGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _inputTextOutputInfoGroupBox.Controls.Add(simbolsCountPartLabel);
            _inputTextOutputInfoGroupBox.Controls.Add(wordCountsPartPannel);
            _inputTextOutputInfoGroupBox.Dock = DockStyle.Top;
            _inputTextOutputInfoGroupBox.Enabled = false;
            _inputTextOutputInfoGroupBox.ImeMode = ImeMode.NoControl;
            _inputTextOutputInfoGroupBox.Location = new Point(0, 0);
            _inputTextOutputInfoGroupBox.Margin = new Padding(4);
            _inputTextOutputInfoGroupBox.Name = "_inputTextOutputInfoGroupBox";
            _inputTextOutputInfoGroupBox.Size = new Size(185, 66);
            _inputTextOutputInfoGroupBox.TabIndex = 0;
            _inputTextOutputInfoGroupBox.TabStop = false;
            _inputTextOutputInfoGroupBox.Text = "Info";
            // 
            // simbolsCountPartLabel
            // 
            simbolsCountPartLabel.AutoSize = true;
            simbolsCountPartLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            simbolsCountPartLabel.Controls.Add(_simbolsCountValue);
            simbolsCountPartLabel.Controls.Add(_simbolsCountLabel);
            simbolsCountPartLabel.Dock = DockStyle.Top;
            simbolsCountPartLabel.Location = new Point(3, 43);
            simbolsCountPartLabel.Name = "simbolsCountPartLabel";
            simbolsCountPartLabel.Size = new Size(179, 20);
            simbolsCountPartLabel.TabIndex = 1;
            // 
            // _simbolsCountValue
            // 
            _simbolsCountValue.AutoSize = true;
            _simbolsCountValue.Dock = DockStyle.Right;
            _simbolsCountValue.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _simbolsCountValue.Location = new Point(161, 0);
            _simbolsCountValue.Name = "_simbolsCountValue";
            _simbolsCountValue.Size = new Size(18, 20);
            _simbolsCountValue.TabIndex = 2;
            _simbolsCountValue.Text = "0\r\n";
            // 
            // _simbolsCountLabel
            // 
            _simbolsCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _simbolsCountLabel.Location = new Point(0, 0);
            _simbolsCountLabel.Name = "_simbolsCountLabel";
            _simbolsCountLabel.Size = new Size(106, 20);
            _simbolsCountLabel.TabIndex = 1;
            _simbolsCountLabel.Text = "Simbols count:";
            // 
            // wordCountsPartPannel
            // 
            wordCountsPartPannel.AutoSize = true;
            wordCountsPartPannel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            wordCountsPartPannel.Controls.Add(_wordsCountValue);
            wordCountsPartPannel.Controls.Add(_wordsCountLabel);
            wordCountsPartPannel.Dock = DockStyle.Top;
            wordCountsPartPannel.Location = new Point(3, 23);
            wordCountsPartPannel.Name = "wordCountsPartPannel";
            wordCountsPartPannel.Size = new Size(179, 20);
            wordCountsPartPannel.TabIndex = 0;
            // 
            // _wordsCountValue
            // 
            _wordsCountValue.AutoSize = true;
            _wordsCountValue.Dock = DockStyle.Right;
            _wordsCountValue.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _wordsCountValue.Location = new Point(161, 0);
            _wordsCountValue.Name = "_wordsCountValue";
            _wordsCountValue.Size = new Size(18, 20);
            _wordsCountValue.TabIndex = 1;
            _wordsCountValue.Text = "0";
            // 
            // _wordsCountLabel
            // 
            _wordsCountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _wordsCountLabel.Location = new Point(0, 0);
            _wordsCountLabel.Name = "_wordsCountLabel";
            _wordsCountLabel.Size = new Size(95, 20);
            _wordsCountLabel.TabIndex = 0;
            _wordsCountLabel.Text = "Words count:";
            // 
            // SettingsMenuStrip
            // 
            SettingsMenuStrip.ImageScalingSize = new Size(20, 20);
            SettingsMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            SettingsMenuStrip.Name = "SettingsMenuStrip";
            SettingsMenuStrip.Size = new Size(137, 31);
            SettingsMenuStrip.Text = "Settings";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { grgToolStripMenuItem });
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(76, 24);
            toolStripButton1.Text = "Settings";
            // 
            // grgToolStripMenuItem
            // 
            grgToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { writeAndCompileToolStripMenuItem, realtimeCalculateToolStripMenuItem });
            grgToolStripMenuItem.Name = "grgToolStripMenuItem";
            grgToolStripMenuItem.Size = new Size(169, 26);
            grgToolStripMenuItem.Text = "Work mode";
            // 
            // writeAndCompileToolStripMenuItem
            // 
            writeAndCompileToolStripMenuItem.Checked = true;
            writeAndCompileToolStripMenuItem.CheckState = CheckState.Checked;
            writeAndCompileToolStripMenuItem.Name = "writeAndCompileToolStripMenuItem";
            writeAndCompileToolStripMenuItem.Size = new Size(220, 26);
            writeAndCompileToolStripMenuItem.Text = "Write and calculate";
            // 
            // realtimeCalculateToolStripMenuItem
            // 
            realtimeCalculateToolStripMenuItem.Name = "realtimeCalculateToolStripMenuItem";
            realtimeCalculateToolStripMenuItem.Size = new Size(220, 26);
            realtimeCalculateToolStripMenuItem.Text = "Realtime calculate";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(generalSplitContainer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(488, 273);
            panel1.TabIndex = 4;
            // 
            // WordCountFinder
            // 
            ClientSize = new Size(488, 273);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WordCountFinder";
            Text = "Words Count Finder";
            generalSplitContainer.Panel1.ResumeLayout(false);
            generalSplitContainer.Panel2.ResumeLayout(false);
            generalSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)generalSplitContainer).EndInit();
            generalSplitContainer.ResumeLayout(false);
            _inputTextOutputInfoGroupBox.ResumeLayout(false);
            _inputTextOutputInfoGroupBox.PerformLayout();
            simbolsCountPartLabel.ResumeLayout(false);
            simbolsCountPartLabel.PerformLayout();
            wordCountsPartPannel.ResumeLayout(false);
            wordCountsPartPannel.PerformLayout();
            SettingsMenuStrip.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private CheckBox _realtimeCheckBox;
        private RichTextBox _wordsInputBox;
        private GroupBox _inputTextOutputInfoGroupBox;
        private Button _btnCalculate;
        private Label _wordsCountLabel;
        private Label _simbolsCountLabel;
        private Label _wordsCountValue;
        private Label _simbolsCountValue;
        private ContextMenuStrip SettingsMenuStrip;
        private System.ComponentModel.IContainer components;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem grgToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem writeAndCompileToolStripMenuItem;
        private ToolStripMenuItem realtimeCalculateToolStripMenuItem;

        private Func<bool> _textWrited = () => false;
        private Func<CalculateMode> _calculateMode = () => CalculateMode.WriteAndCalculate;

        private void _btnCalculate_Click(object sender, EventArgs e)
        {
            _inputTextOutputInfoGroupBox.Enabled = true;

            CalculateValues();
        }

        private void _realtimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Action<CalculateMode> _changeMode = (mode) => Config.WorkMode.Value = mode;

            if (_calculateMode() == CalculateMode.WriteAndCalculate)
            {
                _changeMode(CalculateMode.Realtime);

                CalculateValues();
            }
            else
            {
                _changeMode(CalculateMode.WriteAndCalculate);
            }

            _inputTextOutputInfoGroupBox.Enabled = _textWrited();
        }

        private void _wordsInputBox_TextChanged(object sender, EventArgs e)
        {
            if (_calculateMode() == CalculateMode.Realtime)
            {
                _inputTextOutputInfoGroupBox.Enabled = _textWrited();

                CalculateValues();
            }
            else
            {
                _inputTextOutputInfoGroupBox.Enabled = false;
            }
        }

        private void CalculateValues()
        {
            _wordsCountValue.Text = _wordsInputBox.Text.Split(' ').Length.ToString();
            _simbolsCountValue.Text = _wordsInputBox.Text.Trim().Length.ToString();
        }
    }
}
