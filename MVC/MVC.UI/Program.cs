using MVC.Entities;
using MVC.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid = false;
            bool newAdd = false;
            bool newUpdate = false;
            bool newDelete = false;
            bool actionAdd;
            bool actionUpdate;
            bool actionDelete;
            int shipperId;
            string shipperCompanyName;
            string shipperPhone;
            CustomersUI customersUI = new CustomersUI();
            ShippersUI shippersUI = new ShippersUI();
            customersUI.GetAll();
            Console.WriteLine(" ");
            shippersUI.GetAll();
            while (!valid)
            {
                actionAdd = false;
                actionUpdate = false;
                actionDelete = false;
                while (!actionAdd)
                {
                    Console.WriteLine("¿Desea agregar un nuevo shipper? Inserte cualquier letra para Si, o vacío para No");
                    var add = Console.ReadLine();
                    if (add == "") { actionAdd = true; }
                    
                    if (add != "")
                    {
                        actionAdd = false;
                        newAdd = false;
                        while (!newAdd)
                        {
                            try
                            {
                                Console.WriteLine("Inserte los datos para ingresar un nuevo shipper");
                                Console.WriteLine("Inserte el nombre de la Compañía");
                                shipperCompanyName = Console.ReadLine();
                                Console.WriteLine("Inserte el numero de teléfono de la Compañía");
                                shipperPhone = Console.ReadLine();
                                newAdd = shippersUI.Add(shipperCompanyName, shipperPhone);
                                Console.WriteLine("Shippers Actualizados");
                                Console.WriteLine(" ");
                                shippersUI.GetAll();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
                while (!actionUpdate)
                {
                    Console.WriteLine("¿Desea actualizar un shipper? Inserte cualquier letra para Si, o vacío para No");
                    var update = Console.ReadLine();
                    if (update == "") { actionUpdate = true; }
                    if (update != "")
                    {
                        actionUpdate = false;
                        newUpdate = false;
                        while (!newUpdate)
                        {
                            try
                            {
                                Console.WriteLine("Inserte los datos para actualizar un shipper");
                                Console.WriteLine("Inserte el ID");
                                shipperId = int.Parse(Console.ReadLine());
                                Console.WriteLine("Inserte el numero de teléfono de la Compañía");
                                shipperPhone = Console.ReadLine();
                                newUpdate = shippersUI.Update(shipperId, shipperPhone);
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
                        
                    }

                }

                while (!actionDelete)
                {
                    Console.WriteLine("¿Desea eliminar un shipper? Inserte cualquier letra para Si, o vacío para No");
                    var delete = Console.ReadLine();
                    if (delete == "") { actionDelete = true; }
                    if (delete != "")
                    {
                        actionDelete = false;
                        newDelete = false;
                        while (!newDelete)
                        {
                            try
                            {
                                Console.WriteLine($"Ingrese el ID del shipper a elimminar. Los ID de los shippers que puede eliminar son: {String.Join(", ", shippersUI.idShippers)}");
                                shipperId = int.Parse(Console.ReadLine());
                                newDelete = shippersUI.Delete(shipperId);
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
                    }
                }
                Console.WriteLine("¿Desea salir del programa? Inserte cualquier letra para Si, o vacío para No");
                var exit = Console.ReadLine();
                if (exit != "")
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }
                 
            }
        }
    }
}
