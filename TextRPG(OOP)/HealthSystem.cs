﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace TextRPG_OOP_
{
    /// <summary>
    /// Health system used by all characters, handles damage and healing. 
    /// </summary>
    internal class HealthSystem
    {
        public int health;
        public int maxHealth;
        public int armor;
        public bool IsAlive = true;
        public bool wasHurt;
        

        /// <summary>
        /// heals player for HpGain value, max health needed for clamping
        /// </summary>
        /// <param name="HpGain"></param>
        /// <param name="maxHeath"></param>
        public void Heal(int HpGain) //Health gain and health max needed to not over heal. 
        {
            health += HpGain;
            if(health > maxHealth)
            {
                health = maxHealth;
            }
        }

        /// <summary>
        /// Damages what ever is hit by passed in damage value
        /// </summary>
        /// <param name="Damage"></param>
        public void TakeDamage(int Damage) //Damage taking system.
        {
            int effectiveDamage = Math.Max(Damage - armor, 0);

            if (effectiveDamage == 0)
            {
                Debug.WriteLine("Armor is too hard to damage");
                return;
            }
            else
            {
                health -= effectiveDamage;
                wasHurt = true;

                if(health <= 0)
                {
                    health = 0;
                    IsAlive = false;
                }
            }
        }

        /// <summary>
        /// Sets max health for start of game
        /// </summary>
        /// <param name="maxHP"></param>
        public void SetHealth(int maxHP) //Sets HP for start of game.
        {
            maxHealth = maxHP;
            health = maxHP;
        }

        /// <summary>
        /// Returns current HP, used to check if player is alive
        /// </summary>
        /// <returns></returns>
        public int GetHealth() //returns current HP.
        {
            return health;
        }
        
        /// <summary>
        /// Ups armor stat bt passed in value
        /// </summary>
        /// <param name="armorUp"></param>
        public void IncreaseArmor(int armorUp) //Increses Armor
        {
            armor += armorUp;
        }
    }
}
