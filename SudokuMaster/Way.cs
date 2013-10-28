﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace SudokuMaster
{
    class Way
    {
        private string _reverse;

        public Field[,] Desk { get; set; }

        public string Text { get; set; }
        public string Reverse
        {
            get
            {
                if (string.IsNullOrEmpty(_reverse) || _reverse.Length != Text.Length)
                {
                    char[] array = Text.ToCharArray();
                    Array.Reverse(array);
                    _reverse = new String(array);
                }
                return _reverse;
            }
        }

        public bool TwoWords
        {
            get
            {
                if (Text.Length >= 4 && Words != null)
                {
                    if (Words.Contains(Text) && Words.Contains(Reverse))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool IsWord
        {
            get
            {
                if (Text.Length >= 4 && Words != null)
                {
                    if (Words.Contains(Text) || Words.Contains(Reverse))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public string Word
        {
            get
            {
                if (IsWord)
                {
                    return Words.Contains(Text) ? Text : Reverse;
                }
                return string.Empty;
            }
        }

        public Field First { get; set; }
        public Field Last { get; set; }

        public List<string> Words { get; set; }

        public Way(Field[,] desk)
        {
            Desk = new Field[BaldaProcessor.Size, BaldaProcessor.Size];
            for (int i = 0; i < BaldaProcessor.Size; i++)
            {
                for (int j = 0; j < BaldaProcessor.Size; j++)
                {
                    Desk[i,j] = new Field(i , j)
                        {
                            Value = desk[i,j].Value,
                            Step = desk[i,j].Step
                        };
                }
            }
        }

        public Way(Field[,] desk, Field start)
        {
            Desk = new Field[BaldaProcessor.Size, BaldaProcessor.Size];
            for (int i = 0; i < BaldaProcessor.Size; i++)
            {
                for (int j = 0; j < BaldaProcessor.Size; j++)
                {
                    Desk[i,j] = new Field(i , j)
                        {
                            Value = desk[i, j].Value,
                            Step = desk[i, j].Step
                        };
                }
            }
            start.Step = 0;
            First = start;
            Last = start;
            Text = "" + start.Value;
            Desk[start.X, start.Y] = start;
        }

        public Way CopyWay()
        {
            var result = new Way(Desk)
            {
                Text = Text,
                Words = Words
            };
            result.First = result.Desk[First.X, First.Y];
            result.Last = result.Desk[Last.X, Last.Y];
            return result;
        }

        public Way AddFirst(Field field)
        {
            var result = CopyWay();
            field.Step = First.Step - 1;
            result.First = field;
            result.Text = field.Value + Text;
            result.Desk[field.X, field.Y] = field;
            return result;
        }
        public Way AddLast(Field field)
        {
            var result = CopyWay();
            field.Step = Last.Step + 1;
            result.Last = field;
            result.Text = Text + field.Value;
            result.Desk[field.X, field.Y] = field;
            return result;
        }

        public void ReformWords()
        {
            if (Words != null && Words.Count > 0 && Words[0].Length != Text.Length)
            {
                var newList = Words.Where(w => w.Contains(Text) || w.Contains(Reverse)).ToList();
                Words = newList;
            }
        }

        public List<Field> GetNeighbors(Field field)
        {
            var result = new List<Field>();
            if (field.X != 0 && Desk[field.X - 1, field.Y].Value != ' ' && Desk[field.X - 1, field.Y].Step == null)
            {
                result.Add(Desk[field.X - 1, field.Y]);
            }
            if (field.Y != 0 && Desk[field.X, field.Y - 1].Value != ' ' && Desk[field.X, field.Y - 1].Step == null)
            {
                result.Add(Desk[field.X, field.Y - 1]);
            }
            if (field.X != BaldaProcessor.Size - 1 && Desk[field.X + 1, field.Y].Value != ' ' && Desk[field.X + 1, field.Y].Step == null)
            {
                result.Add(Desk[field.X + 1, field.Y]);
            }
            if (field.Y != BaldaProcessor.Size - 1 && Desk[field.X, field.Y + 1].Value != ' ' && Desk[field.X, field.Y + 1].Step == null)
            {
                result.Add(Desk[field.X, field.Y + 1]);
            }
            return result;
        }

        public Field GetStartField()
        {
            for (int i = 0; i < BaldaProcessor.Size; i++)
            {
                for (int j = 0; j < BaldaProcessor.Size; j++)
                {
                    if (Desk[i, j] != null && Desk[i, j].Step != null && Desk[i, j].Step == 0)
                    {
                        return Desk[i, j];
                    }
                }
            }
            return null;
        }
    }
}