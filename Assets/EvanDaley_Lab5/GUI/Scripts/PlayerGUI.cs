using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour {

	// Size of textures
	public Vector2 size = new Vector2(240,40);

	// Health UI
	public Vector2 healthPos = new Vector2(20,20);
	public float healthDisplay = 1F;
	public Texture2D healthBarEmpty;
	public Texture2D healthBarFul;

	// Hunger UI
	public Vector2 hungerPos = new Vector2(20,60);
	public float hungerDisplay = 1F;
	public Texture2D hungerBarEmpty;
	public Texture2D hungerBarFul;

	// Thirst UI
	public Vector2 thirstPos = new Vector2(20,60);
	public float thirstDisplay = 1F;
	public Texture2D thirstBarEmpty;
	public Texture2D thirstBarFul;

	// Stamina UI
	public Vector2 staminaPos = new Vector2(20,60);
	public float staminaDisplay = 1F;
	public Texture2D staminaBarEmpty;
	public Texture2D staminaBarFul;

	public int healthFallRate = 150;
	public int hungerFallRate = 150;
	public int thirstFallRate = 100;
	public int staminaFallRate = 35;

}
