using GG.PlugInTabanliHesapMakinesi.Contracts;
using System;

namespace GG.PlugInTabanliHesapMakinesi.PlugInEngine
{
    /// <summary>
    /// Plug-in'lerimizi serialize hale getirecek class'ımız.
    /// </summary>
    public class CalculationCommandCommunicator : MarshalByRefObject, ICalculationCommand
    {
        #region Constructor
        /// <summary>
        /// CalculationCommand türündeki gerçek nesnemiz.
        /// </summary>
        private ICalculationCommand _RealCommand;
        public CalculationCommandCommunicator(ICalculationCommand realCommand)
        {
            this._RealCommand = realCommand;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Hesaplama fonksiyon adı
        /// </summary>
        public string Name { get { return this._RealCommand.Name; } }
        #endregion

        #region Public Methods
        /// <summary>
        /// 2 argümanlı hesaplama fonksiyonumuz için execute edecek metotumuz
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public double Execute(double arg1, double arg2)
        {
            return this._RealCommand.Execute(arg1, arg2);
        }

        public override string ToString()
        {
            return this.Name;
        }
        #endregion
    }
}