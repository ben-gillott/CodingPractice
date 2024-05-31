// See https://aka.ms/new-console-template for more information
//https://code.visualstudio.com/docs/csharp/get-started
//Command palette - new .net - console app template

using System.Configuration.Assemblies;

Console.WriteLine("STARTING PROGRAM");
Test();

void Test(){
    Console.WriteLine("Starting Test");
    int[] t1 = new int[]{2,4,1,5,3};
    Console.WriteLine("in:" + arrayToString(t1));
    
    quickSort(ref t1, 0 , t1.Length-1);
    Console.WriteLine("out:" + arrayToString(t1));
}

string arrayToString(int[] a){
    string s = "[";

    for(int i = 0; i < a.Length; i++){
        s = s + a[i];
        if(i < a.Length-1){
            s = s + ", ";
        }
    }
    s = s + "]";
    return s;
}

// ===========

void quickSort(ref int[] arr, int leftBound, int rightBound){
    if(rightBound < leftBound){
        return;
    }

    int pi = partition(ref arr, leftBound, rightBound);
    //Recurse left and right
    quickSort(ref arr, leftBound, pi-1);
    quickSort(ref arr, pi+1, rightBound);
}

int partition(ref int[] arr, int leftBound, int rightBound){
    
    Console.WriteLine("\t Parting [" + leftBound+ ", " + rightBound + "] " + arrayToString(arr));

    //Select the pivot value  - say last element
    int pivotValue = arr[rightBound];
    
    int i = leftBound - 1; // Represents greater value

    for(int j = leftBound; j < rightBound - 1; j++){
        if(arr[j] <= pivotValue){
            i++; //i moves to j

            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    arr[rightBound] = arr[i+1];
    arr[i+1] = pivotValue;

    Console.WriteLine("\t Parted [" + leftBound + ", " + rightBound + "] " + arrayToString(arr));
    
    return i+1;
}
