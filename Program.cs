using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Saiyagym
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
                        Login ob = new Login();
                        ob.Entrar();

                        if (ob.acceso == true)
                        {
                            if (ob.admin == true)
                            {
                                Console.Clear();
                                SqlConnection conexion = new SqlConnection();

                                try
                                {

                                    conexion.ConnectionString = "Server = 127.0.0.1; Database=gym; User id=root; Pwd=;";
                                    conexion.Open(); //Se abre conexion a la base de datos

                                    Console.WriteLine("Conexión realizada con exito.");
                                    Console.Write("Estado: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(conexion.State + "\n");

                        Console.WriteLine("ADMIN");

                        // SWITCH DE LAS POSIBLES ACCIONES //


                        user1options U1 = new user1options();

                        ////////////////////////////////////

                                    Console.ReadLine();
                                    conexion.Close();
                                }
                                catch (SqlException ex)
                                {
                                    Console.Write("Error: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(ex.Message + "\n");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                }
                            }
                            if (ob.regular == true)
                            {
                                Console.Clear();
                                SqlConnection conexion = new SqlConnection();

                                try
                                {

                                    conexion.ConnectionString = "Server = 127.0.0.1; Database=gym; User id=root; Pwd=;";
                                    conexion.Open(); //Se abre conexion a la base de datos

                                    Console.WriteLine("Conexión realizada con exito.");
                                    Console.Write("Estado: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(conexion.State + "\n");


                        // SWITCH DE LAS POSIBLES ACCIONES //


                        user2options U2 = new user2options();

                        ////////////////////////////////////


                        Console.ReadLine();
                                    conexion.Close();
                                }
                                catch (SqlException ex)
                                {
                                    Console.Write("Error: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write(ex.Message + "\n");
                                    Console.ResetColor();
                                    Console.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition(28, 11);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ACCESO DENEGADO");
                            Console.ReadLine();
                        }


        }
    }
}