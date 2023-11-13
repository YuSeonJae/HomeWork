namespace Chapter2_Homework
{
    internal class Program
    {
        private static Character player;
        private static Inventory item;
        private static Inventory2 item2;


        static void Main(string[] args)
        {
            GameDataSetting();
            DisplayGameIntro();
        }

        static void GameDataSetting()
        {
            // 캐릭터 정보 세팅
            player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);

            // 아이템 정보 세팅
            item = new Inventory("무쇠갑옷", "방어력 +", 5, "무쇠로 만들어져 튼튼한 갑옷입니다.");
            item2 = new Inventory2("낡은 검", "공격력 +", 2, "쉽게 볼 수 있는 낡은 검 입니다.");
        }

        static void DisplayGameIntro()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(1, 2);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    DisplayInventory();
                    break;
            }
        }

        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name}({player.Job})");
            Console.WriteLine($"공격력 :{player.Atk}");
            Console.WriteLine($"방어력 : {player.Def}");
            Console.WriteLine($"체력 : {player.Hp}");
            Console.WriteLine($"Gold : {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }

        static void DisplayInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine($"{item.ItemName}" + "|" + $"{item.Stat}" + $"{item.StatNum}" + "|" + $"{item.Info}");
            Console.WriteLine($"{item2.ItemName2}" + "|" + $"{item2.Stat2}" + $"{item2.StatNum2}" + "|" + $"{item2.Info2}");

            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }

        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }


    public class Character
    {
        public string Name { get; }
        public string Job { get; }
        public int Level { get; }
        public int Atk { get; }
        public int Def { get; }
        public int Hp { get; }
        public int Gold { get; }

        public Character(string name, string job, int level, int atk, int def, int hp, int gold)
        {
            Name = name;
            Job = job;
            Level = level;
            Atk = atk;
            Def = def;
            Hp = hp;
            Gold = gold;
        }
    }

    public class Inventory
    {
        public string ItemName { get; }
        public string Stat { get; }
        public int StatNum { get; }
        public string Info { get; }


        public Inventory(string itemname, string stat, int statnum, string info)
        {
            ItemName = itemname;
            Stat = stat;
            StatNum = statnum;
            Info = info;
        }
    }
    public class Inventory2
    {
        public string ItemName2 { get; }
        public string Stat2 { get; }
        public int StatNum2 { get; }
        public string Info2 { get; }


        public Inventory2(string itemname, string stat, int statnum, string info)
        {
            ItemName2 = itemname;
            Stat2 = stat;
            StatNum2 = statnum;
            Info2 = info;
        }
    }
}