using System;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace SF_Module13
{
    class Program
    {
        // [13.4.4]
        /*
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com")
        };
        */

        // [13.4.5]
        /*
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };

        private static SortedDictionary<string, Contact> SortedPhoneBook = new SortedDictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };
        */

        // [13.5.4]
        /*
        public static Stack<string> words = new Stack<string>();
        */

        // [13.5.8]
        /*
        public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();
        */

        static void Main(string[] args)
        {
            // [13.1.4]
            /*
            Console.WriteLine(CheckAscending(new[] { -1, 2, 3, 4, 8 }));

            Console.WriteLine(CheckAscending(new[] { -1, 2, 3, 10, 8 }));
            */

            // [13.1.6]
            /*
            string text = File.ReadAllText(@"D:\cdev_Text.txt");

            char[] delimiters = new char[] { ' ', '\r', '\n' };

            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);
            */

            // [13.2.5]
            /*
            var months = new[]
            {
                "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
                1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12
            };

            var combinedList = new ArrayList();

            foreach (var number in numbers)
            {
                combinedList.Add(months[number - 1]);

                combinedList.Add(number);
            }

            foreach (var value in combinedList)
                Console.WriteLine(value);
            */

            // [13.2.6]
            /*
            var arrayList = new ArrayList()
            {
               1,
               "Андрей ",
               "Сергей ",
               300,
            };

            int sum = 0;

            StringBuilder text = new StringBuilder();

            foreach (var element in arrayList)
            {
                if (element is int)
                {
                    sum += (int)element;
                }

                if (element is string s)
                {
                    text.Append(element);
                }
            }

            var result = new ArrayList() { sum, text.ToString() };

            foreach (var elem in result)
            {
                Console.WriteLine(elem);
            }
            */

            /* [13.3.5]
            var months = new List<string>()
            {
                "Jan", "Feb", "Mar", "Apr", "May"
            };

            var missing = new ArrayList()
            {
                 1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            */

            // [13.3.10 - 13.3.12]
            /*
            //var sentence = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, " +
            //    "учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

            while (true)
            {
                var sentence = Console.ReadLine();

                var characters = sentence.ToCharArray();

                var symbols = new HashSet<char>();

                foreach (var symbol in characters)
                    symbols.Add(symbol);

                Console.WriteLine($"Всего {symbols.Count} уникальных символов");

                var signs = new[] { ',', ' ', '.' };
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                bool containsNumbers = symbols.Overlaps(numbers);

                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

                symbols.ExceptWith(signs);

                Console.WriteLine($"Символов без знаков препинания:: {symbols.Count}");
            }
            */

            // [13.4.4]
            /*
            Console.WriteLine("Текущий список контактов: ");
            WriteAllContacts();

            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

            Console.WriteLine("Обновленный список контактов: ");
            WriteAllContacts();

            if (PhoneBook.TryGetValue("Диана", out Contact contact))
                contact.PhoneNumber = 79990000001;

            Console.WriteLine("Список после изменения: ");
            WriteAllContacts();
            */

            // [13.4.5]
            /*
            var watchOne = Stopwatch.StartNew();

            PhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

            Console.WriteLine($"Вставка в  словарь: {watchOne.Elapsed.TotalMilliseconds}  мс");

            var watchTwo = Stopwatch.StartNew();

            SortedPhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

            Console.WriteLine($"Вставка в сортированный словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
            */

            // [13.5.4]
            /*
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();

                switch(input)
                {
                    case "pop":
                        words.TryPop(out string popResult);
                        break;
                    case "peek":
                        words.TryPeek(out string peekResult);
                        break;
                    default:
                        words.Push(input);
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
            */

            // [13.5.8]
            /*
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
            Console.WriteLine();

            StartQueueProcessing();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "peek")
                {
                    if (words.TryPeek(out var elem))
                        Console.WriteLine(elem);
                }
                else
                {
                    words.Enqueue(input);
                }
            }
            */
        }

        // [13.1.4]
        /*
        static bool CheckAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] < numbers[i])
                    return false;
            }

            return true;
        }
        */

        // [13.3.4]
        /*
        public class Contact
        {
            public String Name { get; }
            public long PhoneNumber { get; }
            public String Email { get; }

            public Contact(string name, long phoneNumber, String email)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }

        private static void AddUnique(Contact newContact, List<Contact> phoneBook)
        {
            bool alreadyExists = false;

            foreach (var contact in phoneBook)
            {
                if (contact.Name == newContact.Name)
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
                phoneBook.Add(newContact);

            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
        }
        */

        // [13.3.5]
        /*
        private static void GetMissing(List<string> months, ArrayList missing)
        {
            var missedArray = new string[7];

            missing.GetRange(4, 7).CopyTo(missedArray);

            months.AddRange(missedArray);

            foreach (var month in months)
                Console.WriteLine(month);
        }
        */

        // [13.4.4 - 13.4.5]
        /*
        public class Contact
        {
            public long PhoneNumber { get; set; }
            public String Email { get; set; }

            public Contact(long phoneNumber, String email)
            {
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }

        public static void WriteAllContacts()
        {
            foreach (var contact in PhoneBook)
                Console.WriteLine(contact.Key + ": " + contact.Value.PhoneNumber);
            Console.WriteLine();
        }
        */

        // [13.5.8]
        /*
        static void StartQueueProcessing()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while (true)
                {
                    Thread.Sleep(5000);
                    if (words.TryDequeue(out var element))
                        Console.WriteLine("======>  " + element + " прошел очередь");
                }
            }).Start();
        }
        */
    }
}