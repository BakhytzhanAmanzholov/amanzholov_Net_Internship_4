<<<<<<< HEAD
﻿

namespace Fraction
{
    public class Application
    {
        public static void Main()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 4);
            Fraction fraction3 = new Fraction(2, 4);

            Console.WriteLine($"Fraction 1: {fraction1}");
            Console.WriteLine($"Fraction 2: {fraction2}");
            Console.WriteLine($"Fraction 3: {fraction3}");

            // Test arithmetic operations
            Fraction sum = fraction1.Summation(fraction2);
            Fraction difference = fraction1.Subtraction(fraction2);
            Fraction product = fraction1.Multiplication(fraction2);
            Fraction quotient = fraction1.Division(fraction2);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            // Test converting fraction to double
            double fraction1Double = fraction1.ToDouble();
            double fraction2Double = fraction2.ToDouble();
            double fraction3Double = fraction3.ToDouble();

            Console.WriteLine($"Fraction 1 as double: {fraction1Double}");
            Console.WriteLine($"Fraction 2 as double: {fraction2Double}");
            Console.WriteLine($"Fraction 3 as double: {fraction3Double}");

            // Test equality
            bool equal1 = fraction1.Equals(fraction3);
            bool equal2 = fraction1.Equals(fraction2);

            Console.WriteLine($"Fraction 1 equals Fraction 3: {equal1}");
            Console.WriteLine($"Fraction 1 equals Fraction 2: {equal2}");

            // Test GetHashCode
            int hash1 = fraction1.GetHashCode();
            int hash2 = fraction2.GetHashCode();
            int hash3 = fraction3.GetHashCode();

            Console.WriteLine($"Hash code for Fraction 1: {hash1}");
            Console.WriteLine($"Hash code for Fraction 2: {hash2}");
            Console.WriteLine($"Hash code for Fraction 3: {hash3}");
            
            // Create a dictionary with Fraction keys
            Dictionary<Fraction, string> dictionary = new Dictionary<Fraction, string>();
            
            
            // Add fractions as keys to the dictionary
            dictionary[fraction1] = "Value 1";
            dictionary[fraction2] = "Value 2";
            dictionary[fraction3] = "Value 3";

            // Retrieve values using fractions as keys
            string value1 = dictionary[fraction1];
            string value2 = dictionary[fraction2];
            string value3 = dictionary[fraction3];

            Console.WriteLine($"Value 1: {value1}");
            Console.WriteLine($"Value 2: {value2}");
            Console.WriteLine($"Value 3: {value3}");

            // Create a hash set of fractions
            HashSet<Fraction> hashSet = new HashSet<Fraction>();

            // Add fractions to the hash set
            hashSet.Add(fraction1);
            hashSet.Add(fraction2);
            hashSet.Add(fraction3);

            // Check if the hash set contains a specific fraction
            bool containsFraction1 = hashSet.Contains(fraction1);
            bool containsFraction2 = hashSet.Contains(fraction2);
            bool containsFraction3 = hashSet.Contains(fraction3);

            Console.WriteLine($"HashSet contains Fraction 1: {containsFraction1}");
            Console.WriteLine($"HashSet contains Fraction 2: {containsFraction2}");
            Console.WriteLine($"HashSet contains Fraction 3: {containsFraction3}");

