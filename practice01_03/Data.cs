
using Animal;
using System;

class Program
{
    static void Main(string[] args)
    {
        Tiger tiger = new Tiger("Shera");
        Crocodile crocodile = new Crocodile("Snappy");
        Kangaroo kangaroo = new Kangaroo("Jack");

        tiger.Move();
        tiger.Sound();

        crocodile.Move();
        crocodile.Sound();

        kangaroo.Move();
        kangaroo.Sound();
    }
}
