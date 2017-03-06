/**
 * Created by marcin on 05.03.17.
 */
public class Card {
    private char colour;
    private char value;

    public Card(char v, char c)
    {
        colour=c;
        value=v;
    }

    public char getColour() {
        return colour;
    }

    public char getValue() {
        return value;
    }

    public void setColourAndValue(char value, char colour) {
        this.value = value;
        this.colour = colour;
    }

    public void show()
    {
        System.out.printf("%c%c ", value, colour);
    }



}
