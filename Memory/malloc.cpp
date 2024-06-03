#include <iostream>
#include <stdlib.h>  

int main()
{
    printf("Hello World!\n");

    //Malloc, "Dynamic Allocation" - not fixed -> Heap
    int *ptr;
    ptr = (int*) malloc(3 * sizeof(int));
    
    if(ptr != NULL){
        printf("Memory not allocated\n");
        return 1;
    }

    *(ptr + 1) = 5;
    *(ptr + 2) = 6;
    *(ptr + 3) = 7;

    printf("%d", *(ptr+2));

    free(ptr);
    return 0;
}