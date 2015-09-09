
public interface IThirst
{
	int Thirst{ get; }
	
	void Drink (int gain);
	void Dehydrate(int loss);
}
