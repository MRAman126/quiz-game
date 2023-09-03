using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QU
{
    public partial class Form1 : Form
    {
        //quize game variables

        int correctAnswer;
       
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
     


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;

            }
           
            if(questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((Double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quize Ended!" + Environment.NewLine + 
                    "You have Answered" + score + "Question Correctly Answered. "  +
                    Environment.NewLine + "Your total Persentage is " + percentage + "%"
                    + Environment.NewLine + "Click Ok to Play again"




                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

                questionNumber++;
                askQuestion(questionNumber);




            }



        

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources.start_img;

                    lblQuestion.Text = "Are you Excited to start the game ?";

                    button1.Text = "Yes";
                    button2.Text = "No";
                    button3.Text = "Can't Wait";
                    button4.Text = "Never";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.greenland_img;

                    lblQuestion.Text = "Which is the largest island in the world?";

                    button1.Text = "Iraland";
                    button2.Text = "Andaman";
                    button3.Text = "Green land";
                    button4.Text = "Goa";
                    button5.Text = " Back";
                   

                    correctAnswer = 3;
                
                   
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.sord_img;

                    lblQuestion.Text = "What is the name of the sword owned by King Arthur?\r\n\r\n";

                    button1.Text = "Zulfikar";
                    button2.Text = "Excalibar";
                    button3.Text = "Zubida";
                    button4.Text = "Sord of Honor";
                    button5.Text = " Back";
                    
                    correctAnswer = 2;
             
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.geometry_img;

                    lblQuestion.Text = "What is the name of the sword owned by King Arthur?\r\n\r\n";

                    button1.Text = "Danial ";
                    button2.Text = "Thor";
                    button3.Text = "Ratan Sigh";
                    button4.Text = "Euclid";
                    button5.Text = " Back";
                    

                    correctAnswer = 4;
          

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.india_flag;

                    lblQuestion.Text = "Who wrote the national song of India?\r\n\r\n";

                    button1.Text = "Galif ";
                    button2.Text = "Neharu";
                    button3.Text = "Rabindranath tagore";
                    button4.Text = "Harish chandra";
                    button5.Text = " Back";
                   

                    correctAnswer = 3;
                

                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.girl_child;

                    lblQuestion.Text = "When is National Girl Child Day celebrated in India?\r\n\r\n";

                    button1.Text = "Feb 24 ";
                    button2.Text = "Jan 24";
                    button3.Text = "Sep 24";
                    button4.Text = "Agu 24";
                    button5.Text = " Back";
                   

                    correctAnswer = 2;

                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.leap_year;

                    lblQuestion.Text = " A leap year has _____ days?\r\n\r\n";

                    button1.Text = "361";
                    button2.Text = "365";
                    button3.Text = "367";
                    button4.Text = "366";
                    button5.Text = " Back";
                   

                    correctAnswer = 4;
                 

                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.india_flag;

                    lblQuestion.Text = "Taj Mahal is situated on the banks of which river?\r\n\r\n";

                    button1.Text = "Yamuna ";
                    button2.Text = "Jmuna";
                    button3.Text = "Bhagirathi";
                    button4.Text = "Ganga";
                    button5.Text = " Back";
                

                    correctAnswer = 1;
                 

                    break;
                




            }


        }

        
    }
}
