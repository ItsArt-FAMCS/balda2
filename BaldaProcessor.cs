using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBalda.BaldaProcessor
{
    class BaldaProcessor
    {
        public const int KeyLength = 4;
        public const int Size = 7;
        public const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        //Singleton
        private static readonly BaldaProcessor _instance = new BaldaProcessor();
        public static BaldaProcessor Instance
        {
            get { return _instance; }
        }
        protected BaldaProcessor() { }

        //Fields
        private List<string> Words { get; set; }
        private Dictionary<string, List<string>> LongWordsContainer { get; set; }
        private List<string> ShortWordsContainer { get; set; }

        public void InitializeDictionaries(String words)
        {
            Words = words.Split(new []{' ', '\r', '\n', '\t'}).ToList();
            LongWordsContainer = new Dictionary<string, List<string>>();
            ShortWordsContainer = new List<string>();

            foreach (var w in Words)
            {
                var word = w.ToUpper().Trim();
                if (word.Length >= KeyLength)
                {
                    var keys = new List<String>();
                    for (int i = 0; i < word.Length - KeyLength; i++)
                    {
                        var key = word.Substring(i, KeyLength);
                        if (keys.Contains(key) == false)
                        {
                            keys.Add(key);
                        }
                        var array = key.ToCharArray();
                        Array.Reverse(array);
                        key = new string(array);
                        if (keys.Contains(key) == false)
                        {
                            keys.Add(key);
                        }
                    }
                    foreach (var key in keys)
                    {
                        if (LongWordsContainer.ContainsKey(key))
                        {
                            var list = LongWordsContainer[key];
                            list.Add(word);
                            LongWordsContainer[key] = list;
                        }
                        else
                        {
                            LongWordsContainer.Add(key, new List<string>() { word });
                        }
                    }
                }
                else if (string.IsNullOrWhiteSpace(word) == false)
                {
                    ShortWordsContainer.Add(word);
                }
            }
        }

        public Way Process(char[,] values, List<string> used)
        {
            //Initialize desk
            var desk = new Field[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    var field = new Field(i, j)
                    {
                        Value = Alphabet.Contains(values[i, j]) ? values[i, j] : ' '
                    };
                    desk[i, j] = field;
                }
            }

            Way result = null;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (desk[i, j].Value == ' ')
                    {
                        foreach (var letter in Alphabet)
                        {
                            var startField = new Field(i, j)
                            {
                                Value = letter
                            };
                            var way = GetBestWay(desk, startField, used);
                            if (way != null && (result == null || result.Text.Length < way.Text.Length))
                            {
                                result = way;
                            }
                        }
                    }
                }
            }
            return result;
        }

        public bool IsWord(string word)
        {
            return Words.Contains(word.ToUpper().Trim());
        }

        protected List<Way> GetStartWays(Field[,] desk, Field start)
        {
            var ways = new List<Way>();
            var startWay = new Way(desk, start);
            var startNeighbors = startWay.GetNeighbors(start);
            foreach (var neighbor in startNeighbors)
            {
                ways.Add(startWay.AddFirst(neighbor));
                ways.Add(startWay.AddLast(neighbor));
            }
            return ways;
        }

        protected List<Way> ExtendLastWays(List<Way> ways)
        {
            var result = new List<Way>();
            foreach (var way in ways)
            {
                var neighbors = way.GetNeighbors(way.Last);
                result.AddRange(neighbors.Select(neighbor => way.AddLast(neighbor)));
            }
            return result;
        }

        protected List<Way> ExtendBothWays(List<Way> ways)
        {
            var result = new List<Way>();
            foreach (var way in ways)
            {
                var lastNeighbors = way.GetNeighbors(way.Last);
                result.AddRange(lastNeighbors.Select(neighbor => way.AddLast(neighbor)));

                var firstNeighbors = way.GetNeighbors(way.First);
                result.AddRange(firstNeighbors.Select(neighbor => way.AddFirst(neighbor)));
            }
            return result;
        }

        protected Way GetBestWay(Field[,] desk, Field start, List<string> used)
        {
            //Get Start Keys
            var ways = GetStartWays(desk, start);
            if (ways.Count == 0)
                return null;
            var result = ways.FirstOrDefault(way => (ShortWordsContainer.Contains(way.Text) && (used.Contains(way.Text) == false))
                || (ShortWordsContainer.Contains(way.Reverse) && (used.Contains(way.Reverse) == false)));

            for (int i = 0; i < KeyLength - 2; i++)
            {
                ways = ExtendLastWays(ways);
                foreach (var way in ways.Where(way => (ShortWordsContainer.Contains(way.Text) && (used.Contains(way.Text) == false))
                || (ShortWordsContainer.Contains(way.Reverse) && (used.Contains(way.Reverse) == false))))
                {
                    result = way;
                    break;
                }
            }
            //Initialize start dictionaries
            foreach (var way in ways)
            {
                way.Words = LongWordsContainer.ContainsKey(way.Text) ? LongWordsContainer[way.Text] : new List<string>();
                if ((way.IsWord && used.Contains(way.Word) == false) || (way.TwoWords && used.Contains(way.Reverse) == false))
                {
                    result = way;
                }
            }
            //Поиск в ширину, короче
            while (ways.Count > 0)
            {
                var tempWays = ExtendBothWays(ways);
                ways = new List<Way>();
                foreach (var way in tempWays)
                {
                    way.ReformWords();
                    if (way.Words.Count > 0)
                    {
                        ways.Add(way);
                    }
                    if ((result == null || way.Text.Length > result.Text.Length) 
                        && ((way.IsWord && used.Contains(way.Word) == false) || (way.TwoWords && used.Contains(way.Reverse) == false)))
                    {
                        result = way;
                    }
                }
            }
            return result;
        }

    }
}
