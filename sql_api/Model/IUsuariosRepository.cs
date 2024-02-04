namespace sql_api.Model
{
    public interface IUsuariosRepository
    {
        void Add(Usuarios usuarios);

        List<Usuarios>GetUsuarios();    


    }
}
