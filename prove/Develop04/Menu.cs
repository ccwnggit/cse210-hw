public class Menu

{

public string MenuOption()
{
    Console.Clear();
    Console.WriteLine("Which activity you want to go:");
    Console.WriteLine ("1. Start breathing activity");
    Console.WriteLine ("2. Start reflection activity");
    Console.WriteLine ("3. Start listing activity");
    Console.WriteLine ("4. Quit\n");
    Console.Write("Select a choice frm the menu: ");
    string input = Console.ReadLine();
    return input;

}


}