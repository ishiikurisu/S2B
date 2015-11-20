using System;

namespace JogoDaVelha
{
    class TicTacToe
    {
        public string[,] Board { get; private set; }
        public bool Player { get; private set; }

        public TicTacToe()
        {
            Board = new string[3, 3];
            Player = false;

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 3; ++j)
                    Board[i, j] = null;
        }

        public void SetPlace(string player, int x, int y)
        {
            Board[x, y] = player;
        }

        public bool GetWinner()
        {
            return !Player;
        }

        public void NextPlayer()
        {
            Player = GetWinner();
        }

        public bool IsFinished()
        {
            bool answer = false;
            
            answer = answer || CheckRows();
            answer = answer || CheckColumns();
            answer = answer || CheckDiagonals();

            return answer;
        }

        private bool CheckDiagonals()
        /* a arte da gambiarra */
        {
            bool flag = true;
            int i;

            /* main diagonal */
            // check errors
            do
            {
                flag = true;
                for (i = 0; i < 3 && flag; ++i)
                    if (Board[i, i] == null)
                        flag = false;
                if (!flag)
                    break;

                // check diagonal
                flag = true;
                for (i = 1; i < 3 && flag; ++i)
                    flag = Board[i, i].Equals(Board[i - 1, i - 1]);
                if (flag)
                    return true;
            } while (false);

            /* inverted diagonal */
            // check errors
            do
            {
                flag = true;
                for (i = 0; i < 3 && flag; ++i)
                    if (Board[i, 2 - i] == null)
                        flag = false;
                if (!flag)
                    break;

                // check diagonal
                flag = true;
                for (i = 1; i < 3 && flag; ++i)
                    flag = Board[i - 1, 3 - i].Equals(Board[i, 2 - i]);
                if (flag)
                    return true;

                // [0, 2] == [1, 1], i = 1
                // [flag1, 1] == [2, 0], i = 2
            } while (false);


            return false;
        }

        private bool CheckColumns()
        {
            bool result = false;
            int i, j;

            for (j = 0; j < 3 && !result; ++j)
            {
                /* check errors */
                bool flag = true;
                for (i = 0; i < 3 && flag; ++i)
                    if (Board[i, j] == null)
                        flag = false;
                if (!flag)
                    continue;

                /* check column */
                flag = true;
                for (i = 1; i < 3 && flag; ++i)
                    flag = Board[i, j].Equals(Board[i-1, j]);
                result = flag;
            }

            return result;
        }

        private bool CheckRows()
        {
            bool result = false;
            int i, j;

            for (i = 0; i < 3 && !result; ++i)
            {
                /* check errors */
                bool flag = true;
                for (j = 0; j < 3 && flag; ++j)
                    if (Board[i, j] == null)
                        flag = false;
                if (!flag)
                    continue;

                /* check row */
                flag = true;
                for (j = 1; j < 3 && flag; ++j)
                    flag = Board[i, j].Equals(Board[i, j - 1]);
                result = flag;
            }

            return result;
        }
    }
}

