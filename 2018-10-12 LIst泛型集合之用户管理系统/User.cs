using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_10_12_LIst泛型集合之用户管理系统
{
    class User
    {
        public enum Sex
        {
            男,
            女
        }

        private string name;
        private int age;
        private string address;

        public string Name { get => name; set => name = value;}
        public int Age { get => age;set => age = value;}
        public Sex sex;
        public string Address
        {
            get => address; set => address = value;
        }

        public User(string name, int age, Sex sex, string address)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.address = address;
        }

        public override string ToString()
        {
            return string.Format($"{name}|{age}|{sex}|{address}");
        }

    }
}
