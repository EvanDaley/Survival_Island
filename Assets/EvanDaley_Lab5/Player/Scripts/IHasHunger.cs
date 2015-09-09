
public interface IHasHunger
{
	int Hunger{ get; }
	
	void Eat (int gain);
	void Shrivel(int loss);
}
