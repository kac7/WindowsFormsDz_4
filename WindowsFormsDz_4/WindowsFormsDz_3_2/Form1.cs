using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDz_3_2
{
    //Написать программу «Проводник»
    //■■ При первом запуске программа отображает список доступных дисков;
    //■■ Программа должна содержать дерево дисков, строку адреса, меню, панель инструментов и окно 
    //для отображения содержимого папки;
    //■■ Дерево дисков отображает только диски и папки(можно реализовать с помощью ListBox);
    //■■ При двойном щелчке по папке – окно содержимого отображаются файлы и подпапки;
    //■■ Программа должна иметь развернутое меню, контекстное меню и возможность работы с горячими клавишами.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
