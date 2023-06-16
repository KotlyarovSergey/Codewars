// Top solutions from Codewars

public class Permutations1 {
    public static List<string> SinglePermutations( string s ) {
        if ( s.Length < 2 ) {
            return new List<string> {s};
        }
        var result = new HashSet<string>( );
        foreach ( var sub in SinglePermutations( s.Substring( 1 ) ) ) {
            for ( int i = 0; i <= sub.Length; i++ ) {
                result.Add( sub.Substring( 0, i ) + s [ 0 ] + sub.Substring( i ) );
            }
        }
        return result.ToList( );
    }
}

class Permutations2
{
  public static List<string> SinglePermutations(string s) => $"{s}".Length < 2 ?
  	new List<string> { s } :
  	SinglePermutations(s.Substring(1))
  		.SelectMany(x => Enumerable.Range(0, x.Length + 1)
  			.Select((_, i) => x.Substring(0, i) + s[0] + x.Substring(i)))
  		.Distinct()
  		.ToList();
}