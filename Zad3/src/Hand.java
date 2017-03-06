/**
 * Created by marcin on 05.03.17.
 */
public class Hand {
    Card[] set=new Card[5];

    private int NumOfDiamonds=0;
    private int NumOfHearts=0;
    private int NumOfSpades=0;
    private int NumOfClubs=0;

    int[] NumOfValues=new int[13];

    public Hand(char x1,char y1,char x2,char y2,
                char x3,char y3,char x4,char y4,
                char x5,char y5)
    {
        set[0]=new Card(x1,y1);
        set[1]=new Card(x2,y2);
        set[2]=new Card(x3,y3);
        set[3]=new Card(x4,y4);
        set[4]=new Card(x5,y5);
    }


    public void countNumberOfColours()
    {
        for(int i=0;i<5;i++) {
            if (this.set[i].getColour() == 'D') {
                this.NumOfDiamonds++;
            } else if (this.set[i].getColour() == 'H') {
                this.NumOfHearts++;
            } else if (this.set[i].getColour() == 'S') {
                this.NumOfSpades++;
            } else if (this.set[i].getColour() == 'C') {
                this.NumOfClubs++;
            }
        }
    }

    public void countNumberOfValues()
    {
        for(int i=0;i<5;i++)
        {
            if (set[i].getValue()=='2') NumOfValues[0]++;
            if (set[i].getValue()=='3') NumOfValues[1]++;
            if (set[i].getValue()=='4') NumOfValues[2]++;
            if (set[i].getValue()=='5') NumOfValues[3]++;
            if (set[i].getValue()=='6') NumOfValues[4]++;
            if (set[i].getValue()=='7') NumOfValues[5]++;
            if (set[i].getValue()=='8') NumOfValues[6]++;
            if (set[i].getValue()=='9') NumOfValues[7]++;
            if (set[i].getValue()=='T') NumOfValues[8]++;
            if (set[i].getValue()=='J') NumOfValues[9]++;
            if (set[i].getValue()=='Q') NumOfValues[10]++;
            if (set[i].getValue()=='K') NumOfValues[11]++;
            if (set[i].getValue()=='A') NumOfValues[12]++;
        }
    }

    public void show()
    {
        for(int i=0;i<5;i++)
            this.set[i].show();
    }

    public int highCard()
    {
        for(int i=12;i>=0;i--)
        {
            if(NumOfValues[i]==1)
            {
                return i;
            }
        }
        return 0;
    }

    public boolean pair()
    {
        for(int i=0;i<13;i++)
        {
            if(NumOfValues[i]==2) return true;
        }
        return false;
    }

    public boolean twoPair()
    {
        int x=0;
        for(int i=0;i<13;i++)
        {
            if(NumOfValues[i]==2)
            {
                x++;
            }
            if(x==2) return true;
        }
        return false;
    }

    public boolean threeOfAKind()
    {
        for(int i=0;i<13;i++)
        {
            if(NumOfValues[i]==3) return true;
        }
        return false;
    }

    public boolean fourOfAKind()
    {
        for(int i=0;i<13;i++)
        {
            if(NumOfValues[i]==4) return true;
        }
        return false;
    }

    public boolean straight()
    {
        int x=0;
        if(NumOfValues[12]==1 && NumOfValues[0] ==1 && NumOfValues[1] ==1 && NumOfValues[2] ==1 && NumOfValues[3] ==1 )
            return true;
        for(int i=0;i<13;i++)
        {
            if(NumOfValues[i]==1)
            {
                x++;
            }
            if(x==5)
            {
                if(NumOfValues[i]==1 && NumOfValues[i-1]==1 && NumOfValues[i-2]==1 && NumOfValues[i-3]==1 && NumOfValues[i-4]==1)
                return true;
            }
        }
        x=0;
        return false;
    }

    public boolean flush()
    {
        if (NumOfClubs == 5 || NumOfSpades == 5 || NumOfHearts == 5 || NumOfDiamonds == 5 )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public boolean straightFlush()
    {
        if(straight() && flush())
            return true;
        else return false;
    }

    public boolean royalFlush()
    {
        if(flush())
        {
            if(NumOfValues[12]==1 && NumOfValues[11]==1 && NumOfValues[10]==1 && NumOfValues[9]==1)
                return true;
            else return false;
        }
        else return false;
    }

    public boolean fullHouse()
    {
        if(pair() && threeOfAKind())
            return true;
        else return false;
    }

    public int valueOfSet()
    {
        countNumberOfColours();
        countNumberOfValues();

        if(royalFlush()) return 9;
        if(straightFlush()) return 8;
        if(fourOfAKind()) return 7;
        if(fullHouse()) return 6;
        if(flush()) return 5;
        if(straight()) return 4;
        if(threeOfAKind()) return 3;
        if(twoPair()) return 2;
        if(pair()) return 1;
        return 0;

    }
}

