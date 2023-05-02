public class Kata 
{
    public static bool Game(int[] frank, int[] sam, int[] tom) 
    {
        if(frank[2] < sam[0] || frank[2] < tom[0]) return false;
        if(frank[3] < sam[1] || frank[3] < tom[1]) return false;
		return true;
    }

    public static bool Game2(int[] frank, int[] sam, int[] tom) 
    {
        return !(frank[2] < sam[0] || frank[2] < tom[0] || frank[3] < sam[1] || frank[3] < tom[1]);
    }

}