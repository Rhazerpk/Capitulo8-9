using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo8_9
{
    class Cap9
    {
        public class Tienda
        {
            public double Precio;
            public string NombreProducto = string.Empty;

            public Tienda()
            {

            }

            public Tienda(double Precio, string NombreProducto)
            {
                this.Precio = Precio;
                this.NombreProducto = NombreProducto;
            }

        }
        public class MascotaDueño
        {
            public string NombreDueño = string.Empty;
            public string NombreMascota = string.Empty;
            public string Edades = string.Empty;
            public string Direccion = string.Empty;

            Tienda productos = new Tienda();

            public MascotaDueño() 
            { 

            }

            public void setNombre(string NombreDueño)
            {
                this.NombreDueño = NombreDueño;
            }

            public string getNombre()
            {
                return NombreDueño;
            }

            public void setNombreMascota(string NombreMascota)
            {
                this.NombreMascota = NombreMascota;
            }

            public string getNombreMascota()
            {
                return NombreMascota;
            }

            public void setEdades(string Edades)
            {
                this.Edades = Edades;
            }

            public string getEdades()
            {
                return Edades;
            }

            public void setDireccion(string Direccion)
            {
                this.Direccion = Direccion;
            }

            public string getDireccion()
            {
                return Direccion;
            }

            public void setPrecio(double Precio)
            {
                this.productos.Precio = Precio;
            }

            public double getPrecio()
            {
                return productos.Precio;
            }

            public void setNombreProducto(string NombreProducto)
            {
                this.productos.NombreProducto = NombreProducto;
            }

            public string getNombreProducto()
            {
                return productos.NombreProducto;
            }
        }
        public void ShowUp()
        {
            MascotaDueño datos = new MascotaDueño();

            datos.setNombre("Cristiano");
            datos.setNombreMascota("Ronaldo");
            datos.setEdades("38 y 10 años");
            datos.setDireccion("Calle al Nassr, 16, Arabia Saudita");
            datos.setPrecio(3000);
            datos.setNombreProducto("Arroz blanco");

            Console.WriteLine($"\n Datos\n\n- Nombre del Dueño: {datos.getNombre()} \n- Nombre de la mascota: {datos.getNombreMascota()} \n- Edad del dueño & mascota: {datos.getEdades()} \n- Direccion: {datos.getDireccion()} \n- Precio: {datos.getPrecio()} \n- Nombre del producto: {datos.getNombreProducto()}");

            Neumaticos neumaticos = Neumaticos.Direccional;

            Console.WriteLine("- Neumaticos: " + neumaticos + "\n");

        }

        enum Neumaticos
        {
            Diagonal, Radial, Verano,Invierno,ALLTIME,Asimetrico,Direccional,Tubeless
        }
    }
}

