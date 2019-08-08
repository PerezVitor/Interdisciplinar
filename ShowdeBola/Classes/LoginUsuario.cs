using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowdeBola
{
    class LoginUsuario
    {
        static string usuario;
        static string senha;
        static int id;
        static int idReserva;

        public static void login(string usuario1, string senha1, int id1)
        {
            usuario = usuario1;
            senha = senha1;
            id = id1;
        }

        public static void logout()
        {
            usuario = null;
            senha = null;
        }

        public static string getUsuarioLogado()
        {
            return "Usuário: " + usuario;
        }

        public static int getUsuarioId()
        {
            return id;
        }

        public static void reserva(int id1)
        {
            idReserva = id1;
        }

        public static int getReserva()
        {
            return idReserva;
        }
    }
}
