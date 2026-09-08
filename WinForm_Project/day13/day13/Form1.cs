using System;
using System.Drawing;
using System.Windows.Forms;

namespace day13
{
    //**************************************俄罗斯方块************************************************************

    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timerGame = new System.Windows.Forms.Timer();
        // 格子大小
        private const int BlockSize = 25;
        // 游戏区域行列
        private const int Rows = 20;
        private const int Cols = 10;

        //游戏地图：0为空，其他数字代表不同颜色方块
        private int[,] map = new int[Rows, Cols];

        //当前方块
        private int[,] currentShape;
        private int shapeX, shapeY;

        //7种方块模板
        private readonly int[][,] shapes =
        {
            new int[,]{{1,1,1,1}},                  //I
            new int[,]{{1,1},{1,1}},                //O
            new int[,]{{0,1,0},{1,1,1}},            //T
            new int[,]{{1,0,0},{1,1,1}},            //L
            new int[,]{{0,0,1},{1,1,1}},            //J
            new int[,]{{0,1,1},{1,1,0}},            //S
            new int[,]{{1,1,0},{0,1,1}}             //Z
        };

        private readonly Color[] colors =
        {
            Color.Black,Color.Cyan,Color.Yellow,Color.Purple,
            Color.Orange,Color.Blue,Color.Lime,Color.Red
        };

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            panelGame.Width = Cols * BlockSize;
            panelGame.Height = Rows * BlockSize;
            timerGame.Tick += TimerGame_Tick;
            this.KeyDown += Form1_KeyDown;
            panelGame.Paint += panelGame_Paint;
            timerGame.Interval = 400;
            timerGame.Start();

            NewShape();
        }

        //生成新方块
        void NewShape()
        {
            int index = rand.Next(shapes.Length);
            currentShape = shapes[index];
            shapeX = Cols / 2 - currentShape.GetLength(1) / 2;
            shapeY = 0;

            //刚出来就碰撞=游戏结束
            if (CheckCollision(0, 0))
            {
                timerGame.Stop();
                MessageBox.Show("游戏结束！");
            }
        }

        //碰撞检测 offsetX offsetY偏移量
        bool CheckCollision(int offsetX, int offsetY)
        {
            for (int y = 0; y < currentShape.GetLength(0); y++)
            {
                for (int x = 0; x < currentShape.GetLength(1); x++)
                {
                    if (currentShape[y, x] == 1)
                    {
                        int nx = shapeX + x + offsetX;
                        int ny = shapeY + y + offsetY;
                        if (nx < 0 || nx >= Cols || ny >= Rows) return true;
                        if (ny >= 0 && map[ny, nx] != 0) return true;
                    }
                }
            }
            return false;
        }

        //把方块固化到地图数组
        void LockShape()
        {
            for (int y = 0; y < currentShape.GetLength(0); y++)
            {
                for (int x = 0; x < currentShape.GetLength(1); x++)
                {
                    if (currentShape[y, x] == 1)
                    {
                        int nx = shapeX + x;
                        int ny = shapeY + y;
                        map[ny, nx] = rand.Next(1, colors.Length);
                    }
                }
            }
            ClearFullLine();
            NewShape();
        }

        //消除满行
        void ClearFullLine()
        {
            for (int y = Rows - 1; y >= 0; y--)
            {
                bool full = true;
                for (int x = 0; x < Cols; x++)
                {
                    if (map[y, x] == 0) { full = false; break; }
                }
                if (full)
                {
                    //这一行删掉，上面全部往下挪一行
                    for (int row = y; row > 0; row--)
                    {
                        for (int x = 0; x < Cols; x++)
                        {
                            map[row, x] = map[row - 1, x];
                        }
                    }
                    //最顶行清空
                    for (int x = 0; x < Cols; x++) map[0, x] = 0;
                    y++; //重新检查当前行
                }
            }
        }

        //定时器：方块自动下落
        private void TimerGame_Tick(object sender, EventArgs e)
        {
            if (!CheckCollision(0, 1))
            {
                shapeY++;
            }
            else
            {
                LockShape();
            }
            panelGame.Invalidate();//重绘画面
        }

        //键盘控制 ← → ↓ 空格旋转
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!CheckCollision(-1, 0)) shapeX--;
                    break;
                case Keys.Right:
                    if (!CheckCollision(1, 0)) shapeX++;
                    break;
                case Keys.Down:
                    if (!CheckCollision(0, 1)) shapeY++;
                    break;
                case Keys.Space:
                    RotateShape();
                    break;
            }
            panelGame.Invalidate();
        }

        //旋转方块
        void RotateShape()
        {
            int h = currentShape.GetLength(0);
            int w = currentShape.GetLength(1);
            int[,] temp = new int[w, h];
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    temp[x, h - 1 - y] = currentShape[y, x];
                }
            }
            var old = currentShape;
            currentShape = temp;
            if (CheckCollision(0, 0))
            {
                currentShape = old; //旋转碰撞就撤销旋转
            }
        }

        //绘制游戏画面
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //画地图
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    Brush b = new SolidBrush(colors[map[y, x]]);
                    g.FillRectangle(b, x * BlockSize, y * BlockSize, BlockSize - 1, BlockSize - 1);
                    b.Dispose();
                }
            }
            //画当前下落方块
            for (int y = 0; y < currentShape.GetLength(0); y++)
            {
                for (int x = 0; x < currentShape.GetLength(1); x++)
                {
                    if (currentShape[y, x] == 1)
                    {
                        Brush b = new SolidBrush(Color.Cyan);
                        g.FillRectangle(b,
                            (shapeX + x) * BlockSize,
                            (shapeY + y) * BlockSize,
                            BlockSize - 1, BlockSize - 1);
                        b.Dispose();
                    }
                }
            }
        }
    }
}