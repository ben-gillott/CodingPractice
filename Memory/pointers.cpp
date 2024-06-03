#include <iostream>

int main()
{
    std::cout << "Hello World" << std::endl;
    
    //Pointers, "Static Allocation" - fixed size at runtime -> Stack
    char c = 'a';
    printf("Size: %lu \n", sizeof(c));
    printf("Pointer: %p \n", &c);

    int i = 9; //Create the value
    int *pi = &i; //Set pi to a pointer to the address of i
    int y = *pi; //Dereference pi and set in y
    printf("Pointer: %p \n", &c);
}