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
            var ItemFactura = new Invoice
            {
                UBLVersionID = "2.1",
                CustomizationID = "2.0",
                ID = new ID { Value = "FFF1-1" },
                IssueDate = DateTime.Now.ToString("yyyy-MM-dd"),
                IssueTime = DateTime.Now.ToString("hh:mm:ss"),



                InvoiceTypeCode = new InvoiceTypeCode
                {

                    ListID = "0101",
                    ListAgencyName = "PE:SUNAT",
                    ListName = "Tipo de Documento",
                    ListURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01",
                    Name = "Tipo de Operacion",
                    ListSchemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo51",
                    Value = "01"
                },
                Note = new Note
                {   //No. 52 Catálogo    Códigos de leyendas
                    LanguageLocaleID = "1000",
                    Value = "SETECIENTOS OCHO CON 00/100 SOLES"
                },
                DocumentCurrencyCode = new DocumentCurrencyCode
                {
                    ListID = "ISO 4217 Alpha",
                    ListAgencyName = "United Nations Economic Commission for Europe",
                    ListName = "Currency",
                    Value = "PEN"
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
                    ID = new ID { Value = "10728110771" },
                    Note = new Note { Value = "WWW.NUBEFACT.COM" },
                    SignatoryParty = new SignatoryParty
                    {
                        PartyIdentification = new PartyIdentification
                        {
                            ID = new ID { Value = "10728110771" }
                        },
                        PartyName = new PartyName
                        {
                            Name = "TIMO LUGO DAVID JOSE"
                        }
                    },
                    DigitalSignatureAttachment = new DigitalSignatureAttachment
                    {

                        ExternalReference = new ExternalReference
                        {
                            URI = "10728110771"
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
                                Value = "10728110771"
                            }
                        },
                        PartyName = new PartyName
                        {

                            Name = "TIMO LUGO DAVID JOSE"
                        },
                        PartyLegalEntity = new PartyLegalEntity
                        {
                            RegistrationName = "TIMO LUGO DAVID JOSE",
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

                                schemeID = "6",
                                schemeName = "Documento de Identidad",
                                schemeAgencyName = "PE:SUNAT",
                                schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06",
                                Value = "20600695771"
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntity
                        {

                            RegistrationName = "NUBEFACT SA",
                            RegistrationAddress = new RegistrationAddress
                            {
                                AddressLine = new AddressLine
                                {
                                    Line = "CALLE LIBERTAD 116 MIRAFLORES - LIMA - PERU"
                                }
                            }
                        }

                    }

                }
                ,
                PaymentTerms = new PaymentTerms
                {
                    ID = new ID { Value = "FormaPago" },
                    PaymentMeansID = "Contado"
                },
                TaxTotal = new TaxTotal
                {
                    TaxAmount = new TaxAmount
                    {
                        CurrencyID = "PEN",
                        Value = "108.00"
                    },
                    TaxSubtotal = new TaxSubtotal
                    {
                        TaxableAmount = new TaxableAmount
                        {
                            CurrencyID = "PEN",
                            Value = "600.00",
                        },
                        TaxAmount = new TaxAmount
                        {
                            CurrencyID = "PEN",
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
                                    Value = "1000"
                                },
                                Name = "IGV",
                                TaxTypeCode = "VAT"
                            }

                        }

                    }


                },
                LegalMonetaryTotal = new LegalMonetaryTotal
                {
                    LineExtensionAmount = new LineExtensionAmount { CurrencyID = "PEN", Value = "600.00" },
                    TaxInclusiveAmount = new TaxInclusiveAmount { CurrencyID = "PEN", Value = "708.00" },
                    AllowanceTotalAmount = new AllowanceTotalAmount { CurrencyID = "PEN", Value = "0.00" },
                    ChargeTotalAmount = new ChargeTotalAmount { CurrencyID = "PEN", Value = "0.00" },
                    PrepaidAmount = new PrepaidAmount { CurrencyID = "PEN", Value = "0.00" },
                    PayableAmount = new PayableAmount { CurrencyID = "PEN", Value = "708.00" }
                },
                InvoiceLine = new List<InvoiceLine> { 
                    new InvoiceLine
                {
                    ID = new ID{
                        Value ="1"
                    },
                    InvoicedQuantity= new InvoicedQuantity
                    {
                        UnitCode = "NIU",
                        UnitCodeListID ="UN/ECE rec 20",
                        UnitCodeListAgencyName= "United Nations Economic Commission for Europe",
                        Value ="1.0"
                    },
                    LineExtensionAmount = new LineExtensionAmount
                    {
                        CurrencyID= "PEN",
                        Value = "500.00"
                    },
                    PricingReference = new PricingReference
                    {
                        AlternativeConditionPrice = new AlternativeConditionPrice
                        {
                            PriceAmount = new PriceAmount{ CurrencyID = "PEN" ,Value= "500.00"},
                            PriceTypeCode = new PriceTypeCode{
                                listAgencyName  = "PE:SUNAT",
                                listName = "Tipo de Precio",
                                listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo16",
                                Value = "01"

                            }
                        }
                    },
                    TaxTotal = new TaxTotal
                    {

                        TaxAmount =new TaxAmount
                        {
                            CurrencyID = "PEN",
                            Value = "90.00"
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxableAmount =new TaxableAmount {
                                 CurrencyID = "PEN",
                                 Value = "500.00"
                            },
                            TaxAmount = new TaxAmount
                            {
                                  CurrencyID = "PEN",
                                  Value = "90.00"
                            },
                            TaxCategory = new TaxCategory
                            {
                                Percent ="18.00",
                                TaxExemptionReasonCode=new TaxExemptionReasonCode
                                {
                                        listAgencyName  = "PE:SUNAT",
                                        listName = "Afectacion del IGV",
                                        listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07",
                                        Value = "10"
                                },
                                TaxScheme=new TaxScheme
                                {
                                    ID = new ID
                                    {
                                        schemeName = "Codigo de tributos",
                                        schemeAgencyName = "PE:SUNAT",
                                        schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo05",
                                        Value = "1000"
                                    },
                                    Name="IGV",
                                    TaxTypeCode="VAT"
                                }
                            }

                        }
                    },
                    Item = new Item
                    {

                        Description = "DETALLE DEL PRODUCTO",
                        SellersItemIdentification=new SellersItemIdentification
                        {
                            ID =  new ID{Value ="001"}
                        }
                    },
                    Price = new Price {
                    PriceAmount= new PriceAmount {CurrencyID = "PEN",Value = "500.0"
                    }
                    }

                } ,

                new InvoiceLine
                {
                    ID = new ID{
                        Value ="2"
                    },
                    InvoicedQuantity= new InvoicedQuantity
                    {
                        UnitCode = "ZZ",
                        UnitCodeListID ="UN/ECE rec 20",
                        UnitCodeListAgencyName= "United Nations Economic Commission for Europe",
                        Value ="5.0"
                    },
                    LineExtensionAmount = new LineExtensionAmount
                    {
                        CurrencyID= "PEN",
                        Value = "100.00"
                    },
                    PricingReference = new PricingReference
                    {
                        AlternativeConditionPrice = new AlternativeConditionPrice
                        {
                            PriceAmount = new PriceAmount{ CurrencyID = "PEN" ,Value= "23.6"},
                            PriceTypeCode = new PriceTypeCode{
                                listAgencyName  = "PE:SUNAT",
                                listName = "Tipo de Precio",
                                listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo16",
                                Value = "01"

                            }
                        }
                    },
                    TaxTotal = new TaxTotal
                    {

                        TaxAmount =new TaxAmount
                        {
                            CurrencyID = "PEN",
                            Value = "18.00"
                        },
                        TaxSubtotal = new TaxSubtotal
                        {
                            TaxableAmount =new TaxableAmount {
                                 CurrencyID = "PEN",
                                 Value = "100.00"
                            },
                            TaxAmount = new TaxAmount
                            {
                                  CurrencyID = "PEN",
                                  Value = "18.00"
                            },
                            TaxCategory = new TaxCategory
                            {
                                Percent ="18.00",
                                TaxExemptionReasonCode=new TaxExemptionReasonCode
                                {
                                        listAgencyName  = "PE:SUNAT",
                                        listName = "Afectacion del IGV",
                                        listURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo07",
                                        Value = "10"
                                },
                                TaxScheme=new TaxScheme
                                {
                                    ID = new ID
                                    {
                                        schemeName = "Codigo de tributos",
                                        schemeAgencyName = "PE:SUNAT",
                                        schemeURI = "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo05",
                                        Value = "1000"
                                    },
                                    Name="IGV",
                                    TaxTypeCode="VAT"
                                }
                            }

                        }
                    },
                    Item = new Item
                    {

                        Description = "DETALLE DEL SERVICIO",
                        SellersItemIdentification=new SellersItemIdentification
                        {
                            ID =  new ID{Value ="001"}
                        }
                    },
                    Price = new Price {
                    PriceAmount= new PriceAmount {CurrencyID = "PEN",Value = "20.0"
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
            string filePath = Path.Combine(folderPath, "Factura.xml");

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
