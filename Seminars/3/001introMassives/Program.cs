// string name1="Bob1";
// string name2="Bob2";
// string name3="Bob3";
// string name4="Bob4";

// string[] names = {"Bob1","Bob2",name3,name4};


// int[] num;
// int[] nums=new int[5]; //создаю массив из пяти элементов, но все будут нули
// int [] nums = {1,3,6,7,5};
//или
// int[] nums=new int[5]{1,3,6,7,5};

int [] nums = {1,3,6,7,5};
Console.WriteLine(nums[3]);//вытащил число 7 с индексом 3
int x=nums[3]+nums[1];
Console.WriteLine(x);
nums[3]=17;
Console.WriteLine(nums[3]);

Console.WriteLine(nums.Length);

for (int i = 0; i<nums.Length; i++)
{
    Console.WriteLine(nums[i]);
    // nums[i]= new Random().Next(1,10); рандомное число от 1 до 10
}
