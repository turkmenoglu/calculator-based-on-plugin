using GG.PlugInTabanliHesapMakinesi.Contracts;
using System;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;

namespace GG.PlugInTabanliHesapMakinesi.PlugInStarter
{
    /// <summary>
    /// Ana hesap makinesi uygulamamız içinde plug-in'lerimizi çalıştıracak olan class'ımız.
    /// </summary>
    public static class PlugInStarter
    {
        public static List<ICalculationCommand> Start()
        {
            #region Create AppDomain
            var setUp = new AppDomainSetup();
            setUp.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;

            // Kısıtlı ve güvenli olarak üretiyoruz. (CAS)
            var permissionSet = new PermissionSet(PermissionState.None);
            permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution)); // Çalıştırabilmek için yetki veriyoruz
            permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.PathDiscovery, AppDomain.CurrentDomain.BaseDirectory)); // Sadece gerekli klasörümüze keşife izin veriyoruz
            permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.Read, AppDomain.CurrentDomain.BaseDirectory + "PlugIns")); // Sadece gerekli klasörümüze okuma izni veriyoruz

            var plugInApplicationDomain = AppDomain.CreateDomain("Plug In App Domain", null, setUp, permissionSet); // Gerekli bilgileri vererek domain ismi, kurulum bilgisi ve güvenlik izinleri gibi domainimizi üretiyoruz
            #endregion

            // Diğer application domain'imizde PlugInEngine'mizi üretip bu objenin bize ObjectHandle bilgisini geriye döner.
            var plugInEngine = (PlugInEngine.PlugInEngine)plugInApplicationDomain.CreateInstanceAndUnwrap(typeof(PlugInEngine.PlugInEngine).Assembly.FullName, typeof(PlugInEngine.PlugInEngine).FullName);

            return plugInEngine.LoadPlugInCommands();
        }
    }
}
