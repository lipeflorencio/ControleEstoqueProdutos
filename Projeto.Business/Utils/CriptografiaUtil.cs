using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Business.Utils
{
    public class CriptografiaUtil
    {
        //algoritmo de criptografia baseado em HASH
        public static string GetMD5( string valor )
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //converter o valor recebido para bytes..
            byte[] valorEmBytes = Encoding.UTF8.GetBytes(valor);

            //realizando a encriptação..
            byte[] resultadoEmBytes = md5.ComputeHash(valorEmBytes);

            //retornando o resultado como string..
            string saida = string.Empty;

            //percorrendo o resultado da criptografia..
            foreach ( byte item in resultadoEmBytes )
            {
                saida += item.ToString( "X2" ); //X2 -> HEXADECIMAL
            }

            return saida; //16 algarismos hexadecimais
        }
    }
}
