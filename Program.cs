// 인덱서 선언
//class Products
//{
//    public int this[int i]
//    {
//        get { return i; }
//        set
//        { Console.WriteLine(i);}
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Products products = new Products();
//        products[3] = 100;

//        Console.WriteLine(products[3]);
//    }
//}

//인덱서를 배열처럼 사용하는 제곱 클래스
//class SquareCalculator
//{
//    public int this[int i]
//    {
//        get
//        {
//            return i * i;
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        SquareCalculator square = new SquareCalculator();

//        Console.WriteLine(square[10]);
//    }
//}

//int.TryParse() 매서드
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("숫자 입력: ");
//        int output;
//        bool result = int.TryParse(Console.ReadLine(), out output);

//        if (result)
//        {
//            Console.WriteLine("입력한 숫자: " + output);
//        }
//        else
//        {
//            Console.WriteLine("숫자를 입력해주세요: ");
//        }
//    }
//}

//out 키워드를 사용하는 메서드
//class Program
//{
//    static void NextPosition(int x, int y, int vx, int vy, out int rx, int ry)
//    {
//        rx = x + vx;
//        ry = y + vy;
//    }
//    static void Main()
//    {
//        int x = 0; int y = 0; vx = 1; vy = 1;
//        Console.WriteLine("현재 좌표" + x + "" + y);
//        NextPosition(x,y,vx,vy,out x,out y);
//        System.Console.WriteLine("다음 좌표 : " + x + "" + y);
//    }
//}

//new 키워드를 사용하지 않고 구조체 인스턴스 생성
//class Program
//{
//    struct Point
//    {
//        public int x; 
//        public int y;
//    }

//    static void Main(string[] args)
//    {
//        Point point;
//        point.x = 10; point.y = 10;

//        Console.WriteLine(point.x);
//        Console.WriteLine(point.y);
//    }
//}

//구조체의 생성자
//class Program
//{
//    struct Point
//    {
//        public int x;
//        public int y; 

//        public Point(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    static void Main(string[] args)
//    {
//        Point point = new Point(1,2);

//        Console.WriteLine(point.x);
//        Console.WriteLine(point.y);
//    }
//}

// 값 복사

//class Program
//{
//    class PointClass
//    {
//        public int x;
//        public int y;
//        public string testA;
//        public string testB;

//        public PointClass(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    struct PointStruct
//    {
//        public int x;
//        public int y;

//        public PointStruct(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }
//    }

//    static void Main(string[] args)
//    {
//        PointClass pointClassA = new PointClass(10, 20);
//        PointClass pointClassB = pointClassA;

//        pointClassB.x = 100;
//        pointClassB.y = 200;

//        Console.WriteLine("pointClassA: " + pointClassA.x + "," + pointClassB.y);
//        Console.WriteLine("pointClassB: " + pointClassB.x + "," + pointClassB.y);
//        Console.WriteLine();

//        PointStruct pointStructA = new PointStruct(10, 20);
//        PointStruct pointStructB = pointStructA;

//        pointStructB.x = 100;
//        pointStructB.y = 200;

//        Console.WriteLine("pointClassA: " + pointClassA.x + "," + pointClassB.y);
//        Console.WriteLine("pointClassB: " + pointClassB.x + "," + pointClassB.y);
//    }
//}

