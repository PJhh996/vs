using System.Security;

namespace day05
{
    public partial class Form1 : Form
    {
        private List<Dictionary<string, dynamic>> data = new();
        public Form1()
        {
            InitializeComponent();
            data = new List<Dictionary<string, dynamic>>()
            {
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 1,
                    ["name"] = "广东省",
                    ["parent_id"] = 0
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 2,
                    ["name"] = "深圳市",
                    ["parent_id"] = 1
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 3,
                    ["name"] = "广州市",
                    ["parent_id"] = 1
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 4,
                    ["name"] = "广西省",
                    ["parent_id"] = 0
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 5,
                    ["name"] = "桂林市",
                    ["parent_id"] = 4
                },
                new Dictionary<string, dynamic>()
                {
                    ["id"] = 6,
                    ["name"] = "柳州市",
                    ["parent_id"] = 4
                }
            };
            List<Dictionary<string, dynamic>> list = data.FindAll(item => item["parent_id"] == 0);
            var names = list.Select(item => item["name"]).ToArray();//映射方法将 list中的name 转换成另一种形式
            shengfenCb.Items.AddRange(names);

            shengfenCb.SelectedIndexChanged += ShengfenCb_SelectedIndexChanged;
            shiCb.Leave += ShiCb_Leave;
        }

        private void ShiCb_Leave(object? sender, EventArgs e)
        {
            //shiCb.Items.Clear();
            shiCb.SelectedItem = null;
            shiCb.Text = "请选择城市";
            
        }

        private void ShengfenCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = (sender as ComboBox).SelectedItem.ToString();
            Dictionary<string, dynamic> dic = data.Find(item => item["name"] == text);
            //通过 dic 里的id 对应 城市的 parent_id 找到对应省份的城市
            List<Dictionary<string, dynamic>> cityList = data.FindAll(item => item["parent_id"] == dic["id"]);
            var city = cityList.Select(item => item["name"]).ToArray();
            shiCb.Items.Clear();
            shiCb.Items.AddRange(city);
        }



    }
}
//二级联动
/*
    -模拟二级联动数据
        -字典：{id = 唯一，name = 省份或城市}
 
 
 */