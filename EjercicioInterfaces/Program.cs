using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
            Cree una interfaz llamada IColeccionable y luego impleméntela en una clase Libro
            Almacénelos en un arreglo llamado biblioteca
            Ordenar el arreglo y mostrar los resultados
            Guíese por el diagrama adjuntos
            
             */

            Libro libro1 = new Libro("yo", "yosoy");
            Libro libro2 = new Libro("yo", "yosoy");
            
            

            Libro[] biblioteca = new Libro[] { new Libro("hola", "comoestas"), libro1, libro2, new Libro("chau", "nosvemos") };

            //no tengo idea que parametros tengo que tener en cuenta para ordenar esto XD

        }

        interface IColeccionable
        {
            string TITULO
            {
                get;
                set;
            }

            void Describir();

        }

        public class Libro : IColeccionable
        {
            private static int id;
            private String autor;
            private String titulo;

            public Libro(String autor, String titulo)
            {
                this.autor = autor;
                this.titulo = titulo;
            }

       
            public void CompareTo(Libro libro)
            {
                String mensaje = "";
                if (this.autor.Equals(libro.autor))
                {

                    mensaje += "El autor de ambos libros es el mismo";
                    

                }
                else
                {
                    mensaje += "El autor de ambos libros no es el mismo";
                    
                }
                if (this.titulo.Equals(libro.titulo))
                {
                    mensaje += " y el titulo de ambos libros es igual";
                    
                }
                else
                {
                    mensaje += " y el titulo de ambos libros es distinto";
                    
                }

                Console.WriteLine(mensaje);
            }

            public void Describir()
            {
                Console.WriteLine($"El titulo de este libro es: {this.titulo}\n" +
                    $"El autro de este libro es: {this.autor}\n");
            }

            public String TITULO
            {
                get => this.titulo;
                set => this.titulo = value;
            }
            public String AUTOR
            {
                get => this.autor;
                set => this.autor = value;
            }
            public static int Id { get => id; set => id = value; }
        }
        



    }
}
