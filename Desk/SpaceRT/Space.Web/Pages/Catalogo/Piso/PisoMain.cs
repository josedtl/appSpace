using Microsoft.AspNetCore.Components;
using Space.ServiceConsumer;

namespace Space.Web.Pages.Catalogo.Piso
{
    public partial class PisoMain
    {

        Boolean _loading = true;
        String _Titulo = String.Empty;
        [Parameter]
        public String MiVariable { get; set; }
        List<InfraListaMainModel> lst_InfraLista = new List<InfraListaMainModel>();
        protected override async Task OnInitializedAsync()
        {
            try
            {
                _loading = true;

                await EventMethod_LoadData();

                _loading = false;
            }
            catch (Exception ex)
            {
            }
        }
        private async Task EventMethod_LoadData()
        {
            try
            {
                EncryptionService d = new EncryptionService();
                var _Decrypt = d.Decrypt(MiVariable);


                var TituloItem = await ServiceConsumer.Service.GeneralService.GetInfraCampoTitulo(_Decrypt);
                _Titulo = TituloItem[0].Titulo;


                lst_InfraLista = await ServiceConsumer.Service.GeneralService.GetInfraLista_Main(_Decrypt);

                Int32 OrderNumber = 1;
                foreach (var i in lst_InfraLista) i.Item = (OrderNumber++);

            }
            catch (Exception ex)
            {
                //_loading = false;
                //_snackBar.Add("Hubo un error en el sistema", Severity.Error, a => a.VisibleStateDuration = 1000);

            }
        }


    }
}
