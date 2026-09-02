using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClssProject
{
    internal class MySql
    {
        //连接数据  属性
        public string Server { get; set; } = "127.0.0.1";
        public string Port { get; set; } = "3306";
        public string Database { get; set; }
        public string Uid { get; set; } = "root";
        public string Password { get; set; } = "root";
        public string Charset { get; set; } = "utf8";

        // 连接 数据库字符串
        public string ConnStr { get; set; }

        public MySql(string database)
        { 
            this.Database = database;
        }

        // 数据库连接 及其 操作
        public async void ConAndHandler(string sql, Action<MySqlCommand> handlerCall)
        {
            //拼接字符串  数据库连接字符串
            ConnStr = $"Server={Server};Port={Port};Database={Database};Uid={Uid};Password={Password};Charset={Charset}";
            using (MySqlConnection conn = new MySqlConnection(ConnStr))
            { 
                await conn.OpenAsync();
                using (MySqlCommand comm = new MySqlCommand(sql,conn))
                { 
                    handlerCall(comm);//执行后操作
                }
            }
        }


    }
}
