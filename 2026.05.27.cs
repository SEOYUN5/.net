//class Program
//{
//    class Product: IComparable
//    {
//        public string Name { get; set; }
//        public int Price { get; set; }

//        public int CompareTo(object? obj)
//        {
//            throw new NotImplementedException();
//        }

//        public override string ToString()
//        {
//            return Name + " : " + Price + "원";
//        }
//    }
//    static void Main(string[] args)
//    {
//        List<Product>list = new List<Product>();
//        {
//            new Product() { Name = "고구마", Price = 1500},
//            new Product() { Name = "사과", Price = 2400},
//            new Product() { Name = "바나나", Price = 1000},
//            new Product() { Name = "배", Price = 3000},

//        };
//        list.Sort();

//        foreach(var item in list)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//인터페이스 상속 및 구현
//class Program
//{
//    interface IBasic
//    {
//        int TestProPerty {  get; set; }
//    }
//    class TestClass : IBasic
//    {
//        public int TestProPerty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public int TestInstancemethod()
//        {
//            throw new NotImplementedException();
//        }
//    }
//    static void Main(string[] args)
//    {
//        IBasic basic = new TestClass();

//    }
//}

//다중 상속
//class Program
//{
//    class Parent { }

//    class Child : Parent, IComparable, IDisposable
//    {
//        public int CompareTo(object? obj)
//        {
//            throw new NotImplementedException();
//        }

//        public void Dispose()
//        {
//            throw new NotImplementedException();
//        }
//    }
//    static void Main(string[] args) { }
//}
