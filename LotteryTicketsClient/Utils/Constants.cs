using System;
using System.Collections.Generic;
using System.Text;

namespace LotteryTicketsClient.Utils
{
    public static class Constants
    {
        public const string MODE_ADD        = "ADD";
        public const string MODE_EDIT       = "EDIT";

        public const int MIN_CHOOSED_NUMBERS_COUNT = 6;
        public const int MAX_CHOOSED_NUMBERS_COUNT = 17;

        public const int MIN_CIRCULATION_NUMBER = 1;
        public const int MAX_CIRCULATION_NUMBER = 65535;
    }
}
