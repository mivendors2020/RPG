﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class BassKlass
    {
        
        private protected string Name = null;

        private protected string rasa=null;
        private protected int lvl=0;
        private protected int  power = 0;
        private protected int xp= 0;
        private protected int domag = 0;
        private protected int armour = 0;
        private protected int money = 0;
        private protected int speedAtak = 0;



        Random rnd = new Random();



        public BassKlass()
        {

        }
        public BassKlass(string name,int lvl ,int power,int xp,int domag,int armour,int money ,int speedAtak)
        
        {
            this.Name = name;
            this.lvl = lvl;
            this.power = power;
            this.xp = xp;
            this.domag = domag;
            this.armour = armour;
            this.money = money;
            this.speedAtak = speedAtak;
            

        }
        public int Ataaka()
        {

            
            Random rnd = new Random();
            int dop = rnd.Next(50, 100);
            int attaka = (domag + power+dop) * speedAtak;
            return attaka;

            
            
        }


        void Zachita(int attaka)
        {
            int armour1 = 0;

            Random rnd = new Random();

            armour1 = armour * rnd.Next(1, 4);

            if (attaka > armour1)
            {
                xp = (armour1 + xp) - attaka;
                if (xp < 0)
                    xp = 0;
            }
        }
         public bool lifeGeroi() { return xp > 0; }

        public void lvlup()
        {
            Random rnd = new Random();
            int lvlup = rnd.Next(1, 3);
            //если 1 то бро ,2 atta ,3 xp
            if (1 == lvlup)
                armour += 50;
            else if (2 == lvlup)
                domag += 50;
            else if (3 == lvlup)
                armour += 50;

            
        }


    }



           
    }
}
