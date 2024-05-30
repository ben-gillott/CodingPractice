// See https://aka.ms/new-console-template for more information
//https://code.visualstudio.com/docs/csharp/get-started
//Command palette - new .net - console app template

Console.WriteLine("STARTING PROGRAM");
Test();

void Test(){
    Console.WriteLine("Starting Test");
    int[] t1 = new int[]{3,2,4,1,5,2,1,4,6,3,6,1,8,23,4,32,99,-1};
    int[] sorted = mergeSort(t1);

    Console.WriteLine("input:" + arrayToString(t1));
    Console.WriteLine("output:" + arrayToString(sorted));
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

int[] mergeSort(int[] arr){
    //Recursive approach
    if(arr.Length <= 1){
        return arr;
    }

    int midIndex = (int)(arr.Length/2);

    int[] firstHalf = mergeSort(arr.Take(midIndex).ToArray());
    int[] secondHalf = mergeSort(arr.Skip(midIndex).ToArray());

    return combineSortedArrays(firstHalf, secondHalf);
}


int[] combineSortedArrays(int[] a, int[] b){
    int i = 0, j = 0;
    int[] c = new int[a.Length + b.Length];

    while(i+j < c.Length){
        if(j >= b.Length){
            c[i+j] = a[i];
            i++;
        }
        else if(i >= a.Length){
            c[i+j] = b[j];
            j++;
        }
        else if(a[i] <= b[j]){
            c[i+j] = a[i];
            i++;
        }
        else if(b[j] < a[i]){
            c[i+j] = b[j];
            j++;
        }
    }
    return c;
}