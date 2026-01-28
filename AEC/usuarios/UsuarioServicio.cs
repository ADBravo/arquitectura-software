namespace Usuarios
{
    class UsuarioServicio
    {
        UsuarioDatos datos = new UsuarioDatos();

        public Usuario[] Listar()
        {
            return datos.Obtener();
        }
    }
}