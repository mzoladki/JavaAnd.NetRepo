import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws IOException {

        File temp = new File("//home//marcin//IdeaProjects//ZAD3//src//com//company//poker.txt");
        Scanner file = new Scanner(temp);

        int con = 0;
        char x[] = new char[20];
        while (file.hasNext()) {

            String litera = file.nextLine();
            litera = litera.replaceAll(" ", "");

            for (int i = 0; i < 20; i++)
                x[i] = litera.charAt(i);

            Hand firstPlayer = new Hand(x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], x[9]);
            Hand secondPlayer = new Hand(x[10], x[11], x[12], x[13], x[14], x[15], x[16], x[17], x[18], x[19]);
            Game Gra = new Game(firstPlayer, secondPlayer);
            if (Gra.whoWin()) con++;
        }
        System.out.println(con);
    }
}
