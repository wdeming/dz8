void FillArray(int[,] array,int rows, int colums){
    Random random = new Random();
    int maxValue = 100;
    int minValue = 0;
    for (int i=0; i<rows; i++){
        for (int j=0; j<colums; j++){
            array[i,j] = random.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] array,int rows, int colums){
    for (int i=0; i<rows; i++){
        for (int j=0; j<colums; j++){
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 2 4 1
// 9 5 3 2
// 8 4 4 2
void dz54(){
    Console.WriteLine("Задача 54");
    int rows = 3;
    int colums = 4;
    
    int [,] array = new int[rows,colums];
    FillArray(array,rows,colums);
    Console.WriteLine("До сортировки");
    PrintArray(array,rows,colums);
    Console.WriteLine("После сортировки");
    SortArrayRow(array,rows,colums);

}
dz54();
void SortArrayRow(int[,] array,int rows, int colums){
    for (int i=0; i<rows; i++){
        for (int j=0; j<colums; j++){
            for (int k=j+1; k<colums; k++){
                if(array[i,j] < array[i,k]){
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
            Console.Write(array[i,j] + "\t"); 
        }
    Console.WriteLine();
    }
}
        

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void dz56(){
    Console.WriteLine("Задача 56");
    int rows = 4;
    int colums = 4;
    
    int [,] array = new int[rows,colums];
    FillArray(array,rows,colums);
    PrintArray(array,rows,colums);
    RowSum(array,rows,colums);
}

void RowSum(int[,] array,int rows, int colums){
    int [] Sum = new int[rows];
    int temp = 0;

    for (int i=0; i<rows; i++){
        for (int j=0; j<colums; j++){
            temp += array[i,j];     
        }   
        Sum[i] = temp;
        temp = 0;
    }
    int min = Sum [0];
    for (int i = 0; i < rows; i++){
        if (min > Sum[i]) min = Sum[i]; 
        Console.Write(Sum[i] + "\t");
    }
        Console.WriteLine();
        Console.WriteLine("минимальный элемент:"+min);
}   


dz56();

// Задача 58. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10  9  8  7
void dz58(){
    Console.WriteLine("Задача 58");
    int rows = 4;
    int colums = 4;
    
    int[,] array = new int[rows, colums]; 
    FillArraySpiral(array, rows, colums);
    PrintArray(array,rows,colums);    
}

void FillArraySpiral(int[,] array, int rows, int colums){
    int val = 1;
    int firstRows = 0; 
    int firstColums = 0;
    while (firstRows < rows && firstColums < colums) {

        for (int j = firstColums; j < colums; j++){
            array[firstRows, j] = val++;
        }
        firstRows++;
        
        for (int i = firstRows; i < rows; i++){
            array[i, colums - 1] = val++;
        }
        colums--;
  
        if (firstRows < rows)      {
            for (int i = colums - 1; i >= firstColums; i--){
                array[rows - 1,i] = val++;
            }
            rows--;
        }

        if (firstColums < colums)        {
            for (int i = rows - 1; i >= firstRows; i--){
                array[i,firstColums] = val++;
            }
            firstColums++;
        }
    }
}
dz58();