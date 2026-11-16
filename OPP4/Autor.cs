class Autor
{
    public string name = "Здесь имя Автора";
    public string first_name = "Здесь Фамилия Автора";
    public DateTime birth_day = new DateTime();
    public DateTime death_day = new DateTime();
    public string genre = "Здесь жанр Автора";
    public string country = "Здесь происхождение Автора!";


    public void Print_autor()
    {
        Console.WriteLine($"Имя автора:\t{name},\nВаша фамилия:\t{first_name}," +
            $"\nДата рождения автора:\t{birth_day},\nДата смерти автора:{death_day}," +
            $"\nЖанр автора:\t{genre},\nПроисхождение автора:\t{country}");
    }


}



















