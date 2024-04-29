namespace Training2
{
    internal class CoinCase
    {
        private int _500yen;
        private int _100yen;
        private int _50yen;
        private int _10yen;
        private int _5yen;
        private int _1yen;

        public void AddCoins(int kinds, int amount)
        {
            if (kinds == 500)
                _500yen += amount;
            if (kinds == 100)
                _100yen += amount;
            if (kinds == 50)
                _50yen += amount;
            if (kinds == 10)
                _10yen += amount;
            if (kinds == 5)
                _5yen += amount;
            if (kinds == 1)
                _1yen += amount;
        }

        public int GetCount(int kinds)
        {
            if (kinds == 500)
                return _500yen;
            if (kinds == 100)
                return _100yen;
            if (kinds == 50)
                return _50yen;
            if (kinds == 10)
                return _10yen;
            if (kinds == 5)
                return _5yen;
            if (kinds == 1)
                return _1yen;

            return 0;
        }

        public int GetCount()
        {
            return _500yen + _100yen + _50yen + _10yen + _5yen + _1yen;
        }

        public int GetAmount()
        {
            var answer = 0;
            return answer = 500 * _500yen + 100 * _100yen + 50 * _50yen + 10 * _10yen + 5 * _5yen + 1 * _1yen;
        }

        public int GetAmount(int kinds)
        {
            if (kinds == 500)
                return 500 * _500yen;
            if (kinds == 100)
                return 100 * _100yen;
            if (kinds == 50)
                return 50 * _50yen;
            if (kinds == 10)
                return 10 * _10yen;
            if (kinds == 5)
                return 5 * _5yen;
            if (kinds == 1)
                return 1 * _1yen;

            return 0;
        }
    }

}
