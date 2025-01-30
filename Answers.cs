using System;

class PrintNumbers{
    public static void Main(String[] args){
        Console.WriteLine("Enter a Number: ");
        int num = int.Parse(Console.ReadLine());
        int temp = num;
        int digits = 0;
        while(temp > 0){
            digits++;
            temp /= 10;
        }
        int[] Nums = new int[digits];
        temp = num;
        for(int i = digits - 1; i >= 0; i--){
            Nums[i] = temp % 10;
            temp /= 10;
        }
		for(int i = 0; i < digits; i++){
            int sum = 0;
            bool isFirst = true;
            for(int j = 0; j < digits; j++){
                if(j == i) continue;
                
                if (isFirst){
                    Console.Write(Nums[j]);
                    isFirst = false;
                } else {
                    Console.Write(" + " + Nums[j]);
                }
                sum += Nums[j];
            }
            Console.WriteLine(" = " + sum);
        }
    }
}
