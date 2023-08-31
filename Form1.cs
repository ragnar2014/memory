namespace Memory
{
    public enum MathOperator
    {
        Add,
        Subtract
    }
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private List<Label> _clickedLabels = new List<Label>();
        private bool pair = false;
        private List<Color> prepColorList;
        private List<Color> _colorList = new List<Color>()
        {
            Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, 
            Color.Azure, Color.LightPink, Color.Turquoise
        };

        public Form1()
        {
            StartGame();
        }

        public void StartGame()
        {
            if(GamePlan != null)
            {
                GamePlan.Parent.Controls.Remove(GamePlan);
                GamePlan = null;
            }
            InitializeComponent();
            InitializeTable();
            AddRandomColors();
        }

        public void InitializeTable()
        {
            prepColorList = new List<Color>(); 
            for (int i= 0; i<_colorList.Count(); i++)
            {
                for(int j = 0; j< 2; j++)
                {
                    Color color = new Color();
                    color = _colorList[i];
                    prepColorList.Add(color);
                }              
            }
            int NameCounter = 0;
            for (int row = 0; row < 4; row++)
            {
                NameCounter++;
                for (int columns = 0; columns < 4; columns++)
                {
                    Sqr.Name = null;
                    Sqr.Name += Sqr.Name + NameCounter.ToString();
                    Label tempLabel = new Label();
                    tempLabel.AutoSize = true;
                    tempLabel.BackColor = SystemColors.ActiveCaption;
                    tempLabel.Dock = DockStyle.Fill;
                    tempLabel.Location = new Point(5, 2);
                    tempLabel.Size = new Size(125, 125);
                    tempLabel.TabIndex = 0;
                    tempLabel.Click += new EventHandler(Sqr_Click);
                    tempLabel.Name = NameCounter.ToString();
                    tempLabel.Image = Properties.Resources.dennis;
                    tempLabel.MouseLeave += new EventHandler(Sqr_MouseLeave);
                    GamePlan.Controls.Add(tempLabel, row, columns);
                }
            }
        }

        private void Sqr_MouseLeave(object? sender, EventArgs e)
        {
            if (pair)
            {
                Thread.Sleep(2000);
                foreach (Label l in _clickedLabels)
                {
                    GamePlan.Controls.Remove(l);
                }

                pair = false;
            }

            if(GamePlan.Controls.Count == 0)
            {
                GameOver.Visible = true;
            }
        }

        private void AddRandomColors()
        {
            foreach(Control control in GamePlan.Controls)
            {
                Label tempLabel = control as Label;
                Color tempColor;
                if(tempLabel != null)
                {
                    int randomPos = _random.Next(_colorList.Count);
                    while(!prepColorList.Contains(_colorList[randomPos]))
                    {
                        randomPos = _random.Next(_colorList.Count);
                    }
                    tempColor = _colorList[randomPos];
                    prepColorList.Remove(_colorList[randomPos]);
                    tempLabel.BackColor = tempColor;
                }
            }
        }

        private void Sqr_Click(object sender, EventArgs e)
        {
            Label newClickedLabel = sender as Label;
            if (newClickedLabel != null && _clickedLabels.Count() < 1)
            {
                newClickedLabel.Image = null;
                _clickedLabels.Add(newClickedLabel);
            }

            else if (_clickedLabels.Count() == 1)
            {
                newClickedLabel.Image = null;
                foreach (Label l in _clickedLabels)
                {
                    if (l.BackColor == newClickedLabel.BackColor)
                    {
                        //Point!
                        if(string.IsNullOrEmpty(PointLabel.Text))
                        {
                            PointLabel.Text = 1.ToString();
                        }
                        else
                        {
                            AdjustPoints(MathOperator.Add);
                        }

                        pair = true;
                    }

                    else
                    {
                        AdjustPoints(MathOperator.Subtract);
                    }
                }
                _clickedLabels.Add(newClickedLabel);
            }

            else
            {
                foreach (Label l in _clickedLabels)
                {
                    l.Image = Properties.Resources.dennis;
                }
                
                newClickedLabel.Image = null;
                _clickedLabels.Clear();
                _clickedLabels.Add(newClickedLabel);
            }

        }


        private void AdjustPoints(MathOperator expression)
        {
            int labelPoints = int.Parse(PointLabel.Text);

            switch (expression)
            {
                case MathOperator.Add:
                    labelPoints++;
                    break;
                default:
                if (labelPoints > 0)
                {
                    labelPoints--;
                }
                break;
            }
            PointLabel.Text = labelPoints.ToString();
        }

        private void StartGame(object sender, MouseEventArgs e)
        {

            PointLabel.Invoke(new Action(() => PointLabel.Text = "0"));
            GameOver.Visible = false;
            
            StartGame();
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}


