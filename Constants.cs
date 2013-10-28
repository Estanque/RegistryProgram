using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistryProgram
{
    class Constants
    {
        public static string ERROR_MESSAGE = "Программа не зарегистрирована";
        public static string ERROR = "Ошибка";
        public static string SERIAL_NUMBER = "SerialNumber";
        public static string PATH_TO_PASS = "HKCU\\Password\\";
        public static string ROOT_CIMV2 = "root\\CIMV2";
        public static string BASEBOARD_QUERY = "SELECT * FROM Win32_BaseBoard";
        public static string DD = "DD.vbs";
        public static string HDD = "HDD.vbs";
        public static string YD = "YD.vbs";
        public static string SHOW_DEMO = "Пароль неверный. Вы будете работать в Демо режиме";
    }
}
