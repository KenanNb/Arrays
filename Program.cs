using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        public static void PrintPoint(int points)
        {
            Console.Write("Exam ended. Your points : ");
            if(points > 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (points > 80)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            else if (points > 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (points > 60)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (points > 500)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(points);
            Console.ResetColor();
        }

        public static void getData(out string[] questions,out string[][] answers)
        {
            const int questionsCount = 10;
            questions = new string[questionsCount];
            answers = new string[questionsCount][];

            questions[0] = "In the United States, what is traditionally the proper way to address a judge?     ";
            answers[0] = new string[4];
            answers[0][0] = "Your holiness          ";
            answers[0][1] = "Your honor             ";
            answers[0][2] = "your eminence          ";
            answers[0][3] = answers[0][1];

            questions[1] = "The popular children's song \"It's Raining, It's Pouring\" mentions an \"old man\" doing what?    ";
            answers[1] = new string[4];
            answers[1][0] = "Snoring           ";
            answers[1][1] = "Cooking           ";
            answers[1][2] = "Laughing          ";
            answers[1][3] = answers[1][0];

            questions[2] = "In which of these films does Whoopi Goldberg dress up as a nun?    ";
            answers[2] = new string[4];
            answers[2][0] = "Ghost                     ";
            answers[2][1] = "The Color Purple          ";
            answers[2][2] = "Sister Act                ";
            answers[2][3] = answers[2][2];

            questions[3] = "If someone asked to see your ID, what might you show them?    ";
            answers[3] = new string[4];
            answers[3][0] = "Your tongue            ";
            answers[3][1] = "Your passport          ";
            answers[3][2] = "Your door              ";
            answers[3][3] = answers[3][1];

            questions[4] = "According to a common phrase, a person who takes chances is \"going out on a\" what?    ";
            answers[4] = new string[4];
            answers[4][0] = "Limb           ";
            answers[4][1] = "Horse          ";
            answers[4][2] = "Skateboard     ";
            answers[4][3] = answers[4][0];

            questions[5] = "Due to the geographical areas they represented, the opposing sides of the US Civil War were known by what names?    ";
            answers[5] = new string[4];
            answers[5][0] = "The Hills and the Valleys      ";
            answers[5][1] = "The North and The south        ";
            answers[5][2] = "The Kool and the Gang          ";
            answers[5][3] = answers[5][1];

            questions[6] = "Due to the geographical areas they represented, the opposing sides of the US Civil War were known by what names?    ";
            answers[6] = new string[4];
            answers[6][0] = "Granite boulders        ";
            answers[6][1] = "Precious stones         ";
            answers[6][2] = "Fruity Pebbles          ";
            answers[6][3] = answers[6][2];

            questions[7] = "A feisty train is the hero of a classic children's book titled The Little Engine That what?    ";
            answers[7] = new string[4];
            answers[7][0] = "Ran          ";
            answers[7][1] = "Could        ";
            answers[7][2] = "Cried        ";
            answers[7][3] = answers[7][1];

            questions[8] = "According to the old saying, \"love of\" what \" is the root of all evil\"?    ";
            answers[8] = new string[4];
            answers[8][0] = "Money         ";
            answers[8][1] = "Food          ";
            answers[8][2] = "Clothing      ";
            answers[8][3] = answers[8][0];

            questions[9] = "When a person is rudely ignored, he is said to be getting what?    ";
            answers[9] = new string[4];
            answers[9][0] = "Hot knee          ";
            answers[9][1] = "Cold shoulder     ";
            answers[9][2] = "Warm toe          ";
            answers[9][3] = answers[9][1];
        }
        public static sbyte GetAnswerIndex(string answer)
        {
            if (!String.IsNullOrWhiteSpace(answer))
            {
                char variant = (char)(answer.ToUpper().ToCharArray()[0]);
                if(variant.Equals('A') || variant.Equals('B') || variant.Equals('C'))
                {
                    return (sbyte)(variant - 65);
                }
            }
            return -1;
        }
        public static void PrintAnswers(string[] answers)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($@"                                     _____________________________
                                    |{(char)(65 + i)} {answers[i]}    |
                                    |_____________________________|");
            }
        }
        public static void PrintCorrectAnswer(string[] answers)
        {
            for (int i = 0; i < 3; i++)
            {
                if(answers[i] != answers[3])
                {
                Console.WriteLine($@"                                     _____________________________
                                    |{(char)(65 + i)} {answers[i]}    |
                                    |_____________________________|");
                continue;
                }
            Console.ForegroundColor = ConsoleColor.Green;            
            Console.WriteLine($@"                                     _____________________________
                                |{(char)(65 + i)} {answers[i]}    |
                                |_____________________________|");
            Console.ResetColor();
            }
        }
        public static void PrintCorrectAndWrongAnswer(string[] answers, byte wrongAnswer)
        {
            for (int i = 0; i < 3; i++)
            {
                if (answers[i] == answers[3])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"                                     _____________________________
                                        |{(char)(65 + i)} {answers[i]}    |
                                        |_____________________________|");
                    Console.ResetColor();
                    continue;
                }
                else if (i == wrongAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($@"                                     _____________________________
                                        |{(char)(65 + i)} {answers[i]}    |
                                        |_____________________________|");
                    Console.ResetColor();
                    continue;
                }
                Console.WriteLine($@"                                     _____________________________
                                    |{(char)(65 + i)} {answers[i]}    |
                                    |_____________________________|");
            }

        }
        public static string[] GetRandomAnswer(string[] answers)
        {
            var random = new Random();
            var randomAnswers = new string[4];
            var numbers = String.Empty;
            var counter = 0;
            while (counter < 3)
            {
                var index = random.Next(0, 3);
                if (!numbers.Contains(index.ToString()))
                {
                    numbers += index.ToString();
                    randomAnswers[index] = answers[counter];
                    counter++;
                }
            }
            randomAnswers[3] = answers[3];
            return randomAnswers;
        }
        public static void Start(byte counter)
        {
            Console.Title = "We are starting Who wants to be a millioner!!! ";
            getData(out string[] questions, out string[][] answers);
            var points = 0;
            for (int i = 0; i < questions.GetLength(0); i++)
            {
                counter++;
                var randomAnswers = GetRandomAnswer(answers[i]);
                if(i == 9)
                {
                    Console.WriteLine($"Question{i + 1}       ");
                    Console.WriteLine($"{questions[i]}");
                }
                if (i < 9)
                {
                    Console.WriteLine($"Question{i + 1}       ");
                    Console.WriteLine($"{questions[i]}");
                }
                PrintAnswers(randomAnswers);
                sbyte answerIndex;
                while (true)
                {
                    Console.WriteLine("Your answer is  : ");
                    var answer = Console.ReadLine();
                    answerIndex = GetAnswerIndex(answer);
                    if (answerIndex >= 0)                    
                        break;
                     Console.WriteLine("Your answer is wrong try answer correctly next time!!! ");
                    
                }
                    if (i == 9)
                    {
                        Console.Clear();
                        Console.WriteLine($"Question{i + 1}       ");
                        Console.WriteLine($"{questions[i]}");
                    }
                    if (i < 9)
                    {
                        Console.Clear();
                        Console.WriteLine($"Question{i + 1}       ");
                        Console.WriteLine($"{questions[i]}");
                    }
                    if (randomAnswers[answerIndex] == randomAnswers[3])
                    {

                        PrintCorrectAnswer(randomAnswers);
                        points += 10;
                    }
                    else
                    {
                        PrintCorrectAndWrongAnswer(randomAnswers, (byte)answerIndex);
                        if (points != 0)
                        {
                            points -= 10;
                        }
                    }
                    if (i == questions.Length - 1)
                    {
                        Console.WriteLine("Press enter to the continue!!!");
                    }
                    else
                    {
                        Console.WriteLine("Press enter for the next question!");
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                PrintPoint(points);
            }
        
     
        static void Main(string[] args)
        {
            Start(0);

        }
    }
}
