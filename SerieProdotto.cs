using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int s, max = 0, prova = 1;
        if(span < 0 || span > digits.Count() || int.TryParse(digits, out s) == false){
            if(digits == "" && span == 0){
                return 1;
            }
            if(digits.Count() < 10){
                throw new ArgumentException();
            }
        }

        if(span == 0){
            return 1;
        }

        for(int i = 0; i <= digits.Count() - span; i++){
            for (int j = i; j < span + i; j++){
                int temp = 0;
                int.TryParse(digits[j].ToString(), out temp);
                prova = prova * temp;
            }
            if(prova > max){
                max = prova;
            }
            prova = 1;
        }
        return max;
    }
}