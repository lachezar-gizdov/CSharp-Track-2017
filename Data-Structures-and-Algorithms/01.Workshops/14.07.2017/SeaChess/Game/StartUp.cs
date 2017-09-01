using Game;

namespace SeaChess
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var engine = new Engine(board);
            engine.Start();
        }
    }
}