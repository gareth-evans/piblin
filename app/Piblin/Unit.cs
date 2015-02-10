namespace Piblin
{
    public class Unit
    {
        private static Unit _instance;

        public static Unit Instance { get { return _instance ?? (_instance = new Unit()); } }

        private Unit()
        {
        }
    }
}