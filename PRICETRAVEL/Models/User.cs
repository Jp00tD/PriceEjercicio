namespace PRICETRAVEL.Models
{
    public class User
    {
        public int idUsuario { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string rol { get; set; }

        public static List<User> DB()
        {
            var list = new List<User>()
            {
                new User
                {
                    idUsuario = 1,
                    username = "admin",
                    password = "fldsmdfr",
                    rol = "Administrador"


                },
                new User
                {
                    idUsuario = 2,
                    username = "Joaquin",
                    password = "fldsmdfr2",
                    rol = "Empleado"


                }
            };

            return list;
        }
    }
}
