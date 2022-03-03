using GG.PlugInTabanliHesapMakinesi.Contracts;

namespace ABCSirketi.ToplamaPlugIn
{
    /// <summary>
    /// ABCSirketi tarafından hazırlanan toplama plug-in'i.
    /// </summary>
    public class ToplamaIslemi : ICalculationCommand
    {
        // Plug-in'imizin ismi
        public string Name
        {
            get { return "Toplama"; }
        }

        public double Execute(double arg1, double arg2)
        {
            return arg1 + arg2; // Plug-in'imizin toplama işlevi
        }
    }
}