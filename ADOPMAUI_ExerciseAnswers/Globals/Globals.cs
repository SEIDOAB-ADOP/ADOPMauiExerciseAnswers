using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Globals
{
    public class Global

    {
        #region Lazy implementation
        Global() { } // just to avoid any direct instantiations

        private static Lazy<Global> _instance = new Lazy<Global>(() => new Global());
        public static Global Data => _instance.Value;
        #endregion

        #region Data implementation 
        // accessible as GlobalData.Data.xx 
        public List<Friend> Friends { get; set; }
        public List<City> Cities { get; set; }
        public List<NamedColor> NamedColors { get; set; }
        #endregion
    }
}
