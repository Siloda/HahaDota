using System;
using System.Collections.Generic;
using System.Text;

namespace HahaDota
{
    public class Hero
    {
        public String name;
        public int hp;
        public int strength;
        public int agility;
        public int intelligence;
        public int strike;
       

        public Hero()
        {

        }
        
        public void takeItem(int heroIndex,int itemIndex)
        {
            Engine en = Engine.Letsgo;
            en.heroesList[heroIndex].strength += en.itemList[itemIndex].strength;
            en.heroesList[heroIndex].agility += en.itemList[itemIndex].agility;
            en.heroesList[heroIndex].intelligence += en.itemList[itemIndex].intelligence;
            en.heroesList[heroIndex].strike += en.itemList[itemIndex].strike;

        }
        public void HitHero(int heroIndex)
        {
            Engine en = Engine.Letsgo;
            en.heroesList[heroIndex].hp -= strike;
        }
        public  void stStrike()
        {
            
            strike = strength / 3 + agility / 5 + intelligence / 7;
        }
        public  void agStrike()
        {
           
            strike = agility / 3+ intelligence / 5 + strength  / 7;
        }
        public void intStrike()
        {
           
            strike = (intelligence  / 3) + (strength / 5) + (agility /  7);
        }

        public virtual int getStrike()
        {
            return strike ;
        }

        public String getName()
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
        public int getAgility()
        {
            return agility;
        }
        public int getIntelligence()
        {
            return intelligence;
        }

        public virtual String getInfo()
        {

            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }

    public class Pudge : Hero     
    {
       
        public Pudge()
        {
           name = "Pudge";
           hp = 700;
           strength = 10;
           agility = 10;
           intelligence = 10;
           stStrike();
        }
        public override int getStrike()
        {
            return strike;
        }
        public override String getInfo()
        {
                return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }
    public class Viper : Hero
    {
        

        public Viper()
        {
         name = "Viper";
         hp = 620;
         strength = 10;
         agility = 10;
         intelligence = 10;
         agStrike();
        }
        public override String getInfo()
        {
                return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }
    public class Luna : Hero
    {

        public Luna()
        {
            name = "Luna";
            hp = 520;
            strength = 10;
            agility = 10;
            intelligence = 10;
            agStrike();
            

        }
        public override int getStrike()
        {
            return strike;
        }

        public override String getInfo()
        {
                return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }
    public class Lion : Hero
    {
        
        public Lion()
        {
            name = "Lion";                
            hp = 560;
            strength = 10;
            agility = 10;
            intelligence = 10;
            intStrike();
            
        }
        public override int getStrike()
        {
            return strike;
        }
        public override String getInfo()
        {
            return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }
    public class Sniper : Hero
    {


        public Sniper()
        {
            name = "Sniper";
            hp = 580;
            strength = 10;
            agility = 10;
            intelligence = 10;           
            agStrike();
        }
        public override int getStrike()
        {
            return strike;
        }

        public override String getInfo()
        {
                return "Name: " + name + "\n hp: " + hp + "\n strength: " + strength + "\n agility: " + agility + "\n intelligence: " + intelligence + "\n attak: " + strike;
        }
    }
  

}