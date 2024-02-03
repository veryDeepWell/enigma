//NOTES:
//when ring spins the last letter becomes first

//TODO:
//expand uniqueTest to just bool
//ring spin
//three rings
//decryption
//test for git )))

using System;

namespace testForEnigma
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public string[] ringFirstChars =
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " "
        };

        public string[] ringFirstNums =
        { 
            "23", "11", "5", "10", "1", "6", "13", "19", "8", "4", "3", "9", "26", "25", "12", "21", "18", "20", "15", "16", "24", "2", "7", "14", "17", "22", "27"
        };

        public string[] ringSecondChars = new string[]
        {
            "C", "T", "F", "K", "V", "W", "D", "H", "E", "I", "Y", "P", "N", "Q", "B", "U", "S", "M", "J", "A", "L", "G", "R", "Z", "X", "O", " "
        };

        public string[] ringSecondNums =
        { 
            "7", "14", "5", "4", "23", "20", "10", "17", "9", "26", "13", "8", "25", "19", "3", "1", "24", "6", "18", "12", "21", "11", "16", "2", "22", "15", "27"
        };

        public string[] ringThirdChars = new string[]
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " "
        };

        public string[] ringThirdNums =
        { 
            "23", "11", "5", "10", "1", "6", "13", "19", "8", "4", "3", "9", "26", "25", "12", "21", "18", "20", "15", "16", "24", "2", "7", "14", "17", "22", "27"
        };

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
            string[] firstEncryptPoses = new string[textEntered.Length];

            for (int i = 0; i < textEntered.Length; i++)
            {
                textBox2.Text += nextRingEncrypt(ringSecondChars, ringSecondNums, encryptLetter(ringFirstChars, ringFirstNums, textEntered[i].ToString()));
            }
        }

        private string encryptLetter(string[] _ringChars, string[] _ringNums, string _letterToEncrypt)
        {
            string letterToEncrypt = _letterToEncrypt;
            string[] ringChars = _ringChars;
            string[] ringNums = _ringNums;

            int positionOfLetterInRing = Array.IndexOf(ringChars, letterToEncrypt);
            string ringNumberByPosition = ringNums[positionOfLetterInRing];

            return ringNumberByPosition;
        }

        private string nextRingEncrypt(string[] _nextRingChars, string[] _nextRingNums, string _indexOfPrevLetter)
        {
            string indexOfPrevLetter = _indexOfPrevLetter;
            string[] nextRingChars = _nextRingChars;
            string[] nextRingNums = _nextRingNums;

            int positionOfNumberInRing = Array.IndexOf(nextRingNums, indexOfPrevLetter);
            string ringLetterByPosition = nextRingChars[positionOfNumberInRing];

            return ringLetterByPosition;
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
