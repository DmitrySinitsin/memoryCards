using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryLibrary
{
    public class LogicMemory
    {
        IPlayable play;
        static Random rand = new Random();
        int[] cards = new int[16];
        bool[] opens = new bool[16];//булевский массив какие карточки уже открыты
        int done;//сколько картинок открыто
        int status = 0;//выбор типа действия программы в соответствии с блок-схемой
        int card_a;// первая из открываемых в процессе игры карточек
        int card_b;// вторая из открываемых в игре карточек


        public LogicMemory(IPlayable play)
        {
            this.play = play;
        }
        public void CreateNewGame()
        {
            /*for (int j = 0; j < 16; j++)
                play.ShowCard(j, j / 2 + 1);
                    //play.HideCard(j);*/
            for (int j = 0; j < cards.Length; j++)
                cards[j] = j % (cards.Length / 2) + 1;//создаем картинки
            for (int j = 0; j < 100; j++)
                shuffle_cards();// перемешиваем картинки
            /*for (int j = 0; j < cards.Length; j++)
                load_picture(j, 0);//загружаем и спрятать все картинки через 0*/
            for (int j = 0; j < cards.Length; j++)
                play.HideCard(j);// спрятать все картинки методом hide
            for (int j = 0; j < cards.Length; j++)
                opens[j] = false;//все картинки массива opens с значением false то есть закрыты
            done = 0;//открыто ноль картинок
            status = 0;

        }

        public void ClickPicture(int nr)
        {
            /*play.ShowCard(nr, nr / 2 + 1);
            if (nr == 15)
                play.ShowWinner();*/
            if (opens[nr]) return;
            switch (status)
            {
                case 0: status_0(nr); break;
                case 1: status_1(nr); break;
                case 2: status_2(nr); break;
                case 3: status_3(nr); break;
            }

        }

        private void shuffle_cards()
        {
            int a = rand.Next(0, cards.Length);
            int b = rand.Next(0, cards.Length);
            if (a == b) return;
            int x;
            x = cards[a];
            cards[a] = cards[b];
            cards[b] = x;
        }
        private void open(int picture)//метод открывает картинку и запрещает её закрытие
        {
            opens[picture] = true;//картинка массива opens с номером picture true (открыта)
            play.ShowCard(picture, cards[picture]);// метод show для номера picture - показать картинку
        }

        private void status_0(int nr)
        {
            card_a = nr;//какая была первая нажатая картинка
            play.ShowCard(card_a, cards[card_a]);//показать кликнутую картинку
            status = 1;//изменить статус с 0 на 1
        }

        private void status_1(int nr)
        {
            card_b = nr;//какая была вторая нажатая картинка
            if (card_a == card_b)//если карточки одинаковы
                return;//выйти из
            play.ShowCard(card_b, cards[card_b]);
            status = 2;
            if (cards[card_a] == cards[card_b])
            {
                open(card_a);//открываем карточку а
                open(card_b);//открываем карточку б
                done += 2;// количество открытых карточек увеличить на 2
                if (done == 16)//если счетчик равен 16 то есть открыты все карточки
                    play.ShowWinner();// вызвать метод поздравления с победой
                else
                    status = 0;
            }
            else
                status = 3;
        }

        private void status_2(int nr)
        {
            status = 0;
        }

        private void status_3(int nr)
        {
            play.HideCard(card_a);
            play.HideCard(card_b);
            status_0(nr);
        }

    }
}
