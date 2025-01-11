using Group7_Rakhmanov_Ohalebo_QGame.Properties;
using System.Windows.Forms;

namespace Group7_Rakhmanov_Ohalebo_QGame
{
    public partial class PlayForm : Form
    {
        #region Game grid variables
        // Constants for grid positioning and size
        private const int INIT_TOP = 30;
        private const int INIT_LEFT = 50;
        private int WIDTH = 40;
        private int HEIGHT = 40;
        private const int VGAP = 0;
        private const int HGAP = 0;
        #endregion

        // Declare images for the grid
        private Bitmap wall;
        private Bitmap whiteBlock;
        private Bitmap redDoor;
        private Bitmap redBox;
        private Bitmap greenDoor;
        private Bitmap greenBox;
        private Bitmap blueDoor;
        private Bitmap blueBox;
        private PictureBox selectedBox;
        private PictureBox assigningCell;
        private PictureBox checkingCell;

        public int numberOfRows;
        public int numberOfColumns;
        public int numberOfMoves = 0;
        public int numberOfBoxes = 0;
        public int selectedBoxRow;
        public int selectedBoxColumn;

        public string selectedBoxDoor = "";
        public string[] selectedBoxRowColumn;

        public bool isEmptyCell = true;

        public PlayForm()
        {
            InitializeComponent();
            LoadImages();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            // Update Arrow Buttons (Movement Buttons)
            foreach (var ctrl in panelControls.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    // Add optional hover effects
                    btn.MouseEnter += (s, e) => { btn.BackColor = Color.FromArgb(119, 119, 119); }; // Slightly darker on hover
                    btn.MouseLeave += (s, e) => { btn.BackColor = Color.Transparent; }; // Revert to light blue
                }
            }


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Apply rounded corners to panel
            var graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var rect = toolBoxPanel.ClientRectangle;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int cornerRadius = 20;
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            toolBoxPanel.Region = new Region(path);
        }



