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
            SplitContainer generalSplitContainer;
            Panel simbolsCountPartLabel;
            Panel wordCountsPartPannel;
            _wordsInputBox = new RichTextBox();
            _btnClearText = new Button();
            _btnCalculate = new Button();
            _inputTextOutputInfoGroupBox = new GroupBox();
            _simbolsCountValue = new Label();
            _simbolsCountLabel = new Label();
            _wordsCountValue = new Label();
            _wordsCountLabel = new Label();
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
            generalSplitContainer.Panel2.Controls.Add(_btnClearText);
            generalSplitContainer.Panel2.Controls.Add(_btnCalculate);
            generalSplitContainer.Panel2.Controls.Add(_inputTextOutputInfoGroupBox);
            generalSplitContainer.Panel2.Margin = new Padding(10);
            generalSplitContainer.Size = new Size(472, 267);
            generalSplitContainer.SplitterDistance = 283;
            generalSplitContainer.TabIndex = 2;
            // 
            // _wordsInputBox
            // 
            _wordsInputBox.Dock = DockStyle.Fill;
            _wordsInputBox.Location = new Point(0, 0);
            _wordsInputBox.Name = "_wordsInputBox";
            _wordsInputBox.Size = new Size(283, 267);
            _wordsInputBox.TabIndex = 0;
            _wordsInputBox.Text = "";
            _wordsInputBox.TextChanged += _wordsInputBox_TextChanged;
            // 
            // _btnClearText
            // 
            _btnClearText.Dock = DockStyle.Bottom;
            _btnClearText.Enabled = false;
            _btnClearText.Location = new Point(0, 209);
            _btnClearText.Name = "_btnClearText";
            _btnClearText.Size = new Size(185, 29);
            _btnClearText.TabIndex = 2;
            _btnClearText.Text = "Clear";
            _btnClearText.UseVisualStyleBackColor = true;
            _btnClearText.Click += _btnClearText_Click;
            // 
            // _btnCalculate
            // 
            _btnCalculate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _btnCalculate.Dock = DockStyle.Bottom;
            _btnCalculate.Enabled = false;
            _btnCalculate.Location = new Point(0, 238);
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
            // WordCountFinder
            // 
            ClientSize = new Size(488, 283);
            Controls.Add(generalSplitContainer);
            Name = "WordCountFinder";
            Padding = new Padding(8);
            Text = "Words Count Finder";
            Load += WordCountFinder_Load;
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
            ResumeLayout(false);
        }

        private RichTextBox _wordsInputBox;
        private GroupBox _inputTextOutputInfoGroupBox;
        private Button _btnCalculate;
        private Label _wordsCountLabel;
        private Label _simbolsCountLabel;
        private Label _wordsCountValue;
        private Label _simbolsCountValue;
        private Button _btnClearText;

        bool realtimeMode = false;

        private void WordCountFinder_Load(object sender, EventArgs e)
        {
            if (realtimeMode)
            {
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
            Func<bool> textStatus = () => _wordsInputBox.TextLength > 0;
            _btnClearText.Enabled = textStatus();

            if (realtimeMode)
            {
                _inputTextOutputInfoGroupBox.Enabled = _wordsInputBox.TextLength > 0;

                CalculateValues();

                return;
            }

            _btnCalculate.Enabled = textStatus();

            _inputTextOutputInfoGroupBox.Enabled = false;
        }

        private void CalculateValues()
        {
            _wordsCountValue.Text = _wordsInputBox.Text.Split(' ').Length.ToString();
            _simbolsCountValue.Text = _wordsInputBox.Text.Trim().Length.ToString();
        }

        private void RealtimeModeInit()
        {
            _btnCalculate.Enabled = false;
        }
    }
}
