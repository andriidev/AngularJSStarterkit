using System.Collections.Generic;

namespace SeleniumTest.Utilities
{
    class Dictionary
    {
        public static Dictionary<string, string> EngDictionary = new Dictionary<string, string>
        {
            //Login Page
            {"successively logged in", "successively logged in"},
            {"LoginError", "TBD"},
            //ItemView page
            { "View", "Show"},
            { "Create", "Add a new item"},
            { "Edit", "EDIT item"},
             //home page
            { "Home", "Home"},
            { "Logout", "Logout"},
            { "Help", "Help"},
            { "Global message", "Features: internationalization, pagination, filters, bootstrap ui and partial templates, flash message notifications, Authentication, Authorization, CRUD features and RestFull API services"}
        };
        public static Dictionary<string, string> FrDictionary = new Dictionary<string, string>
        {
            //Login Page
            {"successively logged in", "TBD"},
            {"LoginError", "TBD"},
            //ItemView page
            { "View", "TBD"},
            { "Create", "TBD"},
            { "Edit", "TBD"},
             //home page
            { "Home", "Accueil"},
            { "Logout", "Logout"},
            { "Help", "Aide"},
            { "Global message", "Fonctionnalités : internationalization, pagination, filtres, bootstrap ui et templates, flash message notifications, Authentification, Autorisation, operations CRUD et services RestFull API"}
        };
    }
}
