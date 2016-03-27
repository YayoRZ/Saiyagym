using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Data.SqlClient; //
using System.Data; //

namespace Saiyagym
{
    class Login
    {
        public bool admin;
        public bool regular;
        public bool acceso;
        public void Entrar()
        {
            string user;
            string pass;
            ConsoleKeyInfo key;
            int i = 6, intentos = 3;
            inicio:
            Console.Clear();
            Console.SetCursorPosition(18, i);
            Console.Write("Ingrese el usuario: ");
            user = Convert.ToString(Console.ReadLine());
            StreamReader objetolee = new StreamReader("C:\\BORRAR CARPETA\\usuarios.txt");
            string Linea = "";
            string Linea2 = "";
            ArrayList arrText = new ArrayList();
            Linea = objetolee.ReadLine();
            arrText.Add(Linea);
            Linea2 = objetolee.ReadLine();
            arrText.Add(Linea2);

            if (user == Linea || user == Linea2)
            {
                // Linea = objetolee.ReadLine();
                //arrText.Add(Linea);
                Console.SetCursorPosition(18, i + 3);
                Console.Write("Ingrese su contraseña: ");
                //Fondo y color de letra es el mismo para 'ocultar' la contraseña.
                //Console.ForegroundColor = ConsoleColor.Black;
                //pass = Convert.ToString(Console.ReadLine());
                pass = "";
                do
                {
                    key = Console.ReadKey(true);


                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                // Stops Receving Keys Once Enter is Pressed
                while (key.Key != ConsoleKey.Enter);


                StreamReader readPass = new StreamReader("C:\\BORRAR CARPETA\\passwords.txt");
                string Line = "";
                string Line2 = "";
                ArrayList contras = new ArrayList();
                Line = readPass.ReadLine();
                contras.Add(Line);
                Line2 = readPass.ReadLine();
                contras.Add(Line2);

                if (pass == Line || pass == Line2)
                {

                    if (user == Linea && pass == Line)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(25, i + 5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Autenticación válida");
                        Console.SetCursorPosition(21, i + 7);
                        Console.WriteLine("Privilegios de administrador");
                        Console.ResetColor();
                        acceso = true;
                        admin = true;
                    }
                    else if (user == Linea2 && pass == Line2)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(25, i + 5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Autenticación válida.");
                        Console.ResetColor();
                        acceso = true;
                        regular = true;
                    }
                    /*if (user == Linea2 && pass == Line2)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(25, i + 5);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Autenticación válida.");
                        Console.ResetColor();
                        acceso = true;
                        regular = true;
                    } */
                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(17, i + 5);
                        Console.ForegroundColor = ConsoleColor.Red;
                        intentos--;
                        Console.WriteLine("Contraseña errónea, le quedan {0} intentos.", intentos);
                        Console.ResetColor();
                        if (intentos > 0)
                        {
                            Console.ReadLine();
                        }

                        if (intentos > 0)
                        {
                            goto inicio;
                        }
                        else
                        {
                            Console.ResetColor();
                            acceso = false;
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(17, i + 5);
                    Console.ForegroundColor = ConsoleColor.Red;
                    intentos--;
                    Console.WriteLine("Contraseña errónea, le quedan {0} intentos.", intentos);
                    Console.ResetColor();
                    if (intentos > 0)
                    {
                        Console.ReadLine();
                    }

                    if (intentos > 0)
                    {
                        goto inicio;
                    }
                    else
                    {
                        Console.ResetColor();
                        acceso = false;
                    }

                }
            }
            else
            {
                Console.SetCursorPosition(13, i + 8);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usuario inválido, favor de volver a intentarlo.");
                Console.ResetColor();
                Console.ReadLine();
                goto inicio;
            }
            objetolee.Close();
            Console.ReadLine();
        }
    }
}