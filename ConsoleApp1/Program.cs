// See https://aka.ms/new-console-template for more information

using System.Text;

var firstTasks = File.ReadAllText("./First.txt").Split("@",StringSplitOptions.RemoveEmptyEntries);
var secondTasks = File.ReadAllText("./Second.txt").Split("@",StringSplitOptions.RemoveEmptyEntries);
var thirdTasks = File.ReadAllText("./Third.txt").Split("@",StringSplitOptions.RemoveEmptyEntries);
var fourthTasks = File.ReadAllText("./Fourth.txt").Split("@",StringSplitOptions.RemoveEmptyEntries);

var rnd = new Random();
for (var i = 0; i < 100; i++)
{
   GenerateDoc(i, rnd.Next(firstTasks.Length), rnd.Next(secondTasks.Length), rnd.Next(thirdTasks.Length), rnd.Next(fourthTasks.Length));
}


void GenerateDoc(int number, int first, int second, int third, int fourth)
{
   var sb = new StringBuilder();
   sb.AppendLine($"Вариант: {number}");
   sb.AppendLine("ФИО:");
   sb.AppendLine("Номер группы:");
   sb.AppendLine();
   sb.AppendLine(firstTasks[first]);
   sb.AppendLine();
   sb.AppendLine(secondTasks[second]);
   sb.AppendLine();
   sb.AppendLine(thirdTasks[third]);
   sb.AppendLine();
   sb.Append(
      "Необходимо разработать программу, содержащую как минимум 3 файла (при необходимости можно добавить свои):\nWindow.xaml, Window.xaml.cs, WindowViewModel.cs\n\nПри разработке программы придерживайтесь паттерна MVVM\n\nДля решения вам могут потребоваться следующие контролы:\n<Checkbox>, <Listbox>, <Textbox>, <Image>, <Button>, <Canvas>\n\nПри решении нельзя ссылаться на сторонние библиотеки, за исключением: flurl, community toolkit, reacriveui, prism, ef, dapper.");
   sb.AppendLine();
   sb.AppendLine();
   sb.AppendLine(fourthTasks[fourth]);
   File.WriteAllText($"Document{number}.txt", sb.ToString());
}
