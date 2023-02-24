Console.WriteLine("массив : ");
string[] array={"car","Monday","dogs","2","344"};
int i=0;
while(i<array.Length)
{
int index=array[i].Length;
if(index<=3) Console.WriteLine(array[i]);
i++; 
}