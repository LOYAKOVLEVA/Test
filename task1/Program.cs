string[] inputArray = new string[] { "hello", "world", "this", "is", "a", "test" }; 
string[] outputArray = new string[inputArray.Length];  
int j = 0;  
 
for (int i = 0; i < inputArray.Length; i++)  
{ 
    if (inputArray[i].Length <= 3)  
    { 
        outputArray[j] = inputArray[i];  
        j++;  
    } 
} 
 
for (int i = 0; i < j; i++)  
{ 
    Console.WriteLine(outputArray[i]);  
}