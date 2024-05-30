// See https://aka.ms/new-console-template for more information
//https://code.visualstudio.com/docs/csharp/get-started
//Command palette - new .net - console app template

Console.WriteLine("STARTING PROGRAM");
Test();

void Test(){
    Console.WriteLine("Starting Test");
    int[] t1 = new int[]{3,2,4,1,5,2,1,4,6,3,6,1,8,23,4,32,99,-1};
    int[] sorted = quickSort(t1);

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

int[] quickSort(int[] arr){
    //Recursive approach

    return [];
}
