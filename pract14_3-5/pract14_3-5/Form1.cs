using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pract14_3_5
{
    public partial class Form1 : Form
    {
        private bool CheckN(string N)
        {
           
                if (!int.TryParse(N, out int result)) {
                    MessageBox.Show("Число N не является числом");
                    return false;
                }
                else
                {
                if (result <= 1)
                {
                    MessageBox.Show("Число N должно быть больше одного");
                    return false;
                }
                else
                    return true;
                }

            
        }
        private bool CheckFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                if (sr.ReadToEnd().Length != 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Файл пуст");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Такого файла не существует");
                return false;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        Queue<int> numbers = new Queue<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            if(addOrExportButton.Text =="Добавить значения")
            {
                if (CheckN(numberNTextBox.Text) == true)
                {
                    int N = int.Parse(numberNTextBox.Text);
                    for(int i = 1; i <= N; i++)
                    {
                        numbers.Enqueue(i);
                        numbersListBox.Items.Add(i);
                    }
                    addOrExportButton.Text = "Извлечь из очереди";
                    MessageBox.Show($"Очередь чисел от 1 до {N}");
                }
            }
            else
            {
                while (numbersListBox.Items.Count != 0)
                {
                    numbers.Dequeue();
                    numbersListBox.Items.RemoveAt(0);
                    
                }
            }
        }

        private void showPeopleButton_Click(object sender, EventArgs e)
        {
            if (CheckFile(pathToFileTextBox.Text))
            {
                Queue<string> peoples = new Queue<string>();
                StreamReader sr = File.OpenText(pathToFileTextBox.Text);
                while (!sr.EndOfStream)
                {
                    string[] array = sr.ReadLine().Split(' ');
                    if (int.Parse(array[3]) < 40)
                        peoples.Enqueue(String.Join(" ", array));

                }
                sr = File.OpenText(pathToFileTextBox.Text);
                while (!sr.EndOfStream)
                {
                    string people = sr.ReadLine();
                    if (!peoples.Contains(people))
                        peoples.Enqueue(people);
                }
                listOfPeopleListBox.Items.Clear();
                while (peoples.Count != 0)
                {
                    listOfPeopleListBox.Items.Add(peoples.Dequeue());
                }
            }
        }

        private void sortAndShowTextBox_Click(object sender, EventArgs e)
        {
            if (CheckFile(pathTextBox.Text))
            {
                int r = 0;
                Queue<string> people = new Queue<string>();
                StreamReader sr = File.OpenText(pathTextBox.Text);
                while (!sr.EndOfStream)
                {
                    sr.ReadLine();
                    r++;
                }
                string[,] array = new string[r, 5];
                sr = File.OpenText(pathTextBox.Text);
                int k = 0;
                while (!sr.EndOfStream)
                {
                    string[] peoples = sr.ReadLine().Split(' ');
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[k, j] = peoples[j];
                    }
                    k++;
                }
                int index = 0;
                int w = 0;
                while (w < r)
                {

                    string person = string.Empty;
                    int age = 0;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        
                        if (int.Parse(array[i, 3]) > age)
                        {
                            age = int.Parse(array[i, 3]);
                            index = i;
                        }

                    }
                    for(int i = 0; i < 5; i++)
                    {
                        person = person + $" {array[index, i]}";
                    }
                    sortedPeopleTextBox.Items.Add(person);
                    array[index, 3] = "-4";
                    w++;
                }
            }
        }
    }
}
