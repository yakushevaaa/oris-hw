namespace Socialite.Models
{
    public class NavLinkModel
    {
        public string IconPath { get; set; }
        public string LinkText { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public bool IsActive { get; set; }
    }
}
