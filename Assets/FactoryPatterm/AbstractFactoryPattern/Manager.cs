using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstratcFactoryPattern
{
	public class Manager : MonoBehaviour
	{
		private WeaponFactory weaponFactory;
		private Weapon weapon;
		
		[SerializeField] private WeaponType weaponType;
		
		void Update()
		{
			switch(weaponType)
			{
				case WeaponType.Melee:
					weaponFactory = new MeleeWeaponFactory();
					weapon = weaponFactory.CreateMeleeWeapon();
					weapon.Attack();
					break;
				case WeaponType.Ranged:
					weaponFactory = new RangedWeaponFactory();
					weapon = weaponFactory.CreateRangedWeapon();
					weapon.Attack();
					break;
			}
		}
	}
}

