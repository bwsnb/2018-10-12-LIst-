using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_10_12_LIst泛型集合之用户管理系统
{
    /// <summary>
    /// C((Controller)控制器层-用于处理逻辑
    /// </summary>
    class UserController
    {
        //实例一个User集合
        List<User> ListUser = new List<User>();
        

        /// <summary>
        /// 添加用户方法
        /// </summary>

        public void AddUser(User user)
        {
            ListUser.Add(user);
        }

        /// <summary>
        /// 根据用户编号删除用户
        /// </summary>
        public void RemoveUser(int index)
        {
            ListUser.RemoveAt(index);

        }

        /// <summary>
        /// 修改用户
        /// </summary>
        public void ChangeUser()
        {

        }


        /// <summary>
        /// 查看用户数据
        /// </summary>
        public void FindUser(int index)
        {
            Console.WriteLine("ID | 姓名 | 年龄 | 性别 | 地址\n");
            if (ListUser.Count == 0)
            {
                Console.WriteLine("用户数据为空\n");
            }
            else
            {
                for (int i = 0; i < ListUser.Count; i++)
                {
                    Console.WriteLine( i+"  |"+ListUser[i]);
                }
            }
        }

        public int Count
        {
            get => ListUser.Count;
        }
    }
}
