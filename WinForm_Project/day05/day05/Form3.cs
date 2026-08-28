using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace day05
{        
    public partial class Form3 : Form
    {
        //新建一个list 待会好使用list里的方法
        List<Bcolor> backCList = new List<Bcolor>();
        public Form3()
        {
            InitializeComponent();
            Bcolor[] arr = [
                new Bcolor("红色",Color.Red),
                new Bcolor("蓝色",Color.Blue),
                new Bcolor("黄色",Color.Yellow),
                new Bcolor("绿色",Color.Green),               
                ];
            //将集合放进list中
            backCList.AddRange(arr);
            //把颜色名 放进 colorCb
            colorCb.Items.AddRange(backCList.ConvertAll(item => item.name).ToArray());
            //绑定事件
            colorCb.SelectedIndexChanged += ColorCb_SelectedIndexChanged;
        }

        private void ColorCb_SelectedIndexChanged(object? sender, EventArgs e)
        {
            //获取cb的text内容
            string name = (sender as ComboBox).SelectedItem.ToString();
            Bcolor res = backCList.Find(item => item.name == name);
            Color haha = res.color;
            this.BackColor = haha;
        }


        //新建一个类用于 做一个构造函数
        public class Bcolor
        {
            public string name;
            public Color color;

            public Bcolor(string name, Color color)
            {
                this.name = name;
                this.color = color;
            }
        }

    }
}
