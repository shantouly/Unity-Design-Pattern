using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstratcFactoryPattern
{
	public class AbstractFactorys : MonoBehaviour
	{
		
	}
	
	public interface WeaponFactory
	{
		public MeleeWeapon CreateMeleeWeapon();
		public RangedWeapon CreateRangedWeapon();
	}

	public class MeleeWeaponFactory : WeaponFactory
	{
		public MeleeWeapon CreateMeleeWeapon()
		{
			return new Sword();
		}

		public RangedWeapon CreateRangedWeapon()
		{
			return new NullRangedWeapon();
		}
	}

	public class RangedWeaponFactory : WeaponFactory
	{
		public MeleeWeapon CreateMeleeWeapon()
		{
			return new NullMeleeWeapon();
		}

		public RangedWeapon CreateRangedWeapon()
		{
			return new Bow();
		}
	}
}

