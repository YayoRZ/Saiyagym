using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Saiyagym
{
    class user1options //EL USUARIO 1 PUEDE AGREGAR, MODIFICAR, VENDER Y ELIMINAR
    {
        static int option;
        static int retorno;
        public user1options()
        {
            
            MAINMENU:

            Console.WriteLine("1. AGREGAR UN CLIENTE \n 2.ABONO MENSUAL \n 3.PUNTO DE VENTA \n 4.ELIMINAR CLIENTE");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:

                    clientfields op1 = new clientfields();
                    retorno = 0;
                    Console.WriteLine("ID");
                    op1.id_client = Convert.ToInt32(Console.ReadLine());
                    SqlCommand comando1 = new SqlCommand(string.Format("Insert into clients(id_client) values ('{0}')", op1.id_client));
                    retorno = comando1.ExecuteNonQuery();
                    goto MAINMENU;


                case 2:

                    clientfields op2 = new clientfields();
                    retorno = 0;
                    Console.WriteLine("Introduzca ID del cliente");
                    op2.id_client = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Estado");
                    op2.status = true;
                    Console.WriteLine("Avisos");
                    op2.advice = Convert.ToString(Console.ReadLine());
                    SqlCommand comando2 = new SqlCommand(string.Format("Insert into clients(id_client, status, advice) values ('{0}','{1}','{2}')",
                        op2.id_client, op2.status, op2.advice));
                    retorno = comando2.ExecuteNonQuery();
                    goto MAINMENU;


                case 3:
                    break;


                case 4:

                    clientfields op4 = new clientfields();
                    retorno = 0;
                    Console.WriteLine("ID");
                    op4.id_client = Convert.ToInt32(Console.ReadLine());
                    SqlCommand comando4 = new SqlCommand(string.Format("Delete from clients(id_client) values ('{0}')", op4.id_client));
                    retorno = comando4.ExecuteNonQuery();
                    goto MAINMENU;


                default:
                    Console.WriteLine("ERROR");
                    Console.ReadLine();
                    break;
            }
        }
    }
    class user2options
    {
        static int option;
        static int retorno;
        public user2options()
        {
            MAINMENU:

            Console.WriteLine("1. AGREGAR UN CLIENTE \n 2.ABONO MENSUAL \n 3.PUNTO DE VENTA");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:

                    clientfields op1 = new clientfields();
                    retorno = 0;
                    Console.WriteLine("ID");
                    op1.id_client = Convert.ToInt32(Console.ReadLine());
                    SqlCommand comando1 = new SqlCommand(string.Format("Insert into clients(id_client) values ('{0}')", op1.id_client));
                    retorno = comando1.ExecuteNonQuery();
                    goto MAINMENU;


                case 2:

                    clientfields op2 = new clientfields();
                    retorno = 0;
                    Console.WriteLine("Introduzca ID del cliente");
                    op2.id_client = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Estado");
                    op2.status = true;
                    Console.WriteLine("Avisos");
                    op2.advice = Convert.ToString(Console.ReadLine());
                    SqlCommand comando2 = new SqlCommand(string.Format("Insert into clients(id_client, status, advice) values ('{0}','{1}','{2}')",
                        op2.id_client, op2.status, op2.advice));
                    retorno = comando2.ExecuteNonQuery();
                    goto MAINMENU;


                case 3:
                    break;
                    
                default:
                    Console.WriteLine("ERROR");
                    Console.ReadLine();
                    break;
            }
        }
    } //EL USUARIO 2 NO PUEDE ELIMINAR
}
