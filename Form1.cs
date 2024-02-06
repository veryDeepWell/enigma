//NOTES:
//when ring spins the last letter becomes first

//TODO:
//ring spin
//decryption

using System;

namespace testForEnigma
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        //LOL                                    "1" , "2" , "3" , "4" , "5" , "6" , "7" , "8" , "9" , "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27" 

        public string[] ringFirstLetters     = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };
        public string[] ringFirstPosWires    = { "23", "11", "5" , "10", "1" , "6" , "13", "19", "8" , "4" , "3" , "9" , "26", "25", "12", "21", "18", "20", "15", "16", "24", "2" , "7" , "14", "17", "22", "27" };
        
        public string[] ringSecondLetters    = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };
        public string[] ringSecondPosWires   = { "7" , "14", "5" , "4" , "23", "20", "10", "17", "9" , "26", "13", "8" , "25", "19", "3" , "1" , "24", "6" , "18", "12", "21", "11", "16", "2" , "22", "15", "27" };

        public string[] ringThirdLetters     = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };
        public string[] ringThirdPosWires    = { "22", "18", "12", "19", "4" , "2" , "23", "7" , "26", "14", "16", "20", "6" , "24", "9" , "25", "5" , "11", "1" , "10", "17", "15", "21", "13", "3" , "8" , "27" };

        public string[] reflectorFirstLayer  = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };
        public string[] reflectorSecondLayer = { "Y" , "R" , "U" , "H" , "Q" , "S" , "L" , "D" , "P" , "X" , "N" , "G" , "O" , "K" , "M" , "I" , "E" , "B" , "F" , "Z" , "C" , "W" , "V" , "J" , "A" , "T" , " "  };

        //DEBUG
        //public string[] ringFirstLetters = { "A", "B", "C", "D" };
        //public string[] ringFirstPosWires = { "4", "1", "3", "2" };

        //public string[] ringSecondLetters = { "A", "B", "C", "D" };
        //public string[] ringSecondPosWires = { "3", "2", "1", "4" };

        //public string[] ringThirdLetters = { "A", "B", "C", "D" };
        //public string[] ringThirdPosWires = { "4", "3", "1", "2" };

        //public string[] reflectorFirstLayer  = { "A", "B", "C", "D" };
        //public string[] reflectorSecondLayer = { "C", "D", "A", "B" };

        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textEntered = textBox1.Text;
            string encryptedText = "";

            foreach (char letter in textEntered)
            {
                encryptedText += firstRingEncryption(letter.ToString());
            }

            textBox2.Text = encryptedText;
        }

        private string firstRingEncryption(string _letterToEncrypt)
        {
            string letterToEncrypt = _letterToEncrypt;
            int positionOfLetterInRing = Array.IndexOf(ringFirstLetters, letterToEncrypt);
            int linkToNextRing = Convert.ToInt32(ringFirstPosWires[positionOfLetterInRing]) - 1;
            string nextLetter = ringSecondLetters[linkToNextRing];

            return secondRingEncryption(nextLetter);
        }

        private string secondRingEncryption(string _letterToEncrypt)
        {
            string letterToEncrypt = _letterToEncrypt;
            int positionOfLetterInRing = Array.IndexOf(ringSecondLetters, letterToEncrypt);
            int linkToNextRing = Convert.ToInt32(ringSecondPosWires[positionOfLetterInRing]) - 1;
            string nextLetter = ringThirdLetters[linkToNextRing];

            return thirdRingEncryption(nextLetter);
        }

        private string thirdRingEncryption(string _letterToEncrypt)
        {
            string letterToEncrypt = _letterToEncrypt;
            int positionOfLetterInRing = Array.IndexOf(ringThirdLetters, letterToEncrypt);
            int linkToNextRing = Convert.ToInt32(ringThirdPosWires[positionOfLetterInRing]) - 1;
            string nextLetter = reflectorFirstLayer[linkToNextRing];

            int positionOfLetterInReflectorFirstLayer = Array.IndexOf(reflectorFirstLayer, nextLetter);
            string letterInReflectorFirstLayer = reflectorFirstLayer[positionOfLetterInReflectorFirstLayer];
            int positionOfLetterInReflectorSecondLayer = Array.IndexOf(reflectorSecondLayer, letterInReflectorFirstLayer);
            string letterInReflectorSecondLayer = reflectorFirstLayer[positionOfLetterInReflectorSecondLayer];

            //return nextLetter;
            return firstReflectorEncryption(letterInReflectorSecondLayer);
        }

        private string firstReflectorEncryption(string _letterToReflect)
        {
            string letterToReflect = _letterToReflect;
            int positionOfLetterInRing = Array.IndexOf(reflectorFirstLayer, letterToReflect);
            string wireToReflect = ringThirdPosWires[positionOfLetterInRing];
            string letterByWire = ringThirdLetters[Convert.ToInt32(wireToReflect) - 1];

            return secondReflectorEncryption(letterByWire);
        }

        private string secondReflectorEncryption(string _letterToReflect)
        {
            string letterToReflect = _letterToReflect;
            int positionOfLetterInRing = Array.IndexOf(reflectorFirstLayer, letterToReflect);
            string wireToReflect = ringSecondPosWires[positionOfLetterInRing];
            string letterByWire = ringSecondLetters[Convert.ToInt32(wireToReflect) - 1];

            return thirdReflectorEncryption(letterByWire);
        }

        private string thirdReflectorEncryption(string _letterToReflect)
        {
            string letterToReflect = _letterToReflect;
            int positionOfLetterInRing = Array.IndexOf(reflectorFirstLayer, letterToReflect);
            string wireToReflect = ringFirstPosWires[positionOfLetterInRing];
            string letterByWire = ringFirstLetters[Convert.ToInt32(wireToReflect) - 1];

            return letterByWire;
        }
    }
}
