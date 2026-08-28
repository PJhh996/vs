using System.Text.RegularExpressions;

namespace homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitSum();
        }
        //新建一个list接收单价的控件和 数量的控件 组合的字典
        List<Dictionary<string, Control>> sumList = [];
        private void InitSum()
        {
            /* 功能: 
                 每个输入框 数量变化则 总计统计结果 变化
                    - 输入框的数量 * 单价 得到这一行的 小计
                    - 因为有多行,每一个的数量和单价 需要一一对应起来
                        + 将单价的控件和数量的控件 一起组合 成一个字典(对象)
                        + 多个行的组合字典  放到list中
             */
            // 初始化 将 单价控件和数量控件 组合的字典 添加到 ConList
            sumList.Add(new Dictionary<string, Control>
            {
                ["price"] = lab1,
                ["count"] = textBox1,
                ["sub"] = btnSub1,
                ["add"] = btnUp1
            });
            sumList.Add(new Dictionary<string, Control>
            {
                ["price"] = lab2,
                ["count"] = textBox2,
                ["sub"] = btnSub2,
                ["add"] = btnUp2
            });
            //遍历sumList 绑定事件
            sumList.ForEach(item => item["count"].TextChanged += Form2_TextChanged);
            //给数量 默认值
            textBox1.Text = "1";
            textBox2.Text = "1";
            //添加按钮控制数量加减功能
            btnSub1.Click += Sub_Click1;
            btnSub2.Click += Sub_Click2;
            btnUp1.Click += Add_Click1;
            btnUp2.Click += Add_Click2;


        }

        private void Sub_Click1(object? sender, EventArgs e)
        {
            Sub(0);
        }
        private void Sub_Click2(object? sender, EventArgs e)
        {
            Sub(1);
        }
        private void Add_Click1(object? sender, EventArgs e)
        {
            Add(0);
        }
        private void Add_Click2(object? sender, EventArgs e)
        {
            Add(1);
        }




        private void Form2_TextChanged(object? sender, EventArgs e)
        {
            int sum = 0;
            //遍历sumList 实现累加
            sumList.ForEach(item =>
            {
                // item是每一个字典 { ["price"]=单价控件,["count"] = 数量控件}
                if (!Regex.IsMatch(item["count"].Text, @"^[1-9]\d*$"))
                {
                    item["count"].Text = "1";
                    //(item["count"] as TextBox).SelectionStart = 1;
                    int p = int.Parse(item["price"].Text);
                    int c = int.Parse(item["count"].Text);
                    sum += p * c;
                    return;
                }
                int price = int.Parse(item["price"].Text);
                int count = int.Parse(item["count"].Text);
                sum += price * count;
            });
            sumLab.Text = sum.ToString();
        }


        private void Sub(int i)
        {
            int p = int.Parse(sumList[i]["count"].Text);
            int a = p - 1;
            sumList[i]["count"].Text = a.ToString();
        }
        private void Add(int i)
        {
            int p = int.Parse(sumList[i]["count"].Text);
            int a = p + 1;
            sumList[i]["count"].Text = a.ToString();
        }
    }
}

