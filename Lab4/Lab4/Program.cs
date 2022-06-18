//Варіант 28
//Створити суперклас Текст і підкласи Речення, Слово, Ієрогліф. За допомогою конструктора задати кількість символів в тексті. 
//Визначити кількість слів у реченні та алфавіт(латиниця або кирилиця). 
//Вивести походження ієрогліфа(японський, китайський, корейський).


using Lab4;

//Оскільки при введенні речення я питаю їх номер щоб далі їх знаходити
//роблю списки усіх щоб легше було працювати з номерами
List<Sentence> sentences = new List<Sentence>();
List<Word> words = new List<Word>();
List<Hieroglyph> hieroglyphs = new List<Hieroglyph>();
for (; ; )//меню програми
{
    Console.WriteLine("1 - Додати текст | 2 - Визначити кiлькiсть слiв у реченнi | 3 - Визначити це кирилиця чи латиниця");
    Console.WriteLine(" 4 - Визначити походження iєроглiфа | 5 - Завершити роботу");
    string place = Console.ReadLine();
    switch (place)
    {
        case "1":
            AddText();
            break;
        case "2":
            Wordcount();
            break;
        case "3":
            Alphabet();
            break;
        case "4":
            HieroglyphOrigin();
            break;
    }
    if (place == "5")
    {
        break;
    }
    Console.ReadKey();
    Console.Clear(); 
}
void AddText()//додавання тексту
{
    try
    {
        Console.WriteLine("Це речення - 1, слово - 2 чи iєроглiф - 3?");
        string place = Console.ReadLine();
        switch (place)
        {
            case "1":
                Console.WriteLine("Введiть речення:");
                string a = Console.ReadLine();
                Console.WriteLine("Введiть тип алфавіту: латиниця - 1, кирилиця - 2");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введiть номер речення");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Sentence sentence = new Sentence(a, b, n1);//створюю об'єкти 
                sentences.Add(sentence);//додаю до словника
                break;
            case "2":
                Console.WriteLine("Введiть слово:");
                string c = Console.ReadLine();
                Console.WriteLine("Введiть тип алфавіту: латиниця - 1, кирилиця - 2");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введiть номер слова");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Word word = new Word(d, c, n2);
                words.Add(word);
                break;
            case "3":
                Console.WriteLine("Введiть ієрогліфи:");
                string e = Console.ReadLine();
                Console.WriteLine("Введiть походження ієрогліфу: японське - 1, китайське - 2, корейське - 3");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введiть номер iєроглiфа");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Hieroglyph hieroglyph = new Hieroglyph(f, e, n3);
                hieroglyphs.Add(hieroglyph);
                break;
        }
        Console.Clear();
        Console.WriteLine("Текст додано");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
void Wordcount()//обчислення кількості слів у реченні
{
    try
    {
        Console.WriteLine("Введіть номер речення");
        int number = Convert.ToInt32(Console.ReadLine());
        foreach (Sentence sentence in sentences)//задля цього робив списки
        {
            if (sentence.number == number)
            {
                sentence.WordCount();//метод класу sentence
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
void Alphabet()
{
    try
    {
        Console.WriteLine("Якщо це речення введiть 1, якщо слово щось iнше");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
            Console.WriteLine("Введiть номер речення");
            int number = Convert.ToInt32(Console.ReadLine());
            foreach (Sentence sentence in sentences)
            {
                if (sentence.number == number)
                {
                    sentence.Type();//метод класу Word для визначення типу алфавіту який наслідується до Sentence
                }
            }
        }
        else
        {
            Console.WriteLine("Введiть номер слова");
            int number = Convert.ToInt32(Console.ReadLine());
            foreach (Word word in words)
            {
                if (word.number == number)
                {
                    word.Type();
                }
            }
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
void HieroglyphOrigin()//метод визначення походження ієрогліфа працює аналогічно до попереднього методу
{
    try
    {
        Console.WriteLine("Введiть номер iєроглiфа");
        int number = Convert.ToInt32(Console.ReadLine());
        foreach (Hieroglyph hieroglyph in hieroglyphs)
        {
            if (hieroglyph.number == number)
            {
                hieroglyph.Type();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}