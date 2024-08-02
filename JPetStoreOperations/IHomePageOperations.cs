using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPetStoreOperations
{
    public interface IHomePageOperations
    {
        LogoDetails getLogoDetails();
        /// <summary>
        /// This Method return the details of logo as a string
        /// </summary>
        /// <returns>
        /// Top-Left
        /// Bottom-Right
        /// Middle
        /// </returns>
        //string getLogoDetails();
        string[] getTopMenuItems();

        string[] getLeftMenuItems();

        string[] DoSearch(string searchTerm);

        string getLogoPosition();

        void visitFishSection();
        void visitReptileSection();
        void VisitPetCategorySection(string petCategory);

    }
    // Interface Segregation Principle
    interface IHomePageSearch {
        
    }
    interface IHomePageTopMenu { }

    class ProperlyDesignedPetStoreHomePage : IHomePageSearch, IHomePageTopMenu {
        
    }
}
