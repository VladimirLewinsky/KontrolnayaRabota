string[] array = new string[6] { "hello", "2", "world", ":-)", "Kazan", "-2" };
string[] newarray = new string[6];
int i = 0;
for (i = 0; i < array.Length; i++){
    if (array[i].Length <= 3)
    {
        newarray[i] = array[i];
        Console.Write($"{newarray[i]}");
    }

}