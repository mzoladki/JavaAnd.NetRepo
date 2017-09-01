package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.geom.Ellipse2D;

import static javafx.application.Platform.exit;

/**
 * Created by marcin on 02.04.17.
 */
public class Ball extends JPanel implements Runnable {

    double x = 40, y = 40, velX = 1.5, velY = 1.5;
    Paddle pal1;
    Paddle pal2;

    public Ball(Paddle p1, Paddle p2)
    {
        pal1 = p1;
        pal2 = p2;
    }

    public void paintComponent(Graphics g)
    {
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D) g;
        Ellipse2D circle = new Ellipse2D.Double(x,y,20,20);
        g2.fill(circle);
    }

    public void move(){

        if ((y > pal1.y && y < pal1.y + pal1.height) && x <= 15) {
            if(pal1.vely > 0 || pal1.vely <0) {
                velX = -velX -0.25;
                velY = velY + 0.2;
            }
            /*if(y > pal1.y && y < pal1.y + 20)
            {
                velX = -velX -0.25;
                velY = -velY;
            }*/
            else velX = -velX - 0.25;

        }

        if ((y > pal2.y  && y < pal2.y + pal2.height ) && x >= 550) {
            if(pal2.vely > 0 || pal2.vely <0) {
                velX = -velX - 0.25;
                velY = velY + 0.2;
            }
            /*if(y > pal2.y && y < pal2.y + 20)
            {
                velX = -velX -0.25;
                velY = -velY;
            }*/
            else velX = -velX - 0.25;
        }

        if (y < 0 || y > 400) {
            velY = -velY;
        }
        if (x < -20 || x > 570) {
            velX = 2;
            velY = 2;
            x=0;
            y=0;

        }

        x += velX;
        y += velY;

    }

    @Override
    public void run() {
        while(true) {
            synchronized (this) {
                try {
                    wait();
                } catch (InterruptedException ex) {

                }
            }
            move();
        }
    }
}