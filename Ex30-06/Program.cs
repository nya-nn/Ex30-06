using System;
namespace Ex30_06
{
    class Program
    {
        static void Main()
        {
            Student student = new Student(100, "田中五郎", 19, 172, 60,"12/25", 01);
            Console.WriteLine($"名前:{student.name}、年齢:{student.age}、身長:{student.height}cm、体重:{student.weight}kg、学籍番号:{student.id}、誕生日:{student.birthDay}、" +
                $"寿命:{student.life-student.age}年、{student.GetBD(student.birthDay)}");

            Worker worker = new Worker(100, "佐藤幸助", 25, 178, 70,"12/01", 300);
            Console.WriteLine($"名前:{worker.name}、年齢:{worker.age}、身長{worker.height}cm:、体重:{worker.weight}kg、年収:{worker.income}万、誕生日:{worker.birthDay}、" +
                $"寿命:{worker.life-worker.age}年、{worker.GetBD(worker.birthDay)}");

            Fish fish = new Fish(6, "鮭", "北太平洋", 5, "白身魚");
            Console.WriteLine($"種族{fish.race}:、生息地{fish.habitat}:、重さ:{fish.weight}kg、平均寿命:{fish.life}年、{fish.body}");

            refrigerator refrigerator = new refrigerator(20, 139, "三菱", 700);
            Console.WriteLine($"製造元:{refrigerator.manufacturer}、重さ:{refrigerator.weight}、耐用年数:{refrigerator.life}年、内容量:{refrigerator.capacity}L");

            Bug bug = new Bug(1, "ヒアリ", "南米中部", 1, "羽なし");
            Console.WriteLine($"種族:{bug.race}、生息地:{bug.habitat}、重さ:{bug.weight}mg、平均寿命:{bug.life}年,{bug.wing}");

            car car = new car(5, 1635, "トヨタ", "黒");
            Console.WriteLine($"製造元{car.manufacturer}:、重さ{car.weight}kg:、耐用年数:{car.life}年、色:{car.color}");

            Cat cat = new Cat(15, "三毛猫", "屋内", 5, "飼い猫");
            Console.WriteLine($"種族{cat.race}:、生息地{cat.habitat}:、重さ{cat.weight}:、平均寿命{cat.life}:、{cat.status}");

            clothes clothes = new clothes(4, 700, "ユニクロ", "冬用");
            Console.WriteLine($"製造元:{clothes.manufacturer}、重さ{clothes.weight}:、耐用年数{clothes.life}:、{clothes.season}");
        }
    }
}