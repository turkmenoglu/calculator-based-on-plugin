using GG.PlugInTabanliHesapMakinesi.Contracts;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GG.PlugInTabanliHesapMakinesi.PlugInEngine
{
    /// <summary>
    /// Plug-in'lerimizi bulup instance'larını türetip geyire dönderecek olan class'ımız.
    /// </summary>
    public class PlugInEngine : MarshalByRefObject
    {
        public List<ICalculationCommand> LoadPlugInCommands()
        {
            var commandList = new List<ICalculationCommand>(); // Plug-in'lerimizin instance'larını ekleyeceğimiz listemiz
            string basePath = AppDomain.CurrentDomain.BaseDirectory + "PlugIns"; // Plug-in'lerimizi bulmak için tarıyacağımız ana PlugIns path'imiz.

            foreach (var filePath in Directory.GetFiles(basePath, "*.dll")) // GetFiles metotuna yazdığımız "*.dll" patterni ile ilgili path'imizdeki assembly'lerimizi buluyoruz
            {
                var loadedAssembly = Assembly.LoadFile(filePath); // Reflection namespace'si altındaki Assembly sınıfı ile ilgili assembly'imizi yüklüyoruz
                var calculationTypes = loadedAssembly.GetTypes().Where(t => typeof(ICalculationCommand).IsAssignableFrom(t)); // ICalculationCommand'dan inherit alan nesneleri buluyoruz

                foreach (var calculationType in calculationTypes)
                {
                    var cmd = Activator.CreateInstance(calculationType); // Instance'sini üretiyoruz
                    commandList.Add(new CalculationCommandCommunicator(cmd as ICalculationCommand)); // Ürettiğimiz instance'ımızı hazırlamış olduğumuz bizim için serialize hale getirecek olan CalculationCommandCommunicator ile sarmalıyor ve commandList'imize ekliyoruz
                }
            }

            return commandList;
        }
    }
}
