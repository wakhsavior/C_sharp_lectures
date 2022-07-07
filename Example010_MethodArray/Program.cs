int[] array = {1124,322,433,324,48,512,461,72,48};

int n = array.Length;
int find = 48;

int index = 0;

while(index < n){

    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
    index++;
}