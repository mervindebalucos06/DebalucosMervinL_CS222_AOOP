/* We are all familiar with the Fibonacci Sequence, where each term is the sum of the two preceding numbers, 
starting with 0 and 1. The sequence begins as follows: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, … 
Similarly, there is another sequence where each term is the sum of the three preceding numbers, 
starting with 0, 1, and 1. This is known as Tribonacci Sequence. The first few terms are: 0, 1, 1, 2, 4, 7, 13, 24, 44, 81, … 
Given a positive integer n, determine the nth term of the Tribonacci Sequence. Note: 0 is considered the zeroth term.
 */
 
       //Prompt the user for the number of Tribonacci terms to generate
       Console.Write("Enter value of n: ");
       int n = Convert.ToInt32(Console.ReadLine());
  
        //Get and display the nth Tribonacci number
        long nthTerm = GetTribonacci(n);
        Console.WriteLine($"Element {n}th of the Tribonacci sequence is: {nthTerm}");
       
       static long GetTribonacci(int n){
           if (n == 0) return 0;
           if (n == 1 || n == 2) return 1;
           
           long a = 0, b = 1, c = 1;
           long next = 0;
           
           for (int i = 3; i <= n; i++){
               next = a + b + c; //Compute the next term
               a = b;
               b = c;
               c = next;
           }
           return c;
       
     
    }