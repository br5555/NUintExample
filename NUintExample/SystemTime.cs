﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUintExample
{
    public class SystemTime
    {
        private static DateTime _date;

        public static void Set(DateTime custom)
        {
            _date = custom;
        }

        public static void Reset()
        {
            _date = DateTime.MinValue;
        }

        public static DateTime Now
        {
            get
            {
                if(_date != DateTime.MinValue)
                {
                    return _date;
                }

                return DateTime.Now;
            }
        }
    }
}
