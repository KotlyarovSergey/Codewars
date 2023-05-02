class Cards
{
	readonly int[] DEFAULTSET = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
	
	public int[] setFrank;
	public int[] setTom;
	public int[] setSam;
	
	public Cards()
	{
		this.Generate();
	}
	
	public override string ToString()
	{
		string s = string.Join(", ", setSam);
		string t = string.Join(", ", setTom);
		string f = string.Join(", ", setFrank);
		
		//return $"Frank: [{f}], Sam: [{s}], Tom:[{t}]";
		return $"F({Sum(setFrank)}):[{f}] S({Sum(setSam)}):[{s}] T({Sum(setTom)}):[{t}]";
	}
	
	int Sum(int[] data)
    {
        int sum = 0;
        foreach (var item in data)
        {
            sum+=item;
        }
        return sum;
    }

	public void Generate()
	{
		int[] set = new int[12];
		DEFAULTSET.CopyTo(set, 0);
	
		Shufle(ref set);
		HandOut(set);
		
	}
	
	private void Shufle(ref int[] set)
	{
		Random rnd = new();
		for(int i = 0; i < 12; i++)
		{
			int j = rnd.Next(12);
			(set[i], set[j]) = (set[j], set[i]);
		}
	}
	
	private void HandOut(int[] pack)
	//private (int[] frank, int[] sam, int[] tom) HandOut(int[] pack)
	{
		setFrank = new int[4];
		setSam = new int[4];
		setTom = new int[4];
		
		for(int i = 0; i < 4; i++)
		{
			setFrank[i] = pack[i*3];
			setSam[i] = pack[i*3+1];
			setTom[i] = pack[i*3+2];
		}
		
		Array.Sort(setSam);
		Array.Sort(setTom);
		Array.Sort(setFrank);
		
		//return (setFrank, setSam, setTom);
	}
	
}