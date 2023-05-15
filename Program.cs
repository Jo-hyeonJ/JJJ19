namespace JJJ19
{
    internal class Program
    {
        // Q. 나이를 입력 받으면 출생년도를 출력하는 함수를 만들어보자.
        static void Solution(int age)
        {
            if (age < 0 || age > 120)
                Console.WriteLine("올바르지 않은 나이입니다.");
            else
                Console.WriteLine($"{age}살의 출생연도 : {DateTime.Now.Year - age + 1}년"); 
        }

        static void Main(string[] args)
        {
            // 1교시
            /*
            Solution(20);
            Solution(30);

            Action<int> getBirth = (int age) =>
            {
                if (age <= 0 || age > 120)
                    Console.WriteLine("올바르지 않은 나이입니다.");
                else
                    Console.WriteLine($"{age}살의 출생연도 : {DateTime.Now.Year - age + 1}년");
            };

            while (false)
            {
                getBirth(int.Parse(Console.ReadLine()));
            }

            // C#의 날짜 계산
            // DateTime : 날짜와 시간을 '표기'하기 위한 자료형
            // TimeSpan : 날짜와 시간의 '차이'를 구하기 위한 자료형
            // Math : 수학 계산 관련 함수가 들어있는 자료형
            
            Console.WriteLine(DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));

            // 시간의 차이를 나타내는 자료형
            // 새해의 시작부터 경과된 시간 보기
            DateTime newYear = new DateTime(2023, 1, 1);
            TimeSpan time = DateTime.Now - newYear;
            Console.WriteLine($"새해로부터 {Math.Ceiling(time.TotalDays)}일 지났습니다.");
            Console.WriteLine($"{(Math.Ceiling(time.TotalSeconds)).ToString("N0")}초 지났습니다.");
            Console.WriteLine($"{(Math.Ceiling(time.TotalMinutes)).ToString("N0")}분 지났습니다.");
            Console.WriteLine($"{(Math.Ceiling(time.TotalHours)).ToString("N0")}시간 지났습니다.");


            // 스탑 워치 만들기
            Console.Clear();
            Console.WriteLine("시작");
            Console.WriteLine("00:00:00.000");
            Console.ReadKey();

            DateTime start = DateTime.Now;
            while(!Console.KeyAvailable)
            {
                TimeSpan current = DateTime.Now - start;
                Console.Clear();
                Console.WriteLine(current.ToString(@"mm\:ss\.fff"));

                Thread.Sleep(20);
            }
            Console.WriteLine("종료");
            */
            // 2교시
            /*
                        // 평균 구하기
                        int[] array = { 1,2,3,3,4,5,5,6,7};
                        int total = 0;
                        foreach (int i in array)
                        {
                            total += i;
                        }

                        Console.WriteLine ($"평균 : {total / array.Length}");
            *//*
             * 파쇄
                        List<int> list = new List<int>();

                        bool mode = true;
                        while(mode)
                        {
                                Console.WriteLine("입력한 값들의 평균을 구하려면 stop을 입력하세요.");
                                Console.Write("값을 입력하세요 : ");

                            int num;
                            int n;
                            num = int.Parse(Console.ReadLine());
                            if (num == "Stop" || num == "stop" || num == "STOP")
                            {
                                mode = false;
                                break;
                            }
                            else if (num != null)
                            {
                                if (0 < num)
                                list.Add(num);
                                else
                                    Console.WriteLine("잘못된 값입니다.");

                            }
                            else
                                Console.WriteLine("잘못된 값입니다.");
                        }
                        foreach(int i in list)
                        {
                            total += i;
                        }
                        Console.WriteLine($"평균 : {total / array.Length}");


                        Player player = new Player(Player.JOB.Warrior);
                        Console.WriteLine(player.GetJobKorea());
                        */

            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            // 기존 배열 확인
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }


            // 배열 뒤집기

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            // 바뀐 배열 확인
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            int[] array2 = array.ReverseArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }





            // 한 배열을 같은 숫자로 채우기
            int n = 10;
            int[] array3 = new int[n];

            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = 30;
            }
            array3.ToWriteLine();

            // 함수 Fill
            // 특정 배열의 내부 값을 전부 채워준다.
            Array.Fill(array3, 40);

            // Repeat(값, 개수) Enumerable<T>
            // Range (최소, 최대) Enumerable<T>

            int[] array4 = Enumerable.Repeat(30, n).ToArray();
            int[] array5 = Enumerable.Repeat(1, 10).ToArray();

            array4.ToWriteLine();
            array5.ToWriteLine();


        }
    }
}

   // 확장 메소드
   // => 객체 안에 정의되어 있지 않지만 추가로 정의할 수 있는 기능이다.

public class Player
{
    public enum JOB
    {
        Warrior,
        Archor,
    }

    JOB job;
    public Player( JOB job )
    {
        this.job = job;
    }
    public JOB GetJob()
    {
        return job;
    }

}
public static class Method
{
    // 첫번째 매개변수 앞의 this가 의미하는 것은 해당 자료형에 대한 확장을 하겠다.
    public static string GetJobKorea(this Player target)
    {
        Player.JOB job = target.GetJob();
        string[] korea = new string[] { "전사", "궁수" };
        return korea[(int)job];
    }

    public static T[] ReverseArray<T>(this T[] array)
    {
        T[] temparray = new T[array.Length];
        for(int i = 0; i < array.Length; i++)
        {
            int index = array.Length - 1-i;
            temparray[i] = array[index];
        }
        return temparray;
    }
    public static void ToWriteLine<T>(this T[] array)
    {
        foreach(T item in array)
        {
            Console.WriteLine(item);
        }
    }

}