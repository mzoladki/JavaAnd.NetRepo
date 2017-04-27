package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.geom.Rectangle2D;

/**
 * Created by marcin on 02.04.17.
 */
public class Paddle extends JPanel implements Runnable{

    int x,y,weight, height;
    int velx = 0, vely = 0;
    public int player_number;
    boolean bot;
    Ball b1;
    public Paddle(int player_number) {
        this.player_number = player_number;
        x = 0;
        y = 150;
        weight = 20;
        height = 150;
        if(player_number == 3) bot = true;
    }


    public void paintComponent(Graphics g)
    {
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D) g;
        g2.setColor(Color.BLACK);
        g2.fill(new Rectangle2D.Double(x,y,weight,height));
    }

    @Override
    public void run() {
        while (true) {
            synchronized (this) {
                try {
                    wait();
                } catch (InterruptedException e) {
                }
            }
            move();
        }
    }

    public void move()
    {
        synchronized (this)
        {

            if(bot)
                botmove(b1);
            if (y < 0) {
                vely = 0;
                y = 0;
            }
            if (y > 250) {
                vely = 0;
                y = 250;
            }
            if (y >= 0 && y <= 250) {
                x += velx;
                y += vely;
            }
        }
    }

    public void botmove(Ball b1)
    {
        if(b1.y < (y+height)/2)
        {
            up();
        }
        if(b1.y > (y+height)/2)
        {
            down();
        }
    }

    public void up()
    {
        vely = -2;
        velx = 0;
    }

    public void down()
    {
        vely = 2;
        velx = 0;
    }

    public void stop() {
        vely = 0;
        velx = 0;
    }
    public void setBall(Ball b1)
    {
        this.b1 = b1;
    }


}