using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour, IDamageable, IHaveStamina, IHasHunger, IThirst {

	// Health System
	private int health = 100;
	public int Health{ get{ return health; } }
	public void TakeDamage (int damage){health -= damage;}

	// Stamina System
	private int stamina  = 100;
	public int Stamina{ get{ return stamina; } }
	public void LooseStamina (int loss){stamina -= loss;}

	// Hunger System (more hunger is better)
	private int hunger  = 100;
	public int Hunger { get { return hunger; } }
	public void Eat (int gain){ hunger += gain; }
	public void Shrivel(int loss){ hunger -= loss; }

	// Hunger System (more thirst is better)
	private int thirst  = 100;
	public int Thirst { get { return thirst; } }
	public void Drink (int gain){ thirst += gain; }
	public void Dehydrate(int loss){ thirst -= loss; }

	void Start()
	{

	}

	void Update()
	{

	}
}
