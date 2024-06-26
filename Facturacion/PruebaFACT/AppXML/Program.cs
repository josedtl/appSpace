using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppXML
{
    internal class Program
    {
        static void Main(string[] args)
        {


            String m_Serie = "FFF1";
            String m_Correlativo = "1";
            String m_CodigoFactura = m_Serie + "-" + m_Correlativo;

            //Datos de Emisor
            String m_NumDocumentoEmpresaEmite = "10728110771";
            String m_NomEmpresaEmite = "TIMO LUGO DAVID JOSE";

            //catalogo01 TipoDocumento
            String m_CodigoTipoDocumento = "01";

            //catalogo01 TipoOperacion
            String m_CodigoTipoOperacion = "0101";


            //No. 52 Catálogo    Códigos de leyendas
            String m_CodigoLeyenda = "1000";
            String m_LetraImporte = "SETECIENTOS OCHO CON 00/100 SOLES";


            //CLiente
            String m_NumCliente = "20600695771";
            //catalogo06
            String m_CodigoTipoDocumentoCliente = "6";
            String m_NomCliente = "NUBEFACT SA";
            String m_Direccion = "CALLE LIBERTAD 116 MIRAFLORES - LIMA - PERU";

            //Forma de Pago
            String m_FormaPago = "Contado";


            //Codigo de Tributo catalogo05

            String m_CodTributo = "1000";
            String m_CodInternacionalTributo = "VAT";
            String m_NomTributo = "IGV";


            //Codigo de Moneda 
            String m_CodigoMoneda = "PEN";


            //Tipo de Precio catalogo16
            String m_CodigoTipoPrecio = "01";





            /////////////1 Detalle  DETALLE DE PRODUCTO

            String mD1_Numeracion = "1";
            String mD1_PrecioUnitario = 500.ToString("N2");
            String mD1_Cantidad = 1.ToString("N1");

            String mD1_SumaCantidadPrecio = (500 * 1).ToString("N2"); ;

            String mD1_PrecioConImpuesto = 590.ToString("N2");
            String mD1_ImpuestoSolo = 90.ToString("N2");
            //Afectacion del IGV catalogo07
            String mD1_CodigoTipoAfectacionIGV = "10";
            String mD1_Porcentaje = "18.00";
            //Codigo de Tributo catalogo05
            String mD1_CodTributo = "1000";
            String mD1_CodInternacionalTributo = "VAT";
            String mD1_NomTributo = "IGV";
            String mD1_PrecioUnitarioUnDecimal = 500.ToString("N1");
            String mD1_CodUnidadMedida = "NIU";
            String mD1_DetalleConcepto = "DETALLE DEL PRODUCTO";
            String mD1_CodigoDetalleConcepto = "001";


            /////////////2 Detalle  DETALLE DE PRODUCTO

            String mD2_Numeracion = "2";
            String mD2_PrecioUnitario = 20.ToString("N2");
            String mD2_Cantidad = 5.ToString("N1");

            String mD2_SumaCantidadPrecio = (20 * 5).ToString("N2"); ;

            String mD2_PrecioConImpuesto = 23.6.ToString("N2");
            String mD2_ImpuestoSolo = 18.ToString("N2");
            //Afectacion del IGV catalogo07
            String mD2_CodigoTipoAfectacionIGV = "10";
            String mD2_Porcentaje = "18.00";
            //Codigo de Tributo catalogo05
            String mD2_CodTributo = "1000";
            String mD2_CodInternacionalTributo = "VAT";
            String mD2_NomTributo = "IGV";
            String mD2_PrecioUnitarioUnDecimal = 500.ToString("N1");
            String mD2_CodUnidadMedida = "ZZ";
            String mD2_DetalleConcepto = "DETALLE DEL SERVICIO";
            String mD2_CodigoDetalleConcepto = "001";





            var ItemFactura = new Invoice
            {
                UBLVersionID = "2.1",
                CustomizationID = "2.0",
                ID = new ID { Value = m_CodigoFactura },
                IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                IssueTime = DateTime.Now.ToString("hh:mm:ss"),
                InvoiceTypeCode = new InvoiceTypeCode
                {

                    ListAgencyName = "PE:SUNAT",
                    ListSchemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo51",
                    Name = "Tipo de Operacion",
                    ListID = m_CodigoTipoOperacion,
                    ListURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01",
                    ListName = "Tipo de Documento",
                    Value = m_CodigoTipoDocumento
                },
                Note = new Note
                {   //No. 52 Catálogo    Códigos de leyendas
                    LanguageLocaleID = m_CodigoLeyenda,
                    Value = m_LetraImporte
                },
                DocumentCurrencyCode = new DocumentCurrencyCode
                {
                    ListID = "ISO 4217 Alpha",
                    ListAgencyName = "United Nations Economic Commission for Europe",
                    ListName = "Currency",
                    Value = m_CodigoMoneda
                },
                DespatchDocumentReference = new DespatchDocumentReference
                {
                    ID = new ID { Value = "0001-23" },
                    DocumentTypeCode = new DocumentTypeCode
                    {
                        ListAgencyName = "PE:SUNAT",
                        ListName = "Tipo de Documento",
                        ListURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01",
                        Value = "09"
                    }
                },
                Signature = new Signature
                {
                    ID = new ID { Value = m_NumDocumentoEmpresaEmite },
                    Note = new Note { Value = "WWW.NUBEFACT.COM" },
                    SignatoryParty = new SignatoryParty
                    {
                        PartyIdentification = new PartyIdentification
                        {
                            ID = new ID { Value = m_NumDocumentoEmpresaEmite }
                        },
                        PartyName = new PartyName
                        {
                            Name = m_NomEmpresaEmite
                        }
                    },
                    DigitalSignatureAttachment = new DigitalSignatureAttachment
                    {

                        ExternalReference = new ExternalReference
                        {
                            URI = m_NumDocumentoEmpresaEmite
                        }
                    }
                },

                AccountingSupplierParty = new AccountingSupplierParty
                {
                    Party = new Party
                    {
                        PartyIdentification = new PartyIdentification
                        {
                            ID = new ID
                            {
                                schemeID = "6",
                                schemeName = "Documento de Identidad",
                                schemeAgencyName = "PE:SUNAT",
                                schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06",
                                Value = m_NumDocumentoEmpresaEmite
                            }
                        },
                        PartyName = new PartyName
                        {

                            Name = m_NomEmpresaEmite
                        },
                        PartyLegalEntity = new PartyLegalEntity
                        {
                            RegistrationName = m_NomEmpresaEmite,
                            RegistrationAddress = new RegistrationAddress
                            {
                                ID = new ID
                                {
                                    schemeName = "Ubigeos",
                                    schemeAgencyName = "PE:INEI",
                                    Value = "000000",
                                },
                                AddressTypeCode = new AddressTypeCode
                                {
                                    listAgencyName = "PE:SUNAT",
                                    listName = "Establecimientos anexos",
                                    Value = "0000"
                                },
                                CityName = "-",
                                CountrySubentity = "-",
                                District = "-",
                                AddressLine = new AddressLine
                                {
                                    Line = "-"
                                },
                                Country = new Country
                                {
                                    IDentificationCode = new IDentificationCode
                                    {
                                        listID = "ISO 3166-1",
                                        listAgencyName = "United Nations Economic Commission for Europe",
                                        listName = "Country",
                                        Value = "PE"
                                    }

                                }


                            }

                        }

                    },
                }
                ,
                AccountingCustomerParty = new AccountingCustomerParty
                {

                    Party = new Party
                    {
                        PartyIdentification = new PartyIdentification
                        {

                            ID = new ID
                            {

                                schemeAgencyName = "PE:SUNAT",
                                schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06",
                                schemeName = "Documento de Identidad",
                                schemeID = m_CodigoTipoDocumentoCliente,
                                Value = m_NumCliente
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntity
                        {

                            RegistrationName = m_NomCliente,
                            RegistrationAddress = new RegistrationAddress
                            {
                                AddressLine = new AddressLine
                                {
                                    Line = m_Direccion
                                }
                            }
                        }

                    }

                }
                ,
                PaymentTerms = new PaymentTerms
                {
                    ID = new ID { Value = "FormaPago" },
                    PaymentMeansID = m_FormaPago
                },
                TaxTotal = new TaxTotal
                {
                    TaxAmount = new TaxAmount
                    {
                        CurrencyID = m_CodigoMoneda,
                        Value = "108.00"
                    },
                    TaxSubtotal = new TaxSubtotal
                    {
                        TaxableAmount = new TaxableAmount
                        {
                            CurrencyID = m_CodigoMoneda,
                            Value = "600.00",
                        },
                        TaxAmount = new TaxAmount
                        {
                            CurrencyID = m_CodigoMoneda,
                            Value = "108.00"
                        },
                        TaxCategory = new TaxCategory
                        {
                            TaxScheme = new TaxScheme
                            {
                                ID = new ID
                                {
                                    schemeName = "Codigo de tributos",
                                    schemeAgencyName = "PE:SUNAT",
                                    schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo05",
                                    Value = m_CodTributo
                                },
                                Name = m_NomTributo,
                                TaxTypeCode = m_CodInternacionalTributo
                            }

                        }

                    }


                },
                LegalMonetaryTotal = new LegalMonetaryTotal
                {
                    LineExtensionAmount = new LineExtensionAmount { CurrencyID = m_CodigoMoneda, Value = "600.00" },
                    TaxInclusiveAmount = new TaxInclusiveAmount { CurrencyID = m_CodigoMoneda, Value = "708.00" },
                    AllowanceTotalAmount = new AllowanceTotalAmount { CurrencyID = m_CodigoMoneda, Value = "0.00" },
                    ChargeTotalAmount = new ChargeTotalAmount { CurrencyID = m_CodigoMoneda, Value = "0.00" },
                    PrepaidAmount = new PrepaidAmount { CurrencyID = m_CodigoMoneda, Value = "0.00" },
                    PayableAmount = new PayableAmount { CurrencyID = m_CodigoMoneda, Value = "708.00" }
                },
                InvoiceLine = new List<InvoiceLine> {
                new InvoiceLine{

                    ID = new ID{
                        Value =mD1_Numeracion
                    },
                    InvoicedQuantity= new InvoicedQuantity
                    {
                        UnitCode = mD1_CodUnidadMedida,
                        UnitCodeListID ="UN/ECE rec 20",
                        UnitCodeListAgencyName= "United Nations Economic Commission for Europe",
                        Value =mD1_Cantidad
                    },
                    LineExtensionAmount = new LineExtensionAmount
                    {
                        CurrencyID= m_CodigoMoneda,
                        Value = mD1_SumaCantidadPrecio
                    },
                    PricingReference = new PricingReference
                    {
                        AlternativeConditionPrice = new AlternativeConditionPrice
                        {
                            PriceAmount = new PriceAmount{ CurrencyID = m_CodigoMoneda ,Value= mD1_PrecioConImpuesto},
                            PriceTypeCode = new PriceTypeCode{
                                listAgencyName  = "PE:SUNAT",
                                listName = "Tipo de Precio",
                                listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo16",
                                Value = m_CodigoTipoPrecio

                            }
                        }
                    },
                    TaxTotal = new TaxTotal
                    {

                        TaxAmount =new TaxAmount
                        {
                            CurrencyID = m_CodigoMoneda,
                            Value = mD1_ImpuestoSolo
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxableAmount =new TaxableAmount {
                                 CurrencyID = m_CodigoMoneda,
                                 Value = mD1_PrecioUnitario
                            },
                            TaxAmount = new TaxAmount
                            {
                                  CurrencyID = m_CodigoMoneda,
                                  Value = mD1_ImpuestoSolo
                            },
                            TaxCategory = new TaxCategory
                            {
                                Percent =mD1_Porcentaje,
                                TaxExemptionReasonCode=new TaxExemptionReasonCode
                                {
                                        listAgencyName  = "PE:SUNAT",
                                        listName = "Afectacion del IGV",
                                        listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07",
                                        Value = mD1_CodigoTipoAfectacionIGV
                                },
                                TaxScheme=new TaxScheme
                                {
                                    ID = new ID
                                    {
                                        schemeName = "Codigo de tributos",
                                        schemeAgencyName = "PE:SUNAT",
                                        schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo05",
                                        Value = mD1_CodTributo
                                    },
                                    Name=mD1_NomTributo,
                                    TaxTypeCode=mD1_CodInternacionalTributo
                                }
                            }

                        }
                    },
                    Item = new Item
                    {

                        Description = mD1_DetalleConcepto,
                        SellersItemIdentification=new SellersItemIdentification
                        {
                            ID =  new ID {Value =mD1_CodigoDetalleConcepto}
                        }
                    },
                    Price = new Price {
                    PriceAmount= new PriceAmount {CurrencyID = m_CodigoMoneda,Value = mD1_PrecioUnitarioUnDecimal
                    }
                    }

                } ,

                new InvoiceLine
                {
                    ID = new ID{
                        Value =mD2_Numeracion
                    },
                    InvoicedQuantity= new InvoicedQuantity
                    {
                        UnitCode = mD2_CodUnidadMedida,
                        UnitCodeListID ="UN/ECE rec 20",
                        UnitCodeListAgencyName= "United Nations Economic Commission for Europe",
                        Value = mD2_Cantidad
                    },
                    LineExtensionAmount = new LineExtensionAmount
                    {
                        CurrencyID= m_CodigoMoneda,
                        Value = mD2_SumaCantidadPrecio
                    },
                    PricingReference = new PricingReference
                    {
                        AlternativeConditionPrice = new AlternativeConditionPrice
                        {
                            PriceAmount = new PriceAmount{ CurrencyID = m_CodigoMoneda ,Value= mD2_PrecioConImpuesto},
                            PriceTypeCode = new PriceTypeCode{
                                listAgencyName  = "PE:SUNAT",
                                listName = "Tipo de Precio",
                                listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo16",
                                Value = m_CodigoTipoPrecio

                            }
                        }
                    },
                    TaxTotal = new TaxTotal
                    {

                        TaxAmount =new TaxAmount
                        {
                            CurrencyID = m_CodigoMoneda,
                            Value = mD2_ImpuestoSolo
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxableAmount =new TaxableAmount {
                                 CurrencyID = m_CodigoMoneda,
                                 Value = mD2_PrecioUnitario
                            },
                            TaxAmount = new TaxAmount
                            {
                                  CurrencyID = m_CodigoMoneda,
                                  Value = mD2_ImpuestoSolo
                            },
                            TaxCategory = new TaxCategory
                            {
                                Percent =mD2_Porcentaje,
                                TaxExemptionReasonCode=new TaxExemptionReasonCode
                                {
                                        listAgencyName  = "PE:SUNAT",
                                        listName = "Afectacion del IGV",
                                        listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07",
                                        Value = mD2_CodigoTipoAfectacionIGV
                                },
                                TaxScheme=new TaxScheme
                                {
                                    ID = new ID
                                    {
                                        schemeName = "Codigo de tributos",
                                        schemeAgencyName = "PE:SUNAT",
                                        schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo05",
                                        Value = mD2_CodTributo
                                    },
                                    Name=mD2_NomTributo,
                                    TaxTypeCode=mD2_CodInternacionalTributo
                                }
                            }

                        }
                    },
                    Item = new Item
                    {

                        Description = mD2_DetalleConcepto,
                        SellersItemIdentification=new SellersItemIdentification
                        {
                            ID =  new ID{Value = mD2_CodigoDetalleConcepto}
                        }
                    },
                    Price = new Price {
                    PriceAmount= new PriceAmount {CurrencyID = m_CodigoMoneda,Value = mD2_PrecioUnitarioUnDecimal
                    }
                    }

                }
                }

            };

            // Especificar la carpeta de destino
            string folderPath = @"D:\XML";

            // Asegurarse de que la carpeta exista
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Especificar el nombre del archivo
            string filePath = Path.Combine(folderPath, m_CodigoFactura + ".xml");

            // Serializar el objeto a XML y guardarlo en el archivo
            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, ItemFactura);
            }

            Console.WriteLine("Archivo XML generado y guardado en " + filePath);

        }


    }


}
