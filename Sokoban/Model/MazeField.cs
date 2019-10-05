namespace Sokoban
{
    public abstract class MazeField //Abstract omdat deze niet geïnstantieerd hoort te worden
    {

        public MazeField _north { get; set; }
        public MazeField _east { get; set; }
        public MazeField _south { get; set; }
        public MazeField _west { get; set; }

        public void collide()
        {

        }

    }
}