            Console.ReadLine();

        } 
    }

    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(Fraction fraction)
        {
            numerator = fraction.numerator;
            denominator = fraction.denominator;
        }
        
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
        
        public Fraction Summation(Fraction fraction)
        {
            var newNumerator = numerator * fraction.denominator + denominator * fraction.numerator;
            var newDenominator = denominator * fraction.denominator;

            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Subtraction(Fraction fraction)
        {
            var newNumerator = numerator * fraction.denominator - denominator * fraction.numerator;
            var newDenominator = denominator * fraction.denominator;

            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Multiplication(Fraction fraction)
        {
            var newNumerator = numerator * fraction.numerator;
            var newDenominator = denominator * fraction.denominator;

            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Division(Fraction fraction)
        {
            var newNumerator = numerator * fraction.denominator;
            var newDenominator = denominator * fraction.numerator;

            return new Fraction(newNumerator, newDenominator);
        }

        public double ToDouble()
        {
            return (double)numerator / denominator;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Fraction other = obj as Fraction;
            return numerator == other.numerator && denominator == other.denominator;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }
    }

};
=======
﻿

namespace Fraction
{
    public class Application
    {
        public static void Main()
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 4);
            Fraction fraction3 = new Fraction(2, 4);

            Console.WriteLine($"Fraction 1: {fraction1}");
            Console.WriteLine($"Fraction 2: {fraction2}");
            Console.WriteLine($"Fraction 3: {fraction3}");

            // Test arithmetic operations
            Fraction sum = fraction1.Summation(fraction2);
            Fraction difference = fraction1.Subtraction(fraction2);
            Fraction product = fraction1.Multiplication(fraction2);
            Fraction quotient = fraction1.Division(fraction2);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            // Test converting fraction to double
            double fraction1Double = fraction1.ToDouble();
            double fraction2Double = fraction2.ToDouble();
            double fraction3Double = fraction3.ToDouble();

            Console.WriteLine($"Fraction 1 as double: {fraction1Double}");
            Console.WriteLine($"Fraction 2 as double: {fraction2Double}");
            Console.WriteLine($"Fraction 3 as double: {fraction3Double}");

            // Test equality
            bool equal1 = fraction1.Equals(fraction3);
            bool equal2 = fraction1.Equals(fraction2);

            Console.WriteLine($"Fraction 1 equals Fraction 3: {equal1}");
            Console.WriteLine($"Fraction 1 equals Fraction 2: {equal2}");

            // Test GetHashCode
            int hash1 = fraction1.GetHashCode();
            int hash2 = fraction2.GetHashCode();
            int hash3 = fraction3.GetHashCode();

            Console.WriteLine($"Hash code for Fraction 1: {hash1}");
            Console.WriteLine($"Hash code for Fraction 2: {hash2}");
            Console.WriteLine($"Hash code for Fraction 3: {hash3}");
            
            // Create a dictionary with Fraction keys
            Dictionary<Fraction, string> dictionary = new Dictionary<Fraction, string>();
            
            
            // Add fractions as keys to the dictionary
            dictionary[fraction1] = "Value 1";
            dictionary[fraction2] = "Value 2";
            dictionary[fraction3] = "Value 3";

            // Retrieve values using fractions as keys
            string value1 = dictionary[fraction1];
            string value2 = dictionary[fraction2];
            string value3 = dictionary[fraction3];

            Console.WriteLine($"Value 1: {value1}");
            Console.WriteLine($"Value 2: {value2}");
            Console.WriteLine($"Value 3: {value3}");

            // Create a hash set of fractions
            HashSet<Fraction> hashSet = new HashSet<Fraction>();

            // Add fractions to the hash set
            hashSet.Add(fraction1);
            hashSet.Add(fraction2);
            hashSet.Add(fraction3);

            // Check if the hash set contains a specific fraction
            bool containsFraction1 = hashSet.Contains(fraction1);
            bool containsFraction2 = hashSet.Contains(fraction2);
            bool containsFraction3 = hashSet.Contains(fraction3);

            Console.WriteLine($"HashSet contains Fraction 1: {containsFraction1}");
            Console.WriteLine($"HashSet contains Fraction 2: {containsFraction2}");
            Console.WriteLine($"HashSet contains Fraction 3: {containsFraction3}");

            Console.ReadLine();

        } 
    }

    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(Fraction fraction)
        {
            numerator = fraction.numerator;
            denominator = fraction.denominator;
        }
        
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
        
        public Fraction Summation(Fraction fraction)
        {
            var newNumerator = numerator * fraction.denominator + denominator * fraction.numerator;
            var newDenominator = denominator * fraction.denominator;

            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Subtraction(Fraction fraction)
        {
            var newNumerator = numerator * fraction.denominator - denominator * fraction.numerator;
            var newDenominator = denominator * fraction.denominator;

            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Multiplication(Fraction fraction)
        {
            var newNumerator = numerator * fraction.numerator;
            var newDenominator = denominator * fraction.denominator;

            return new Fraction(newNumerator, newDenominator);
        }
        public Fraction Division(Fraction fraction)
        {
            var newNumerator = numerator * fraction.denominator;
            var newDenominator = denominator * fraction.numerator;

            return new Fraction(newNumerator, newDenominator);
        }

        public double ToDouble()
        {
            return (double)numerator / denominator;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Fraction other = obj as Fraction;
            return numerator == other.numerator && denominator == other.denominator;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denominator.GetHashCode();
                return hash;
            }
        }
    }

};
>>>>>>> 62bab4c8f5737b0a442dbfbf7ea8be747b8420d7
