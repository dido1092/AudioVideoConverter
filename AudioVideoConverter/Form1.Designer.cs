namespace AudioVideoConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBoxItems = new RichTextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonStart = new Button();
            comboBoxFormats = new ComboBox();
            label1 = new Label();
            labelItems = new Label();
            labelPath = new Label();
            comboBoxDestination = new ComboBox();
            label2 = new Label();
            buttonBrowse = new Button();
            progressBarAll = new ProgressBar();
            label3 = new Label();
            buttonClear = new Button();
            textBoxURL = new TextBox();
            buttonDownloadURL = new Button();
            SuspendLayout();
            // 
            // richTextBoxItems
            // 
            richTextBoxItems.Location = new Point(12, 126);
            richTextBoxItems.Name = "richTextBoxItems";
            richTextBoxItems.Size = new Size(609, 288);
            richTextBoxItems.TabIndex = 0;
            richTextBoxItems.Text = "";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(62, 39);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(90, 12);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(62, 39);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(559, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(62, 39);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // comboBoxFormats
            // 
            comboBoxFormats.AccessibleName = "";
            comboBoxFormats.FormattingEnabled = true;
            comboBoxFormats.Items.AddRange(new object[] { "MP3", "MKV", "AVI", "FLV", "MP4" });
            comboBoxFormats.Location = new Point(89, 475);
            comboBoxFormats.Name = "comboBoxFormats";
            comboBoxFormats.Size = new Size(107, 23);
            comboBoxFormats.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 478);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 5;
            label1.Text = "Format To:";
            // 
            // labelItems
            // 
            labelItems.AutoSize = true;
            labelItems.Location = new Point(528, 417);
            labelItems.Name = "labelItems";
            labelItems.Size = new Size(42, 15);
            labelItems.TabIndex = 6;
            labelItems.Text = "Items: ";
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(12, 581);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(34, 15);
            labelPath.TabIndex = 7;
            labelPath.Text = "Path:";
            // 
            // comboBoxDestination
            // 
            comboBoxDestination.FormattingEnabled = true;
            comboBoxDestination.Location = new Point(89, 513);
            comboBoxDestination.Name = "comboBoxDestination";
            comboBoxDestination.Size = new Size(433, 23);
            comboBoxDestination.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 516);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 9;
            label2.Text = "Destination:";
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(528, 512);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(93, 23);
            buttonBrowse.TabIndex = 10;
            buttonBrowse.Text = "Browse...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // progressBarAll
            // 
            progressBarAll.Location = new Point(12, 422);
            progressBarAll.Name = "progressBarAll";
            progressBarAll.Size = new Size(510, 10);
            progressBarAll.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 478);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 14;
            label3.Text = "Exp: AAC";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(173, 12);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(62, 39);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear All";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxURL
            // 
            textBoxURL.Location = new Point(12, 86);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(487, 23);
            textBoxURL.TabIndex = 16;
            // 
            // buttonDownloadURL
            // 
            buttonDownloadURL.Location = new Point(505, 85);
            buttonDownloadURL.Name = "buttonDownloadURL";
            buttonDownloadURL.Size = new Size(116, 23);
            buttonDownloadURL.TabIndex = 17;
            buttonDownloadURL.Text = "Download URL";
            buttonDownloadURL.UseVisualStyleBackColor = true;
            buttonDownloadURL.Click += buttonDownloadURL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 605);
            Controls.Add(buttonDownloadURL);
            Controls.Add(textBoxURL);
            Controls.Add(buttonClear);
            Controls.Add(label3);
            Controls.Add(progressBarAll);
            Controls.Add(buttonBrowse);
            Controls.Add(label2);
            Controls.Add(comboBoxDestination);
            Controls.Add(labelPath);
            Controls.Add(labelItems);
            Controls.Add(label1);
            Controls.Add(comboBoxFormats);
            Controls.Add(buttonStart);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(richTextBoxItems);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuduioVideoConverter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxItems;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonStart;
        private ComboBox comboBoxFormats;
        private Label label1;
        private Label labelItems;
        private Label labelPath;
        private ComboBox comboBoxDestination;
        private Label label2;
        private Button buttonBrowse;
        private ProgressBar progressBarAll;
        private Label label3;
        private Button buttonClear;
        private TextBox textBoxURL;
        private Button buttonDownloadURL;
    }
}