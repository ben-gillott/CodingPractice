// See https://aka.ms/new-console-template for more information
//https://code.visualstudio.com/docs/csharp/get-started
//Command palette - new .net - console app template

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
    Console.WriteLine("\t Sorting [" + leftBound+ ", " + rightBound + "] " + arrayToString(arr));

    if(rightBound - leftBound <= 0){
        return;
    }
    //Select the pivot value  - say last element
    int n = arr.Length - 1;

    int pivot = arr[n-1];

    //Iterate from left and right - swapping high values right, and low to the left
    int i = 0; //i will be set to the leftmost value greater than pivot
    int j = n-1; //j will be set to the rightmost value less than pivot

    while(i < j){
        if(arr[i] > pivot && arr[j] < pivot){
            //Swap
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
            i++;
            j--;
        }
        else if(arr[i] < pivot){
            i++;
        }
        else{
            j++;
        }
    }

    //Move the pivot to it's correct positon
    arr[n-1] = arr[j];
    arr[j] = pivot;

    //Recurse left and right
    quickSort(ref arr, leftBound, j-1);
    quickSort(ref arr, j+1, rightBound);
}
