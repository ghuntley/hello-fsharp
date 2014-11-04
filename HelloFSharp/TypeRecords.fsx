// specification:
//
//    type called weapon
//	    has properties of
//		    damage int
//		    durability int
//
//    type called armor
//	    has properties of
//		    protection int
//		    durability int


// learnings:
// types in f# are created by syntax similar to named parameters.
type weaponType = { damage: int; durability: int }
type armorType = { protection: int; durability: int }

let sword = { damage = 1; durability = 100}
let robes = { protection = 1; durability = 50}

// c# example
// var dmg = 1;
// var dura = 100;
//
// var sword = new WeaponType(damage: int, durability: dura)
// var sword = new WeaponType(dmg, dura)
 