namespace Programma
{
    public class WatWeWillenTesten : IWatWeWillenTesten
    {
        private IAfhankelijkheid _afhankelijkheid;

        public WatWeWillenTesten(IAfhankelijkheid afhankelijkheid)
        {
            this._afhankelijkheid = afhankelijkheid;
        }

        public int DezeMethodeWillenWeTesten()
        {
            return _afhankelijkheid.AfhankelijkheidMethode();
        }
    }
}