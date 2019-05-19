using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Result
        {
            public double Result1, Result2, Result3, Result4, Result5;

            public void sumResult(double first, double second, double third, double fourth, double fifth)
            {
                Result1 += first;
                Result2 += second;
                Result3 += third;
                Result4 += fourth;
                Result5 += fifth;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            res.Result1 = 0;
            res.Result2 = 0;
            res.Result3 = 0;
            res.Result4 = 0;
            res.Result5 = 0;

            //1 вопрос
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked)
                {
                   double  selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0, 0, 0, 0); //природ.ресурсы
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 1, 0, 0, 0);//энергетики
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0, 0, 1, 0, 0);//ядерные
                    if (selectedRadioButtonTabIndex == 4)
                        res.sumResult(0, 0, 0, 1, 0);//программисты/роботы
                    if (selectedRadioButtonTabIndex == 5)
                        res.sumResult(0, 0, 0, 0, 1);//производство/инновации
                    break;
                }
            }

            //2 вопрос
            foreach (RadioButton rb in groupBox2.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 1, 1, 1, 1);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 0, 0, 0, 0);
                    break;
                }
            }
            
            //3 вопрос
            foreach (RadioButton rb in groupBox3.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 1, 0, 0, 1);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 0, 0, 0, 0);
                    break;
                }
            }

            //4 вопрос
            foreach (RadioButton rb in groupBox4.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0, 1, 1, 0);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 1, 0, 0, 1);
                    break;
                }
            }

            //5 вопрос
            foreach (RadioButton rb in groupBox5.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0, 0, 0, 1, 1);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(1, 1, 1, 0, 0);
                    break;
                }
            }

            //6 вопрос
            foreach (RadioButton rb in groupBox6.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0.5, 1, 0, 1);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 0.5, 0, 1, 0);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0.5, 0, 0.5, 0, 0);
                    break;
                }
            }

            //7 вопрос
            foreach (RadioButton rb in groupBox7.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0.5, 1, 0, 0);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 0, 0, 1, 0);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0.5, 0, 0.5, 0, 0.5);
                    break;
                }
            }

            //8 вопрос 
            foreach (RadioButton rb in groupBox8.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0, 0, 0, 1);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 1, 1, 1, 0);
                    break;
                }
            }

            //9 вопрос 
            foreach (RadioButton rb in groupBox9.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0, 0, 1, 0.5, 1);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(1, 1, 0, 0.5, 0);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0.5, 0, 0, 0.5, 0);
                    break;
                }
            }
           
            //10 вопрос 
            foreach (RadioButton rb in groupBox10.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.4, 0.1, 0.3, 0.8, 0.9);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.6, 0.9, 0.7, 0.2, 0.1);
                    break;
                }
            }

            //11 вопрос 
            foreach (RadioButton rb in groupBox11.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.7, 0, 0.6, 1, 0.8);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.3, 0, 0.4, 0, 0.2);
                    break;
                }
            }

            //12 вопрос 
            foreach (RadioButton rb in groupBox12.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.8, 1, 1, 0.5, 0.9);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.7, 0.7, 0.2, 0.8, 0.3);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0.5, 0.5, 0.2, 1, 0.3);
                    break;
                }
            }

            //13 вопрос 
            foreach (RadioButton rb in groupBox13.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.7, 0, 0, 0.9, 0);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.5, 0.2, 0.9, 0.2, 0.3);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(1, 0.7, 0.4, 0.1, 0.4);
                    if (selectedRadioButtonTabIndex == 4)
                        res.sumResult(1, 0.8, 1, 0.7, 1);
                    break;
                }
            }

            //14 вопрос 
            foreach (RadioButton rb in groupBox14.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.3, 0.5, 0.1, 0.5, 0.9);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.7, 0.5, 0.9, 0.5, 0.1);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0.2, 0.3, 0.3, 0, 0);
                    break;
                }
            }

            //15 вопрос 
            foreach (RadioButton rb in groupBox15.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.6, 0.2, 0.8, 0.8, 0.9);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.4, 0.8, 0.2, 0.2, 0.1);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0.5, 0.5, 0.4, 0.4, 0.5);
                    break;
                }
            }

            //16 вопрос 
            foreach (RadioButton rb in groupBox16.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0.5, 0, 0, 0.8);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 0.5, 1, 1, 0.2);
                    break;
                }
            }

            //17 вопрос 
            foreach (RadioButton rb in groupBox17.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.8, 0, 0, 1, 0);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.2, 1, 1, 0, 1);
                    break;
                }
            }

            //18 вопрос 
            foreach (RadioButton rb in groupBox18.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0, 1, 1, 1, 0);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(1, 0, 0, 0, 1);
                    break;
                }
            }

            //19 вопрос 
            foreach (RadioButton rb in groupBox19.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0, 1, 1, 1, 0);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(1, 0, 0, 0, 1);
                    break;
                }
            }

            //20 вопрос 
            foreach (RadioButton rb in groupBox20.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.7, 0.3, 0.9, 1, 0.6);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.3, 0.7, 0.1, 0, 0.4);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0.5, 0.4, 0.4, 0.5, 0.5);
                    break;
                }
            }

            //21 вопрос 
            foreach (RadioButton rb in groupBox21.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0.4, 0.6, 0.3, 0.7, 0.7);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0.6, 0.6, 0.5, 0.9, 0.8);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(0.8, 0.8, 0.8, 1, 1);
                    if (selectedRadioButtonTabIndex == 4)
                        res.sumResult(1, 1, 1, 1, 1);
                    break;
                }
            }

            //22 вопрос 
            foreach (RadioButton rb in groupBox22.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0.5, 0, 0.3, 0.2);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 0.5, 1, 0.7, 0.8);
                    break;
                }
            }

            //23 вопрос 
            foreach (RadioButton rb in groupBox23.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(0, 0, 1, 0.7, 0.6);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(1, 1, 0, 0.3, 0.4);
                    break;
                }
            }

            //24 вопрос 
            foreach (RadioButton rb in groupBox24.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0.2, 0.1, 1, 0.2);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(1, 0.4, 0.3, 1, 0.4);
                    if (selectedRadioButtonTabIndex == 3)
                        res.sumResult(1, 0.5, 0.7, 1, 0.6);
                    if (selectedRadioButtonTabIndex == 4)
                        res.sumResult(0.8, 0.9, 1, 1, 0.9);
                    break;
                }
            }

            //25 вопрос 
            foreach (RadioButton rb in groupBox25.Controls)
            {
                if (rb.Checked)
                {
                    double selectedRadioButtonTabIndex = Convert.ToDouble(rb.TabIndex);
                    if (selectedRadioButtonTabIndex == 1)
                        res.sumResult(1, 0, 1, 0, 1);
                    if (selectedRadioButtonTabIndex == 2)
                        res.sumResult(0, 1, 0, 1, 0);
                    break;
                }
            }

            //подсчет результатов
            double[] finalResult = new double[] { res.Result1, res.Result2, res.Result3, res.Result4, res.Result5 };
            double MAX = 0;
            int prof = 0;
            for (int i = 0; i < finalResult.Length; i++)
            {
                if (finalResult[i] > MAX)
                {
                    MAX = finalResult[i];
                    prof = i;
                }
            }

            if (res.Result1 == 0 & res.Result2 == 0 & res.Result3 == 0 & res.Result4 == 0 & res.Result5 == 0)
            {
                
                 MessageBox.Show("Вы не ответили на вопросы", "ОШИБКА"); ;
            }

            //Вывод возможных работодателей
            else if (prof == 0)
            {
                MessageBox.Show("ПАО Сибур\nПАО Газпром\nSchlumberger ", "Добыча нефти");
            }
            else if(prof == 1)
            {
                MessageBox.Show("ОАО Системный оператор ЕЭС\nРАО ЭС Востока", "Энергетика");
            }
            else if(prof == 2)
            {
                MessageBox.Show("ГК Росатом\nГК Роскосмос", "Ядерные технологии");
            }
            else if(prof == 3)
            {
                MessageBox.Show("SoftLine Academy\nKDV\nMicrosoft\nЦНИИИ РТК", "Информационные технологии");
            }
            else if(prof == 4)
            {
                MessageBox.Show("СИБУР\nРКК Энергия\nРоснано\nSchlumberger", "Производство");
            } 
        }
    }
}
