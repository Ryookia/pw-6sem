using System;
using Durczak.AplikacjaWielowarstowa.BL;
using Durczak.AplikacjaWielowarstowa.Interfaces;

namespace Durczak.AplikacjaWielowarstowa.UI
{
    public class ConsoleInterface
    {

        private readonly InputProcessor _inputProcessor;
        private IBusinessLogic _logicController;

        public ConsoleInterface()
        {
            _logicController = new LogicController(Properties.Settings.Default.database_name);
            _inputProcessor = new InputProcessor(_logicController);
        }

        

        public void LaunchInterface()
        {
            _inputProcessor.PrintHelp();
            while (true)
            {
                var input = Console.ReadLine();
                _inputProcessor.ProcessInput(input);
            }
        }


    }
}