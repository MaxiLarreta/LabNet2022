using EF.Entities;
using EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shipperId;
            string shipperCompanyName;
            string shipperPhone;
            CustomersUI customersUI = new CustomersUI();
            ShippersUI shippersUI = new ShippersUI();
            customersUI.GetAll();
            Console.WriteLine(" ");
            shippersUI.GetAll();
            Console.WriteLine("¿Desea agregar un nuevo shipper? Inserte cualquier letra para Si, o vacío para No");
            var add = Console.ReadLine();

            if (add != "")
            {
                try
                {
                    Console.WriteLine("Inserte los datos para ingresar un nuevo shipper");
                    Console.WriteLine("Inserte el nombre de la Compañía");
                    shipperCompanyName = Console.ReadLine();
                    Console.WriteLine("Inserte el numero de teléfono de la Compañía");
                    shipperPhone = Console.ReadLine();
                    shippersUI.Add(shipperCompanyName, shipperPhone);
                    Console.WriteLine("Shippers Actualizados");
                    Console.WriteLine(" ");
                    shippersUI.GetAll();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            Console.WriteLine("¿Desea actualizar un shipper? Inserte cualquier letra para Si, o vacío para No");
            var update = Console.ReadLine();

            if(update != "")
            {
                try
                {
                    Console.WriteLine("Inserte los datos para actualizar un shipper");
                    Console.WriteLine("Inserte el ID");
                    shipperId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inserte el numero de teléfono de la Compañía");
                    shipperPhone = Console.ReadLine();
                    shippersUI.Update(shipperId, shipperPhone);
                    Console.WriteLine(" ");
                    Console.WriteLine("Shippers Actualizados");
                    Console.WriteLine(" ");
                    shippersUI.GetAll();
                   
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Probablemente ingreso mal el ID ex: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            Console.WriteLine("¿Desea eliminar un shipper? Inserte cualquier letra para Si, o vacío para No");
            var delete = Console.ReadLine();
            if(delete != "")
            {
                try
                {
                    Console.WriteLine($"Ingrese el ID del shipper a elimminar. Los ID de los shippers que puede eliminar son: {String.Join(", ", shippersUI.idShippers)}");
                    shipperId = int.Parse(Console.ReadLine());
                    shippersUI.Delete(shipperId);
                    Console.WriteLine(" ");
                    Console.WriteLine("Shippers Actualizados");
                    Console.WriteLine(" ");
                    shippersUI.GetAll();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Probablemente ingreso mal el ID ex: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
