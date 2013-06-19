public class Car
{
	private final long CAR_NUM;
	private String owner;
	private int km;
	
	public Car(long num, String owner, int km)
	{
	}
	
	public long getCar_NUM()
	{
		return CAR_NUM;
	}
	public String getOwner()
	{
		return owner;
	}
	public void setOwner(String owner)
	{
		this.owner = owner;
	}
	public int getKm()
	{
		return km;
	}
	public void setKm(int km)
	{
		this.km = km;
	}
	
	public void sellCar()
	{
	}
	public void drive(int km)
	{
	}
}