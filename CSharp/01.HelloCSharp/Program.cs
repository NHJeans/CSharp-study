using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using 다음에 있는 것들은 네임스페이스라고 함
// System이라는 보따리에 있는 것들을 가져오겠다는 뜻
// import 라고 생각하면 됨

namespace HelloCSharp // HelloCSharp라는 이름의 보따리안에
{
    class Program // Program이라는 이름의 클래스를 만들겠다는 뜻
    {
        static void Main(string[] args) 
        // Main이라는 이름의 함수를 만들겠다는 뜻
        // Main이라는 함수는 프로그램이 시작될 때 가장 먼저 실행되는 함수
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(args.Length); // 0
            Console.WriteLine("Hello, " + args[0]); 

            Console.ReadKey();  // 키의 입력을 받기 전까지 프로그램이 멈춤
        }
    }
}