internal class Program
{


    private static void Main(string[] args)

    {
        Console.WriteLine("Wprowadź swoją wagę w kg");
        double masa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wprowadź swój wzrost w cm");
        double wzrost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wprowadź swój wiek");
        double wiek = Convert.ToDouble(Console.ReadLine());



        double KcalM = (9.99 * masa) + (6.25 * wzrost) - (4.92 * wiek)+5;
        Console.WriteLine("Twoje referencyjne kalorie to:" + Math.Round(KcalM));

        /*double KcalM = (9.99 * masa) + (6.25 * wzrost) - (4.92 * wiek) - 161;
        Console.WriteLine("Twoje referencyjne kalorie to:" + Math.Round(KcalM));
        */
    }
    #region
    /* private static void Main(string[] args)
     {





         Console.WriteLine("Wprowadź swoją wagę w kg");
         double waga = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Wprowadź swój wzrost w m");
         double wzrost = Convert.ToDouble(Console.ReadLine());

         double BMI = waga / (wzrost * wzrost);
         Console.WriteLine("Twoje BMI to:" + Math.Round(BMI, 2));
         if (BMI < 18.5)
         {
             Console.WriteLine("Niedowaga");
         }

         else if (BMI <= 24.9)
         {
             Console.WriteLine("Waga w normie");
         }
         else if (BMI <= 34.9)
         {
             Console.WriteLine("Otyłość");
         }
         else if (BMI < 35)
         {
             Console.WriteLine("Skrajna Otyłość");
         }
     }
     */
    #endregion
}

/*
         wszystkie wartości poniżej są na kilogram masy ciała  ||| utrzymanie masy ciała
         int tłuszcz = 1;
        9 kcal                  20%     100G    900 kcal
         int węglowodany = 1;
        4 kcal                  55%     275G    1100 kcal                 2500 kcal
         int białko = 1;
        4 kcal                  25%     125G    500 kcal
         
        by przybrać na masie potrzeba od 300 do 500 dodatkowych kcal do podstawowej diety
                
        redukcja masy ciała od 500 do 1000 mniej kcal z podstawowej diety

        PPMM = (9,99*masa)+(6,25*wzrost)-(4,92*wiek)-161
        PPMK = (9,99*masa)+(6,25*wzrost)-(4,92*wiek)+5

        
*/


//kropka to wróg przecinek to bóg