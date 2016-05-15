using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolFeeTrackingSystem.Forms
{
    public class mod_encryption
    {

        public static string s_encrypt(string s)
        {
            string enc="";
            char[] sTemp;
            int sLength,x,int_s;

            sLength = s.Length;
            s = " " + s + " ";
            sTemp = s.ToCharArray();

            for (x = 0; x < sLength; x++) {   
                int_s = Convert.ToInt32(sTemp[x])+x;
                int_s += int_s;
                enc += Convert.ToChar(int_s);
            }
            
            enc = enc.Substring(enc.Length -2 ,1) + enc + enc.Substring(0, 1);
            return enc;
        }


    }
}
