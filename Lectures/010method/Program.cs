int [] array ={1,12,4,13124,124214124,14,455,55,4};
int n = array.Length;
int find = 4;
int index=0;
while (index<n)
{
if(array[index]==find) 
{
    Console.WriteLine(index);
    break;
}
    index++; //index+1

}