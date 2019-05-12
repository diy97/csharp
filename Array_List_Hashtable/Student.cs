using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Hashtable
{
    /// <summary>
    /// 学生信息
    /// </summary>
    class Student
    {
        //成员变量
        private string stuNum;
        private string name;
        private string classId;
        private string className;


        //以下是属性
        /// <summary>
        /// 学号
        /// </summary>
        public string StuNum
        {
            get { return stuNum;}
            set{ stuNum = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 班级ID
        /// </summary>
        public string ClassId
        {
            get { return classId; }
            set { classId = value; }
        }

        /// <summary>
        /// 班级名称
        /// </summary>
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        //无参构造函数
        public Student() { }

        //有参构造函数
        /// <summary>
        /// 学生信息
        /// </summary>
        /// <param name="stuNum">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="classId">班级编号</param>
        /// <param name="className">班级名称</param>
        public Student(string stuNum,string name,string classId,string className)
        {
            this.stuNum = stuNum;
            this.name = name;
            this.classId = classId;
            this.className = className;
        }

    }

}

