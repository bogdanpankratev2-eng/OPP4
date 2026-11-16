class Book
{
    public string name_book = "Название книги Автора";
    public string name = "Имя Автора книги";
    public string genre = "Жанр книги Аватора";
    public DateTime creating_a_book = new DateTime();
    public DateTime the_origin_of_the_book = new DateTime();


    public void Print_kniga()
    {
        Console.WriteLine($"Название книги:\t{name_book},\nИмя автора:\t{name}," +
            $"\nЖанр книги:\t{genre},\nСоздание книги:\t{creating_a_book}," +
            $"\nПроисхождение книги:\t{the_origin_of_the_book}");
    }
}
