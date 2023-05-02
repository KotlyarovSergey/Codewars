Cards cards= new Cards();;
for (int i = 0; i < 10; i++)
{
    cards.Generate();
    
    Console.Write(cards);
    Console.Write(" ");
    Console.Write(Kata.Game(cards.setFrank, cards.setSam, cards.setTom));
    Console.Write(" ");
    Console.WriteLine(Kata.Game2(cards.setFrank, cards.setSam, cards.setTom));
}
