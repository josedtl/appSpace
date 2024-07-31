namespace Space.Web.Pages.Entidad
{
    public partial class EntidadMenuPreview
    {


        private async Task Method_PersonaNatural()
        {
            try
            {

                NavigationManager.NavigateTo($"/PersonaNatrual", false);

            }
            catch (Exception ex)
            {

            }
        }


        private async Task Method_Empresa()
        {
            try
            {

                NavigationManager.NavigateTo($"/Empresa", false);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
