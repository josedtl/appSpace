
using AntDesign;
using Microsoft.AspNetCore.Components;
using Space.ServiceConsumer;

namespace Space.Web.Pages.Infraestructura.Main
{
    public partial class InfraestructuraMain : ComponentBase
    {

        List<InfraestructuraMainModel> Infrastructura_Lista = new List<InfraestructuraMainModel>();
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

                Infrastructura_Lista = await ServiceConsumer.Service.InfraestructuraService.GetInfraestructuraMain();

                Int32 OrderNumber = 1;
                foreach (var i in Infrastructura_Lista) i.Item = (OrderNumber++);

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
                NavigationManager.NavigateTo($"/InfraestructuraSave/0", false);
            }
            catch (Exception ex)
            { }

        }

        private async Task Method_Editar(Int32 RowItem)
        {
            try
            {

                NavigationManager.NavigateTo($"/InfraestructuraSave/{RowItem.ToString()}", false);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
