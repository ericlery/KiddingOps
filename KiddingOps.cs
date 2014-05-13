using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int _randomNb1;
        int _randomNb2;
        int _selectOperation;
        int leftInt;
        int rightInt;
        int resultInt;
        int realResult;
        int _randomAdVar;

        public Form1()
        {
            InitializeComponent();
        }
        /*Nouvel objet nbGenerator
        depuis la class 'Random' du framework .NET*/
        Random nbGenerator = new Random(); // ,  

        // Attribue à chaque membre un chiffre aléatoire.
        public void StartRandom()
        {
            /*membre de gauche: Chiffre aléatoire entre 5 et 9, 
            membre de droite: Chiffre aléatoire entre 1 et (9-membre de gauche)
            
            5 car Ex: 5-(9-5=4)= 1, résultat positif approprié pour un enfant
            en dessous de 5 -> Ex: 4-(9-4=5) = -1, résultat négatif non approprié pour un enfant*/
            _randomNb1 = nbGenerator.Next(5,10); 
            _selectOperation = nbGenerator.Next(2); //Chiffre aléatoire inferieur à 2(0 ou 1)
            _randomNb2 = nbGenerator.Next(1,10-_randomNb1);//Chiffre aléatoire entre 1 et (9-_randomNb1)

            /*le Texte du membre de gauche = 
            valeure aléatoire généré > convertie en Chaine de caractère*/
            leftLabel.Text = _randomNb1.ToString(); //  

            /*Condition qui défini le type d'opération, 
            si 0 >soustraction
            si > addition*/
            if (_selectOperation == 0) // == pour une comparaison , = pour une affectation
            {
                typeOperation.Text = "-";
            }
            else
            {
                typeOperation.Text = "+";
            }
            rightLabel.Text = _randomNb2.ToString();
        }

        public void corrector()
        {
            leftInt = Convert.ToInt32(leftLabel.Text);
            rightInt = Convert.ToInt32(rightLabel.Text);
            resultInt = Convert.ToInt32(userAnswer.Text);
            realResult = resultInt;

            if(typeOperation.Text == "-")
            {
                resultInt = leftInt - rightInt;
            }
            else
            {
                resultInt = leftInt + rightInt;
            }
        }

        public void ad()
        {
            _randomAdVar = nbGenerator.Next(5);
            switch(_randomAdVar)
            {
                case 0:
                    Image ad1 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad1.jpg");
                    break;

                case 1:
                    Image ad2 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad2.jpg");
                    break;

                case 2:
                    Image ad3 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad3.jpg");
                    break;

                case 3:
                    Image ad4 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad4.jpg");
                    break;

                case 4:
                    Image ad5 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad5.jpg");
                    break;
            }

            //if(_randomAdVar == 0)
            //{
            //    Image ad1 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad1.jpg");
            //}
            //else if (_randomAdVar == 1)
            //{
            //    Image ad2 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad2.jpg");
            //}
            //else if (_randomAdVar == 2)
            //{
            //    Image ad3 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad3.jpg");
            //}
            //else if (_randomAdVar == 3)
            //{
            //    Image ad4 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad4.jpg");
            //}
            //else if (_randomAdVar == 4)
            //{
            //    Image ad5 = Image.FromFile("C:\\Users\\WINDOWS\\Pictures\\ppe\\pub\\ad5.jpg");
            //}
        }

        //public void correctorSoustraction()
        //{
        //    int a;
        //    int b;
        //    int c;

        //    a = Convert.ToInt32(leftLabel);
        //    b = Convert.ToInt32(rightLabel);
        //    c = Convert.ToInt32(userAnswer);

        //    c = a - b;
        //}
            
        // Bouton pour démarré l'exercice
        private void startOps_Click(object sender, EventArgs e)
        {
            StartRandom(); // Execute la méthode StartRandom ci-dessus
            startOps.Enabled = false;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            /*Assigne une valeur en chaine de caractère
            car le Texte du Label est une chaine de caractère.
            La convertion en entier ce fera dans une autre méthode.*/
            userAnswer.Text = "0";
            
            //if (startOps. == true)
            //{
            //    userAnswer.Text = "0"; 
            //}
            //else
            //{
            //    MessageBox.Show("Clique d'abord sur 'Commencer!'");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userAnswer.Text = "10";
        }

        private void userAnswer_Click(object sender, EventArgs e)
        {
         
        }

        public void ExitApplication()
        {
            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Do you want to exit?", "My Application",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void validButton_Click(object sender, EventArgs e)
        {
            corrector();
            startOps.Enabled = false;

            if (resultInt == realResult)
            {
                MessageBox.Show("Bravo!");
            }
            else
            {
                MessageBox.Show("Faux! Essaie encore!");
            }
            //
        }
    }
}
