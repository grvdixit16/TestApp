
using TestApp;


var bst = new BinarySearchTree<int>();
bst.Insert(5);
bst.Insert(3);
bst.Insert(7);
bst.Insert(2);
bst.Insert(4);

Console.WriteLine("In-order traversal:");
bst.InOrderTraversal(Console.WriteLine);


//Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
//Console.Write("\n\nEnter number of elements: ");
//int max = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[max];
//for (int i = 0; i < max; i++)
//{
//    Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.Write("Input int array : ");
//Console.Write("\n");
//for (int k = 0; k < max; k++)
//{
//    Console.Write(numbers[k] + " ");
//    Console.Write("\n");
//}
//Console.WriteLine("MergeSort By Recursive Method");

//MergeSortAlgorithm.SortMerge(numbers, 0, max - 1);
//for (int i = 0; i < max; i++)
//    Console.WriteLine(numbers[i]);
//Console.ReadLine();

//Console.WriteLine("Please enter a string to check palindrome and press enter button");
//var inputString = Console.ReadLine();

//new PalindromeStringCheck(inputString);
////new InvertedRightAngleTrianglePattern();