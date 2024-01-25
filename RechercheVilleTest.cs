using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    [TestClass]
    public class RechercheVilleTest
    {
        private List<string> _villes;

        private RechercheVille _rechercheVille;

        

        [TestMethod]
        //1. Si le texte de la recherche contient moins de 2 caractères, ***Une exception est levée de type NotFoundException***.
        public void WhenSearch_hasLessThan_2chars()
        {
            //Arrange
            string mot = "A";
            _rechercheVille = new RechercheVille();

            //Act
            _rechercheVille.Rechercher(mot);
            //Assert

            Assert.ThrowsException<Exception>(()=> _rechercheVille.Rechercher(mot));
        }
    }
    
}
