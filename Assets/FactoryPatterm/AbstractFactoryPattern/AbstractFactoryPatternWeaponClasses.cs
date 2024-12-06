using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstratcFactoryPattern
{
	
	public enum WeaponType
	{
		Melee,
		Ranged
	}
	public class AbstractFactoryPatternWeaponClasses : MonoBehaviour
	{
		
	}
	
	public interface Weapon
	{
		public void Attack();
	}
	
	public interface MeleeWeapon : Weapon
	{
		
	}
	
	public class Sword : MeleeWeapon
	{
		public void Attack()
		{
			Debug.Log("A meleeWeapon: sword");
		}
	}
	
	public class NullMeleeWeapon : MeleeWeapon
	{
		public void Attack()
		{
			Debug.Log("No a meleeWeapon");
		}
	}
	
	public interface RangedWeapon : Weapon
	{
		
	}
	
	public class Bow : RangedWeapon
	{
		public void Attack()
		{
			Debug.Log("A rangedWeapon : bow");
		}
	}
	
	public class NullRangedWeapon : RangedWeapon
	{
		public void Attack()
		{
			Debug.Log("No a rangedWeapon");
		}
	}
}

