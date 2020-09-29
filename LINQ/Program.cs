using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            Program a=  new Program();
            a.LearnLinqOnComplexCollection();
            // LINQ - Language INtegrated Query

            int[] numbers = { 7, 12, 34, 23, 67, 445, 68, 10, 89, 26, 123, 43542 };

            // Method syntax
            var result1 = numbers.Where(num => num > 50).Select(num => num);

            // Query expression systax
            var result2 = from num in numbers
                          where num > 50
                          select num;

            // Restrictions - where
            var result3 = from num in numbers
                          where num > 50 && num < 70
                          select num;

            // Projections - select
            var result4 = from num in numbers
                          where num % 2 == 0
                          select num * num;

            // Ordering - orderby, orderby descending
            var result5 = from num in numbers
                          orderby num descending
                          select num;

            // Partitioning: skip, take
            var result6 = numbers.Skip(5).Take(5);

            // Quantifiers: any, all, contains
            var result7 = numbers.Any(num => num % 2 == 0);
            var result8 = numbers.All(num => num % 2 == 0);
            var result9 = numbers.Contains(23);

            // Generations: range, repeat
            var result10 = Enumerable.Range(1, 1000);
            var result11 = Enumerable.Repeat("Hello world", 20);
        }

        void LearnLinqOnComplexCollection()
        {
            Country c1 = new Country("Nepal", "Kathmandu", "Asia", 324242234);
            Country c2 = new Country("India", "Delhi", "Asia", 33224242234, DateTime.Parse("1947/11/1"));
            Country c3 = new Country("England", "GB", "Europe", 1024234);
            Country c4 = new Country("Bhutan", "Thimpu", "Asia", 42234);
            Country c5 = new Country("Russia", "Mosco", "Europe", 242234, DateTime.Parse("1907/11/1"));
            Country c6 = new Country("Australia", "Canberra", "Australia", 4242234, DateTime.Parse("1943/11/1"));
            Country c7 = new Country("Belgium", "Brussels", "Europe", 440000, DateTime.Parse("1947/11/1"));
            Country c8 = new Country("Denmark", "Copenhagen", "Europe", 400000, DateTime.Parse("1947/11/1"));
            Country c9 = new Country("Finland", "Helsinki", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c10 = new Country("Germany", "Berlin", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c11 = new Country("Nigeria", "Abuja", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c12 = new Country("Ghana", "Accra", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c13 = new Country("Eritrea", "Asmara", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c14 = new Country("South Sudan", "Juba", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c15 = new Country("Morocco", "Rabat", "Africa", 54324564, DateTime.Parse("1947/11/1"));
            Country c16 = new Country("China", "Beijing", "Asia", 54324564, DateTime.Parse("1947/11/1"));
            Country c17 = new Country("Pakistan", "Islamabad", "Asia", 54324564, DateTime.Parse("1947/11/1"));
            Country c18 = new Country("France", "Paris", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c19 = new Country("Italy", "Rome", "Europe", 54324564, DateTime.Parse("1947/11/1"));
            Country c20 = new Country("Netherlands", "Amsterdam", "Europe", 450000, DateTime.Parse("1947/11/1"));

            var countries = new List<Country> { c1, c2, c3, c4, c5, c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20 };

            //List all asian country names
            var result12 = from country in countries            
                          where country.Continent == "Asia"
                          select country.Name;

            // List all asian Countries which are never been invaded
            var result13 = from country in countries
                           where country.IndependenceDay == default
                           select country.Name;
            
            //countries in asceding order that has population less than 500k
            var result14 = from country in countries
                           where country.Population<500000 & country.Continent =="Europe"
                           select country.Name;
            Console.WriteLine("Countries that has never been invaded are: ");
            foreach (var name in result13)
            {
                
                Console.WriteLine(name);
            }

            Console.WriteLine("Europian countries that has population less than 500k are: ");
            foreach (var name in result14)
            {
                
                Console.WriteLine(name);
            }

            
            //HW - List all asian country names which are never been invaded
            //HW - List all europian countries in asceding order that has population less than 500k
            
        }
        
    }
}