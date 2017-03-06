/**
 * Created by marcin on 05.03.17.
 */
public class Game {

    private Hand Player1;
    private Hand Player2;


    public Game(Hand player1, Hand player2) {
        Player1 = player1;
        Player2 = player2;
    }

    private boolean compareHighCards()     //jezeli gracz pierwszy bedzie mial lepsza karte to
    {                                                               //zwracamy true
        int v1=0;
        int v2=0;

        for(int i=12;i>=0;i--)
        {
            if(Player1.NumOfValues[i]==1)
            {
                v1=Player1.NumOfValues[i];
            }
            if(Player2.NumOfValues[i]==1)
            {
                v2=Player2.NumOfValues[i];
            }
            if(v1>v2)
            {
                return true;
            }
            else if(v2>v1) {
                return false;
            }
        }
        return false;
    }
    private int highCard(Hand player)
    {
        for(int i=12;i>=0;i--)
        {
            if(player.NumOfValues[i]==1)
            {
                return i;
            }
        }
        return 0;
    }

    private int lowestCard(Hand player)
    {
        int x=0;
        for(int i=12;i>=0;i--)
        {
            if(player.NumOfValues[i]==1)
            {
                x=i;
            }
        }
        return x;
    }

    private int fourOfAKindValue(Hand player)
    {
        int x=0;
        for(int i=12;i>=0;i--)
        {
            if(player.NumOfValues[i]==4) x=i;
        }
        return x;
    }

    private int threeOfAKindValue(Hand player)
    {
        int x=0;
        for(int i=12;i>=0;i--)
        {
            if(player.NumOfValues[i]==3) x=i;
        }
        return x;
    }

    private boolean compare(int v1, int v2)
    {
        if(v1 > v2) {
            return true;
        }
        else
        {
            return false;
        }
    }

    private boolean compareTwoPairs()
    {
        int v1=0,v2=0;
        for(int i=12;i>=0;i--)
        {
            if (Player1.NumOfValues[i] == 2)       //jezeli znajdziemy dwojke to bierzemy jej wartosc
            {
                v1 = i;
            }
            if (Player2.NumOfValues[i] == 2) {
                v2 = i;
            }
            if (v1 > v2)                           //jezeli para pierwszego gracza bedzie wieksza to zwracamy true
            {
                return true;
            }
            if (v1 < v2)                           //jezeli para drugiego gracza bedzie wieksza to zwracamy false
            {
                return false;
            }
        }
        v1=highCard(Player1);               //jezeli obydwie pary beda takie same, to sprawdzamy 5 karte
        v2=highCard(Player2);
        if(v1>v2)
        {
            return true;
        }
        return false;
    }

    public boolean whoWin()
    {
        int value1=Player1.valueOfSet();
        int value2=Player2.valueOfSet();

        if(value1 > value2) {
            return true;
        }
        else if(value1==value2)   //Sprawdzamy strita - przechodzac po kazdej karcie znajdujemy najmniejsza, jezeli
        {                         //najmniejsza karta pierwszego gracza bedzie wieksza, oznacza to ze ma mocniejszy zestaw
            if(value1==8)
            {
                value1=lowestCard(Player1);
                value2=lowestCard(Player2);
                return compare(value1,value2);
            }
            if(value1==7)       //Sprawdzamy karete jezeli gracz bedzie mial karete zlozona z wyzszych
            {                   //kart oznacza to, ze wygral
                value1=fourOfAKindValue(Player1);
                value2=fourOfAKindValue(Player2);
                return compare(value1,value2);
            }
            if(value1==6)       //Sprawdzamy fula, jezeli trojka gracza bedzie zlozona z wyzszych kart, wtedy wygrywa
            {
                value1=threeOfAKindValue(Player1);
                value2=threeOfAKindValue(Player2);
                return compare(value1,value2);
            }
            if(value1==5)       //sprawdzamy kolor, wygrywa gracz ktory ma wyzsza karte
            {
                if(compareHighCards()) return true;
                else return false;
            }
            if(value1==4)       //Sprawdzamy strita
            {
                value1=lowestCard(Player1);
                value2=lowestCard(Player2);
                return compare(value1,value2);
            }
            if(value1==3)       //sprawdzamy trojki, gracz z wyzsza wygrywa.
            {
                value1=threeOfAKindValue(Player1);
                value2=threeOfAKindValue(Player2);
                return compare(value1,value2);
            }
            if(value1==2)       //sprawdzamy pary - jezeli gracz ma wyzsza pare, to wygrywa, jezeli maja dwie takie same
            {                   //to sprawzamy piata karte, ktora jest wieksza
            return compareTwoPairs();
            }
            if(value1==1)
            {
                return compareTwoPairs();
            }
            if(value1==0)
            {
                value1=highCard(Player1);
                value2=highCard(Player2);
                return compare(value1,value2);
            }
        }
        else
        {
            return false;
        }
    return false;
    }

}
