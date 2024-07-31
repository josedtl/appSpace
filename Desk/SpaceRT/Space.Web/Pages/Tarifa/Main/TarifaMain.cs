using AntDesign;
using Microsoft.AspNetCore.Components;
using Space.ServiceConsumer;

namespace Space.Web.Pages.Tarifa.Main
{
    public partial class TarifaMain : ComponentBase
    {


        List<TarifaMainModel>  Tarifa_Lista = new List<TarifaMainModel>();
        string _size = AntSizeLDSType.Large;
        Boolean _loading = true;

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

                Tarifa_Lista = await ServiceConsumer.Service.TarifaService.GetTarifaMain();

                Int32 OrderNumber = 1;
                foreach (var i in Tarifa_Lista) i.Item = (OrderNumber++);

            }
            catch (Exception ex)
            {
                //_loading = false;
                //_snackBar.Add("Hubo un error en el sistema", Severity.Error, a => a.VisibleStateDuration = 1000);

            }
        }
        private async Task IrAlSave()
        {
            try
            {
                NavigationManager.NavigateTo($"/TarifaSave/0", false);
            }
            catch (Exception ex)
            { }

        }
        private async Task Method_Editar(Int32 RowItem)
        {
            try
            {

                NavigationManager.NavigateTo($"/TarifaSave/{RowItem.ToString()}", false);

            }
            catch (Exception ex)
            {

            }
        }

    }
}
