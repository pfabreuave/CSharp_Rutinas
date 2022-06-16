using System.Text.RegularExpressions;
namespace projeto01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cboRutinas.SelectedIndex == 0)
            {
                Manejo_Array();
            }

            if (cboRutinas.SelectedIndex == 1)
            {
                Masa_Muscular();
            }


            if (cboRutinas.SelectedIndex == 2)
            {
                Mayor_Igual();
            }

            if (cboRutinas.SelectedIndex == 3)
            {
                Mayor_Menor();
            }

            if (cboRutinas.SelectedIndex == 4)
            {
                Promedio();
            }

            if (cboRutinas.SelectedIndex == 5)
            {
                Numeros_Primos();
            }

            if (cboRutinas.SelectedIndex == 6)
            {
                Cadena_Caracteres();
            }

            if (cboRutinas.SelectedIndex == 7)
            {
                ContarUn_Caracter();
            }

            if (cboRutinas.SelectedIndex == 8)
            {
                Distancia_Hamming();
            }

            if (cboRutinas.SelectedIndex == 9)
            {
                Contar_Palabras();
            }

            if (cboRutinas.SelectedIndex == 10)
            {
                Contar_Tipo_Caracter();
            }

        }
        
        private static void Numeros_Primos()
        {
            string Resultado = "";
            double numero = 2;
            int contador = 0;

            while(contador < 100)
            {
                if (EsNumeroPrimo(numero))
                   
                    {
                        Resultado = Resultado + "," + numero;
                        contador++;
                    }
                    numero++;
            }       
            MessageBox.Show("                Estos son los primeros cien NUMEROS PRIMOS\n "+Resultado); 
        }

        private static bool EsNumeroPrimo(double numero)
        {
            bool esPrimo = true;
            for(int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                }
            }
            return esPrimo;
        }

        private void Promedio()
        {
            int var01 = Int32.Parse(varBox01.Text);
            int var02 = Int32.Parse(varBox02.Text);
            int var03 = Int32.Parse(varBox03.Text);

            LblResultado.Text = "Promedio es : " + ((Double)(var01 + var02 + var03) / 3);
        }

        private void Mayor_Menor()
        {
            int var01 = Int32.Parse(varBox01.Text);
            int var02 = Int32.Parse(varBox02.Text);
            int var03 = Int32.Parse(varBox03.Text);

            if (var01 > var02) {
                if (var01 > var03) {
                    if (var02 > var03) {
                        LblResultado.Text = "mayor = " + var01 + " menor = " + var03;
                    }else
                    {
                        LblResultado.Text = "mayor = " + var01 + " menor = " + var02;
                    }
                }else
                {
                    LblResultado.Text = "mayor = " + var03 + " menor = " + var02;
                }
            }else
            {
               if (var01 > var03)
            {
                    LblResultado.Text = "mayor = " + var02 + " menor = " + var03;
                }else
                {
                    if (var02 > var03)
                    {
                        LblResultado.Text = "mayor = " + var02 + " menor = " + var01;
                    }
                    else
                    {
                        LblResultado.Text = "mayor = " + var03 + " menor = " + var01;
                    }
                }
            }
        }

        private void Mayor_Igual()
        {
             // rutina para calcular si es mayor o  igual a ??

              
            int edad = Int32.Parse(varBox01.Text);
            bool mayorque = edad >= 18;
            LblResultado.Text = "definitivamente  Menor";
            if (mayorque)
            {
                LblResultado.Text = "Es mayor o igual a 18";
            }
        }

        private void Masa_Muscular()
        {
            //  calculo de masa muscular

            LblResultado.Text = ("var 01 = peso; var 02 = estatura");
            double peso = Double.Parse(varBox01.Text);
            double altura = Double.Parse(varBox02.Text);
            LblResultado.Text = "IMC es :" + (peso / (altura * altura));
            
        }

        private static void Manejo_Array()
        {
            // manejo de listas y arrays

            int[] optionFuncion = new int[] { 1, 2, 3, 4, 5 };
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);
            List<List<string>> Articulos = new List<List<string>>()
            {
                new List<string>() { "pantalon", "30", "5" },
                new List<string>() { "camisa", "20", "12" },
                new List<string>() { "franela", "15", "10" },
                new List<string>() { "medias", "5", "7" }
            };

            for (int i = 0; i < Articulos.Count; i++)
            {

                for (int j = 0; j < Articulos[i].Count; j++)
                {
                    MessageBox.Show(Articulos[i][j]);
                }
            }
        }

        private void Cadena_Caracteres()
        {
            //  Invertir cadena de caracteres

            //LblResultado.Text = ("var 01 = entrada");
            string texto = varBox01.Text;
            string textoResult = " ";
            for (int i = texto.Length - 1; i >= 0; i--)
            {
                textoResult += texto[i];
            }
            LblResultado.Text = "Invertido: " + textoResult;

            // convirtiendo la cadena en array
            // hacer reverse
            // convertir array en string

            texto = varBox01.Text;
            char[] chars = texto.ToCharArray();
            Array.Reverse(chars);
            textoResult = new string(chars);
            LblResultado.Text = "Invertido: " + textoResult;
        }

        private void ContarUn_Caracter()
        {
            //  Contar un caracter dentro de un string
/*
 *          modo uno (forma imperativa)
*/
            
            string texto = varBox01.Text;
            char buscar = char.Parse(varBox02.Text);
            int textoResult = 0;
            /*
            foreach (var c in texto)
            {
                if (c == buscar)
                    textoResult++;
            }
            */

            /*
             *          modo dos (forma declarativa)
            */

            textoResult = texto.Where(c => c == buscar).Count();


            LblResultado.Text = "el caracter " + buscar + " se encuentra " + textoResult + " veces ";
           
        }

        private void Distancia_Hamming()
        {
            //  Distancia de Hamming
            /*
             *          modo uno (forma imperativa)
            */

            string cadena1 = varBox01.Text;
            string cadena2 = varBox02.Text;
           
            int textoResult = 0;

            if (cadena1.Length != cadena2.Length)
                throw new Exception("las dos cadenas de caracteres deben tener el mismo tamano");

            for (var i = 0; i < cadena1.Length; i++)
            {
                if (cadena1[i] != cadena2[i])
                    textoResult++;
            }

            LblResultado.Text = "la distancia Hamming es " + textoResult;

        }

        private void Contar_Palabras()
        {
            //  Contar cuantas palabras hay en un texto
                   

            string Texto_in = varBox01.Text;
            
            int textoResult = 0;

            Texto_in = Regex.Replace(Texto_in, @"\s+", " ").Trim();
            var palabras = Texto_in.Split(' ');
            textoResult = palabras.Length;
            

            LblResultado.Text = "el texto tiene  " + textoResult + " palabras";

        }

        private void Contar_Tipo_Caracter()
        {
            //  Contar tipos de caracter


            string Texto_in = varBox01.Text;
            string Texto_B = varBox02.Text;
            //string Texto_B = @"[0-9]"; // @"[a-zA-Z]"
            var regex = new Regex(Texto_B);
            int textoResult = regex.Matches(Texto_in).Count;

            


            LblResultado.Text = "el texto tiene  " + textoResult + " palabras " + Texto_B;

        }
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cboRutinas.Items.Add("Manejo_Array()");
            cboRutinas.Items.Add("Masa_Muscular()");
            cboRutinas.Items.Add("Mayor_Igual()");
            cboRutinas.Items.Add("Mayor_Menor()");
            cboRutinas.Items.Add("Promedio()");
            cboRutinas.Items.Add("Numeros_Primos()");
            cboRutinas.Items.Add("Cadena_Caracteres()");
            cboRutinas.Items.Add("ContarUn_Caracter()");
            cboRutinas.Items.Add("Distancia_Hamming");
            cboRutinas.Items.Add("Contar_Palabras()");
            cboRutinas.Items.Add("Contar_Tipo_Caracter()");
            LblResultado.Text = ("Elige la rutina deseada");
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CboRutinas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(""+cboRutinas.SelectedIndex);
            varBox01.Text = "";
            varBox02.Text = "";
            varBox03.Text = "";
            LblResultado.Text =("Rutina " +  cboRutinas.SelectedItem + " no requiere parametros");
            if (cboRutinas.SelectedIndex == 1)
            {
                LblResultado.Text = ("Variable01 = Peso; Variable02 = Altura");
            }


            if (cboRutinas.SelectedIndex == 2)
            {
                LblResultado.Text = ("Variable01 = Numero; (se compara con 18)");
            }

            if (cboRutinas.SelectedIndex == 3)
            {
                LblResultado.Text = ("Variable01 = Numero01; Variable02 = Numero02; Variable03 = Numero03");
            }

            if (cboRutinas.SelectedIndex == 4)
            {
                LblResultado.Text = ("Variable01 = Numero01; Variable02 = Numero02; Variable03 = Numero03");
            }

            if (cboRutinas.SelectedIndex == 6)
            {
                LblResultado.Text = ("Variable01 = String de entrada");
            }

            if (cboRutinas.SelectedIndex == 7)
            {
                LblResultado.Text = ("Variable01 = String de entrada; Variable02 = lo que queremos buscar");
            }

            if (cboRutinas.SelectedIndex == 8)
            {
                LblResultado.Text = ("Variable01 = cadena de caracteres 1; Variable02 = cadena de caracteres 2");
            }

            if (cboRutinas.SelectedIndex == 9)
            {
                LblResultado.Text = ("Variable01 = texto que sera analizado");
            }

            if (cboRutinas.SelectedIndex == 10)
            {
                LblResultado.Text = ("Variable01 = String que sera analizado; Variable02 = Criterio usar por Ej [0-9] o [a-zA-Z]");
            }

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}