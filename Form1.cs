//NOTES:
//when ring spins the last letter becomes first

//TODO:
//expand uniqueTest to just bool
//ring spin
//three rings
//decryption

using System;

namespace testForEnigma
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public string[] ringFirstLetters     = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };
        public string[] ringFirstPosWires    = { "23", "11", "5" , "10", "1" , "6" , "13", "19", "8" , "4" , "3" , "9" , "26", "25", "12", "21", "18", "20", "15", "16", "24", "2" , "7" , "14", "17", "22", "27" };
        
        public string[] ringSecondLetters    = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };
        public string[] ringSecondPosWires   = { "7" , "14", "5" , "4" , "23", "20", "10", "17", "9" , "26", "13", "8" , "25", "19", "3" , "1" , "24", "6" , "18", "12", "21", "11", "16", "2" , "22", "15", "27" };

        public string[] ringThirdLetters     = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };
        public string[] ringThirdNums        = { "23", "11", "5" , "10", "1" , "6" , "13", "19", "8" , "4" , "3" , "9" , "26", "25", "12", "21", "18", "20", "15", "16", "24", "2" , "7" , "14", "17", "22", "27" };

        public string[] reflectorFirstLayer  = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };
        public string[] reflectorSecondLayer = { "A" , "B" , "C" , "D" , "E" , "F" , "G" , "H" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "Q" , "R" , "S" , "T" , "U" , "V" , "W" , "X" , "Y" , "Z" , " "  };

        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //uniqueAlert(ringFirstNums, "FIRST");
            //uniqueAlert(ringSecondNums, "SECOND");
            //uniqueAlert(ringThirdNums, "THIRD");

            string textEntered = textBox1.Text;
            string encryptedText = "";

            foreach (char letter in textEntered)
            {
                //string firstEncryption  = encryptLetter(ringFirstLetters, ringFirstPosWires, letter.ToString());
                //string secondEncryption = encryptLetter(ringFirstLetters, ringFirstPosWires, firstEncryption);
                //string thirdEncryption  = encryptLetter(ringFirstLetters, ringFirstPosWires, secondEncryption);
            }
        }

        private void encryptLetter(string[] _ringChars, string[] _ringNums, string _letterToEncrypt)
        {
            
        }

        private void nextRingEncrypt(string[] _nextRingChars, string[] _nextRingNums, string _indexOfPrevLetter)
        {
            
        }

        //for library
        private void uniqueAlert(string[] _arrayToAlert)
        {
            string[] arrayToAlert = _arrayToAlert;
            bool alert = false;
            string saveNum = "none :)";

            for (int i = 0; i < arrayToAlert.Length; i++)
            {
                for (int j = 0; j < arrayToAlert.Length; j++)
                {
                    if (arrayToAlert[i] == arrayToAlert[j])
                    {
                        alert = true;
                        saveNum = arrayToAlert[i];
                    }
                }
            }

            if (alert)
            {
                MessageBox.Show(String.Format("ALERT! \nTWO NUMBERS ARE REPETITNG! \nTHE NUMBER IS:{0}", saveNum));
            }
        }

        //for library
        private void uniqueAlert(string[] _arrayToAlert, string _nameOfArray)
        {
            string[] arrayToAlert = _arrayToAlert;
            string nameOfArray = _nameOfArray;
            bool alert = false;
            string saveNum = "none :)";

            for (int i = 0; i < arrayToAlert.Length; i++)
            {
                for (int j = 0; j < arrayToAlert.Length; j++)
                {
                    if (arrayToAlert[i] == arrayToAlert[j])
                    {
                        alert = true;
                        saveNum = arrayToAlert[i];
                    }
                }
            }

            if (alert)
            {
                MessageBox.Show(String.Format("ALERT! \nTWO NUMBERS ARE REPETITNG! \nTHE NUMBER IS:{0} \nTHE ARRAY IS:", saveNum, nameOfArray));
            }
        }
    }
}
