using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppXML
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var people = new SalonEntity
            {
                Grado = "3",
                Seccion = "B",
                Profe = new ProfesorEntity { Name = "Ruth", Apellido = "Medina" },
                DetalleAlumnos = new List<DetalleAlumnos> { new DetalleAlumnos
                {
                      Alumnos = new List<AlumnoEntity>
            {
                new AlumnoEntity { Name = "Juan",Apellido = "Ramirez" },
               new AlumnoEntity { Name = "Maria",Apellido = "Timoteo" },
                  new AlumnoEntity { Name = "Josue",Apellido = "Merino" },
                     new AlumnoEntity { Name = "Pedro",Apellido = "Carrasco" },
                        new AlumnoEntity { Name = "Liz",Apellido = "Tomas" },
            }
                } }

            };

            // Especificar la carpeta de destino
            string folderPath = @"D:\XML";

            // Asegurarse de que la carpeta exista
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Especificar el nombre del archivo
            string filePath = Path.Combine(folderPath, "SALON2.xml");

            // Serializar el objeto a XML y guardarlo en el archivo
            XmlSerializer serializer = new XmlSerializer(typeof(SalonEntity));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, people);
            }

            Console.WriteLine("Archivo XML generado y guardado en " + filePath);

        }


    }
    [Serializable]
    public class ProfesorEntity
    {
        public string Name { get; set; }
        public string Apellido { get; set; }
    }

    [Serializable]
    public class AlumnoEntity
    {
        [XmlElement("Person")]
        public string Name { get; set; }
        public string Apellido { get; set; }
    }

    [Serializable]
    public class DetalleAlumnos
    {
        [XmlElement("Alumnos")]
        public List<AlumnoEntity> Alumnos { get; set; }
    }


    [Serializable]
    public class SalonEntity
    {
        [XmlElement("Grado")]
        public String Grado { get; set; }
        [XmlElement("Seccion")]
        public String Seccion { get; set; }


        [XmlElement("Profesor")]
        public ProfesorEntity Profe { get; set; }


        [XmlElement("DetalleAlumnos")]
        public List<DetalleAlumnos> DetalleAlumnos { get; set; }


    }

}
