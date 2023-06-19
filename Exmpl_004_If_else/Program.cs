/*видимости и где она объявлена. F12 перенесёт вас к объявлению выделенной переменной, функции или метода. Если объявление в другом файле — всё равно перенесёт*/
//Console.clear();
Console.Write("Ты кто такой? ");
string username = Console.ReadLine() ?? "";

if(username.ToLower() == "рустам")
{
    Console.WriteLine("Хозяин явился!!! ");
}
else 
{
    Console.Write("А ну ходи от сюда холоп!!!! ");
    Console.WriteLine(username);
}