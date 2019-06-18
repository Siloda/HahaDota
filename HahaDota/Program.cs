﻿using System;

namespace HahaDota
{
    class Hero
    {
        protected String name;
        protected int hp;
        protected int strength;
        protected int agility;
        protected int intelligence;
        protected int attak;
        public Hero(String name, int hp, int strength, int agility, int intelligence, int attak)
        {
            this.name = name;
            this.hp = hp;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
            this.attak = attak;
        }
        public virtual String getName()
        {
            return name;
        }
        public int getHp()
        {
            return hp;
        }
        public int getStrenght()
        {
            return strength;
        }
        public int getAgillity()
        {
            return agility;
        }
        public virtual int getIntelligence()
        {
            return intelligence;
        }
        public virtual String getInfo()
        {
            return Console.WriteLine( "Name: " + name + "hp: " + hp + "strength: " + strength + "agility: " + agility + "intelligence: " + intelligence + "attak: " + attak;)
        }

    }
    class First : Hero
    {
        First(String name, int hp, int strength, int agility, int intelligence, int attak) : base
        {
            this.name = name;
        }

            public override String getName()
        {
            return "First";
        }
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }
}
