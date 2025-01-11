namespace Group7_Rakhmanov_Ohalebo_QGame
{
    partial class PlayForm
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
            toolTipPopup = new ToolTip(components);
            label1 = new Label();
            loadButton = new Button();
            labelRow = new Label();
            gamePanel = new Panel();
            toolBoxPanel = new Panel();
            labelNumberOfMoves = new Label();
            labelBoxesLeft = new Label();
            label3 = new Label();
            panelControls = new Panel();
            buttonDown = new Button();
            buttonRight = new Button();
            buttonUp = new Button();
            buttonLeft = new Button();
            label2 = new Label();
            newButton = new Button();
            restartButton = new Button();
            exitButton = new Button();
            labelNumberOfBoxes = new Label();
            toolBoxPanel.SuspendLayout();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // toolTipPopup
            // 
            toolTipPopup.ShowAlways = true;
            // 
            // label1
            // 
            label1.Location = new Point(29, 329);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 1;
            label1.Text = "No. of moves";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loadButton
            // 
            loadButton.Image = Properties.Resources.open_file_24;
            loadButton.ImageAlign = ContentAlignment.TopCenter;
            loadButton.Location = new Point(133, 457);
            loadButton.Margin = new Padding(4, 4, 4, 4);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(98, 77);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.TextAlign = ContentAlignment.BottomCenter;
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // labelRow
            // 
            labelRow.Location = new Point(29, 104);
            labelRow.Margin = new Padding(4, 0, 4, 0);
            labelRow.Name = "labelRow";
            labelRow.Size = new Size(203, 32);
            labelRow.TabIndex = 0;
            labelRow.Text = "No. of boxes";
            labelRow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gamePanel
            // 
            gamePanel.AutoSize = true;
            gamePanel.BorderStyle = BorderStyle.Fixed3D;
            gamePanel.Location = new Point(283, -3);
            gamePanel.Margin = new Padding(4, 4, 4, 4);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(950, 951);
            gamePanel.TabIndex = 1;
            // 
            // toolBoxPanel
            // 
            toolBoxPanel.BorderStyle = BorderStyle.Fixed3D;
            toolBoxPanel.Controls.Add(labelNumberOfMoves);
            toolBoxPanel.Controls.Add(labelBoxesLeft);
            toolBoxPanel.Controls.Add(label3);
            toolBoxPanel.Controls.Add(panelControls);
            toolBoxPanel.Controls.Add(gamePanel);
            toolBoxPanel.Controls.Add(label2);
            toolBoxPanel.Controls.Add(newButton);
            toolBoxPanel.Controls.Add(restartButton);
            toolBoxPanel.Controls.Add(exitButton);
            toolBoxPanel.Controls.Add(loadButton);
            toolBoxPanel.Controls.Add(labelNumberOfBoxes);
            toolBoxPanel.Controls.Add(labelRow);
            toolBoxPanel.Controls.Add(label1);
            toolBoxPanel.Location = new Point(16, 15);
            toolBoxPanel.Margin = new Padding(4, 4, 4, 4);
            toolBoxPanel.Name = "toolBoxPanel";
            toolBoxPanel.Size = new Size(1236, 951);
            toolBoxPanel.TabIndex = 3;
            // 
            // labelNumberOfMoves
            // 
            labelNumberOfMoves.Location = new Point(29, 375);
            labelNumberOfMoves.Margin = new Padding(4, 0, 4, 0);
            labelNumberOfMoves.Name = "labelNumberOfMoves";
            labelNumberOfMoves.Size = new Size(204, 32);
            labelNumberOfMoves.TabIndex = 9;
            labelNumberOfMoves.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBoxesLeft
            // 
            labelBoxesLeft.Location = new Point(29, 273);
            labelBoxesLeft.Margin = new Padding(4, 0, 4, 0);
            labelBoxesLeft.Name = "labelBoxesLeft";
            labelBoxesLeft.Size = new Size(203, 32);
            labelBoxesLeft.TabIndex = 9;
            labelBoxesLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(29, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 32);
            label3.TabIndex = 9;
            label3.Text = "No. of boxes left";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(buttonDown);
            panelControls.Controls.Add(buttonRight);
            panelControls.Controls.Add(buttonUp);
            panelControls.Controls.Add(buttonLeft);
            panelControls.Location = new Point(29, 726);
            panelControls.Margin = new Padding(4, 4, 4, 4);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(203, 192);
            panelControls.TabIndex = 6;
            // 
            // buttonDown
            // 
            buttonDown.Image = Properties.Resources.down_arrow_24;
            buttonDown.Location = new Point(70, 122);
            buttonDown.Margin = new Padding(4, 4, 4, 4);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(65, 64);
            buttonDown.TabIndex = 2;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // buttonRight
            // 
            buttonRight.Image = Properties.Resources.right_arrow_24;
            buttonRight.Location = new Point(131, 61);
            buttonRight.Margin = new Padding(4, 4, 4, 4);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(65, 64);
            buttonRight.TabIndex = 3;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonUp
            // 
            buttonUp.Image = Properties.Resources.up_arrow_24;
            buttonUp.Location = new Point(70, 0);
            buttonUp.Margin = new Padding(4, 4, 4, 4);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(65, 64);
            buttonUp.TabIndex = 1;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Image = Properties.Resources.left_arrow_24;
            buttonLeft.Location = new Point(6, 61);
            buttonLeft.Margin = new Padding(4, 4, 4, 4);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(65, 64);
            buttonLeft.TabIndex = 0;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(34, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 37);
            label2.TabIndex = 0;
            label2.Text = "Control Panel";
            // 
            // newButton
            // 
            newButton.Image = Properties.Resources.new_file_24;
            newButton.ImageAlign = ContentAlignment.TopCenter;
            newButton.Location = new Point(30, 457);
            newButton.Margin = new Padding(4, 4, 4, 4);
            newButton.Name = "newButton";
            newButton.Size = new Size(98, 77);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.TextAlign = ContentAlignment.BottomCenter;
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // restartButton
            // 
            restartButton.Image = Properties.Resources.restart_24;
            restartButton.ImageAlign = ContentAlignment.TopCenter;
            restartButton.Location = new Point(30, 573);
            restartButton.Margin = new Padding(4, 4, 4, 4);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(98, 77);
            restartButton.TabIndex = 5;
            restartButton.Text = "Restart";
            restartButton.TextAlign = ContentAlignment.BottomCenter;
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // exitButton
            // 
            exitButton.Image = Properties.Resources.exit_black_24;
            exitButton.ImageAlign = ContentAlignment.TopCenter;
            exitButton.Location = new Point(134, 573);
            exitButton.Margin = new Padding(4, 4, 4, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(98, 77);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.BottomCenter;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // labelNumberOfBoxes
            // 
            labelNumberOfBoxes.Location = new Point(29, 157);
            labelNumberOfBoxes.Margin = new Padding(4, 0, 4, 0);
            labelNumberOfBoxes.Name = "labelNumberOfBoxes";
            labelNumberOfBoxes.Size = new Size(203, 32);
            labelNumberOfBoxes.TabIndex = 0;
            labelNumberOfBoxes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 983);
            Controls.Add(toolBoxPanel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "PlayForm";
            Text = "QGamePlayForm";
            toolBoxPanel.ResumeLayout(false);
            toolBoxPanel.PerformLayout();
            panelControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTipPopup;
        private Label label1;
        private Button loadButton;
        private Label labelRow;
        private Panel gamePanel;
        private Panel toolBoxPanel;
        private Label label2;
        private Panel panelControls;
        private Button buttonRight;
        private Button buttonDown;
        private Button buttonUp;
        private Button buttonLeft;
        private Label label3;
        private Button exitButton;
        private Button newButton;
        private Label labelNumberOfBoxes;
        private Label labelBoxesLeft;
        private Label labelNumberOfMoves;
        private Button restartButton;
    }
}