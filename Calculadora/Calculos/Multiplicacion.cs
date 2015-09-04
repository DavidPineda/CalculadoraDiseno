using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Calculos
{
    public class Multiplicacion
    {

        public int Multiplicando { get; set; }
        public int Multiplicador { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Form Formulario { get; set; }
        public int _yDrawline;

        public int [,] matriz;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="multiplicando">Numero que se a  multiplicar</param>
        /// <param name="multiplicador">Numero por el cual se multiplica el multiplicando</param>
        /// <param name="form"></param>
        public Multiplicacion(int multiplicando, int multiplicador,Form form)
        {
            this.Multiplicando = multiplicando;
            this.Multiplicador = multiplicador;
            this.Formulario = form;
            this.X = (Formulario.Width - 50);
            this.Y = (110);
            this._yDrawline = 140;
            drawMultiplicando();
            drawMultiplicador();
            crearMatrizSuma(Convert.ToString(multiplicando).ToString(), Convert.ToString(multiplicador).ToString());
            //llenarMatrizCeros(matriz);
            initDrawLine();
        }


        /// <summary>
        /// Constructor
        /// </summary>
        public Multiplicacion()
        {
            Multiplicando = 0;
            Multiplicador = 0;
        }

        /// <summary>
        /// Mutiplica dos numeros
        /// </summary>
        public void multiplicacion()
        {
            string strMultiplicando = Convert.ToString(Multiplicando);
            string strMultiplicador = Convert.ToString(Multiplicador);
            //variables para pintado dinamico
            Y += 33;
            int x = X;
            int xdescuento = 10;
            int ydescuento = 0;
            int xretornoCarro = xdescuento;
            //variables para pintado dinamico

            //variables para llenado matriz
            int fmatriz = 0;
            int cmatriz = 0;
            int xmatrizdescuentoPos = 0;
            //varialbles para llenado matriz
            int suma = 0;
            for (int i = strMultiplicador.Length - 1; i >= 0; i--)
            {
                cmatriz = ((matriz.GetLength(1)-1) - xmatrizdescuentoPos);
                    for (int j = strMultiplicando.Length - 1; j >= 0; j--)
                    {
                        string[] resultado = multiplicar(int.Parse(strMultiplicando[j].ToString()), int.Parse(strMultiplicador[i].ToString()));
                        if (resultado != null)
                        {
                            if (resultado.Length > 1)
                            {
                                if (suma == 0)
                                {
                                    addControlsForm(addPointControl(construirLabel(resultado[0].ToString(), Color.Black), x - xdescuento, Y + ydescuento));
                                    //addControlsForm(addPointControl(construirLabel(resultado[1].ToString(), Color.Black), x - xdescuento, (Y -12)));
                                    suma = int.Parse(resultado[1].ToString());
                                    matriz[fmatriz,cmatriz] = int.Parse(resultado[0].ToString());
                                }
                                else
                                {
                                    resultado = multiplicar(int.Parse(resultado[1].ToString() + resultado[0].ToString()) + suma, 1);
                                    addControlsForm(addPointControl(construirLabel(resultado[0].ToString(), Color.Black), x - xdescuento, Y + ydescuento));
                                    matriz[fmatriz,cmatriz] = int.Parse(resultado[0].ToString());
                                    if (resultado.Length > 1) suma = int.Parse(resultado[1].ToString());
                                    if (j == 0)
                                    {
                                        addControlsForm(addPointControl(construirLabel(Convert.ToString(suma).ToString(), Color.Black), x - (xdescuento + 10), Y + ydescuento));
                                        matriz[fmatriz, cmatriz] = int.Parse(Convert.ToString(suma).ToString());
                                        suma = 0;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if (j == 0)
                                {
                                        if (suma == 0){
                                            matriz[fmatriz,cmatriz] = int.Parse(resultado[0].ToString());
                                            addControlsForm(addPointControl(construirLabel(Convert.ToString(int.Parse(resultado[0].ToString())).ToString(), Color.Black), x - (xdescuento ), Y + ydescuento)); 
                                        }else{
                                            if (resultado[0].ToString().Length == 1){
                                                matriz[fmatriz, cmatriz] = int.Parse(Convert.ToString(suma + int.Parse(resultado[0].ToString())).ToString());
                                                addControlsForm(addPointControl(construirLabel(Convert.ToString(suma + int.Parse(resultado[0].ToString())).ToString(), Color.Black), x - (xdescuento), Y + ydescuento));        
                                            }
                                            else{
                                                matriz[fmatriz, cmatriz] = int.Parse(Convert.ToString(suma + int.Parse(resultado[0].ToString())).ToString());
                                                addControlsForm(addPointControl(construirLabel(Convert.ToString(suma + int.Parse(resultado[0].ToString())).ToString(), Color.Black), x - (xdescuento + 10), Y + ydescuento)); 
                                            }
                                         }
                                    suma = 0;
                                    break;
                                }
                                else
                                {
                                    if (suma == 0)
                                    {
                                        addControlsForm(addPointControl(construirLabel(resultado[0].ToString(), Color.Black), x - xdescuento, Y + ydescuento));
                                        matriz[fmatriz,cmatriz] = int.Parse(resultado[0].ToString());
                                    }
                                    else
                                    {
                                        resultado = multiplicar(int.Parse(resultado[0].ToString()) + suma, 1);
                                        addControlsForm(addPointControl(construirLabel(resultado[0].ToString(), Color.Black), x - xdescuento, Y + ydescuento));
                                        //addControlsForm(addPointControl(construirLabel(resultado[1].ToString(), Color.Black), x - xdescuento, (Y -12)));
                                        matriz[fmatriz,cmatriz] = int.Parse(resultado[0].ToString());
                                        if (resultado.Length > 1) 
                                            suma = int.Parse(resultado[1].ToString());
                                        else
                                            suma = 0;
                                    }               
                                }
                            }
                            xdescuento += 10; 
                            cmatriz -=1;
                        }
                    }
                ydescuento += 12;
                x = X - xretornoCarro;
                xdescuento = 10;
                xretornoCarro += 10;
                //
                xmatrizdescuentoPos += 1;
                fmatriz += 1;
            }
            _yDrawline +=(ydescuento +12);
            initDrawLine();
            pintarMatriz();
            //actualizar Y con el ultimo valor para determinar donde pintar la suma
            Y = Y + ydescuento;
            sumarMatriz();
        }

        /// <summary>
        /// Comprueba el valor a retornar de la multiplicacion individual
        /// </summary>
        /// <param name="multiplicando">Multiplicando de la operacion</param>
        /// <param name="multiplicador">Multiplicador de la operacion</param>
        /// <returns>Retorna la cantidad de terminso que genero la division</returns>
        private string[] multiplicar(int multiplicando, int multiplicador)
        {
            string res = string.Empty;
            try
            {
                res = Convert.ToString(multiplicando * multiplicador);
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }
            switch (res.Length)
            {
                case 1:
                    return new string[] { res.Substring(0, 1) };
                case 2:
                    return new string[] { res.Substring(1, 1), res.Substring(0, 1) };
                default:
                    return null;
            }
        }

        /// <summary>
        /// Construir un objeto Label con el numero a dibujar en el form
        /// </summary>
        /// <param name="obje">Numero individual que se va a dibujar en el form</param>
        /// <param name="color">Color con el cual se va a dibujar el objeto</param>
        /// <returns>Object Label</returns>
        private Label construirLabel(string obje, Color color) {
            Label label = new Label();
            label.Text = obje;
            label.Visible = true;
            label.ForeColor = color;
            //label.Width = 9;
            label.Height = 11;
            return label;
        }

        /// <summary>
        /// Actualizar el formulario con el objeto Label creado
        /// </summary>
        /// <param name="obj">Objeto Label a mostrar en el formulario</param>
        private void addControlsForm(Label obj)
        {
            Formulario.Controls.Add(obj);
            Formulario.Update();
        }

        /// <summary>
        /// Adiciona a un objeto label la ubicacion donde sera dibujado
        /// </summary>
        /// <param name="label">Objeto Label para agregar caracteristicas de localizacion</param>
        /// <param name="x">Posicion en el eje x donde se ubicara el objeto label</param>
        /// <param name="y">Posiocion en el eje y donde se ubicara el objeto label</param>
        /// <returns>Object Label</returns>
        private Label addPointControl(Label label,int x , int y){
            label.Location = new Point(x,y);
            return label;
        }

        /// <summary>
        /// Inicializar el evento PainEventHandler para dibujar lineas.
        /// </summary>
        private void initDrawLine()
        {
            Formulario.Paint += new System.Windows.Forms.PaintEventHandler(drawline);
        }
        
        /// <summary>
        /// Dibujar la linea horizontal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawline(object sender, System.Windows.Forms.PaintEventArgs e)
        {
           Graphics g =  Formulario.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);
            g.DrawLine(p, new Point(10, _yDrawline), new Point((Formulario.Width - 20), _yDrawline));
        }

        /// <summary>
        /// Dibuja el multiplicando
        /// </summary>
        private void drawMultiplicando()
        {
            int xdescuento = 10;
            string strMultiplicando = Convert.ToString(Multiplicando);
            for (int i = strMultiplicando.Length - 1; i >= 0; i--)
            {
                addControlsForm(addPointControl(construirLabel(strMultiplicando[i].ToString(), Color.Black), (X - xdescuento), Y));
                xdescuento += 10;
            }
        }

        /// <summary>
        /// Dibuja el multiplicador
        /// </summary>
        private void drawMultiplicador()
        {
            int xdescuento = 10;
            string strMultiplicador = Convert.ToString(Multiplicador);
            for (int i = strMultiplicador.Length - 1; i >= 0; i--)
            {
                addControlsForm(addPointControl(construirLabel(strMultiplicador[i].ToString(), Color.DarkBlue), (X - xdescuento), Y + 12));
                xdescuento += 10;
            }
            addControlsForm(addPointControl(construirLabel("x", Color.DarkBlue), (X - (xdescuento + 10)), Y + 12));
        }

        /// <summary>
        /// Crea una matriz basado el numero con mayor numero de caracateres
        /// </summary>
        /// <param name="multiplicando">Numero a multiplicar</param>
        /// <param name="multiplicador">Numero multiplicador</param>
        private void crearMatrizSuma(string multiplicando, string multiplicador)
        {
            if (multiplicando.Length >= multiplicador.Length)
                matriz = new int[multiplicador.Length , ((multiplicando.Length - 1) * 2) + 2];
            else
                matriz = new int[multiplicador.Length , ((multiplicador.Length - 1) * 2) + 2];
        }

        private void pintarMatriz()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " "); //Escribe en una sola linea
                }
                Console.WriteLine(); //Genera el salto de linea
            } 
        }

        private void sumarMatriz()
        {
            //variables para pintar dinamicamente en el form
            int xdescuento = 10;
            Y += 12; 
            //variables para recorrer la matriz y hacer la sumatorias
            int faux = 0;
            int sumaTotalc = 0;
            int suma = 0;
            if (matriz != null)
            {
                for (int c = matriz.GetLength(1) -1; c > 0; c--)
                {
                    for (int f = 0; f <= faux; f++)
                    {
                        if (f < matriz.GetLength(0) )
                        {
                            sumaTotalc += int.Parse(matriz[f,c].ToString());
                        }     
                    } 
                    faux += 1;
                    if(suma > 0 ){
                         sumaTotalc += suma;
                         suma = 0;
                    }

                    if (Convert.ToString(sumaTotalc).ToString().Length > 1 ){
                        suma = int.Parse(Convert.ToString(sumaTotalc).Substring(0,1));
                        addControlsForm(addPointControl(construirLabel(Convert.ToString(sumaTotalc).Substring(1,1), Color.Black), X - xdescuento, Y));
                    }else{
                        addControlsForm(addPointControl(construirLabel(Convert.ToString(sumaTotalc).Substring(0, 1), Color.Black), X - xdescuento, Y));
                    }
                    sumaTotalc = 0;
                    xdescuento += 10;
                }
            }
        }

    }
}