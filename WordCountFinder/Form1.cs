namespace WordCountFinder
{
    public partial class WordCountFinder : Form
    {
        public WordCountFinder()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SplitContainer _2_generalSplitContainer;
            Panel _4_simbolsCountPartLabel;
            Panel _4_wordCountsPartPannel;
            Panel _1_generalPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordCountFinder));
            _wordsInputBox = new RichTextBox();
            _btnClearText = new Button();
            _btnCalculate = new Button();
            _inputTextOutputInfoGroupBox = new GroupBox();
            _simbolsCountValue = new Label();
            _simbolsCountLabel = new Label();
            _wordsCountValue = new Label();
            _wordsCountLabel = new Label();
            _menuToolStrip = new ToolStrip();
            _menuStripFileCategory = new ToolStripDropDownButton();
            _menuStripLoadFileBtn = new ToolStripMenuItem();
            _menuStripSettingsCategory = new ToolStripDropDownButton();
            _menuStripWorkModeComboBox = new ToolStripComboBox();
            realtimeModeToolStripMenuItem = new ToolStripMenuItem();
            _openFileDialog = new OpenFileDialog();
            _2_generalSplitContainer = new SplitContainer();
            _4_simbolsCountPartLabel = new Panel();
            _4_wordCountsPartPannel = new Panel();
            _1_generalPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)_2_generalSplitContainer).BeginInit();
            _2_generalSplitContainer.Panel1.SuspendLayout();
            _2_generalSplitContainer.Panel2.SuspendLayout();
            _2_generalSplitContainer.SuspendLayout();
            _inputTextOutputInfoGroupBox.SuspendLayout();
            _4_simbolsCountPartLabel.SuspendLayout();
            _4_wordCountsPartPannel.SuspendLayout();
            _1_generalPanel.SuspendLayout();
            _menuToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // _2_generalSplitContainer
            // 
            _2_generalSplitContainer.Dock = DockStyle.Fill;
            _2_generalSplitContainer.Location = new Point(8, 38);
            _2_generalSplitContainer.Margin = new Padding(0);
            _2_generalSplitContainer.Name = "_2_generalSplitContainer";
            // 
            // _2_generalSplitContainer.Panel1
            // 
            _2_generalSplitContainer.Panel1.Controls.Add(_wordsInputBox);
            // 
            // _2_generalSplitContainer.Panel2
            // 
            _2_generalSplitContainer.Panel2.Controls.Add(_btnClearText);
            _2_generalSplitContainer.Panel2.Controls.Add(_btnCalculate);
            _2_generalSplitContainer.Panel2.Controls.Add(_inputTextOutputInfoGroupBox);
            _2_generalSplitContainer.Panel2.Margin = new Padding(10);
            _2_generalSplitContainer.Size = new Size(502, 278);
            _2_generalSplitContainer.SplitterDistance = 300;
            _2_generalSplitContainer.TabIndex = 2;
            // 
            // _wordsInputBox
            // 
            _wordsInputBox.Dock = DockStyle.Fill;
            _wordsInputBox.Location = new Point(0, 0);
            _wordsInputBox.Name = "_wordsInputBox";
            _wordsInputBox.Size = new Size(300, 278);
            _wordsInputBox.TabIndex = 0;
            _wordsInputBox.Text = "";
            _wordsInputBox.TextChanged += _wordsInputBox_TextChanged;
            // 
            // _btnClearText
            // 
            _btnClearText.Dock = DockStyle.Bottom;
            _btnClearText.Enabled = false;
            _btnClearText.Location = new Point(0, 220);
            _btnClearText.Name = "_btnClearText";
            _btnClearText.Size = new Size(198, 29);
            _btnClearText.TabIndex = 2;
            _btnClearText.TabStop = false;
            _btnClearText.Text = "Clear";
            _btnClearText.UseVisualStyleBackColor = true;
            _btnClearText.Click += _btnClearText_Click;
            // 
            // _btnCalculate
            // 
            _btnCalculate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _btnCalculate.Dock = DockStyle.Bottom;
            _btnCalculate.Enabled = false;
            _btnCalculate.Location = new Point(0, 249);
            _btnCalculate.Name = "_btnCalculate";
            _btnCalculate.Size = new Size(198, 29);
            _btnCalculate.TabIndex = 1;
            _btnCalculate.Text = "Calculate";
            _btnCalculate.UseVisualStyleBackColor = true;
            _btnCalculate.Click += _btnCalculate_Click;
            // 
            // _inputTextOutputInfoGroupBox
            // 
            _inputTextOutputInfoGroupBox.AutoSize = true;
            _inputTextOutputInfoGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _inputTextOutputInfoGroupBox.Controls.Add(_4_simbolsCountPartLabel);
            _inputTextOutputInfoGroupBox.Controls.Add(_4_wordCountsPartPannel);
            _inputTextOutputInfoGroupBox.Dock = DockStyle.Top;
            _inputTextOutputInfoGroupBox.Enabled = false;
            _inputTextOutputInfoGroupBox.ImeMode = ImeMode.NoControl;
            _inputTextOutputInfoGroupBox.Location = new Point(0, 0);
            _inputTextOutputInfoGroupBox.Margin = new Padding(4);
            _inputTextOutputInfoGroupBox.Name = "_inputTextOutputInfoGroupBox";
            _inputTextOutputInfoGroupBox.Size = new Size(198, 66);
            _inputTextOutputInfoGroupBox.TabIndex = 0;
            _inputTextOutputInfoGroupBox.TabStop = false;
            _inputTextOutputInfoGroupBox.Text = "Info";
            // 
            // _4_simbolsCountPartLabel
            // 
            _4_simbolsCountPartLabel.AutoSize = true;
            _4_simbolsCountPartLabel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _4_simbolsCountPartLabel.Controls.Add(_simbolsCountValue);
            _4_simbolsCountPartLabel.Controls.Add(_simbolsCountLabel);
            _4_simbolsCountPartLabel.Dock = DockStyle.Top;
            _4_simbolsCountPartLabel.Location = new Point(3, 43);
            _4_simbolsCountPartLabel.Name = "_4_simbolsCountPartLabel";
            _4_simbolsCountPartLabel.Size = new Size(192, 20);
            _4_simbolsCountPartLabel.TabIndex = 1;
            // 
            // _simbolsCountValue
            // 
            _simbolsCountValue.AutoSize = true;
            _simbolsCountValue.Dock = DockStyle.Right;
            _simbolsCountValue.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _simbolsCountValue.Location = new Point(174, 0);
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
            // _4_wordCountsPartPannel
            // 
            _4_wordCountsPartPannel.AutoSize = true;
            _4_wordCountsPartPannel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _4_wordCountsPartPannel.Controls.Add(_wordsCountValue);
            _4_wordCountsPartPannel.Controls.Add(_wordsCountLabel);
            _4_wordCountsPartPannel.Dock = DockStyle.Top;
            _4_wordCountsPartPannel.Location = new Point(3, 23);
            _4_wordCountsPartPannel.Name = "_4_wordCountsPartPannel";
            _4_wordCountsPartPannel.Size = new Size(192, 20);
            _4_wordCountsPartPannel.TabIndex = 0;
            // 
            // _wordsCountValue
            // 
            _wordsCountValue.AutoSize = true;
            _wordsCountValue.Dock = DockStyle.Right;
            _wordsCountValue.Font = new Font("Cascadia Mono Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            _wordsCountValue.Location = new Point(174, 0);
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
            // _1_generalPanel
            // 
            _1_generalPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _1_generalPanel.Controls.Add(_2_generalSplitContainer);
            _1_generalPanel.Dock = DockStyle.Fill;
            _1_generalPanel.Location = new Point(0, 0);
            _1_generalPanel.Name = "_1_generalPanel";
            _1_generalPanel.Padding = new Padding(8, 38, 8, 8);
            _1_generalPanel.Size = new Size(518, 324);
            _1_generalPanel.TabIndex = 3;
            // 
            // _menuToolStrip
            // 
            _menuToolStrip.ImageScalingSize = new Size(20, 20);
            _menuToolStrip.Items.AddRange(new ToolStripItem[] { _menuStripFileCategory, _menuStripSettingsCategory });
            _menuToolStrip.Location = new Point(0, 0);
            _menuToolStrip.Name = "_menuToolStrip";
            _menuToolStrip.Size = new Size(518, 27);
            _menuToolStrip.TabIndex = 4;
            _menuToolStrip.Text = "toolStrip1";
            // 
            // _menuStripFileCategory
            // 
            _menuStripFileCategory.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _menuStripFileCategory.DropDownItems.AddRange(new ToolStripItem[] { _menuStripLoadFileBtn });
            _menuStripFileCategory.Image = (Image)resources.GetObject("_menuStripFileCategory.Image");
            _menuStripFileCategory.ImageTransparentColor = Color.Magenta;
            _menuStripFileCategory.Name = "_menuStripFileCategory";
            _menuStripFileCategory.Size = new Size(46, 24);
            _menuStripFileCategory.Text = "File";
            // 
            // _menuStripLoadFileBtn
            // 
            _menuStripLoadFileBtn.Name = "_menuStripLoadFileBtn";
            _menuStripLoadFileBtn.Size = new Size(125, 26);
            _menuStripLoadFileBtn.Text = "Load";
            _menuStripLoadFileBtn.Click += _menuStripLoadFileBtn_Click;
            // 
            // _menuStripSettingsCategory
            // 
            _menuStripSettingsCategory.DropDownItems.AddRange(new ToolStripItem[] { _menuStripWorkModeComboBox, realtimeModeToolStripMenuItem });
            _menuStripSettingsCategory.Name = "_menuStripSettingsCategory";
            _menuStripSettingsCategory.Size = new Size(76, 24);
            _menuStripSettingsCategory.Text = "Settings";
            // 
            // _menuStripWorkModeComboBox
            // 
            _menuStripWorkModeComboBox.Items.AddRange(new object[] { "Write and calculate", "Realtime calculating" });
            _menuStripWorkModeComboBox.Name = "_menuStripWorkModeComboBox";
            _menuStripWorkModeComboBox.Size = new Size(121, 28);
            _menuStripWorkModeComboBox.Visible = false;
            _menuStripWorkModeComboBox.Click += _menuStripWorkModeComboBox_Click;
            // 
            // realtimeModeToolStripMenuItem
            // 
            realtimeModeToolStripMenuItem.CheckOnClick = true;
            realtimeModeToolStripMenuItem.Name = "realtimeModeToolStripMenuItem";
            realtimeModeToolStripMenuItem.Size = new Size(224, 26);
            realtimeModeToolStripMenuItem.Text = "Realtime mode";
            realtimeModeToolStripMenuItem.Click += realtimeModeToolStripMenuItem_Click;
            // 
            // _openFileDialog
            // 
            _openFileDialog.FileOk += _openFileDialog_FileOk;
            // 
            // WordCountFinder
            // 
            ClientSize = new Size(518, 324);
            Controls.Add(_menuToolStrip);
            Controls.Add(_1_generalPanel);
            Name = "WordCountFinder";
            Text = "Words Count Finder";
            Load += WordCountFinder_Load;
            _2_generalSplitContainer.Panel1.ResumeLayout(false);
            _2_generalSplitContainer.Panel2.ResumeLayout(false);
            _2_generalSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_2_generalSplitContainer).EndInit();
            _2_generalSplitContainer.ResumeLayout(false);
            _inputTextOutputInfoGroupBox.ResumeLayout(false);
            _inputTextOutputInfoGroupBox.PerformLayout();
            _4_simbolsCountPartLabel.ResumeLayout(false);
            _4_simbolsCountPartLabel.PerformLayout();
            _4_wordCountsPartPannel.ResumeLayout(false);
            _4_wordCountsPartPannel.PerformLayout();
            _1_generalPanel.ResumeLayout(false);
            _menuToolStrip.ResumeLayout(false);
            _menuToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private RichTextBox _wordsInputBox;
        private GroupBox _inputTextOutputInfoGroupBox;
        private Button _btnCalculate;
        private Label _wordsCountLabel;
        private Label _simbolsCountLabel;
        private Label _wordsCountValue;
        private Label _simbolsCountValue;
        private Button _btnClearText;
        private ToolStrip _menuToolStrip;
        private ToolStripDropDownButton _menuStripFileCategory;
        private ToolStripMenuItem _menuStripLoadFileBtn;
        private ToolStripDropDownButton _menuStripSettingsCategory;
        private ToolStripComboBox _menuStripWorkModeComboBox;
        private OpenFileDialog _openFileDialog;
        private ToolStripMenuItem realtimeModeToolStripMenuItem;

        //TODO: REWORK IT!!!
        //мм, хуета ↓
        bool realtimeMode = false;
        Func<bool> textWrited = () => false;

        private void WordCountFinder_Load(object sender, EventArgs e)
        {
            textWrited = () => _wordsInputBox.TextLength > 0;

            if (realtimeMode)
            {
                RealtimeModeInit();
            }
        }

        private void _menuStripWorkModeComboBox_Click(object sender, EventArgs e)
        {
            if (_menuStripWorkModeComboBox.Text == "Realtime calculating")
            {
                realtimeMode = true;
                RealtimeModeInit();
            }
        }

        private void _btnClearText_Click(object sender, EventArgs e)
        {
            _wordsInputBox.Clear();
        }

        private void _btnCalculate_Click(object sender, EventArgs e)
        {
            if (realtimeMode)
            {
                return;
            }

            _inputTextOutputInfoGroupBox.Enabled = true;

            CalculateValues();

            _btnCalculate.Enabled = false;
        }

        private void _wordsInputBox_TextChanged(object sender, EventArgs e)
        {
            _btnClearText.Enabled = textWrited();

            if (realtimeMode)
            {
                _inputTextOutputInfoGroupBox.Enabled = _wordsInputBox.TextLength > 0;

                CalculateValues();

                return;
            }

            _btnCalculate.Enabled = textWrited();

            _inputTextOutputInfoGroupBox.Enabled = false;
        }

        private void _menuStripLoadFileBtn_Click(object sender, EventArgs e)
        {
            _openFileDialog.ShowDialog();
        }

        private void _openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _wordsInputBox.Text = ReadFile(_openFileDialog.OpenFile());
        }

        private void realtimeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            realtimeMode = !realtimeMode;

            if (realtimeMode)
            {
                CalculateValues();
                RealtimeModeInit();
            }
        }

        private void CalculateValues()
        {
            _wordsCountValue.Text = _wordsInputBox.Text.Split(' ').Length.ToString();
            _simbolsCountValue.Text = _wordsInputBox.Text.Trim().Length.ToString();
        }

        private void RealtimeModeInit()
        {
            _btnCalculate.Enabled = false;
            _inputTextOutputInfoGroupBox.Enabled = textWrited();
        }

        private string ReadFile(Stream stream)
        {
            try
            {
                using (StreamReader reader = new(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return default;
        }
    }
}
