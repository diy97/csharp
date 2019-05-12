using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *ArrayList是通过索引的方式赋值和取值（数组）,和数组一致长度固定
             */
            ArrayList arrayList = new ArrayList();
            Student stu1 = new Student("10001","张三","201901","普通班");
            Student stu2 = new Student();
            stu2.StuNum = "10002";
            stu2.Name = "李四";
            stu2.ClassId = "201902";
            stu2.ClassName = "精英班";
            Student stu3 = new Student("10003", "王五", "201903", "普通班");

            //arrayList.Add(stu1);
            //arrayList.Add(stu2);
            //arrayList.Add(stu3);

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Student stu = (Student)arrayList[i];
            //    Console.WriteLine(stu.StuNum+"-"+stu.Name+"-"+stu.ClassId+"-"+stu.ClassName);
            //}



            /*
             *  Hashtalbe 是键值形式，键key  值value
             */
            Hashtable ht = new Hashtable();
            ht.Add("ZS", stu1);
            ht.Add("LS", stu2);
            ht.Add("WW", stu3);

            //Student stu = (Student)ht["ZS"];

            //Console.WriteLine(stu.StuNum + "-" + stu.Name + "-" + stu.ClassId + "-" + stu.ClassName);

            foreach (Student item in ht.Keys)
            {
                Console.WriteLine(item.StuNum + "-" + item.Name + "-" + item.ClassId + "-" + item.ClassName);

            }

            Console.ReadKey();

        }
    }
}
