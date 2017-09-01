package com.company;

public class Main {

    public static void main(String[] args) {
        int max = 4000000;
        int a = 0;
        int b = 1;
        int c = 0;
        int suma = 0;

        while(c < max)
        {
            c = a+b;
            if(c%2 == 0)
            {

                suma += c;
            }
            a=b;
            b=c;
        }
        System.out.println("Suma wszystkich liczb wynosi: ");
        System.out.println(suma);
    }
}
