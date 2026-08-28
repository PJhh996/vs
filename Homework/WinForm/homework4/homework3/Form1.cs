using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homework3
{
    public partial class Form1 : Form
    {
        //private List<Dictionary<string, dynamic>> data = new();
        private Dictionary<string, string[]> cityDic = new();
        public Form1()
        {
            InitializeComponent();
            cityDic = new Dictionary<string, string[]>()
            {
                ["广东省"] = new string[]{ "深圳市", "广州市" },
                ["广西省"] = new string[]{ "南宁市", "河池市" },
            };
            //拿到省份，组成数组，放进shengfenCb
            string[] sheng = cityDic.Keys.ToArray();
            shengfenCb.Items.AddRange(sheng);

            shengfenCb.SelectedIndexChanged += ShengfenCb_SelectedIndexChanged;
            chengshiCb.Leave += ShiCb_Leave;
        }

        private void ShiCb_Leave(object? sender, EventArgs e)
        {
            //shiCb.Items.Clear();
            chengshiCb.SelectedItem = null;
            chengshiCb.Text = "请选择城市";

        }

        private void ShengfenCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //先获取 shengfenCb 里面的内容
            //在字典中找到对应的键名 找到后 把键值 加到chengshiCb里面
            string text = (sender as ComboBox).SelectedItem.ToString();
            chengshiCb.Items.Clear();
            chengshiCb.Items.AddRange(cityDic[text]);
        }
    }
}
