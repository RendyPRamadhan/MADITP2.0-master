using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;  

namespace MADITP2._0.Global
{
    public class clsCryptoEngine
    {
        clsGlobal _clsGlobal = new clsGlobal();

        public static string Encrypt(string input, string key)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string input, string key)
        {
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
  
        ////Example of using this Crypto Engine
        //if(Plaintext.Text != string.Empty)  
        //{  
        //    //Here key is of 128 bit  
        //    //Key should be either of 128 bit or of 192 bit  
        //    Ciphertext.Text = CryptoEngine.Encrypt(Plaintext.Text, "sblw-3hn8-sqoy19");  
        //}    
      
        //if(Ciphertext.Text != string.Empty)  
        //{  
        //    //Key should be same for encryption and decryption  
        //    Plaintext.Text = CryptoEngine.Decrypt(Ciphertext.Text, "sblw-3hn8-sqoy19");  
        //}

        //-----------------------------------------------------------------------------//

        //encrypt password using MD5
        public void EncryptPassword(string password, string userid)
        {
            string EncryptedPassword;
            string strSQL = "";

            strSQL = "select CONVERT(VARCHAR(50), HASHBYTES('MD5', '" + password + "'), 2) as gu_password " +
                     "from GS_USER WITH(NOLOCK) " +
                     "where gu_user_id = '" + userid + "'";

            if (_clsGlobal.ExecDT(strSQL).Rows.Count > 0)
            {
                EncryptedPassword = _clsGlobal.ExecDT(strSQL).Rows[0]["gu_password"].ToString().Trim();
            }
            else
            {
                EncryptedPassword = "";
            }
        }

        //-----------------------------------------------------------------------------//

        //encrypt password to base64
        public string base64Encode(string data)
        {
            try
            {
                byte[] encData_byte = new byte[data.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(data);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Encode" + e.Message);
            }
        }

        //decrypt password from base64
        public string base64Decode(string sData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(sData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

    }
}
