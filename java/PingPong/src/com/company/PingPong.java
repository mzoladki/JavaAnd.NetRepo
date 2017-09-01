package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class PingPong extends JFrame implements KeyListener, ActionListener{

    JFrame gra;
    Paddle paletka;
    Paddle paletka2;
    Ball pilka;
    Thread thread, thread2, thread3;
    public PingPong() throws InterruptedException
    {
        javax.swing.Timer t = new javax.swing.Timer(5,this);
        t.start();
        gra = new JFrame();
        paletka = new Paddle(1);
        paletka2 = new Paddle(3);
        pilka = new Ball(paletka, paletka2);


        paletka2.setBall(pilka);


        gra.setSize(600,400);
        gra.setTitle("Ping pong");
        gra.setVisible(true);
        gra.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        gra.add(paletka2, BorderLayout.EAST);
        gra.add(paletka, BorderLayout.WEST);
        gra.add(pilka);
        gra.addKeyListener(this);
        gra.setFocusable(true);
        gra.setFocusTraversalKeysEnabled(false);
        play();

    }

    @Override
    public void actionPerformed(ActionEvent e) {

        synchronized(pilka)
        {
            pilka.notify();
            pilka.repaint();
        }
        synchronized(paletka)
        {
            paletka.notify();
            paletka.repaint();

        }
        synchronized(paletka2)
        {
            paletka2.notify();
            paletka2.repaint();
        }

    }

    @Override
    public void keyTyped(KeyEvent e) {

    }

    @Override
    public void keyPressed(KeyEvent e) {

        int code = e.getKeyCode();
        if (code == KeyEvent.VK_UP) {
            paletka.up();
        }
        if (code == KeyEvent.VK_DOWN) {
            paletka.down();
        }
        if (code == KeyEvent.VK_W) {
            paletka2.up();
        }
        if (code == KeyEvent.VK_S) {
            paletka2.down();
        }

    }

    @Override
    public void keyReleased(KeyEvent e) {
        int code = e.getKeyCode();
        if (code == KeyEvent.VK_UP) {
            paletka.stop();
        }
        if (code == KeyEvent.VK_DOWN) {
            paletka.stop();
        }
        if (code == KeyEvent.VK_W) {
            paletka2.stop();
        }
        if (code == KeyEvent.VK_S) {
            paletka2.stop();
        }
    }

    public void play()
    {
        thread = new Thread(paletka);
        thread2 = new Thread(paletka2);
        thread3 = new Thread(pilka);
        thread.start();
        thread2.start();
        thread3.start();
    }
    public static void main(String[] args)throws InterruptedException {
        new PingPong();
    }

}