        private void LoadImages()
        {
            try
            {
                using (var ms = new MemoryStream(Resources.wall_1024))
                {
                    wall = new Bitmap(ms);
                }
                using (var ms = new MemoryStream(Resources.green_block_1024))
                {
                    greenBox = new Bitmap(ms);
                }
                using (var ms = new MemoryStream(Resources.green_door_1024))
                {
                    greenDoor = new Bitmap(ms);
                }
                using (var ms = new MemoryStream(Resources.red_block_1024))
                {
                    redBox = new Bitmap(ms);
                }
                using (var ms = new MemoryStream(Resources.red_door_1024))
                {
                    redDoor = new Bitmap(ms);
                }
                using (var ms = new MemoryStream(Resources.blue_block_1024))
                {
                    blueBox = new Bitmap(ms);
                }
                using (var ms = new MemoryStream(Resources.blue_door_1024))
                {
                    blueDoor = new Bitmap(ms);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Deserialize(string fileName)
        {
            try
            {
                numberOfBoxes = 0;
                numberOfMoves = 0;
                labelNumberOfBoxes.Text = numberOfBoxes.ToString();
                labelNumberOfMoves.Text = numberOfMoves.ToString();

                string[] lines = File.ReadAllLines(fileName);
                string[] size = lines[0].Split(';');
                numberOfRows = Convert.ToInt32(size[0]);
                numberOfColumns = Convert.ToInt32(size[1]);
                gamePanel.Controls.Clear(); // Clear any previous grid

                if (numberOfBoxes == 5 || numberOfRows == 5)
                {
                    WIDTH = 100;
                    HEIGHT = 100;
                }
                else if (numberOfBoxes >= 8 || numberOfRows >= 8)
                {
                    WIDTH = 60;
                    HEIGHT = 60;
                }
                else if (numberOfBoxes >= 10 || numberOfRows >= 10)
                {
                    WIDTH = 40;
                    HEIGHT = 40;
                }
                    int x = INIT_LEFT;  // Starting X position for the grid
                int y = INIT_TOP;   // Starting Y position for the grid

                // Loop through the grid rows and columns to create PictureBox controls
                for (int i = 0; i < numberOfRows; i++)
                {
                    string[] cells = lines[i + 1].Split(';');
                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        PictureBox pictureBox = new PictureBox
                        {
                            Left = x,                      // Set left position
                            Top = y,                       // Set top position
                            Width = WIDTH,                 // Set width
                            Height = HEIGHT,               // Set height
                            BackColor = Color.White,       // Set background color
                            SizeMode = PictureBoxSizeMode.StretchImage, // Set image size mode
                            Name = string.IsNullOrWhiteSpace(cells[j]) ? "Empty" : cells[j],
                            Tag = $"{i};{j}"
                        };
                        pictureBox.BorderStyle = BorderStyle.Fixed3D; // Set border style
                        gamePanel.Controls.Add(pictureBox);  // Add PictureBox to panel

                        pictureBox.Click += B_Click; // Set up click event for each PictureBox

                        x += WIDTH + HGAP;  // Move to the next column

                        switch (cells[j])
                        {
                            case "Wall":
                                pictureBox.Image = wall;
                                break;
                            case "RedDoor":
                                pictureBox.Image = redDoor;
                                break;
                            case "GreenDoor":
                                pictureBox.Image = greenDoor;
                                break;
                            case "BlueDoor":
                                pictureBox.Image = blueDoor;
                                break;
                            case "RedBox":
                                pictureBox.Image = redBox;
                                numberOfBoxes++;
                                break;
                            case "GreenBox":
                                pictureBox.Image = greenBox;
                                numberOfBoxes++;
                                break;
                            case "BlueBox":
                                pictureBox.Image = blueBox;
                                numberOfBoxes++;
                                break;
                            default:
                                pictureBox.Image = whiteBlock;
                                break;
                        }
                        labelNumberOfBoxes.Text = numberOfBoxes.ToString();
                    }
                    x = INIT_LEFT;          // Reset X position for new row
                    y += HEIGHT + VGAP;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Game load file is empty or has invalid format");
            }
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            selectedBox = null;

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    Title = "Open level file"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(openFileDialog.FileName))
                    {
                        Deserialize(openFileDialog.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Selected file does not contain any game load.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //create a new instance of the DesignerForm
            DesignerForm designerForm = new DesignerForm();

            //show the DesignerForm
            designerForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            //close the DesignerForm
            this.Close();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            ClearGamePanel();
        }
        private void B_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = (PictureBox)sender;

            if (pictureBox != null)
            {
                if (pictureBox.Name != "Empty" && pictureBox.Name != "Wall" &&
                    pictureBox.Name != "RedDoor" && pictureBox.Name != "BlueDoor"
                    && pictureBox.Name != "GreenDoor")
                {
                    if (selectedBox != null)
                    {
                        selectedBox.BackColor = Color.White;
                    }

                    selectedBox = pictureBox;
                    selectedBox.BackColor = Color.DeepSkyBlue;
                    SetDoorAndCellLocation(pictureBox.Name);
                }
            }
        }
        private void SetDoorAndCellLocation(string boxColor)
        {
            switch (boxColor)
            {
                case "RedBox":
                    selectedBoxDoor = "RedDoor";
                    break;
                case "GreenBox":
                    selectedBoxDoor = "GreenDoor";
                    break;
                case "BlueBox":
                    selectedBoxDoor = "BlueDoor";
                    break;
            }
            selectedBoxRowColumn = selectedBox.Tag.ToString().Split(';');
            selectedBoxRow = Convert.ToInt32(selectedBoxRowColumn[0]);
            selectedBoxColumn = Convert.ToInt32(selectedBoxRowColumn[1]);
            assigningCell = (PictureBox)gamePanel.Controls[selectedBoxRow * numberOfColumns + selectedBoxColumn];
        }
        private void buttonUp_Click(object sender, EventArgs e) => Move(MoveUp);
        private void buttonDown_Click(object sender, EventArgs e) => Move(MoveDown);
        private void buttonLeft_Click(object sender, EventArgs e) => Move(MoveLeft);
        private void buttonRight_Click(object sender, EventArgs e) => Move(MoveRight);
        private new void Move(Action move)
        {
            if (selectedBox != null)
            {
                move();
                CheckWinner();
            }
            else
            {
                MessageBox.Show("Please select a box");
            }
        }
        private void MoveUp()
        {
            isEmptyCell = true;

            for (int i = selectedBoxRow - 1; i >= 0 && isEmptyCell; i--)
            {
                checkingCell = (PictureBox)gamePanel.Controls[i * numberOfColumns + selectedBoxColumn];
                CheckNextCell();

            }
            if (selectedBox != null)
            {
                selectedBox = assigningCell;
                SetDoorAndCellLocation(selectedBox.Name);
            }
        }
        private void MoveRight()
        {
            isEmptyCell = true;

            for (int i = 1; i <= (numberOfColumns - selectedBoxColumn) && isEmptyCell; i++)
            {
                checkingCell = (PictureBox)gamePanel.Controls[selectedBoxRow * numberOfColumns + selectedBoxColumn + i];
                CheckNextCell();
            }

            if (selectedBox != null)
            {
                selectedBox = assigningCell;
                SetDoorAndCellLocation(selectedBox.Name);
            }
        }
        private void MoveDown()
        {
            isEmptyCell = true;

            for (int i = selectedBoxRow + 1; i <= numberOfRows - 1 && isEmptyCell; i++)
            {
                checkingCell = (PictureBox)gamePanel.Controls[i * numberOfColumns + selectedBoxColumn];
                CheckNextCell();

            }
            if (selectedBox != null)
            {
                selectedBox = assigningCell;
                SetDoorAndCellLocation(selectedBox.Name);
            }
        }

        private void MoveLeft()
        {
            isEmptyCell = true;

            for (int j = selectedBoxColumn - 1; j >= 0 && isEmptyCell; j--)
            {
                checkingCell = (PictureBox)gamePanel.Controls[selectedBoxRow * numberOfColumns + j];
                CheckNextCell();

            }
            if (selectedBox != null)
            {
                selectedBox = assigningCell;
                SetDoorAndCellLocation(selectedBox.Name);
            }
        }

        private void CheckNextCell()
        {
            // If we hit a wall or an invalid cell, stop movement
            if (checkingCell.Name != "Empty" && checkingCell.Name != selectedBoxDoor)
            {
                isEmptyCell = false;
                return;
            }

            // Handle the case where the box is moved to a door
            if (checkingCell.Name == selectedBoxDoor)
            {
                assigningCell.Image = whiteBlock;
                assigningCell.Name = "Empty";
                assigningCell.BackColor = Color.White;

                selectedBox = null;
                numberOfBoxes--;
                return;
            }

            // Handle the case where the cell is empty
            checkingCell.Image = assigningCell.Image;
            checkingCell.Name = assigningCell.Name;
            checkingCell.BackColor = Color.DeepSkyBlue;

            // Handle the case where the box is moved to an empty cell
            assigningCell.Image = whiteBlock;
            assigningCell.Name = "Empty";
            assigningCell.BackColor = Color.White;
            assigningCell = checkingCell;
        }

        private void CheckWinner()
        {
            //decrease number of boxes
            labelBoxesLeft.Text = numberOfBoxes.ToString();

            if (numberOfBoxes == 0)
            {
                MessageBox.Show("Congratulations! You have won the game!");
                ClearGamePanel();
            }
            else
            {
                //increase number of moves
                labelNumberOfMoves.Text = (++numberOfMoves).ToString();
            }
        }

        private void ClearGamePanel()
        {
            gamePanel.Controls.Clear();
            numberOfBoxes = 0;
            numberOfMoves = 0;
            labelNumberOfBoxes.Text = numberOfBoxes.ToString();
            labelNumberOfMoves.Text = numberOfMoves.ToString();
            labelBoxesLeft.Text = numberOfBoxes.ToString();
        }

       
    }
}
