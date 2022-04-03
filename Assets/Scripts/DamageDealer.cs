using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
   [SerializeField] private int damage = 10;

   public int GetDamage()
   {
      return damage;
   }

   public void Hit()
   {
      Destroy(gameObject);
   }
}
