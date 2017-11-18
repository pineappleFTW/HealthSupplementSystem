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
            products.Add(new Vitamin("Ultra Potency Gymnema Sylvestre", "Source Naturals Ultra Potency Gymnema Sylvestre provides powerful support to help maintain healthy blood sugar levels when used as part of your diet. This herb has been used traditionally in India for centuries and has been shown in research to support healthy glucose metabolism by mediation of insulin release and activity and enhancement of healthy pancreatic function. Ultra Potency Gymnema Sylvestre is standardized to 75% gymnemic acids for potent metabolic support. It also contains 50 mg gymnema leaf 5:1 extract.", "1 tablet daily with a meal", "Source Naturals", 102.80M, 30));
            products.Add(new MineralSupplement("Chitosan", "Chitosan is a dietary fiber derived from crustaceans that can bind to fat and cholesterol in the digestive tract, helping to maintain cholesterol levels already within healthy range. NOW Chitosan features LipoSan Ultra, a patented high-density form of Chitosin that, in laboratory testing, binds up to five times more fat than conventional Chitosan. A clinical study has demonstrating that LipoSan Ultra may aid in supporting a healthy body weight. Chromium, a mineral essential for normal glucose metabolism, has been included to complete this formula.", "Take 3 capsules immediately before the 2 main meals of the day.", "Now Foods", 83.14M, 25));
            products.Add(new Protein("Chitosans", "Chitosan is a dietary fiber derived from crustaceans that can bind to fat and cholesterol in the digestive tract, helping to maintain cholesterol levels already within healthy range. NOW Chitosan features LipoSan Ultra, a patented high-density form of Chitosin that, in laboratory testing, binds up to five times more fat than conventional Chitosan. A clinical study has demonstrating that LipoSan Ultra may aid in supporting a healthy body weight. Chromium, a mineral essential for normal glucose metabolism, has been included to complete this formula.", "Take 3 capsules immediately before the 2 main meals of the day.", "Now Foods", 823.14M, 25));
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
