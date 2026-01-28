namespace Usuarios
{
    class UsuarioDatos
    {
        public Usuario[] Obtener()
        {
            Usuario[] usuarios = new Usuario[2];

            usuarios[0] = new Usuario();
            usuarios[0].id = 1;
            usuarios[0].nombre = "Ana";

            usuarios[1] = new Usuario();
            usuarios[1].id = 2;
            usuarios[1].nombre = "Luis";

            return usuarios;
        }
    }
}