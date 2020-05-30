using MemoryLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryCards
{
    public partial class FormMemory : Form, IPlayable
    {

        LogicMemory logic;

        public FormMemory()//конструктор
        {
            InitializeComponent();
            logic = new LogicMemory(this);
            //init_game();
            logic.CreateNewGame();
        }

        private void menu_game_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void munu_help_rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            @"Цель игры - открыть все карточки
            за минимальное количество ходов.

            На столе лежит 16 перевернутых карточек.
            На них изображено 8 разных картинок.
            Каждая картинка изображена дважды.
            Необходимо найти парные карточки.

            Щёлкайте по карточкам чтобы их перевернуть.
            Если пара подобрана верно - карточки остаются.
            Если ошибочно - карточки перевернутся назад.
            Запоминайте картинки на карточках,
            Чтобы в следующий раз открыть их верно. ", "Правила игры");
        }

        private void menu_help_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            @"Игровая программа 'Карточки памяти'
            создана в обучающих целях
            на практическом видеокурсе
            'Изучаем язык с C# нуля'.

            http://wwwVideoSharp.info/", "О программе");
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int nr = int.Parse (((PictureBox)sender).Tag.ToString()); //возвращает в переменной nr номер нажатой картинки
                                                                      //MessageBox.Show(nr.ToString()); -вывести диалог с номером тега картинки
            logic.ClickPicture(nr);
            //return;

        }

         private void LoadPicture (int picture, int image)
        {
            getPictureBox(picture).Image = getImage (image);
        }

        private PictureBox getPictureBox (int picture)
        {
            switch (picture)
            {
                case 0: return pictureBox0;
                case 1: return pictureBox1;
                case 2: return pictureBox2;
                case 3: return pictureBox3;
                case 4: return pictureBox4;
                case 5: return pictureBox5;
                case 6: return pictureBox6;
                case 7: return pictureBox7;
                case 8: return pictureBox8;
                case 9: return pictureBox9;
                case 10: return pictureBox10;
                case 11: return pictureBox11;
                case 12: return pictureBox12;
                case 13: return pictureBox13;
                case 14: return pictureBox14;
                case 15: return pictureBox15;
                default: return null;
            }
        }

        private Image getImage (int image)
        {
            switch (image)
            {
                case 0: return Properties.Resources._0;
                case 1: return Properties.Resources._1;
                case 2: return Properties.Resources._2;
                case 3: return Properties.Resources._3;
                case 4: return Properties.Resources._4;
                case 5: return Properties.Resources._5;
                case 6: return Properties.Resources._6;
                case 7: return Properties.Resources._7;
                case 8: return Properties.Resources._8;
                default: return null;
            }
        }

        private void menu_game_new_Click(object sender, EventArgs e)
        {
            logic.CreateNewGame();
        }

        public void ShowCard (int nr, int card) //показать картинки, в метод передается номер картинки int picture
        {
            LoadPicture(nr, card); //загрузить картинку
            getPictureBox(nr).Cursor = Cursors.Arrow;
        }

        public void HideCard (int picture)
        {
            LoadPicture(picture, 0);//показать нулевую картинку(спрятать)
            getPictureBox(picture).Cursor = Cursors.Hand;
        }

        public void ShowWinner()
        {
            MessageBox.Show("Вы победили!", "Поздравляем");
            //init_game();
        }
    }
}
