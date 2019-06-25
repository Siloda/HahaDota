using System;
using System.Collections.Generic;
using System.Text;

namespace HahaDota
{

    public class Item
    {
        public int strength;
        public int agility;
        public int intelligence;
        public int strike;

        public Item()
        {

        }
        public void stStrike()
        {

            strike = strength * 3 + agility / 5 + intelligence / 7;
        }
        public void agStrike()
        {

            strike = agility * 3 + intelligence / 5 + strength / 7;
        }
        public void intStrike()
        {

            strike = (intelligence * 3) + (strength / 5) + (agility / 7);
        }


        public virtual int getStrenght()
         { 
            return strength;
         }
         public virtual int getAgility()
         {
            return agility;
         }
        public virtual int getIntelligence()
        {
            return intelligence;
        }
        public virtual int getStrike()
        {
            return strike;
        }




    }
    public class Stik : Item
    {
       
        public Stik()
        {

            strength = 0;
            agility=0;
            intelligence = 160;
            intStrike();
        }
        public override int getStrike()
        {
            return strike;
        }

    }
    public class Sword : Item
    {
        
        public Sword()
        {
            strength = 170;
            agility = 0;
            intelligence = 0;            
            stStrike();
        }
        public override int getStrike()
        {
            return strike;
        }
    }
    public class Bow : Item
    {
        public Bow()
        {
            strength = 0;
            agility = 140;
            intelligence = 0;            
            agStrike();
        }
        public override int getStrike()
        {
            return strike;
        }
    }
    public class Empty : Item
    {

        public Empty()
        {

            strength = 0;
            agility = 0;
            intelligence = 0;
            intStrike();
        }
        public override int getStrike()
        {
            return strike;
        }

    }


}