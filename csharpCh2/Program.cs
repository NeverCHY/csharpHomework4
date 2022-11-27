namespace IndexerSample
{
    public class Student
    {
        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Student(string id)
        {
            this.id = id;
            this.name = "";
        }
        public string id
        {
            get;
            set;
        }
        public string name
        {
            get;
            set;
        }

        public void printStudent()
        {
            Console.WriteLine(id, name);
        }
    }

    class Clazz
    {
        Student[] _Students;
        public Clazz(int capacity)
        {
            _Students = new Student[capacity];
        }

        //整数索引器
        public Student this[int index]
        {
            get
            {
                // 验证索引范围
                if (index < 0 || index >= _Students.Length)
                {
                    Console.WriteLine("索引无效");
                    // 使用 null 指示失败
                    return null;
                }
                // 对于有效索引，返回请求的照片
                return _Students[index];
            }
            set
            {
                if (index < 0 || index >= _Students.Length)
                {
                    Console.WriteLine("索引无效");
                    return;
                }
                _Students[index] = value;
            }
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Clazz clazz = new Clazz(3);
            // 创建 3 张照片
            Student first = new Student("01", "张三");
            Student second = new Student("02", "李四");
            Student third = new Student("03", "王五");

            // 向相册加载照片
            clazz[0] = first;
            clazz[1] = second;
            clazz[2] = third;

            // 按索引检索
            Student objStudent1 = clazz[2];
            Console.WriteLine(objStudent1.name);

        }
    }
}