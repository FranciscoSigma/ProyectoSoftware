using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class UserModel
    {
        DatosUsuario datosUsuario = new DatosUsuario();
        public bool LoginUser(string user, string pass)
        {
            return datosUsuario.Login(user, pass);
        }
    }
}
