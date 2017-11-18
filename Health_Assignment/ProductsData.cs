using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Assignment
{
    public class ProductsData
    {
        public static List<Product> products = new List<Product>();

        public static List<Product> initializeData()
        {
            products.Add(new Protein("Omega-3 Premium Fish Oil", "The natural Fish Oil concentrate used in our Omega-3 softgels is manufactured under strict quality control standards. It is tested to be free of potentially harmful levels of contaminants (e.g., heavy metals [mercury], PCB's dioxins, and other contaminants).", "Take 2 softgels daily, with or without food", "Madre Labs", 28.19M, 20));
            products.Add(new Vitamin("Vitamin D3", "Healthy Origins Vitamin D3 10,000 IU is a key nutrient manufactured in a highly absorbable liquid softgel form. Vitamin D3 is synthesized in the body from sunlight and only a small amount can be obtained from food. The winter season and many sunblock products inhibit the body's ability to produce optimal levels of Vitamin D. As a result, Vitamin D3 supplementation becomes even more necessary to ensure your body receives an adequate supply.","Take one (1) softgel daily", "Healthy Origins", 58.15M, 25));
            products.Add(new Vitamin("Vitamin C", "Ester-C Plus is exclusively formulated by Solgar and provides a patented, pH neutral (non acidic) Vitamin C that is gentle on the stomach. The Vitamin C metabolites in Ester-C positively impact the retention of Vitamin C in cells, providing additional benefits. A special manufacturing process is employed to form a unique calcium ascorbate metabolite complex. This well-retained complex yields beneficial antioxidant and immune system support and incorporates natural bioflavonoids and acerola berry along with rose hips fruit powder.", "Take one (1) tablet daily, preferably with a meal", "Solgar", 62.735M, 35));
            products.Add(new Protein("Hemp Pro 50", "CAs your hemp protein specialists, we are proud to offer a full line of delicious, convenient and easily digestible hemp protein powders. Packed with nutrients, each of our protein powders is rich in omegas and high in protein. Try one today!", "There is no fixed prescription","Manitoba Harvest", 101.77M, 25));
            products.Add(new MineralSupplement("Calcium Plus", "Essential for building & maintaining strong, healthy bones", "As a dietary supplement, take three caplets daily.", "GNC", 50M, 40));
            products.Add(new MineralSupplement("Magnesium",  "Essential for calcium absorption and strong bones and teeth, necessary for cell function", "As a dietary supplement, take one capsule daily. For maximum benefits, take as directed every day.", "GNC", 34M, 40));
            return products;
        }

        public static List<Product> getCurrentList()
        {
            return products;
        }

        public static void updateInformation(Product currentProduct)
        {

            Product existingProduct = products.Find(x => x.ID == currentProduct.ID);
            int index = products.IndexOf(existingProduct);
            if (currentProduct.Category.Equals("Vitamin"))
            {
                Vitamin existingVitaminProduct = (Vitamin)currentProduct;
                products[index] = existingVitaminProduct;
            }
            else if(currentProduct.Category.Equals("Protein"))
            {
                Protein existingProteinProduct = (Protein)currentProduct;
                products[index] = existingProteinProduct;
            }
            else
            {
                MineralSupplement existingMineralProduct = (MineralSupplement)currentProduct;
                products[index] = existingMineralProduct;
            }


        }

        public static void addNewProduct(Product newProduct)
        {
            products.Add(newProduct);
        }

        public static void deleteProduct(Product product)
        {
            products.Remove(product);
        }
        
    }
}
