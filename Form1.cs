namespace Forms_test_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int PauseTime = 300; //How many ms the program waits until drawing the next pillar
        int Moves = 0; //The amount of times the rings have been moved

        //Actual solving algorithem
        private void Solve(int rings, Stack Tower1, Stack Tower3, Stack Tower2)
        {
            //swap values
            if (rings == 1)
            {
                Tower3.In(Tower1.Out());
                DrawPillars(Tower1, Tower2, Tower3,rings);
                Moves++;
                return;
            }
            Solve(rings - 1, Tower1, Tower2, Tower3);
            Tower3.In(Tower1.Out());
            DrawPillars(Tower2, Tower3, Tower1, rings);
            Moves++;
            Solve(rings - 1, Tower2, Tower3, Tower1);
            return;
        }


        private void Start_Click(object sender, EventArgs e)
        {
            //Loads of Hides as I couldnt figure out how to add a new form in old program format because .Net 6.0 issues.
            AmountOfRingsLabel.Hide();
            AmountOfRingsSelector.Hide();
            Start.Hide();
            PauseTimeGet.Hide();
            TimeLabel.Hide();
            PauseTimeInfo.Hide();

            int TotalWidth = ActiveForm.Width;
            int rings = (int)AmountOfRingsSelector.Value;
            if(PauseTimeGet.Text == null && rings > 4 || int.TryParse(PauseTimeGet.Text, out PauseTime) == false)
            {
                PauseTime = 10000 / ((int)Math.Pow(2, rings) - 1); //so it always takes around 10 secongs
            }
            else
            {
                PauseTime = int.Parse(PauseTimeGet.Text);
            }
            Stack Tower1 = new Stack(rings, TotalWidth / 10);
            Stack Tower2 = new Stack(rings,  4 * TotalWidth / 10);
            Stack Tower3 = new Stack(rings, 7 * TotalWidth / 10);

            for (int i = rings; i > 0; i--)
            {
                Tower1.In(i);
            }
            DrawPillars(Tower1, Tower2, Tower3, rings);
            Solve(rings, Tower1, Tower3, Tower2);
            NoMovesLabel.Show();
            NoMovesLabel.Text = "The amount of Moves taken(Should follow 2^n - 1): " + Moves.ToString();
        }

        private void DrawPillars(Stack TowerX, Stack TowerY, Stack TowerZ, int rings)
        {
            Graphics graphics = ActiveForm.CreateGraphics();
            graphics.Clear(Color.Black);
            TowerX.DrawPillars();
            TowerY.DrawPillars();
            TowerZ.DrawPillars();
            
            Thread.Sleep(PauseTime);
        }

        
        class Stack
        {
            private int[] Data; // Index 0 = Largest , Index n = Smallest
            private int Index = -1; //so index always points to a data item
            private const int NullValue = 0; //represents nothing in an array slot

            private Rectangle Tower = new Rectangle();//rectangle to draw
            private Rectangle[] RingRectangles;

            public int Out()
            {
                int output = Data[Index];
                Data[Index] = NullValue;
                Index--;
                return output;
            }
            public Stack(int HowMany, int x)
            {
                Data = new int[HowMany];
                RingRectangles = new Rectangle[HowMany];
                
                Tower.X = x;
                Tower.Y = 50;
                Tower.Size = new Size(ActiveForm.Width / 20, ActiveForm.Height - 250);
            }
            public void In(int data)
            {
                Index++;
                Data[Index] = data;
                if (Index == Data.Length - 1)
                {
                    return;
                }
            }
            public void DrawPillars()
            {
                Graphics graphics = ActiveForm.CreateGraphics();
                Pen pen = new Pen(Color.White);
                graphics.DrawRectangle(pen, Tower);

                //Draw rings
                Pen ringPen = new Pen(Color.Red);
                
                int CenterXOfTower = Tower.X + ActiveForm.Width / 40; //The center x co-ord of the pillar.         
                int SizeOfRing1 =  (ActiveForm.Width / 7)/ Data.Length; //The smallest a ring could be (So the size of ring 1)
                int HeightOfEachRing = Tower.Size.Height / Data.Length; //height of each ring
                int ReverseRingsGoneThrough = Data.Length - 1; //Starts from data length and decrements as the y value on the Windows Form Co-ord grid Increases as you go down
                //and the largest index in data contains the smallest ring
                for(int i = 0; i < Data.Length; i++)
                {
                    if (Data[i] != 0)
                    {
                        
                        RingRectangles[i] = new Rectangle(CenterXOfTower - (SizeOfRing1 * Data[i]), Tower.Y + (HeightOfEachRing * ReverseRingsGoneThrough), width: 2 * (SizeOfRing1 * Data[i]), height: HeightOfEachRing);
                        graphics.DrawRectangle(ringPen, RingRectangles[i]);
                        ReverseRingsGoneThrough--;
                    }
                }
            }
            public int Length()
            {
                return Data.Length;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NoMovesLabel.Hide();
        }
    }
}