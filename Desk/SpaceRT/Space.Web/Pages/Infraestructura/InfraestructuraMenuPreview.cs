using AntDesign;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Space.Web.Data;
using Space.Web.Lib.Encriptar;

namespace Space.Web.Pages.Infraestructura
{
    public partial class InfraestructuraMenuPreview
    {


        private async Task Method_Principal()
        {
            try
            {

                NavigationManager.NavigateTo($"/Infraestructura", false);

            }
            catch (Exception ex)
            {

            }
        }



        private async Task Method_Tipo()
        {
            try
            {
                String key = Guid.NewGuid().ToString();

                String Keytransformado = key.Substring(0, Math.Min(17, key.Length));
                VariableStact.Key = Keytransformado;

                EncryptionService d = new EncryptionService();
                var _Encrypt = d.Encrypt("0006");

                NavigationManager.NavigateTo($"/PisoMain/{_Encrypt}", false);

            }
            catch (Exception ex)
            {

            }
        }


        private async Task Method_Dimension()
        {
            try
            {

                NavigationManager.NavigateTo($"/PisoMain/0007", false);

            }
            catch (Exception ex)
            {

            }
        }
        private async Task Method_Piso()
        {
            try
            {

                NavigationManager.NavigateTo($"/PisoMain/0009", false);

            }
            catch (Exception ex)
            {

            }
        }
    }

}
