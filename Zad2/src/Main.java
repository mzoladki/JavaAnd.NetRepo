import java.io.*;
import java.util.*;

public class Main {

    static boolean Is_Triangular_Number(String word)
    {
        int sum=0;
        boolean notFound = true;
        for(int i=0;i<word.length();i++)
        {
            sum += ((int) word.toUpperCase().charAt(i))-64;
        }
        int row=0;
        int n=0;
        while(notFound)
        {
            row = n*(n+1)/2;
            n++;
            if(row == sum)
            {
                notFound = false;
                return true;
            }
            else if(row>sum)
            {
                notFound = true;
                return false;
            }
        }
        return false;
    }

    public static void main(String[] args) throws IOException
    {
        int counter = 0;
        File temp = new File("//home//marcin//IdeaProjects//Zad2//src//words.txt");
        Scanner file = new Scanner(temp);
        file.useDelimiter(",");
        while(file.hasNext())
        {
            String word = file.next();
            word=word.substring(1,word.length()-1);
            if (Is_Triangular_Number(word))
            {
                counter++;
            }
        }
        System.out.println(counter);
    }
}
