using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_10_12_LIst泛型集合之用户管理系统
{
    /// <summary>
    /// V(View)视图层-和用户进行交互
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************\n*******用户管理系统*******\n**************************\n");

            UserController uc = new UserController();
            while (true)
            {
                Console.WriteLine("1.增加用户\n2.删除用户\n3.修改用户\n4.查找用户\n");

                Console.Write("请输入数字：");
                string command = Console.ReadLine();
                Console.WriteLine();

                switch (command)
                {
                    case "1":
                        Console.Write("请输入姓名：");
                        string name = Console.ReadLine();
                        Console.Write("请输入年龄：");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("请选择性别：1.男   2.女");
                        int sex =int.Parse(Console.ReadLine());
                        User.Sex _sex=User.Sex.男;

                        switch (sex)
                        {
                            case 1:

                                _sex = User.Sex.男;
                                break;
                            case 2:
                                _sex = User.Sex.女;
                                break;
                            default:
                                Console.WriteLine("输入错误请重新输入");
                                break;

                        }

                        Console.Write("请输入地址：");
                        string address = Console.ReadLine();

                        uc.AddUser(new User(name, age, _sex, address));

                        break;
                    case "2":
                        uc.FindUser(0);
                        Console.WriteLine("请输入需要删除的用户ID：");
                        int id = int.Parse(Console.ReadLine());
                        uc.RemoveUser(id);
                        break;
                    case "3":
                        uc.FindUser(0);
                        Console.WriteLine("请输入需要修改的用户ID：");
                        int _id = int.Parse(Console.ReadLine());

                        Console.Write("请输入修改后的姓名：");
                        string Cname = Console.ReadLine();
                        Console.Write("请输入修改后年龄：");
                        int Cage = int.Parse(Console.ReadLine());
                        Console.Write("请选择性别：1.男   2.女");
                        int Csex = int.Parse(Console.ReadLine());
                        User.Sex _Csex = User.Sex.男;

                        switch (Csex)
                        {
                            case 1:

                                _Csex = User.Sex.男;
                                break;
                            case 2:
                                _Csex = User.Sex.女;
                                break;
                            default:
                                Console.WriteLine("输入错误请重新输入");
                                break;

                        }

                        Console.Write("请输入新地址：");
                        string Caddress = Console.ReadLine();


                        uc.ChangeUser(_id,Cname,Cage,_Csex,Caddress);

                        break;
                    case "4":
                        uc.FindUser(0);
                        break;
                    default:
                        Console.WriteLine("输入错误，请输入正确的数字！");
                        break;
                }
            }


            //Console.WriteLine();
            


            Console.ReadKey();
        }
    }
}
