namespace Group7_Rakhmanov_Ohalebo_QGame
{
	partial class DesignerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolBoxPanel = new Panel();
            blueBoxButton = new Button();
            mainPanel = new Panel();
            greenBoxButton = new Button();
            redBoxButton = new Button();
            blueDoorButton = new Button();
            greenDoorButton = new Button();
            redDoorButton = new Button();
            wallButton = new Button();
            noneButton = new Button();
            topBarPanel = new Panel();
            exitButton = new Button();
            saveButton = new Button();
            loadButton = new Button();
            generateButton = new Button();
            columnComboBox = new ComboBox();
            rowComboBox = new ComboBox();
            label1 = new Label();
            labelRow = new Label();
            toolTipPopup = new ToolTip(components);
            label2 = new Label();
            toolBoxPanel.SuspendLayout();
            topBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // toolBoxPanel
            // 
            toolBoxPanel.BorderStyle = BorderStyle.Fixed3D;
            toolBoxPanel.Controls.Add(blueBoxButton);
            toolBoxPanel.Controls.Add(mainPanel);
            toolBoxPanel.Controls.Add(greenBoxButton);
            toolBoxPanel.Controls.Add(redBoxButton);
            toolBoxPanel.Controls.Add(blueDoorButton);
            toolBoxPanel.Controls.Add(greenDoorButton);
            toolBoxPanel.Controls.Add(redDoorButton);
            toolBoxPanel.Controls.Add(wallButton);
            toolBoxPanel.Controls.Add(noneButton);
            toolBoxPanel.Controls.Add(label2);
            toolBoxPanel.Location = new Point(12, 95);
            toolBoxPanel.Name = "toolBoxPanel";
            toolBoxPanel.Size = new Size(952, 661);
            toolBoxPanel.TabIndex = 0;
            // 
            // blueBoxButton
            // 
            blueBoxButton.Image = Properties.Resources.blue_block_24;
            blueBoxButton.ImageAlign = ContentAlignment.MiddleLeft;
            blueBoxButton.Location = new Point(7, 451);
            blueBoxButton.Name = "blueBoxButton";
            blueBoxButton.Size = new Size(149, 44);
            blueBoxButton.TabIndex = 8;
            blueBoxButton.Text = "Blue Box";
            blueBoxButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            blueBoxButton.UseVisualStyleBackColor = true;
            blueBoxButton.MouseClick += blueBoxButton_MouseClick;
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.BorderStyle = BorderStyle.Fixed3D;
            mainPanel.Location = new Point(174, -2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(776, 661);
            mainPanel.TabIndex = 1;
            // 
            // greenBoxButton
            // 
            greenBoxButton.Image = Properties.Resources.green_block_24;
            greenBoxButton.ImageAlign = ContentAlignment.MiddleLeft;
            greenBoxButton.Location = new Point(7, 396);
            greenBoxButton.Name = "greenBoxButton";
            greenBoxButton.Size = new Size(149, 44);
            greenBoxButton.TabIndex = 7;
            greenBoxButton.Text = "Green Box";
            greenBoxButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            greenBoxButton.UseVisualStyleBackColor = true;
            greenBoxButton.MouseClick += greenBoxButton_MouseClick;
            // 
            // redBoxButton
            // 
            redBoxButton.Image = Properties.Resources.red_block_24;
            redBoxButton.ImageAlign = ContentAlignment.MiddleLeft;
            redBoxButton.Location = new Point(7, 341);
            redBoxButton.Name = "redBoxButton";
            redBoxButton.Size = new Size(149, 44);
            redBoxButton.TabIndex = 6;
            redBoxButton.Text = "Red Box";
            redBoxButton.TextAlign = ContentAlignment.MiddleRight;
            redBoxButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            redBoxButton.UseVisualStyleBackColor = true;
            redBoxButton.MouseClick += redBoxButton_MouseClick;
            // 
            // blueDoorButton
            // 
            blueDoorButton.Image = Properties.Resources.blue_door_24;
            blueDoorButton.ImageAlign = ContentAlignment.MiddleLeft;
            blueDoorButton.Location = new Point(7, 286);
            blueDoorButton.Name = "blueDoorButton";
            blueDoorButton.Size = new Size(149, 44);
            blueDoorButton.TabIndex = 5;
            blueDoorButton.Text = "Blue Door";
            blueDoorButton.TextAlign = ContentAlignment.MiddleRight;
            blueDoorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            blueDoorButton.UseVisualStyleBackColor = true;
            blueDoorButton.MouseClick += blueDoorButton_MouseClick;
            // 
            // greenDoorButton
            // 
            greenDoorButton.Image = Properties.Resources.green_door_24;
            greenDoorButton.ImageAlign = ContentAlignment.MiddleLeft;
            greenDoorButton.Location = new Point(7, 231);
            greenDoorButton.Name = "greenDoorButton";
            greenDoorButton.Size = new Size(149, 44);
            greenDoorButton.TabIndex = 4;
            greenDoorButton.Text = "Green Door";
            greenDoorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            greenDoorButton.UseVisualStyleBackColor = true;
            greenDoorButton.MouseClick += greenDoorButton_MouseClick;
            // 
            // redDoorButton
            // 
            redDoorButton.Image = Properties.Resources.red_door_24;
            redDoorButton.ImageAlign = ContentAlignment.MiddleLeft;
            redDoorButton.Location = new Point(7, 176);
            redDoorButton.Name = "redDoorButton";
            redDoorButton.Size = new Size(149, 44);
            redDoorButton.TabIndex = 3;
            redDoorButton.Text = "Red Door";
            redDoorButton.TextAlign = ContentAlignment.MiddleRight;
            redDoorButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            redDoorButton.UseVisualStyleBackColor = true;
            redDoorButton.MouseClick += redDoorButton_MouseClick;
            // 
            // wallButton
            // 
            wallButton.Image = Properties.Resources.wall_24;
            wallButton.ImageAlign = ContentAlignment.MiddleLeft;
            wallButton.Location = new Point(7, 121);
            wallButton.Name = "wallButton";
            wallButton.Size = new Size(149, 44);
            wallButton.TabIndex = 2;
            wallButton.Text = "Wall";
            wallButton.UseVisualStyleBackColor = true;
            wallButton.MouseClick += wallButton_MouseClick;
            // 
            // noneButton
            // 
            noneButton.Image = Properties.Resources.square_24;
            noneButton.ImageAlign = ContentAlignment.MiddleLeft;
            noneButton.Location = new Point(7, 66);
            noneButton.Name = "noneButton";
            noneButton.Size = new Size(149, 44);
            noneButton.TabIndex = 1;
            noneButton.Text = "None";
            noneButton.UseVisualStyleBackColor = true;
            noneButton.MouseClick += noneButton_MouseClick;
            // 
            // topBarPanel
            // 
            topBarPanel.AutoSize = true;
            topBarPanel.BorderStyle = BorderStyle.Fixed3D;
            topBarPanel.Controls.Add(exitButton);
            topBarPanel.Controls.Add(saveButton);
            topBarPanel.Controls.Add(loadButton);
            topBarPanel.Controls.Add(generateButton);
            topBarPanel.Controls.Add(columnComboBox);
            topBarPanel.Controls.Add(rowComboBox);
            topBarPanel.Controls.Add(label1);
            topBarPanel.Controls.Add(labelRow);
            topBarPanel.Location = new Point(12, 12);
            topBarPanel.Name = "topBarPanel";
            topBarPanel.Size = new Size(952, 84);
            topBarPanel.TabIndex = 2;
            // 
            // exitButton
            // 
            exitButton.Image = Properties.Resources.exit_black_24;
            exitButton.ImageAlign = ContentAlignment.TopCenter;
            exitButton.Location = new Point(842, 11);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 60);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.BottomCenter;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // saveButton
            // 
            saveButton.Image = Properties.Resources.save_file_24;
            saveButton.ImageAlign = ContentAlignment.TopCenter;
            saveButton.Location = new Point(739, 11);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 60);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.TextAlign = ContentAlignment.BottomCenter;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Image = Properties.Resources.open_file_24;
            loadButton.ImageAlign = ContentAlignment.TopCenter;
            loadButton.Location = new Point(635, 11);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 60);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.TextAlign = ContentAlignment.BottomCenter;
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // generateButton
            // 
            generateButton.Image = Properties.Resources.game_design_24;
            generateButton.ImageAlign = ContentAlignment.TopCenter;
            generateButton.Location = new Point(419, 11);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(104, 60);
            generateButton.TabIndex = 4;
            generateButton.Text = "Generate";
            generateButton.TextAlign = ContentAlignment.BottomCenter;
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // columnComboBox
            // 
            columnComboBox.FormattingEnabled = true;
            columnComboBox.Items.AddRange(new object[] { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            columnComboBox.Location = new Point(269, 24);
            columnComboBox.Name = "columnComboBox";
            columnComboBox.Size = new Size(75, 33);
            columnComboBox.TabIndex = 3;
            // 
            // rowComboBox
            // 
            rowComboBox.FormattingEnabled = true;
            rowComboBox.Items.AddRange(new object[] { "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            rowComboBox.Location = new Point(72, 24);
            rowComboBox.Name = "rowComboBox";
            rowComboBox.Size = new Size(73, 33);
            rowComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 27);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Column";
            // 
            // labelRow
            // 
            labelRow.AutoSize = true;
            labelRow.Location = new Point(20, 26);
            labelRow.Name = "labelRow";
            labelRow.Size = new Size(46, 25);
            labelRow.TabIndex = 0;
            labelRow.Text = "Row";
            // 
            // toolTipPopup
            // 
            toolTipPopup.ShowAlways = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 22);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 0;
            label2.Text = "Toolbox";
            // 
            // DesignerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 768);
            Controls.Add(topBarPanel);
            Controls.Add(toolBoxPanel);
            Name = "DesignerForm";
            Text = "Q-Game Design Form";
            toolBoxPanel.ResumeLayout(false);
            toolBoxPanel.PerformLayout();
            topBarPanel.ResumeLayout(false);
            topBarPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel toolBoxPanel;
		private Panel mainPanel;
		private Panel topBarPanel;
		private Label labelRow;
		private Label label1;
		private Button exitButton;
		private Button saveButton;
		private Button loadButton;
		private Button generateButton;
		private ComboBox columnComboBox;
		private ComboBox rowComboBox;
		private Button redBoxButton;
		private Button blueDoorButton;
		private Button greenDoorButton;
		private Button redDoorButton;
		private Button wallButton;
		private Button noneButton;
		private Button blueBoxButton;
		private Button greenBoxButton;
		private ToolTip toolTip1;
		private ToolTip toolTipPopup;
        private Label label2;
    }
}