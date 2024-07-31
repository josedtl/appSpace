using AntDesign;
using Microsoft.AspNetCore.Components;
using Space.ServiceConsumer;

namespace Space.Web.Pages.Tarifa.Save
{
    public partial class TarifaSave : ComponentBase
    {
        private String txtValue = String.Empty;
        string _selectedValue4 = "lucy";
        Boolean EsAdd = true;

        private TarifaSaveModel Tarifa = new TarifaSaveModel();
        private List<MonedaModel> lst_Moneda = new List<MonedaModel>();
        private List<UnidadMedidaModel> lst_unidadMedida = new List<UnidadMedidaModel>();

        private MonedaModel select_Moneda = new MonedaModel();
        private UnidadMedidaModel select_UnidadMedida = new UnidadMedidaModel();

        [Parameter]
        public String MiVariable { get; set; }
        Boolean _loading = true;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                _loading = true;
                lst_Moneda = await ServiceConsumer.Service.GeneralService.GetMonedaItems();
                lst_unidadMedida = await ServiceConsumer.Service.GeneralService.GetUnidadMedidaItems();

                Int32 OrdenTarifaId = Convert.ToInt32(MiVariable);

                if (OrdenTarifaId > 0)
                {
                    EsAdd = false;
                    var Items = await ServiceConsumer.Service.TarifaService.GetTarifaItem(OrdenTarifaId);

                    if (Items != null && Items.Count > 0)
                    {
                        var Item_Select = Items[0];

                        Tarifa = Item_Select;


                        Int32 Index_Moneda = lst_Moneda.FindIndex(S => S.MonedaId == Tarifa.MonedaId);
                        select_Moneda = Index_Moneda >= 0 ? lst_Moneda[Index_Moneda] : new MonedaModel();

                        Int32 Index_UnidadMedida = lst_unidadMedida.FindIndex(S => S.UnidadMedidaId == Tarifa.UnidadMedidaId);
                        select_UnidadMedida = Index_UnidadMedida >= 0 ? lst_unidadMedida[Index_UnidadMedida] : new UnidadMedidaModel();
                    }

                }
                _loading = false;
            }
            catch (Exception ex)
            {

            }

        }


        private async Task Method_Guardar()
        {
            try
            {
                Tarifa.MonedaId = select_Moneda.MonedaId;
                Tarifa.UnidadMedidaId = select_UnidadMedida.UnidadMedidaId;
                Tarifa.FechaRegistro = DateTime.Now;
                Tarifa.CodUsuario = "adm";
                Tarifa.EstadoRegistro = true;
                    var item = Tarifa;

                if (Tarifa.TarifaId == 0)
                {
                    var dato = await ServiceConsumer.Service.TarifaService.Save(Tarifa);
                    await _message.Success("Se guardo correctamente");
                }
                else
                {

                    var dato = await ServiceConsumer.Service.TarifaService.Update(Tarifa);
                    await _message.Success("Se actualizo correctamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
