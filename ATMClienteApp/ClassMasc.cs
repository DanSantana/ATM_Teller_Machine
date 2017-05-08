using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMClienteApp
{
    public class ClassMasc
    {
        string word;
        char key;
        Int32 factor = 1;
        private void removechar(char charac)
        {   //retirando caractere da string
            string[] field = word.Split(charac);
            word = Convert.ToDouble(string.Concat(field)).ToString();
        }
        private void addzero(int natural, int backspace)
        {   //acrescentado zeros a string
            while ((word.Length < natural) || ((word.Length < backspace) && (key == (char)Keys.Back)))
            {
                word = "0" + word;
            }
        }
        private void returnfactor()
        {   //compara se backspace
            if (key == (char)Keys.Back)
                factor = 3;
        }
        public void clearnumber(char simbol, int min, int max)
        {   //chama funcao para retirada de caracter e insercao de zeros
            removechar(simbol);
            addzero(min, max);
            returnfactor();
        }
        private void anyMasc(Int32 qnty, string[,] limits)
        {
            string part = "";
            Int32 cnt = 0;
            while (cnt < qnty)
            {
                part += word.Substring(Convert.ToInt32(limits[cnt, 0]), Convert.ToInt32(limits[cnt, 1])) + limits[cnt, 2];
                cnt = cnt + 1;
            }
            word = part;
        }
        public void receiveKey(char x)
        {
            key = x;
        }
        public void ReceiveWord(string y)
        {
            word = y;
        }
        public bool MascNumber(Int32 max)
        {
            if ((!char.IsNumber(key) || (word.Length >= max && Convert.ToInt32(word.Substring(0, 1)) != 0)) && (key != (char)Keys.Back))
                return true;
            else
                return false;
        }
        public string mascAmount()
        {
            string[] auxiliarField;
            word = string.Concat(auxiliarField = word.Split(','));
            clearnumber(',', 3, 15);
            string[,] parts = { { "0", "3", "," }, { "3", "3", "." }
            ,{ "3", Convert.ToString(1 * factor), "" } };
            anyMasc(3, parts);
            return word;
        }









 

    }
}
