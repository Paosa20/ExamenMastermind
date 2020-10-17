using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenComponentes.Logica
{
    class logica
    {

        public logica() { }

        public string validar(string code, string codeUser){

            bool result =  false;
            result = string.Equals(code, codeUser);
            int total = 0;
            int parcial = 0; 

            if (result)
            {
                return ""; 
            }
            else
            {
                total = verificarPos(code, codeUser);
                parcial = verificarColor(code, codeUser);
            }

            string muestraTotal = total.ToString() + ","+parcial.ToString();

            return muestraTotal;
        }


        public int verificarPos(string code, string codeUser)
        {
            char[] codigo = code.ToCharArray();
            char[] codigoUsuario = codeUser.ToCharArray();
            bool result;
            int aciertoTotal = 0; 

            for(int i = 0; i < codigo.Length; i++)
            {
                    result = codigo[i].Equals(codigoUsuario[i]);

                    if (result)
                    {
                        aciertoTotal++; 
                    }
                
            }

            return aciertoTotal; 


            

            //VERIFICA MISMA POSICION
        }

        public int verificarColor(string code, string codeUser)
        {

            char[] codigo = code.ToCharArray(); 
            char[] codigoUsuario = codeUser.ToCharArray();
            bool result;
            int aciertoParcial = 0;

            string codigoV = verificarDuplicados(codigo);

            string usuarioV = verificarDuplicados(codigoUsuario);

            char[] usuarioArr = usuarioV.ToCharArray();

            for (int i = 0; i < usuarioArr.Length; i++)
            {
                result = codigoV.Contains(usuarioArr[i]);

                if (result)
                {
                    aciertoParcial++;
                }

            }

            return aciertoParcial; 
            //VERIFICA MISMOS COLORES
        }

        public string verificarDuplicados(char[] codigo)
        {
            string listaCodigo ="";

            //VERIFICA DUPLICADOS DEL CODIGO
            for (int i = 0; i<codigo.Length; i++)
            {
                
                if (listaCodigo.Contains(codigo[i]) == false)
                {
                    listaCodigo = listaCodigo + codigo[i]; 
                }
            }

         

            return listaCodigo; 
        }

       
    }
}
