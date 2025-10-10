using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.BusinessLogicLayer
{
    internal class Superhero
    {
        private int SuperheroID;
        private string SuperheroName;
        private int SuperheroAge;
        private string SuperPower;
        private int ExamScore;
        private string Rank;
        private string ThreadLevel;

        public Superhero(int superheroID, string superheroName, int superheroAge, string superPower, int examScore, string rank, string threadLevel)
        {
            SuperheroID1 = superheroID;
            SuperheroName1 = superheroName;
            SuperheroAge1 = superheroAge;
            SuperPower1 = superPower;
            ExamScore1 = examScore;
            Rank1 = rank;
            ThreadLevel1 = threadLevel;
        }

        public int SuperheroID1 { get => SuperheroID; set => SuperheroID = value; }
        public string SuperheroName1 { get => SuperheroName; set => SuperheroName = value; }
        public int SuperheroAge1 { get => SuperheroAge; set => SuperheroAge = value; }
        public string SuperPower1 { get => SuperPower; set => SuperPower = value; }
        public int ExamScore1 { get => ExamScore; set => ExamScore = value; }
        public string Rank1 { get => Rank; set => Rank = value; }
        public string ThreadLevel1 { get => ThreadLevel; set => ThreadLevel = value; }
    }
}
