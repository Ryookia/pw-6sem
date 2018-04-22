using System;
using System.Collections.Generic;
using Durczak.AplikacjaWielowarstowa.Interfaces;

namespace Durczak.AplikacjaWielowarstowa.UI
{
    public class InputProcessor
    {

        private readonly IBusinessLogic _logicController;

        public InputProcessor(IBusinessLogic logicController)
        {
            _logicController = logicController;
        }

        public void ProcessKeyInput(int inputCode)
        {
            
        }

        public void ProcessInput(string input)
        {
            switch (input)
            {
                case "1":
                    var producerList = _logicController.GetAllProducers();
                    foreach (var producer in producerList)
                    {
                        Console.WriteLine("Id: {0}, Name: {1}, Origin Country: {2}", producer.Id, producer.Name, producer.CountryOrigin);
                        //System.Console.WriteLine(producer.ToString());
                    }
                    break;
                case "2":
                    var productList = _logicController.GetAllProducts();
                    foreach (var product in productList)
                    {
                        Console.WriteLine("Id: {0}, Name: {1}, Propulsion: {2}, Material: {3}, Velocity: {4} fps, Producer Id: {5} ", 
                            product.Id, product.Name, product.Propulsion, product.Material, product.Velocity, product.ProducerId);
                       // System.Console.WriteLine(product.ToString());
                    }
                    break;
                case "help":
                    PrintHelp();
                    break;
                case "exit":
                    System.Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Sorry I did not understand that one. Need help type 'help'");
                    break;
            }
        }
        public void PrintHelp()
        {
        System.Console.WriteLine("Hello and Welcome to the first stage of three layered application - Work in Progress\n" +
            "Right now you can only read products and producers from the database\n" +
            "Here are the commands\n" +
            "1 : Print all producers\n" +
            "2 : Print all products\n" +
            "exit : To leave the application\n");
        }
    }

}