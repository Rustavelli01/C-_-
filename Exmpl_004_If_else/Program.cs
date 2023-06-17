//Console.clear();
Console.Write("Ты кто такой? ");
string username = Console.ReadLine();

if(username.ToLower() == "рустам")
{
    Console.WriteLine("Хозяин явился!!! ");
}
else 
{
    Console.Write("А ну ходи от сюда холоп!!!! ");
    Console.WriteLine(username);
}